namespace WindowsFormsApp1
{
    partial class form_thongtin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_thongtin));
            this.btn_dangXuat = new System.Windows.Forms.Button();
            this.grb_menu = new System.Windows.Forms.GroupBox();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.lbl_nhapDiem = new System.Windows.Forms.Label();
            this.lbl_nhapMONHOCvaDiem = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_SinhVien = new System.Windows.Forms.Label();
            this.lbl_Admin = new System.Windows.Forms.Label();
            this.ptb_iconNhapThongTIn = new System.Windows.Forms.PictureBox();
            this.ptb_hinhGiaoDien = new System.Windows.Forms.PictureBox();
            this.grb_HinhAnhTrangTri = new System.Windows.Forms.GroupBox();
            this.grb_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_iconNhapThongTIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinhGiaoDien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_dangXuat.AutoSize = true;
            this.btn_dangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btn_dangXuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dangXuat.BackgroundImage")));
            this.btn_dangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangXuat.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangXuat.ForeColor = System.Drawing.Color.Red;
            this.btn_dangXuat.Location = new System.Drawing.Point(16, 566);
            this.btn_dangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Size = new System.Drawing.Size(92, 65);
            this.btn_dangXuat.TabIndex = 0;
            this.btn_dangXuat.UseVisualStyleBackColor = false;
            this.btn_dangXuat.Click += new System.EventHandler(this.btn_dangXuat_Click);
            // 
            // grb_menu
            // 
            this.grb_menu.BackColor = System.Drawing.Color.MidnightBlue;
            this.grb_menu.Controls.Add(this.lbl_Lop);
            this.grb_menu.Controls.Add(this.lbl_nhapDiem);
            this.grb_menu.Controls.Add(this.lbl_nhapMONHOCvaDiem);
            this.grb_menu.Controls.Add(this.pictureBox3);
            this.grb_menu.Controls.Add(this.pictureBox2);
            this.grb_menu.Controls.Add(this.pictureBox1);
            this.grb_menu.Controls.Add(this.btn_dangXuat);
            this.grb_menu.Controls.Add(this.lbl_SinhVien);
            this.grb_menu.Controls.Add(this.lbl_Admin);
            this.grb_menu.Controls.Add(this.ptb_iconNhapThongTIn);
            this.grb_menu.Controls.Add(this.ptb_hinhGiaoDien);
            this.grb_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.grb_menu.Location = new System.Drawing.Point(0, 0);
            this.grb_menu.Margin = new System.Windows.Forms.Padding(2);
            this.grb_menu.Name = "grb_menu";
            this.grb_menu.Padding = new System.Windows.Forms.Padding(2);
            this.grb_menu.Size = new System.Drawing.Size(248, 648);
            this.grb_menu.TabIndex = 2;
            this.grb_menu.TabStop = false;
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Lop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lop.ForeColor = System.Drawing.Color.Red;
            this.lbl_Lop.Location = new System.Drawing.Point(86, 444);
            this.lbl_Lop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(53, 28);
            this.lbl_Lop.TabIndex = 10;
            this.lbl_Lop.Text = "Lớp";
            this.lbl_Lop.Click += new System.EventHandler(this.lbl_Lop_Click);
            // 
            // lbl_nhapDiem
            // 
            this.lbl_nhapDiem.AutoSize = true;
            this.lbl_nhapDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_nhapDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhapDiem.ForeColor = System.Drawing.Color.Red;
            this.lbl_nhapDiem.Location = new System.Drawing.Point(86, 364);
            this.lbl_nhapDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nhapDiem.Name = "lbl_nhapDiem";
            this.lbl_nhapDiem.Size = new System.Drawing.Size(70, 28);
            this.lbl_nhapDiem.TabIndex = 9;
            this.lbl_nhapDiem.Text = "Điểm";
            this.lbl_nhapDiem.Click += new System.EventHandler(this.lbl_nhapDiem_Click);
            // 
            // lbl_nhapMONHOCvaDiem
            // 
            this.lbl_nhapMONHOCvaDiem.AutoSize = true;
            this.lbl_nhapMONHOCvaDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_nhapMONHOCvaDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nhapMONHOCvaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhapMONHOCvaDiem.ForeColor = System.Drawing.Color.Red;
            this.lbl_nhapMONHOCvaDiem.Location = new System.Drawing.Point(86, 297);
            this.lbl_nhapMONHOCvaDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nhapMONHOCvaDiem.Name = "lbl_nhapMONHOCvaDiem";
            this.lbl_nhapMONHOCvaDiem.Size = new System.Drawing.Size(108, 28);
            this.lbl_nhapMONHOCvaDiem.TabIndex = 8;
            this.lbl_nhapMONHOCvaDiem.Text = "Môn Học";
            this.lbl_nhapMONHOCvaDiem.Click += new System.EventHandler(this.lbl_nhapMONHOCvaDiem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(4, 433);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 47);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 356);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 47);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 286);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 47);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_SinhVien
            // 
            this.lbl_SinhVien.AutoSize = true;
            this.lbl_SinhVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_SinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SinhVien.ForeColor = System.Drawing.Color.Red;
            this.lbl_SinhVien.Location = new System.Drawing.Point(86, 219);
            this.lbl_SinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SinhVien.Name = "lbl_SinhVien";
            this.lbl_SinhVien.Size = new System.Drawing.Size(117, 28);
            this.lbl_SinhVien.TabIndex = 4;
            this.lbl_SinhVien.Text = "Sinh Viên";
            this.lbl_SinhVien.Click += new System.EventHandler(this.lbl_nhapThongTin_Click);
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Admin.AutoSize = true;
            this.lbl_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Admin.Location = new System.Drawing.Point(112, 576);
            this.lbl_Admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(117, 36);
            this.lbl_Admin.TabIndex = 3;
            this.lbl_Admin.Text = "ADMIN";
            // 
            // ptb_iconNhapThongTIn
            // 
            this.ptb_iconNhapThongTIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_iconNhapThongTIn.BackgroundImage")));
            this.ptb_iconNhapThongTIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_iconNhapThongTIn.Location = new System.Drawing.Point(4, 210);
            this.ptb_iconNhapThongTIn.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_iconNhapThongTIn.Name = "ptb_iconNhapThongTIn";
            this.ptb_iconNhapThongTIn.Size = new System.Drawing.Size(59, 47);
            this.ptb_iconNhapThongTIn.TabIndex = 1;
            this.ptb_iconNhapThongTIn.TabStop = false;
            // 
            // ptb_hinhGiaoDien
            // 
            this.ptb_hinhGiaoDien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_hinhGiaoDien.BackgroundImage")));
            this.ptb_hinhGiaoDien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_hinhGiaoDien.Location = new System.Drawing.Point(62, 26);
            this.ptb_hinhGiaoDien.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_hinhGiaoDien.Name = "ptb_hinhGiaoDien";
            this.ptb_hinhGiaoDien.Size = new System.Drawing.Size(108, 99);
            this.ptb_hinhGiaoDien.TabIndex = 0;
            this.ptb_hinhGiaoDien.TabStop = false;
            this.ptb_hinhGiaoDien.Click += new System.EventHandler(this.ptb_hinhGiaoDien_Click);
            // 
            // grb_HinhAnhTrangTri
            // 
            this.grb_HinhAnhTrangTri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_HinhAnhTrangTri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grb_HinhAnhTrangTri.BackgroundImage")));
            this.grb_HinhAnhTrangTri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grb_HinhAnhTrangTri.Location = new System.Drawing.Point(253, 0);
            this.grb_HinhAnhTrangTri.Margin = new System.Windows.Forms.Padding(2);
            this.grb_HinhAnhTrangTri.Name = "grb_HinhAnhTrangTri";
            this.grb_HinhAnhTrangTri.Padding = new System.Windows.Forms.Padding(2);
            this.grb_HinhAnhTrangTri.Size = new System.Drawing.Size(605, 638);
            this.grb_HinhAnhTrangTri.TabIndex = 3;
            this.grb_HinhAnhTrangTri.TabStop = false;
            this.grb_HinhAnhTrangTri.Enter += new System.EventHandler(this.grb_HinhAnhTrangTri_Enter);
            // 
            // form_thongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(855, 648);
            this.Controls.Add(this.grb_HinhAnhTrangTri);
            this.Controls.Add(this.grb_menu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_thongtin";
            this.Text = "Thông Tin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.form_thongtin_Load);
            this.grb_menu.ResumeLayout(false);
            this.grb_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_iconNhapThongTIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinhGiaoDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dangXuat;
        private System.Windows.Forms.GroupBox grb_menu;
        private System.Windows.Forms.PictureBox ptb_hinhGiaoDien;
        private System.Windows.Forms.PictureBox ptb_iconNhapThongTIn;
        private System.Windows.Forms.Label lbl_Admin;
        private System.Windows.Forms.Label lbl_SinhVien;
        private System.Windows.Forms.GroupBox grb_HinhAnhTrangTri;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nhapMONHOCvaDiem;
        private System.Windows.Forms.Label lbl_nhapDiem;
        private System.Windows.Forms.Label lbl_Lop;
    }
}