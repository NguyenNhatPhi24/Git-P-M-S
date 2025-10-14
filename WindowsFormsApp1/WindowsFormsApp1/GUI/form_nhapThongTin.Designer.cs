namespace WindowsFormsApp1
{
    partial class form_nhapThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_nhapThongTin));
            this.txt_MaKhoaHoc = new System.Windows.Forms.TextBox();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.rdb_Nữ = new System.Windows.Forms.RadioButton();
            this.grb_NhapThongTin = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_tim = new System.Windows.Forms.Label();
            this.cbb_Tim = new System.Windows.Forms.ComboBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.lbl_MaKhoaHoc = new System.Windows.Forms.Label();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_MSSV = new System.Windows.Forms.Label();
            this.dgv_ThongTinSInhVien = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_LOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_KHOA_HOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_NhapThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinSInhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MaKhoaHoc
            // 
            this.txt_MaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKhoaHoc.Location = new System.Drawing.Point(309, 537);
            this.txt_MaKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaKhoaHoc.Name = "txt_MaKhoaHoc";
            this.txt_MaKhoaHoc.Size = new System.Drawing.Size(393, 38);
            this.txt_MaKhoaHoc.TabIndex = 34;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLop.Location = new System.Drawing.Point(309, 457);
            this.txt_MaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(393, 38);
            this.txt_MaLop.TabIndex = 33;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(309, 377);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(393, 38);
            this.txt_DiaChi.TabIndex = 32;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(309, 304);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(393, 38);
            this.txt_SDT.TabIndex = 31;
            // 
            // rdb_Nữ
            // 
            this.rdb_Nữ.AutoSize = true;
            this.rdb_Nữ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nữ.Location = new System.Drawing.Point(569, 222);
            this.rdb_Nữ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_Nữ.Name = "rdb_Nữ";
            this.rdb_Nữ.Size = new System.Drawing.Size(73, 36);
            this.rdb_Nữ.TabIndex = 30;
            this.rdb_Nữ.TabStop = true;
            this.rdb_Nữ.Text = "Nữ";
            this.rdb_Nữ.UseVisualStyleBackColor = true;
            // 
            // grb_NhapThongTin
            // 
            this.grb_NhapThongTin.Controls.Add(this.btn_Reset);
            this.grb_NhapThongTin.Controls.Add(this.lbl_tim);
            this.grb_NhapThongTin.Controls.Add(this.cbb_Tim);
            this.grb_NhapThongTin.Controls.Add(this.btn_Tim);
            this.grb_NhapThongTin.Controls.Add(this.btn_Xoa);
            this.grb_NhapThongTin.Controls.Add(this.btn_Sua);
            this.grb_NhapThongTin.Controls.Add(this.btn_Them);
            this.grb_NhapThongTin.Controls.Add(this.btn_QuayLai);
            this.grb_NhapThongTin.Controls.Add(this.txt_MaKhoaHoc);
            this.grb_NhapThongTin.Controls.Add(this.txt_MaLop);
            this.grb_NhapThongTin.Controls.Add(this.txt_DiaChi);
            this.grb_NhapThongTin.Controls.Add(this.txt_SDT);
            this.grb_NhapThongTin.Controls.Add(this.rdb_Nữ);
            this.grb_NhapThongTin.Controls.Add(this.rdb_Nam);
            this.grb_NhapThongTin.Controls.Add(this.dtp_NgaySinh);
            this.grb_NhapThongTin.Controls.Add(this.txt_HoTen);
            this.grb_NhapThongTin.Controls.Add(this.txt_MSSV);
            this.grb_NhapThongTin.Controls.Add(this.lbl_MaKhoaHoc);
            this.grb_NhapThongTin.Controls.Add(this.lbl_MaLop);
            this.grb_NhapThongTin.Controls.Add(this.lbl_DiaChi);
            this.grb_NhapThongTin.Controls.Add(this.lbl_SDT);
            this.grb_NhapThongTin.Controls.Add(this.lbl_GioiTinh);
            this.grb_NhapThongTin.Controls.Add(this.lbl_NgaySinh);
            this.grb_NhapThongTin.Controls.Add(this.lbl_HoTen);
            this.grb_NhapThongTin.Controls.Add(this.lbl_MSSV);
            this.grb_NhapThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grb_NhapThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.grb_NhapThongTin.Location = new System.Drawing.Point(0, 0);
            this.grb_NhapThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_NhapThongTin.Name = "grb_NhapThongTin";
            this.grb_NhapThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_NhapThongTin.Size = new System.Drawing.Size(715, 950);
            this.grb_NhapThongTin.TabIndex = 5;
            this.grb_NhapThongTin.TabStop = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(0, 855);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(188, 59);
            this.btn_Reset.TabIndex = 42;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_tim
            // 
            this.lbl_tim.AutoSize = true;
            this.lbl_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tim.Location = new System.Drawing.Point(48, 610);
            this.lbl_tim.Name = "lbl_tim";
            this.lbl_tim.Size = new System.Drawing.Size(219, 32);
            this.lbl_tim.TabIndex = 41;
            this.lbl_tim.Text = "Tìm theo MSSV:";
            // 
            // cbb_Tim
            // 
            this.cbb_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Tim.FormattingEnabled = true;
            this.cbb_Tim.Location = new System.Drawing.Point(309, 604);
            this.cbb_Tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_Tim.Name = "cbb_Tim";
            this.cbb_Tim.Size = new System.Drawing.Size(393, 39);
            this.cbb_Tim.TabIndex = 40;
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tim.BackgroundImage")));
            this.btn_Tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tim.Location = new System.Drawing.Point(557, 734);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(151, 98);
            this.btn_Tim.TabIndex = 39;
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.BackgroundImage")));
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Xoa.Location = new System.Drawing.Point(365, 734);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(151, 98);
            this.btn_Xoa.TabIndex = 38;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sua.Location = new System.Drawing.Point(172, 734);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(151, 98);
            this.btn_Sua.TabIndex = 37;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.BackgroundImage")));
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them.Location = new System.Drawing.Point(0, 734);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(151, 98);
            this.btn_Them.TabIndex = 36;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QuayLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuayLai.BackgroundImage")));
            this.btn_QuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuayLai.Location = new System.Drawing.Point(569, 842);
            this.btn_QuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(125, 96);
            this.btn_QuayLai.TabIndex = 35;
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nam.Location = new System.Drawing.Point(309, 222);
            this.rdb_Nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(97, 36);
            this.rdb_Nam.TabIndex = 29;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yy";
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(309, 154);
            this.dtp_NgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(393, 38);
            this.dtp_NgaySinh.TabIndex = 28;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(309, 82);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(393, 38);
            this.txt_HoTen.TabIndex = 27;
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MSSV.Location = new System.Drawing.Point(309, 18);
            this.txt_MSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(393, 38);
            this.txt_MSSV.TabIndex = 26;
            // 
            // lbl_MaKhoaHoc
            // 
            this.lbl_MaKhoaHoc.AutoSize = true;
            this.lbl_MaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaKhoaHoc.Location = new System.Drawing.Point(55, 537);
            this.lbl_MaKhoaHoc.Name = "lbl_MaKhoaHoc";
            this.lbl_MaKhoaHoc.Size = new System.Drawing.Size(212, 32);
            this.lbl_MaKhoaHoc.TabIndex = 25;
            this.lbl_MaKhoaHoc.Text = "Mã Khóa Học :";
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaLop.Location = new System.Drawing.Point(55, 457);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(131, 32);
            this.lbl_MaLop.TabIndex = 24;
            this.lbl_MaLop.Text = "Mã Lớp :";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(55, 377);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(139, 32);
            this.lbl_DiaChi.TabIndex = 23;
            this.lbl_DiaChi.Text = "Địa Chỉ : ";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(55, 304);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(224, 32);
            this.lbl_SDT.TabIndex = 22;
            this.lbl_SDT.Text = "Số Điện Thoại :";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(75, 222);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(155, 32);
            this.lbl_GioiTinh.TabIndex = 21;
            this.lbl_GioiTinh.Text = "Giới Tính :";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(75, 154);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(171, 32);
            this.lbl_NgaySinh.TabIndex = 20;
            this.lbl_NgaySinh.Text = "Ngày Sinh :";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(75, 89);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(129, 32);
            this.lbl_HoTen.TabIndex = 19;
            this.lbl_HoTen.Text = "Họ Tên :";
            // 
            // lbl_MSSV
            // 
            this.lbl_MSSV.AutoSize = true;
            this.lbl_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MSSV.Location = new System.Drawing.Point(79, 25);
            this.lbl_MSSV.Name = "lbl_MSSV";
            this.lbl_MSSV.Size = new System.Drawing.Size(115, 32);
            this.lbl_MSSV.TabIndex = 18;
            this.lbl_MSSV.Text = "MSSV :";
            // 
            // dgv_ThongTinSInhVien
            // 
            this.dgv_ThongTinSInhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTinSInhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HOTEN,
            this.NGAYSINH,
            this.GIOITINH,
            this.SDT,
            this.DIACHI,
            this.MA_LOP,
            this.MA_KHOA_HOC});
            this.dgv_ThongTinSInhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThongTinSInhVien.Location = new System.Drawing.Point(715, 0);
            this.dgv_ThongTinSInhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_ThongTinSInhVien.Name = "dgv_ThongTinSInhVien";
            this.dgv_ThongTinSInhVien.RowHeadersWidth = 51;
            this.dgv_ThongTinSInhVien.RowTemplate.Height = 24;
            this.dgv_ThongTinSInhVien.Size = new System.Drawing.Size(656, 950);
            this.dgv_ThongTinSInhVien.TabIndex = 6;
            this.dgv_ThongTinSInhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThongTinSInhVien_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 125;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "HỌ TÊN";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 125;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "NGÀY SINH";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 125;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "GIỚI TÍNH";
            this.GIOITINH.MinimumWidth = 6;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SỐ ĐIỆN THOẠI";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "ĐỊA CHỈ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 125;
            // 
            // MA_LOP
            // 
            this.MA_LOP.DataPropertyName = "MA_LOP";
            this.MA_LOP.HeaderText = "MÃ LỚP";
            this.MA_LOP.MinimumWidth = 6;
            this.MA_LOP.Name = "MA_LOP";
            this.MA_LOP.Width = 125;
            // 
            // MA_KHOA_HOC
            // 
            this.MA_KHOA_HOC.DataPropertyName = "MA_KHOA_HOC";
            this.MA_KHOA_HOC.HeaderText = "MÃ KHÓA HỌC";
            this.MA_KHOA_HOC.MinimumWidth = 6;
            this.MA_KHOA_HOC.Name = "MA_KHOA_HOC";
            this.MA_KHOA_HOC.Width = 125;
            // 
            // form_nhapThongTin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1371, 950);
            this.Controls.Add(this.dgv_ThongTinSInhVien);
            this.Controls.Add(this.grb_NhapThongTin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_nhapThongTin";
            this.Text = "Nhập thông tin sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_nhapThongTin_Load);
            this.grb_NhapThongTin.ResumeLayout(false);
            this.grb_NhapThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinSInhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MaKhoaHoc;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.RadioButton rdb_Nữ;
        private System.Windows.Forms.GroupBox grb_NhapThongTin;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.Label lbl_MaKhoaHoc;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_MSSV;
        private System.Windows.Forms.DataGridView dgv_ThongTinSInhVien;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label lbl_tim;
        private System.Windows.Forms.ComboBox cbb_Tim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_LOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_KHOA_HOC;
        private System.Windows.Forms.Button btn_Reset;
    }
}