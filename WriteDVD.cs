using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using testMedia.DVD;
using IMAPI2.Interop;
using IMAPI2.MediaItem;

namespace DxPropPages
{
    public partial class WriteDVD : Form
    {

        DVD_1 dvd_1 = new DVD_1();
        List<IDiscRecorder2> RecordDisk_List = new List<IDiscRecorder2>();

        public WriteDVD()
        {
            InitializeComponent();

            // find all disk on computer
            deviceComboBox.SelectedIndex = -1;
            RecordDisk_List = dvd_1.findAllDisk();
            foreach (IDiscRecorder2 d in RecordDisk_List)
            {
                //MessageBox.Show(d.ProductId);
                deviceComboBox.Items.Add(d.ProductId);
            }
        }

        private void WriteDVD_Load(object sender, EventArgs e)
        {

        }

        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("----------- " + deviceComboBox.SelectedIndex);
        }

        private void btnWriteDVD_Click(object sender, EventArgs e)
        {
            if (deviceComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose CD/DVD disk!");
                return;
            }
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var fileItem = new FileItem(openFileDialog.FileName);
                dvd_1.burnFile2Disk(RecordDisk_List.ElementAt(deviceComboBox.SelectedIndex), fileItem);
            }
        }
    }
}
