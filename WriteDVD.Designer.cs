namespace DxPropPages
{
    partial class WriteDVD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.btnWriteDVD = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(12, 12);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(121, 21);
            this.deviceComboBox.TabIndex = 0;
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceComboBox_SelectedIndexChanged);
            // 
            // btnWriteDVD
            // 
            this.btnWriteDVD.Location = new System.Drawing.Point(12, 50);
            this.btnWriteDVD.Name = "btnWriteDVD";
            this.btnWriteDVD.Size = new System.Drawing.Size(121, 27);
            this.btnWriteDVD.TabIndex = 1;
            this.btnWriteDVD.Text = "Ghi DVD";
            this.btnWriteDVD.UseVisualStyleBackColor = true;
            this.btnWriteDVD.Click += new System.EventHandler(this.btnWriteDVD_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // WriteDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 113);
            this.Controls.Add(this.btnWriteDVD);
            this.Controls.Add(this.deviceComboBox);
            this.Name = "WriteDVD";
            this.Text = "Ghi Dia";
            this.Load += new System.EventHandler(this.WriteDVD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Button btnWriteDVD;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}