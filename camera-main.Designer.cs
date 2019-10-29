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
            this.btn_doi_ben = new System.Windows.Forms.Button();
            this.btn_thu_nho = new System.Windows.Forms.Button();
            this.btn_song_song = new System.Windows.Forms.Button();
            this.btn_ket_thuc = new System.Windows.Forms.Button();
            this.btn_xem_lai = new System.Windows.Forms.Button();
            this.btn_tam_dung = new System.Windows.Forms.Button();
            this.btn_ghi_hinh = new System.Windows.Forms.Button();
            this.total_time_text = new System.Windows.Forms.Label();
            this.time_left_text = new System.Windows.Forms.Label();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1651, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiênLàmViệcMớiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // phiênLàmViệcMớiToolStripMenuItem
            // 
            this.phiênLàmViệcMớiToolStripMenuItem.Name = "phiênLàmViệcMớiToolStripMenuItem";
            this.phiênLàmViệcMớiToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.phiênLàmViệcMớiToolStripMenuItem.Text = "Phiên làm việc mới";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.settingsToolStripMenuItem.Text = "Cài đặt";
            // 
            // softwareInfoToolStripMenuItem
            // 
            this.softwareInfoToolStripMenuItem.Name = "softwareInfoToolStripMenuItem";
            this.softwareInfoToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.softwareInfoToolStripMenuItem.Text = "Thông tin phần mềm";
            this.softwareInfoToolStripMenuItem.Click += new System.EventHandler(this.softwareInfoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 647);
            this.panel1.TabIndex = 1;
            // 
            // lb_total_time
            // 
            this.lb_total_time.AutoSize = true;
            this.lb_total_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_time.Location = new System.Drawing.Point(987, 704);
            this.lb_total_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_total_time.Name = "lb_total_time";
            this.lb_total_time.Size = new System.Drawing.Size(205, 20);
            this.lb_total_time.TabIndex = 5;
            this.lb_total_time.Text = "Tông thời gian đã ghi hình:";
            // 
            // lb_time_left
            // 
            this.lb_time_left.AutoSize = true;
            this.lb_time_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time_left.Location = new System.Drawing.Point(987, 740);
            this.lb_time_left.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_time_left.Name = "lb_time_left";
            this.lb_time_left.Size = new System.Drawing.Size(136, 20);
            this.lb_time_left.TabIndex = 6;
            this.lb_time_left.Text = "Thời gian còn lại:";
            // 
            // btn_doi_ben
            // 
            this.btn_doi_ben.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doi_ben.Image = global::DxPropPages.Properties.Resources._2_1_doc;
            this.btn_doi_ben.Location = new System.Drawing.Point(1535, 33);
            this.btn_doi_ben.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_doi_ben.Name = "btn_doi_ben";
            this.btn_doi_ben.Size = new System.Drawing.Size(116, 96);
            this.btn_doi_ben.TabIndex = 10;
            this.btn_doi_ben.Text = "Đổi bên";
            this.btn_doi_ben.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_doi_ben.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_doi_ben.UseVisualStyleBackColor = true;
            this.btn_doi_ben.Click += new System.EventHandler(this.btn_doi_ben_Click);
            // 
            // btn_thu_nho
            // 
            this.btn_thu_nho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thu_nho.Image = global::DxPropPages.Properties.Resources.bpjkjejdannjfahgbahegaendgjgnpci;
            this.btn_thu_nho.Location = new System.Drawing.Point(1535, 137);
            this.btn_thu_nho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thu_nho.Name = "btn_thu_nho";
            this.btn_thu_nho.Size = new System.Drawing.Size(116, 96);
            this.btn_thu_nho.TabIndex = 9;
            this.btn_thu_nho.Text = "Thu nhỏ";
            this.btn_thu_nho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_thu_nho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_thu_nho.UseVisualStyleBackColor = true;
            this.btn_thu_nho.Click += new System.EventHandler(this.btn_thu_nho_Click);
            // 
            // btn_song_song
            // 
            this.btn_song_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_song_song.Image = global::DxPropPages.Properties.Resources._1_2_doc;
            this.btn_song_song.Location = new System.Drawing.Point(1396, 33);
            this.btn_song_song.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_song_song.Name = "btn_song_song";
            this.btn_song_song.Size = new System.Drawing.Size(131, 96);
            this.btn_song_song.TabIndex = 8;
            this.btn_song_song.Text = "Song song";
            this.btn_song_song.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_song_song.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_song_song.UseVisualStyleBackColor = true;
            this.btn_song_song.Click += new System.EventHandler(this.btn_song_song_Click);
            // 
            // btn_ket_thuc
            // 
            this.btn_ket_thuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ket_thuc.Image = global::DxPropPages.Properties.Resources.stop_button;
            this.btn_ket_thuc.Location = new System.Drawing.Point(732, 704);
            this.btn_ket_thuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ket_thuc.Name = "btn_ket_thuc";
            this.btn_ket_thuc.Size = new System.Drawing.Size(121, 71);
            this.btn_ket_thuc.TabIndex = 7;
            this.btn_ket_thuc.Text = "Kết thúc (F8)";
            this.btn_ket_thuc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ket_thuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ket_thuc.UseVisualStyleBackColor = true;
            this.btn_ket_thuc.Click += new System.EventHandler(this.btn_ket_thuc_Click);
            // 
            // btn_xem_lai
            // 
            this.btn_xem_lai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem_lai.Image = global::DxPropPages.Properties.Resources.Hopstarter_Soft_Scraps_Button_Play;
            this.btn_xem_lai.Location = new System.Drawing.Point(389, 704);
            this.btn_xem_lai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xem_lai.Name = "btn_xem_lai";
            this.btn_xem_lai.Size = new System.Drawing.Size(131, 71);
            this.btn_xem_lai.TabIndex = 4;
            this.btn_xem_lai.Text = "Xem lại (F7)";
            this.btn_xem_lai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_xem_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_xem_lai.UseVisualStyleBackColor = true;
            // 
            // btn_tam_dung
            // 
            this.btn_tam_dung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tam_dung.Image = global::DxPropPages.Properties.Resources.Custom_Icon_Design_Flatastic_8_Pause;
            this.btn_tam_dung.Location = new System.Drawing.Point(176, 705);
            this.btn_tam_dung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_tam_dung.Name = "btn_tam_dung";
            this.btn_tam_dung.Size = new System.Drawing.Size(123, 71);
            this.btn_tam_dung.TabIndex = 3;
            this.btn_tam_dung.Text = "Tạm dừng (F6)";
            this.btn_tam_dung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_tam_dung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_tam_dung.UseVisualStyleBackColor = true;
            // 
            // btn_ghi_hinh
            // 
            this.btn_ghi_hinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghi_hinh.Image = global::DxPropPages.Properties.Resources.record2;
            this.btn_ghi_hinh.Location = new System.Drawing.Point(16, 705);
            this.btn_ghi_hinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ghi_hinh.Name = "btn_ghi_hinh";
            this.btn_ghi_hinh.Size = new System.Drawing.Size(121, 71);
            this.btn_ghi_hinh.TabIndex = 2;
            this.btn_ghi_hinh.Text = "Ghi hình (F5)";
            this.btn_ghi_hinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ghi_hinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ghi_hinh.UseVisualStyleBackColor = true;
            // 
            // total_time_text
            // 
            this.total_time_text.AutoSize = true;
            this.total_time_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_time_text.Location = new System.Drawing.Point(1231, 704);
            this.total_time_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_time_text.Name = "total_time_text";
            this.total_time_text.Size = new System.Drawing.Size(50, 20);
            this.total_time_text.TabIndex = 11;
            this.total_time_text.Text = "15:15";
            // 
            // time_left_text
            // 
            this.time_left_text.AutoSize = true;
            this.time_left_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_left_text.Location = new System.Drawing.Point(1231, 740);
            this.time_left_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_left_text.Name = "time_left_text";
            this.time_left_text.Size = new System.Drawing.Size(50, 20);
            this.time_left_text.TabIndex = 12;
            this.time_left_text.Text = "50:59";
            // 
            // camera_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 806);
            this.Controls.Add(this.time_left_text);
            this.Controls.Add(this.total_time_text);
            this.Controls.Add(this.btn_doi_ben);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btn_doi_ben;
        private System.Windows.Forms.Label total_time_text;
        private System.Windows.Forms.Label time_left_text;
    }
}