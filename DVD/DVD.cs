using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMAPI2.Interop;
using IMAPI2.MediaItem;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using System.ComponentModel;

namespace testMedia.DVD
{
    class DVD_1
    {
        private const string ClientName = "BurnMedia";
        private IMAPI_BURN_VERIFICATION_LEVEL _verificationLevel =
                IMAPI_BURN_VERIFICATION_LEVEL.IMAPI_BURN_VERIFICATION_NONE;
        private BurnData _burnData = new BurnData();

        public static int ERROR_MEDIA_NOT_SUPPORT = -1;
        public static int ERROR_DETECT_MEDIA = -2;

        private Int64 _totalDiscSize;
        private BackgroundWorker backgroundWorkerBurn = new BackgroundWorker();
        private bool _closeMedia = true;
        private bool _ejectMedia = true;


        void discFormatData_Update([In, MarshalAs(UnmanagedType.IDispatch)] object sender, [In, MarshalAs(UnmanagedType.IDispatch)] object progress)
        {
        }

        void fileSystemImage_Update([In, MarshalAs(UnmanagedType.IDispatch)] object sender,
            [In, MarshalAs(UnmanagedType.BStr)]string currentFile, [In] int copiedSectors, [In] int totalSectors)
        { 
        }

        private bool CreateMediaFileSystem(IDiscRecorder2 discRecorder, object[] multisessionInterfaces, out IStream dataStream, IMediaItem mediaItem)
        {
            MsftFileSystemImage fileSystemImage = null;
            try
            {
                fileSystemImage = new MsftFileSystemImage();
                fileSystemImage.ChooseImageDefaults(discRecorder);
                fileSystemImage.FileSystemsToCreate =
                    FsiFileSystems.FsiFileSystemJoliet | FsiFileSystems.FsiFileSystemISO9660;
                fileSystemImage.VolumeName = "2019_10_22";

                fileSystemImage.Update += fileSystemImage_Update;

                //
                // If multisessions, then import previous sessions
                //
                if (multisessionInterfaces != null)
                {
                    fileSystemImage.MultisessionInterfaces = multisessionInterfaces;
                    fileSystemImage.ImportFileSystem();
                }

                //
                // Get the image root
                //
                IFsiDirectoryItem rootItem = fileSystemImage.Root;

                //
                // Add Files and Directories to File System Image
                //
                mediaItem.AddToFileSystem(rootItem);

                fileSystemImage.Update -= fileSystemImage_Update;

                //
                // did we cancel?
                //
                if (backgroundWorkerBurn.CancellationPending)
                {
                    dataStream = null;
                    return false;
                }

                dataStream = fileSystemImage.CreateResultImage().ImageStream;
            }
            catch (COMException exception)
            {
                MessageBox.Show(exception.Message, "Create File System Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataStream = null;
                return false;
            }
            finally
            {
                if (fileSystemImage != null)
                {
                    Marshal.ReleaseComObject(fileSystemImage);
                }
            }

            return true;
        }

        private void backgroundWorkerBurn_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            MsftDiscRecorder2 discRecorder = null;
            MsftDiscFormat2Data discFormatData = null;

            IMediaItem mediaItem;

            try
            {
                //
                // Create and initialize the IDiscRecorder2 object
                //
                discRecorder = new MsftDiscRecorder2();
                var burnData = (BurnData)e.Argument;
                mediaItem = burnData.mediaItem;
                discRecorder.InitializeDiscRecorder(burnData.uniqueRecorderId);

                //
                // Create and initialize the IDiscFormat2Data
                //
                discFormatData = new MsftDiscFormat2Data
                {
                    Recorder = discRecorder,
                    ClientName = ClientName,
                    ForceMediaToBeClosed = _closeMedia
                };

                //
                // Set the verification level
                //
                var burnVerification = (IBurnVerification)discFormatData;
                burnVerification.BurnVerificationLevel = _verificationLevel;

                //
                // Check if media is blank, (for RW media)
                //
                object[] multisessionInterfaces = null;
                if (!discFormatData.MediaHeuristicallyBlank)
                {
                    multisessionInterfaces = discFormatData.MultisessionInterfaces;
                }

                //
                // Create the file system
                //
                IStream fileSystem;
                if (!CreateMediaFileSystem(discRecorder, multisessionInterfaces, out fileSystem, mediaItem))
                {
                    e.Result = -1;
                    return;
                }

                //
                // add the Update event handler
                //
                discFormatData.Update += discFormatData_Update;

                //
                // Write the data here
                //
                try
                {
                    discFormatData.Write(fileSystem);
                    e.Result = 0;
                }
                catch (COMException ex)
                {
                    e.Result = ex.ErrorCode;
                    MessageBox.Show(ex.Message, "IDiscFormat2Data.Write failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    if (fileSystem != null)
                    {
                        Marshal.FinalReleaseComObject(fileSystem);
                    }
                }

                //
                // remove the Update event handler
                //
                discFormatData.Update -= discFormatData_Update;

                if (_ejectMedia)
                {
                    discRecorder.EjectMedia();
                }
            }
            catch (COMException exception)
            {
                //
                // If anything happens during the format, show the message
                //
                MessageBox.Show(exception.Message);
                e.Result = exception.ErrorCode;
            }
            finally
            {
                if (discRecorder != null)
                {
                    Marshal.ReleaseComObject(discRecorder);
                }

                if (discFormatData != null)
                {
                    Marshal.ReleaseComObject(discFormatData);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        public DVD_1()
        {
            backgroundWorkerBurn.DoWork += backgroundWorkerBurn_DoWork;
            backgroundWorkerBurn.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorkerBurn.RunWorkerCompleted += backgrounfBurnWorker_Complete;
            backgroundWorkerBurn.WorkerReportsProgress = true;
        }

        public List<IDiscRecorder2> findAllDisk ()
        {
            List<IDiscRecorder2> RecordDisk_List = new List<IDiscRecorder2>();

            //
            // Determine the current recording devices
            //
            MsftDiscMaster2 discMaster = null;
            try
            {
                discMaster = new MsftDiscMaster2();

                if (!discMaster.IsSupportedEnvironment)
                    return null;
                foreach (string uniqueRecorderId in discMaster)
                {
                    var discRecorder2 = new MsftDiscRecorder2();
                    discRecorder2.InitializeDiscRecorder(uniqueRecorderId);

                    //MessageBox.Show(discRecorder2.ProductId);
                    RecordDisk_List.Add(discRecorder2);
                    //devicesComboBox.Items.Add();
                }
            }
            catch
            {
                MessageBox.Show(string.Format("Error:{0} - Please install IMAPI2"));
                return null;
            }
            finally
            {
                if (discMaster != null)
                {
                    Marshal.ReleaseComObject(discMaster);
                }
            }

            return RecordDisk_List;
        }

        public Int64 detectDisk(IDiscRecorder2 disk)
        {
            int error_code = 0;
            var discRecorder = disk;

            MsftFileSystemImage fileSystemImage = null;
            MsftDiscFormat2Data discFormatData = null;

            try
            {
                //
                // Create and initialize the IDiscFormat2Data
                //
                discFormatData = new MsftDiscFormat2Data();
                if (!discFormatData.IsCurrentMediaSupported(discRecorder))
                {
                    //labelMediaType.Text = "Media not supported!";
                    MessageBox.Show("Media not supported!");
                    _totalDiscSize = 0;
                    error_code = ERROR_MEDIA_NOT_SUPPORT;
                }
                else
                {
                    //
                    // Get the media type in the recorder
                    //
                    discFormatData.Recorder = discRecorder;
                    IMAPI_MEDIA_PHYSICAL_TYPE mediaType = discFormatData.CurrentPhysicalMediaType;
                    //labelMediaType.Text = GetMediaTypeString(mediaType);

                    //
                    // Create a file system and select the media type
                    //
                    fileSystemImage = new MsftFileSystemImage();
                    fileSystemImage.ChooseImageDefaultsForMediaType(mediaType);

                    //
                    // See if there are other recorded sessions on the disc
                    //
                    if (!discFormatData.MediaHeuristicallyBlank)
                    {
                        fileSystemImage.MultisessionInterfaces =
                        discFormatData.MultisessionInterfaces;
                        fileSystemImage.ImportFileSystem();
                    }

                    Int64 freeMediaBlocks = fileSystemImage.FreeMediaBlocks;
                    _totalDiscSize = 2048 * freeMediaBlocks;
                    MessageBox.Show("Disk size: " + _totalDiscSize.ToString());
                }
            }
            catch (COMException exception)
            {
                MessageBox.Show(exception.Message, "Detect Media Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                error_code = ERROR_DETECT_MEDIA;
            }
            finally
            {
                if (discFormatData != null)
                {
                    Marshal.ReleaseComObject(discFormatData);
                }

                if (fileSystemImage != null)
                {
                    Marshal.ReleaseComObject(fileSystemImage);
                }
            }

            if (error_code != 0)
                return error_code;

            return _totalDiscSize;
        }

        public void burnFile2Disk(IDiscRecorder2 disk, IMediaItem mediaItem)
        {
            var discRecorder = disk;
            _burnData.uniqueRecorderId = discRecorder.ActiveDiscRecorder;
            _burnData.mediaItem = mediaItem;

            backgroundWorkerBurn.RunWorkerAsync(_burnData);
        }

        private void backgrounfBurnWorker_Complete(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Burn completed");
        }

    }
}
