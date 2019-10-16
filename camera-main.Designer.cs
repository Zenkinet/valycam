namespace DxPropPages
{
    partial class camera_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiênLàmViệcMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_total_time = new System.Windows.Forms.Label();
            this.lb_time_left = new System.Windows.Forms.Label();
            this.btn_song_song = new System.Windows.Forms.Button();
            this.btn_ket_thuc = new System.Windows.Forms.Button();
            this.btn_xem_lai = new System.Windows.Forms.Button();
            this.btn_tam_dung = new System.Windows.Forms.Button();
            this.btn_ghi_hinh = new System.Windows.Forms.Button();
            this.btn_thu_nho = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.softwareInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiênLàmViệcMớiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // phiênLàmViệcMớiToolStripMenuItem
            // 
            this.phiênLàmViệcMớiToolStripMenuItem.Name = "phiênLàmViệcMớiToolStripMenuItem";
            this.phiênLàmViệcMớiToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.phiênLàmViệcMớiToolStripMenuItem.Text = "Phiên làm việc mới";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingsToolStripMenuItem.Text = "Cài đặt";
            // 
            // softwareInfoToolStripMenuItem
            // 
            this.softwareInfoToolStripMenuItem.Name = "softwareInfoToolStripMenuItem";
            this.softwareInfoToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.softwareInfoToolStripMenuItem.Text = "Thông tin phần mềm";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 526);
            this.panel1.TabIndex = 1;
            // 
            // lb_total_time
            // 
            this.lb_total_time.AutoSize = true;
            this.lb_total_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_time.Location = new System.Drawing.Point(740, 572);
            this.lb_total_time.Name = "lb_total_time";
            this.lb_total_time.Size = new System.Drawing.Size(177, 17);
            this.lb_total_time.TabIndex = 5;
            this.lb_total_time.Text = "Tông thời gian đã ghi hình:";
            // 
            // lb_time_left
            // 
            this.lb_time_left.AutoSize = true;
            this.lb_time_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time_left.Location = new System.Drawing.Point(740, 601);
            this.lb_time_left.Name = "lb_time_left";
            this.lb_time_left.Size = new System.Drawing.Size(116, 17);
            this.lb_time_left.TabIndex = 6;
            this.lb_time_left.Text = "Thời gian còn lại:";
            // 
            // btn_song_song
            // 
            this.btn_song_song.Image = global::DxPropPages.Properties.Resources._1_2_doc;
            this.btn_song_song.Location = new System.Drawing.Point(1070, 27);
            this.btn_song_song.Name = "btn_song_song";
            this.btn_song_song.Size = new System.Drawing.Size(75, 58);
            this.btn_song_song.TabIndex = 8;
            this.btn_song_song.Text = "Song song";
            this.btn_song_song.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_song_song.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_song_song.UseVisualStyleBackColor = true;
            // 
            // btn_ket_thuc
            // 
            this.btn_ket_thuc.Image = global::DxPropPages.Properties.Resources.stop_button;
            this.btn_ket_thuc.Location = new System.Drawing.Point(565, 572);
            this.btn_ket_thuc.Name = "btn_ket_thuc";
            this.btn_ket_thuc.Size = new System.Drawing.Size(75, 58);
            this.btn_ket_thuc.TabIndex = 7;
            this.btn_ket_thuc.Text = "Kết thúc (F8)";
            this.btn_ket_thuc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ket_thuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ket_thuc.UseVisualStyleBackColor = true;
            // 
            // btn_xem_lai
            // 
            this.btn_xem_lai.Image = global::DxPropPages.Properties.Resources.Hopstarter_Soft_Scraps_Button_Play;
            this.btn_xem_lai.Location = new System.Drawing.Point(322, 572);
            this.btn_xem_lai.Name = "btn_xem_lai";
            this.btn_xem_lai.Size = new System.Drawing.Size(75, 58);
            this.btn_xem_lai.TabIndex = 4;
            this.btn_xem_lai.Text = "Xem lại (F7)";
            this.btn_xem_lai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_xem_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_xem_lai.UseVisualStyleBackColor = true;
            // 
            // btn_tam_dung
            // 
            this.btn_tam_dung.Image = global::DxPropPages.Properties.Resources.Custom_Icon_Design_Flatastic_8_Pause;
            this.btn_tam_dung.Location = new System.Drawing.Point(241, 572);
            this.btn_tam_dung.Name = "btn_tam_dung";
            this.btn_tam_dung.Size = new System.Drawing.Size(75, 58);
            this.btn_tam_dung.TabIndex = 3;
            this.btn_tam_dung.Text = "Tạm dừng (F6)";
            this.btn_tam_dung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_tam_dung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_tam_dung.UseVisualStyleBackColor = true;
            // 
            // btn_ghi_hinh
            // 
            this.btn_ghi_hinh.Image = global::DxPropPages.Properties.Resources.record2;
            this.btn_ghi_hinh.Location = new System.Drawing.Point(168, 572);
            this.btn_ghi_hinh.Name = "btn_ghi_hinh";
            this.btn_ghi_hinh.Size = new System.Drawing.Size(67, 58);
            this.btn_ghi_hinh.TabIndex = 2;
            this.btn_ghi_hinh.Text = "Ghi hình (F5)";
            this.btn_ghi_hinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ghi_hinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ghi_hinh.UseVisualStyleBackColor = true;
            // 
            // btn_thu_nho
            // 
            this.btn_thu_nho.Image = global::DxPropPages.Properties.Resources.bpjkjejdannjfahgbahegaendgjgnpci;
            this.btn_thu_nho.Location = new System.Drawing.Point(1151, 27);
            this.btn_thu_nho.Name = "btn_thu_nho";
            this.btn_thu_nho.Size = new System.Drawing.Size(75, 58);
            this.btn_thu_nho.TabIndex = 9;
            this.btn_thu_nho.Text = "Thu nhỏ";
            this.btn_thu_nho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_thu_nho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_thu_nho.UseVisualStyleBackColor = true;
            // 
            // camera_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 655);
            this.Controls.Add(this.btn_thu_nho);
            this.Controls.Add(this.btn_song_song);
            this.Controls.Add(this.btn_ket_thuc);
            this.Controls.Add(this.lb_time_left);
            this.Controls.Add(this.lb_total_time);
            this.Controls.Add(this.btn_xem_lai);
            this.Controls.Add(this.btn_tam_dung);
            this.Controls.Add(this.btn_ghi_hinh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "camera_main";
            this.Text = "Valy Camera";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiênLàmViệcMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareInfoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ghi_hinh;
        private System.Windows.Forms.Button btn_tam_dung;
        private System.Windows.Forms.Button btn_xem_lai;
        private System.Windows.Forms.Label lb_total_time;
        private System.Windows.Forms.Label lb_time_left;
        private System.Windows.Forms.Button btn_ket_thuc;
        private System.Windows.Forms.Button btn_song_song;
        private System.Windows.Forms.Button btn_thu_nho;
    }
}