namespace WindowsFormsApp1.GUI
{
    partial class form_nhapMONHOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_nhapMONHOC));
            this.dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.MA_MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_HOC_PHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_KHOA_HOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_MSSV = new System.Windows.Forms.Label();
            this.lbl_tenMH = new System.Windows.Forms.Label();
            this.lbl_SoHP = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.txt_MAMONHOC = new System.Windows.Forms.TextBox();
            this.txt_TENMONHOC = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.nud_SOHP = new System.Windows.Forms.NumericUpDown();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.lbl_ThôngtinnhapMONHOC = new System.Windows.Forms.Label();
            this.grb_NhapThongTin = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_timtheoM_MH = new System.Windows.Forms.Label();
            this.cbb_TimMa_MH = new System.Windows.Forms.ComboBox();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SOHP)).BeginInit();
            this.grb_NhapThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_MonHoc
            // 
            this.dgv_MonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_MH,
            this.TEN_MH,
            this.SO_HOC_PHAN,
            this.MA_KHOA_HOC});
            this.dgv_MonHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_MonHoc.Location = new System.Drawing.Point(721, 18);
            this.dgv_MonHoc.Name = "dgv_MonHoc";
            this.dgv_MonHoc.RowHeadersWidth = 51;
            this.dgv_MonHoc.RowTemplate.Height = 24;
            this.dgv_MonHoc.Size = new System.Drawing.Size(361, 797);
            this.dgv_MonHoc.TabIndex = 7;
            this.dgv_MonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MonHoc_CellClick);
            // 
            // MA_MH
            // 
            this.MA_MH.DataPropertyName = "MA_MH";
            this.MA_MH.HeaderText = "MÃ MÔN HỌC";
            this.MA_MH.MinimumWidth = 6;
            this.MA_MH.Name = "MA_MH";
            this.MA_MH.Width = 125;
            // 
            // TEN_MH
            // 
            this.TEN_MH.DataPropertyName = "TEN_MH";
            this.TEN_MH.HeaderText = "TÊN MÔN HỌC";
            this.TEN_MH.MinimumWidth = 6;
            this.TEN_MH.Name = "TEN_MH";
            this.TEN_MH.Width = 125;
            // 
            // SO_HOC_PHAN
            // 
            this.SO_HOC_PHAN.DataPropertyName = "SO_HOC_PHAN";
            this.SO_HOC_PHAN.HeaderText = "SỐ HỌC PHẦN";
            this.SO_HOC_PHAN.MinimumWidth = 6;
            this.SO_HOC_PHAN.Name = "SO_HOC_PHAN";
            this.SO_HOC_PHAN.Width = 125;
            // 
            // MA_KHOA_HOC
            // 
            this.MA_KHOA_HOC.DataPropertyName = "MA_KHOA_HOC";
            this.MA_KHOA_HOC.HeaderText = "MÃ KHÓA HỌC";
            this.MA_KHOA_HOC.MinimumWidth = 6;
            this.MA_KHOA_HOC.Name = "MA_KHOA_HOC";
            this.MA_KHOA_HOC.Width = 125;
            // 
            // lbl_MSSV
            // 
            this.lbl_MSSV.AutoSize = true;
            this.lbl_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MSSV.Location = new System.Drawing.Point(37, 106);
            this.lbl_MSSV.Name = "lbl_MSSV";
            this.lbl_MSSV.Size = new System.Drawing.Size(191, 32);
            this.lbl_MSSV.TabIndex = 18;
            this.lbl_MSSV.Text = "Mã Môn Học:";
            // 
            // lbl_tenMH
            // 
            this.lbl_tenMH.AutoSize = true;
            this.lbl_tenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenMH.Location = new System.Drawing.Point(27, 190);
            this.lbl_tenMH.Name = "lbl_tenMH";
            this.lbl_tenMH.Size = new System.Drawing.Size(210, 32);
            this.lbl_tenMH.TabIndex = 19;
            this.lbl_tenMH.Text = "Tên Môn Học :";
            // 
            // lbl_SoHP
            // 
            this.lbl_SoHP.AutoSize = true;
            this.lbl_SoHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoHP.Location = new System.Drawing.Point(37, 284);
            this.lbl_SoHP.Name = "lbl_SoHP";
            this.lbl_SoHP.Size = new System.Drawing.Size(200, 32);
            this.lbl_SoHP.TabIndex = 20;
            this.lbl_SoHP.Text = "Số Học Phần:";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(37, 400);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(212, 32);
            this.lbl_GioiTinh.TabIndex = 21;
            this.lbl_GioiTinh.Text = "Mã Khóa Học :";
            // 
            // txt_MAMONHOC
            // 
            this.txt_MAMONHOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAMONHOC.Location = new System.Drawing.Point(278, 100);
            this.txt_MAMONHOC.Name = "txt_MAMONHOC";
            this.txt_MAMONHOC.Size = new System.Drawing.Size(393, 38);
            this.txt_MAMONHOC.TabIndex = 26;
            // 
            // txt_TENMONHOC
            // 
            this.txt_TENMONHOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENMONHOC.Location = new System.Drawing.Point(278, 190);
            this.txt_TENMONHOC.Name = "txt_TENMONHOC";
            this.txt_TENMONHOC.Size = new System.Drawing.Size(393, 38);
            this.txt_TENMONHOC.TabIndex = 27;
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.BackgroundImage")));
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them.Location = new System.Drawing.Point(25, 732);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(151, 99);
            this.btn_Them.TabIndex = 36;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sua.Location = new System.Drawing.Point(205, 732);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(151, 99);
            this.btn_Sua.TabIndex = 37;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.BackgroundImage")));
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Xoa.Location = new System.Drawing.Point(386, 732);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(151, 99);
            this.btn_Xoa.TabIndex = 38;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tim.BackgroundImage")));
            this.btn_Tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tim.Location = new System.Drawing.Point(552, 732);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(151, 99);
            this.btn_Tim.TabIndex = 39;
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // nud_SOHP
            // 
            this.nud_SOHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_SOHP.Location = new System.Drawing.Point(278, 284);
            this.nud_SOHP.Name = "nud_SOHP";
            this.nud_SOHP.Size = new System.Drawing.Size(393, 38);
            this.nud_SOHP.TabIndex = 42;
            // 
            // txt_maKH
            // 
            this.txt_maKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maKH.Location = new System.Drawing.Point(278, 382);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(393, 38);
            this.txt_maKH.TabIndex = 43;
            // 
            // lbl_ThôngtinnhapMONHOC
            // 
            this.lbl_ThôngtinnhapMONHOC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ThôngtinnhapMONHOC.AutoSize = true;
            this.lbl_ThôngtinnhapMONHOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThôngtinnhapMONHOC.Location = new System.Drawing.Point(216, 6);
            this.lbl_ThôngtinnhapMONHOC.Name = "lbl_ThôngtinnhapMONHOC";
            this.lbl_ThôngtinnhapMONHOC.Size = new System.Drawing.Size(215, 36);
            this.lbl_ThôngtinnhapMONHOC.TabIndex = 52;
            this.lbl_ThôngtinnhapMONHOC.Text = "Nhập Môn Học";
            // 
            // grb_NhapThongTin
            // 
            this.grb_NhapThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grb_NhapThongTin.Controls.Add(this.btn_Reset);
            this.grb_NhapThongTin.Controls.Add(this.lbl_timtheoM_MH);
            this.grb_NhapThongTin.Controls.Add(this.cbb_TimMa_MH);
            this.grb_NhapThongTin.Controls.Add(this.btn_QuayLai);
            this.grb_NhapThongTin.Controls.Add(this.lbl_ThôngtinnhapMONHOC);
            this.grb_NhapThongTin.Controls.Add(this.txt_maKH);
            this.grb_NhapThongTin.Controls.Add(this.nud_SOHP);
            this.grb_NhapThongTin.Controls.Add(this.btn_Tim);
            this.grb_NhapThongTin.Controls.Add(this.btn_Xoa);
            this.grb_NhapThongTin.Controls.Add(this.btn_Sua);
            this.grb_NhapThongTin.Controls.Add(this.btn_Them);
            this.grb_NhapThongTin.Controls.Add(this.txt_TENMONHOC);
            this.grb_NhapThongTin.Controls.Add(this.txt_MAMONHOC);
            this.grb_NhapThongTin.Controls.Add(this.lbl_GioiTinh);
            this.grb_NhapThongTin.Controls.Add(this.lbl_SoHP);
            this.grb_NhapThongTin.Controls.Add(this.lbl_tenMH);
            this.grb_NhapThongTin.Controls.Add(this.lbl_MSSV);
            this.grb_NhapThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grb_NhapThongTin.Location = new System.Drawing.Point(12, 12);
            this.grb_NhapThongTin.Name = "grb_NhapThongTin";
            this.grb_NhapThongTin.Size = new System.Drawing.Size(703, 1114);
            this.grb_NhapThongTin.TabIndex = 6;
            this.grb_NhapThongTin.TabStop = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(0, 981);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(176, 59);
            this.btn_Reset.TabIndex = 43;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_timtheoM_MH
            // 
            this.lbl_timtheoM_MH.AutoSize = true;
            this.lbl_timtheoM_MH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timtheoM_MH.Location = new System.Drawing.Point(18, 491);
            this.lbl_timtheoM_MH.Name = "lbl_timtheoM_MH";
            this.lbl_timtheoM_MH.Size = new System.Drawing.Size(231, 25);
            this.lbl_timtheoM_MH.TabIndex = 56;
            this.lbl_timtheoM_MH.Text = "Tìm theo Mã Môn Học:";
            // 
            // cbb_TimMa_MH
            // 
            this.cbb_TimMa_MH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimMa_MH.FormattingEnabled = true;
            this.cbb_TimMa_MH.Location = new System.Drawing.Point(278, 477);
            this.cbb_TimMa_MH.Name = "cbb_TimMa_MH";
            this.cbb_TimMa_MH.Size = new System.Drawing.Size(393, 39);
            this.cbb_TimMa_MH.TabIndex = 55;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QuayLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuayLai.BackgroundImage")));
            this.btn_QuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuayLai.Location = new System.Drawing.Point(572, 935);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(125, 96);
            this.btn_QuayLai.TabIndex = 54;
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click_1);
            // 
            // form_nhapMONHOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 1055);
            this.Controls.Add(this.dgv_MonHoc);
            this.Controls.Add(this.grb_NhapThongTin);
            this.Name = "form_nhapMONHOC";
            this.Text = "Nhập môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_nhapMONHOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SOHP)).EndInit();
            this.grb_NhapThongTin.ResumeLayout(false);
            this.grb_NhapThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_MonHoc;
        private System.Windows.Forms.Label lbl_MSSV;
        private System.Windows.Forms.Label lbl_tenMH;
        private System.Windows.Forms.Label lbl_SoHP;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.TextBox txt_MAMONHOC;
        private System.Windows.Forms.TextBox txt_TENMONHOC;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.NumericUpDown nud_SOHP;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.Label lbl_ThôngtinnhapMONHOC;
        private System.Windows.Forms.GroupBox grb_NhapThongTin;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.ComboBox cbb_TimMa_MH;
        private System.Windows.Forms.Label lbl_timtheoM_MH;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_HOC_PHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_KHOA_HOC;
    }
}