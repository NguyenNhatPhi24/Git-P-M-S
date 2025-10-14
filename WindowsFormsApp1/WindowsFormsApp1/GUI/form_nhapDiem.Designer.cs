namespace WindowsFormsApp1.GUI
{
    partial class form_nhapDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_nhapDiem));
            this.lbl_diemTB = new System.Windows.Forms.Label();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.lbl_nhapdiem = new System.Windows.Forms.Label();
            this.lbl_diemL2 = new System.Windows.Forms.Label();
            this.grb_nhap = new System.Windows.Forms.GroupBox();
            this.btn_rs = new System.Windows.Forms.Button();
            this.btn_ql = new System.Windows.Forms.Button();
            this.txt_diemtb = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_NhapD = new System.Windows.Forms.Label();
            this.cbb_TimtheoMSSV = new System.Windows.Forms.ComboBox();
            this.lbl_timtheoMSSV = new System.Windows.Forms.Label();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_MaMonHoc = new System.Windows.Forms.TextBox();
            this.nud_diemL2 = new System.Windows.Forms.NumericUpDown();
            this.nud_DiemL1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_maMH = new System.Windows.Forms.Label();
            this.lbl_MSSV = new System.Windows.Forms.Label();
            this.lbl_DiemL1 = new System.Windows.Forms.Label();
            this.dgv_nhapDiem = new System.Windows.Forms.DataGridView();
            this.DIEM_TRUNG_BINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM_LAN_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM_LAN_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_MON_HOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_nhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_diemL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DiemL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_diemTB
            // 
            this.lbl_diemTB.AutoSize = true;
            this.lbl_diemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diemTB.Location = new System.Drawing.Point(29, 102);
            this.lbl_diemTB.Name = "lbl_diemTB";
            this.lbl_diemTB.Size = new System.Drawing.Size(139, 32);
            this.lbl_diemTB.TabIndex = 19;
            this.lbl_diemTB.Text = "Điểm TB:";
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MSSV.Location = new System.Drawing.Point(219, 321);
            this.txt_MSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(369, 38);
            this.txt_MSSV.TabIndex = 27;
            // 
            // lbl_nhapdiem
            // 
            this.lbl_nhapdiem.AutoSize = true;
            this.lbl_nhapdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhapdiem.Location = new System.Drawing.Point(707, 55);
            this.lbl_nhapdiem.Name = "lbl_nhapdiem";
            this.lbl_nhapdiem.Size = new System.Drawing.Size(177, 32);
            this.lbl_nhapdiem.TabIndex = 57;
            this.lbl_nhapdiem.Text = "NHẬP ĐIỂM";
            // 
            // lbl_diemL2
            // 
            this.lbl_diemL2.AutoSize = true;
            this.lbl_diemL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diemL2.Location = new System.Drawing.Point(29, 260);
            this.lbl_diemL2.Name = "lbl_diemL2";
            this.lbl_diemL2.Size = new System.Drawing.Size(135, 32);
            this.lbl_diemL2.TabIndex = 59;
            this.lbl_diemL2.Text = "Điểm L2:";
            // 
            // grb_nhap
            // 
            this.grb_nhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grb_nhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grb_nhap.Controls.Add(this.btn_rs);
            this.grb_nhap.Controls.Add(this.btn_ql);
            this.grb_nhap.Controls.Add(this.txt_diemtb);
            this.grb_nhap.Controls.Add(this.btn_Reset);
            this.grb_nhap.Controls.Add(this.lbl_NhapD);
            this.grb_nhap.Controls.Add(this.cbb_TimtheoMSSV);
            this.grb_nhap.Controls.Add(this.lbl_timtheoMSSV);
            this.grb_nhap.Controls.Add(this.btn_QuayLai);
            this.grb_nhap.Controls.Add(this.btn_Tim);
            this.grb_nhap.Controls.Add(this.btn_Xoa);
            this.grb_nhap.Controls.Add(this.btn_Sua);
            this.grb_nhap.Controls.Add(this.btn_Them);
            this.grb_nhap.Controls.Add(this.txt_MaMonHoc);
            this.grb_nhap.Controls.Add(this.nud_diemL2);
            this.grb_nhap.Controls.Add(this.nud_DiemL1);
            this.grb_nhap.Controls.Add(this.lbl_maMH);
            this.grb_nhap.Controls.Add(this.lbl_MSSV);
            this.grb_nhap.Controls.Add(this.lbl_DiemL1);
            this.grb_nhap.Controls.Add(this.lbl_diemL2);
            this.grb_nhap.Controls.Add(this.lbl_diemTB);
            this.grb_nhap.Controls.Add(this.txt_MSSV);
            this.grb_nhap.Location = new System.Drawing.Point(3, 0);
            this.grb_nhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_nhap.Name = "grb_nhap";
            this.grb_nhap.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_nhap.Size = new System.Drawing.Size(612, 985);
            this.grb_nhap.TabIndex = 61;
            this.grb_nhap.TabStop = false;
            // 
            // btn_rs
            // 
            this.btn_rs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_rs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_rs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rs.Location = new System.Drawing.Point(-2, 703);
            this.btn_rs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rs.Name = "btn_rs";
            this.btn_rs.Size = new System.Drawing.Size(188, 59);
            this.btn_rs.TabIndex = 63;
            this.btn_rs.Text = "RESET";
            this.btn_rs.UseVisualStyleBackColor = false;
            this.btn_rs.Click += new System.EventHandler(this.btn_rs_Click);
            // 
            // btn_ql
            // 
            this.btn_ql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ql.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ql.BackgroundImage")));
            this.btn_ql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ql.Location = new System.Drawing.Point(479, 730);
            this.btn_ql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ql.Name = "btn_ql";
            this.btn_ql.Size = new System.Drawing.Size(125, 96);
            this.btn_ql.TabIndex = 75;
            this.btn_ql.UseVisualStyleBackColor = true;
            this.btn_ql.Click += new System.EventHandler(this.btn_ql_Click);
            // 
            // txt_diemtb
            // 
            this.txt_diemtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diemtb.Location = new System.Drawing.Point(219, 100);
            this.txt_diemtb.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diemtb.Name = "txt_diemtb";
            this.txt_diemtb.Size = new System.Drawing.Size(363, 34);
            this.txt_diemtb.TabIndex = 73;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(0, 926);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(185, 59);
            this.btn_Reset.TabIndex = 63;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // lbl_NhapD
            // 
            this.lbl_NhapD.AutoSize = true;
            this.lbl_NhapD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhapD.Location = new System.Drawing.Point(219, 18);
            this.lbl_NhapD.Name = "lbl_NhapD";
            this.lbl_NhapD.Size = new System.Drawing.Size(177, 32);
            this.lbl_NhapD.TabIndex = 72;
            this.lbl_NhapD.Text = "NHẬP ĐIỂM";
            // 
            // cbb_TimtheoMSSV
            // 
            this.cbb_TimtheoMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimtheoMSSV.FormattingEnabled = true;
            this.cbb_TimtheoMSSV.Location = new System.Drawing.Point(261, 502);
            this.cbb_TimtheoMSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_TimtheoMSSV.Name = "cbb_TimtheoMSSV";
            this.cbb_TimtheoMSSV.Size = new System.Drawing.Size(327, 37);
            this.cbb_TimtheoMSSV.TabIndex = 71;
            // 
            // lbl_timtheoMSSV
            // 
            this.lbl_timtheoMSSV.AutoSize = true;
            this.lbl_timtheoMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timtheoMSSV.Location = new System.Drawing.Point(-5, 507);
            this.lbl_timtheoMSSV.Name = "lbl_timtheoMSSV";
            this.lbl_timtheoMSSV.Size = new System.Drawing.Size(233, 32);
            this.lbl_timtheoMSSV.TabIndex = 70;
            this.lbl_timtheoMSSV.Text = "Tìm theo MSSV:";
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QuayLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuayLai.BackgroundImage")));
            this.btn_QuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuayLai.Location = new System.Drawing.Point(460, 883);
            this.btn_QuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(125, 96);
            this.btn_QuayLai.TabIndex = 63;
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tim.BackgroundImage")));
            this.btn_Tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tim.Location = new System.Drawing.Point(471, 571);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(133, 98);
            this.btn_Tim.TabIndex = 69;
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.BackgroundImage")));
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Xoa.Location = new System.Drawing.Point(323, 571);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(116, 98);
            this.btn_Xoa.TabIndex = 68;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sua.Location = new System.Drawing.Point(169, 571);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(113, 98);
            this.btn_Sua.TabIndex = 67;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.BackgroundImage")));
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them.Location = new System.Drawing.Point(21, 571);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(115, 98);
            this.btn_Them.TabIndex = 66;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_MaMonHoc
            // 
            this.txt_MaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaMonHoc.Location = new System.Drawing.Point(219, 417);
            this.txt_MaMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaMonHoc.Name = "txt_MaMonHoc";
            this.txt_MaMonHoc.Size = new System.Drawing.Size(369, 38);
            this.txt_MaMonHoc.TabIndex = 65;
            // 
            // nud_diemL2
            // 
            this.nud_diemL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_diemL2.Location = new System.Drawing.Point(219, 254);
            this.nud_diemL2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_diemL2.Name = "nud_diemL2";
            this.nud_diemL2.Size = new System.Drawing.Size(369, 38);
            this.nud_diemL2.TabIndex = 64;
            // 
            // nud_DiemL1
            // 
            this.nud_DiemL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_DiemL1.Location = new System.Drawing.Point(219, 169);
            this.nud_DiemL1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_DiemL1.Name = "nud_DiemL1";
            this.nud_DiemL1.Size = new System.Drawing.Size(369, 38);
            this.nud_DiemL1.TabIndex = 63;
            // 
            // lbl_maMH
            // 
            this.lbl_maMH.AutoSize = true;
            this.lbl_maMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maMH.Location = new System.Drawing.Point(-5, 423);
            this.lbl_maMH.Name = "lbl_maMH";
            this.lbl_maMH.Size = new System.Drawing.Size(191, 32);
            this.lbl_maMH.TabIndex = 62;
            this.lbl_maMH.Text = "Mã Môn Học:";
            // 
            // lbl_MSSV
            // 
            this.lbl_MSSV.AutoSize = true;
            this.lbl_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MSSV.Location = new System.Drawing.Point(29, 327);
            this.lbl_MSSV.Name = "lbl_MSSV";
            this.lbl_MSSV.Size = new System.Drawing.Size(107, 32);
            this.lbl_MSSV.TabIndex = 61;
            this.lbl_MSSV.Text = "MSSV:";
            // 
            // lbl_DiemL1
            // 
            this.lbl_DiemL1.AutoSize = true;
            this.lbl_DiemL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiemL1.Location = new System.Drawing.Point(29, 175);
            this.lbl_DiemL1.Name = "lbl_DiemL1";
            this.lbl_DiemL1.Size = new System.Drawing.Size(135, 32);
            this.lbl_DiemL1.TabIndex = 60;
            this.lbl_DiemL1.Text = "Điểm L1:";
            // 
            // dgv_nhapDiem
            // 
            this.dgv_nhapDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nhapDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhapDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DIEM_TRUNG_BINH,
            this.DIEM_LAN_1,
            this.DIEM_LAN_2,
            this.MSSV,
            this.MA_MON_HOC});
            this.dgv_nhapDiem.Location = new System.Drawing.Point(613, 0);
            this.dgv_nhapDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_nhapDiem.Name = "dgv_nhapDiem";
            this.dgv_nhapDiem.RowHeadersWidth = 51;
            this.dgv_nhapDiem.RowTemplate.Height = 24;
            this.dgv_nhapDiem.Size = new System.Drawing.Size(676, 985);
            this.dgv_nhapDiem.TabIndex = 62;
            this.dgv_nhapDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhapDiem_CellClick);
            // 
            // DIEM_TRUNG_BINH
            // 
            this.DIEM_TRUNG_BINH.DataPropertyName = "DIEM_TRUNG_BINH";
            this.DIEM_TRUNG_BINH.HeaderText = "ĐIỂM TRUNG BÌNH";
            this.DIEM_TRUNG_BINH.MinimumWidth = 6;
            this.DIEM_TRUNG_BINH.Name = "DIEM_TRUNG_BINH";
            this.DIEM_TRUNG_BINH.Width = 125;
            // 
            // DIEM_LAN_1
            // 
            this.DIEM_LAN_1.DataPropertyName = "DIEM_LAN_1";
            this.DIEM_LAN_1.HeaderText = "ĐIỂM LẦN 1";
            this.DIEM_LAN_1.MinimumWidth = 6;
            this.DIEM_LAN_1.Name = "DIEM_LAN_1";
            this.DIEM_LAN_1.Width = 125;
            // 
            // DIEM_LAN_2
            // 
            this.DIEM_LAN_2.DataPropertyName = "DIEM_LAN_2";
            this.DIEM_LAN_2.HeaderText = "ĐIỂM LẦN 2";
            this.DIEM_LAN_2.MinimumWidth = 6;
            this.DIEM_LAN_2.Name = "DIEM_LAN_2";
            this.DIEM_LAN_2.Width = 125;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 125;
            // 
            // MA_MON_HOC
            // 
            this.MA_MON_HOC.DataPropertyName = "MA_MON_HOC";
            this.MA_MON_HOC.HeaderText = "MÃ MÔN HỌC";
            this.MA_MON_HOC.MinimumWidth = 6;
            this.MA_MON_HOC.Name = "MA_MON_HOC";
            this.MA_MON_HOC.Width = 125;
            // 
            // form_nhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 823);
            this.Controls.Add(this.dgv_nhapDiem);
            this.Controls.Add(this.grb_nhap);
            this.Controls.Add(this.lbl_nhapdiem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_nhapDiem";
            this.Text = "form_nhapDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_nhapDiem_Load);
            this.grb_nhap.ResumeLayout(false);
            this.grb_nhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_diemL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DiemL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_diemTB;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.Label lbl_nhapdiem;
        private System.Windows.Forms.Label lbl_diemL2;
        private System.Windows.Forms.GroupBox grb_nhap;
        private System.Windows.Forms.DataGridView dgv_nhapDiem;
        private System.Windows.Forms.Label lbl_DiemL1;
        private System.Windows.Forms.TextBox txt_MaMonHoc;
        private System.Windows.Forms.NumericUpDown nud_diemL2;
        private System.Windows.Forms.NumericUpDown nud_DiemL1;
        private System.Windows.Forms.Label lbl_maMH;
        private System.Windows.Forms.Label lbl_MSSV;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Label lbl_timtheoMSSV;
        private System.Windows.Forms.ComboBox cbb_TimtheoMSSV;
        private System.Windows.Forms.Label lbl_NhapD;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txt_diemtb;
        private System.Windows.Forms.Button btn_ql;
        private System.Windows.Forms.Button btn_rs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM_TRUNG_BINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM_LAN_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM_LAN_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_MON_HOC;
    }
}