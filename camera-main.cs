using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DirectShowLib;
using System.Runtime.InteropServices;

namespace DxPropPages
{
    public partial class camera_main : Form
    {
        const int SINGLE = 0;
        const int DUAL = 1;

        IBaseFilter[] devices;
        int mode = DUAL;
        NormalizedRect _0rect = new NormalizedRect();
        NormalizedRect _1rect = new NormalizedRect();

        IGraphBuilder pGB;
        IBaseFilter pVmr;
        IVMRFilterConfig9 pConfig;
        IVMRWindowlessControl9 pWC;
        IVMRMixerControl9 pMix;
        IMediaSeeking pMs;
        IMediaControl pMC;

        [STAThread]
        static void Main()
        {
            Application.Run(new camera_main());
        }

        public camera_main()
        {
            InitializeComponent();
            
            DsDevice[] devs = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            devices = new IBaseFilter[2];

            if (devs.Length <= 0)
            {
                MessageBox.Show("Cannot find any camera !");
                return;
            }

            devices[0] = CreateFilter(FilterCategory.VideoInputDevice, devs[0].Name);

            if (devs.Length >= 2)
            {
                devices[1] = CreateFilter(FilterCategory.VideoInputDevice, devs[1].Name);
            }

            initGraph(panel1.ClientRectangle, panel1.Handle);
            pMC.Run();

        }

        private IBaseFilter CreateFilter(Guid category, string friendlyname)
        {
            object source = null;
            Guid iid = typeof(IBaseFilter).GUID;
            foreach (DsDevice device in DsDevice.GetDevicesOfCat(category))
            {
                if (device.Name.CompareTo(friendlyname) == 0)
                {
                    device.Mon.BindToObject(null, null, ref iid, out source);
                    break;
                }
            }

            return (IBaseFilter)source;
        }

        void initGraph(Rectangle rect, IntPtr hwnd)
        {
            pGB = (IGraphBuilder)new FilterGraph();
            pVmr = (IBaseFilter)new VideoMixingRenderer9();
            pGB.AddFilter(pVmr, "Video");
            
            pConfig = (IVMRFilterConfig9)pVmr;
            pConfig.SetRenderingMode(VMR9Mode.Windowless);
            pWC = (IVMRWindowlessControl9)pVmr;

            pWC.SetVideoPosition(null, DsRect.FromRectangle(rect));
            pWC.SetVideoClippingWindow(hwnd);

            pMix = (IVMRMixerControl9)pVmr;
            pMs = (IMediaSeeking)pGB;
            pMC = (IMediaControl)pGB;
            
            ICaptureGraphBuilder2 cc = (ICaptureGraphBuilder2)new CaptureGraphBuilder2();
            cc.SetFiltergraph(pGB);
            pGB.AddFilter(devices[0], "Camera-1");
            pGB.AddFilter(devices[1], "Camera-2");

            Rectangle win = rect;
            float _w = win.Width;
            float _H = win.Height;

            NormalizedRect _0rect = new NormalizedRect();
            _0rect.top = win.Top;
            _0rect.left = win.Left;
            _0rect.right = (win.Left + win.Width / 2) / _w;
            _0rect.bottom = (win.Bottom / _H);
            
            NormalizedRect _1rect = new NormalizedRect();
            _1rect.top = win.Top;
            _1rect.left = (win.Left + win.Width / 2) / _w; ;
            _1rect.right = win.Right / _w;
            _1rect.bottom = win.Bottom / _H;
            
            pMix.SetOutputRect(0, _0rect);
            pMix.SetOutputRect(1, _1rect);

            int hr = 0;
            hr = cc.RenderStream(PinCategory.Capture, MediaType.Video, devices[0], null, pVmr);
            DsError.ThrowExceptionForHR(hr);
            hr = cc.RenderStream(PinCategory.Capture, MediaType.Video, devices[1], null, pVmr);
            DsError.ThrowExceptionForHR(hr);

            Marshal.ReleaseComObject(cc);
        }

        private void btn_song_song_Click(object sender, EventArgs e)
        {
            if (mode == SINGLE)
            {
                mode = DUAL;

                Rectangle win = panel1.ClientRectangle;
                float _w = win.Width;
                float _H = win.Height;

                _0rect.top = win.Top;
                _0rect.left = win.Left;
                _0rect.right = (win.Left + win.Width / 2) / _w;
                _0rect.bottom = (win.Bottom / _H);

                _1rect.top = win.Top;
                _1rect.left = (win.Left + win.Width / 2) / _w; ;
                _1rect.right = win.Right / _w;
                _1rect.bottom = win.Bottom / _H;

                pMix.SetOutputRect(0, _0rect);
                pMix.SetOutputRect(1, _1rect);
            }
            else
            {
                mode = SINGLE;

                Rectangle win = panel1.ClientRectangle;
                float _w = win.Width;
                float _H = win.Height;

                _0rect.top = win.Top;
                _0rect.left = win.Left;
                _0rect.right = (win.Left + win.Width) / _w;
                _0rect.bottom = (win.Bottom / _H);

                _1rect.top = win.Top;
                _1rect.left = win.Left;
                _1rect.right = win.Left;
                _1rect.bottom = win.Top;

                pMix.SetOutputRect(0, _0rect);
                pMix.SetOutputRect(1, _1rect);
            }
        }

        private void btn_doi_ben_Click(object sender, EventArgs e)
        {
            NormalizedRect tmp;
            tmp.top = _0rect.top;
            tmp.left = _0rect.left;
            tmp.right = _0rect.right;
            tmp.bottom = _0rect.bottom;

            _0rect.top = _1rect.top;
            _0rect.left = _1rect.left;
            _0rect.right = _1rect.right;
            _0rect.bottom = _1rect.bottom;

            _1rect.top = tmp.top;
            _1rect.left = tmp.left;
            _1rect.right = tmp.right;
            _1rect.bottom = tmp.bottom;

            pMix.SetOutputRect(0, _0rect);
            pMix.SetOutputRect(1, _1rect);
        }

        private void btn_thu_nho_Click(object sender, EventArgs e)
        {
            Rectangle win = panel1.ClientRectangle;
            float _w = win.Width;
            float _H = win.Height;

            const int PADDING = 5;
            const float FACTOR = 0.63f;

            _0rect.top = win.Top;
            _0rect.left = win.Left;
            _0rect.right = (win.Left + win.Width) / _w;
            _0rect.bottom = (win.Bottom / _H);

            _1rect.top = (win.Top + _H * FACTOR) / _H;
            _1rect.left = (win.Left + _w * FACTOR) / _w;
            _1rect.right = (win.Left + win.Width - PADDING) / _w;
            _1rect.bottom = ((win.Bottom - PADDING) / _H);

            pMix.SetOutputRect(0, _0rect);
            pMix.SetOutputRect(1, _1rect);
        }

        private void btn_ket_thuc_Click(object sender, EventArgs e)
        {
            WriteDVD formWriteDVD = new WriteDVD();
            formWriteDVD.Show();
        }

        private void softwareInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }
    }
}
