namespace WindowsFormsApp1.GUI
{
    partial class form_nhapLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_nhapLop));
            this.lbl_nhapLOP = new System.Windows.Forms.Label();
            this.grb_nhapD = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_timTheoMALOP = new System.Windows.Forms.ComboBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tenLop = new System.Windows.Forms.Label();
            this.lbl_maLop = new System.Windows.Forms.Label();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_SISO = new System.Windows.Forms.TextBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.dgv_LOP = new System.Windows.Forms.DataGridView();
            this.MA_LOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_LOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SI_SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_nhapD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LOP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nhapLOP
            // 
            this.lbl_nhapLOP.AutoSize = true;
            this.lbl_nhapLOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhapLOP.Location = new System.Drawing.Point(199, 18);
            this.lbl_nhapLOP.Name = "lbl_nhapLOP";
            this.lbl_nhapLOP.Size = new System.Drawing.Size(164, 32);
            this.lbl_nhapLOP.TabIndex = 58;
            this.lbl_nhapLOP.Text = "NHẬP LỚP";
            // 
            // grb_nhapD
            // 
            this.grb_nhapD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grb_nhapD.Controls.Add(this.label1);
            this.grb_nhapD.Controls.Add(this.cbb_timTheoMALOP);
            this.grb_nhapD.Controls.Add(this.btn_Reset);
            this.grb_nhapD.Controls.Add(this.label2);
            this.grb_nhapD.Controls.Add(this.lbl_tenLop);
            this.grb_nhapD.Controls.Add(this.lbl_maLop);
            this.grb_nhapD.Controls.Add(this.btn_QuayLai);
            this.grb_nhapD.Controls.Add(this.btn_Tim);
            this.grb_nhapD.Controls.Add(this.btn_Xoa);
            this.grb_nhapD.Controls.Add(this.btn_Sua);
            this.grb_nhapD.Controls.Add(this.btn_Them);
            this.grb_nhapD.Controls.Add(this.txt_SISO);
            this.grb_nhapD.Controls.Add(this.txt_TenLop);
            this.grb_nhapD.Controls.Add(this.txt_MaLop);
            this.grb_nhapD.Controls.Add(this.lbl_nhapLOP);
            this.grb_nhapD.Location = new System.Drawing.Point(0, 2);
            this.grb_nhapD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_nhapD.Name = "grb_nhapD";
            this.grb_nhapD.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_nhapD.Size = new System.Drawing.Size(597, 812);
            this.grb_nhapD.TabIndex = 59;
            this.grb_nhapD.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 79;
            this.label1.Text = "Tìm theo mã lớp:";
            // 
            // cbb_timTheoMALOP
            // 
            this.cbb_timTheoMALOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_timTheoMALOP.FormattingEnabled = true;
            this.cbb_timTheoMALOP.Location = new System.Drawing.Point(247, 391);
            this.cbb_timTheoMALOP.Name = "cbb_timTheoMALOP";
            this.cbb_timTheoMALOP.Size = new System.Drawing.Size(327, 37);
            this.cbb_timTheoMALOP.TabIndex = 78;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(5, 672);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(188, 59);
            this.btn_Reset.TabIndex = 61;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 77;
            this.label2.Text = "Sỉ Số:";
            // 
            // lbl_tenLop
            // 
            this.lbl_tenLop.AutoSize = true;
            this.lbl_tenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenLop.Location = new System.Drawing.Point(5, 226);
            this.lbl_tenLop.Name = "lbl_tenLop";
            this.lbl_tenLop.Size = new System.Drawing.Size(134, 32);
            this.lbl_tenLop.TabIndex = 76;
            this.lbl_tenLop.Text = "Tên Lớp:";
            // 
            // lbl_maLop
            // 
            this.lbl_maLop.AutoSize = true;
            this.lbl_maLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maLop.Location = new System.Drawing.Point(5, 153);
            this.lbl_maLop.Name = "lbl_maLop";
            this.lbl_maLop.Size = new System.Drawing.Size(123, 32);
            this.lbl_maLop.TabIndex = 75;
            this.lbl_maLop.Text = "Mã Lớp:";
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QuayLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuayLai.BackgroundImage")));
            this.btn_QuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuayLai.Location = new System.Drawing.Point(467, 621);
            this.btn_QuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(125, 96);
            this.btn_QuayLai.TabIndex = 74;
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tim.BackgroundImage")));
            this.btn_Tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tim.Location = new System.Drawing.Point(459, 519);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(133, 98);
            this.btn_Tim.TabIndex = 73;
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.BackgroundImage")));
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Xoa.Location = new System.Drawing.Point(319, 519);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(116, 98);
            this.btn_Xoa.TabIndex = 72;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sua.Location = new System.Drawing.Point(171, 519);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(113, 98);
            this.btn_Sua.TabIndex = 71;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.BackgroundImage")));
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them.Location = new System.Drawing.Point(27, 519);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(115, 98);
            this.btn_Them.TabIndex = 70;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_SISO
            // 
            this.txt_SISO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SISO.Location = new System.Drawing.Point(205, 306);
            this.txt_SISO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SISO.Name = "txt_SISO";
            this.txt_SISO.Size = new System.Drawing.Size(369, 38);
            this.txt_SISO.TabIndex = 68;
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLop.Location = new System.Drawing.Point(205, 224);
            this.txt_TenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(369, 38);
            this.txt_TenLop.TabIndex = 67;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLop.Location = new System.Drawing.Point(205, 149);
            this.txt_MaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(369, 38);
            this.txt_MaLop.TabIndex = 66;
            // 
            // dgv_LOP
            // 
            this.dgv_LOP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LOP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_LOP,
            this.TEN_LOP,
            this.SI_SO});
            this.dgv_LOP.Location = new System.Drawing.Point(604, 2);
            this.dgv_LOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_LOP.Name = "dgv_LOP";
            this.dgv_LOP.RowHeadersWidth = 51;
            this.dgv_LOP.RowTemplate.Height = 24;
            this.dgv_LOP.Size = new System.Drawing.Size(453, 812);
            this.dgv_LOP.TabIndex = 60;
            this.dgv_LOP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LOP_CellClick);
            // 
            // MA_LOP
            // 
            this.MA_LOP.DataPropertyName = "MA_LOP";
            this.MA_LOP.HeaderText = "MÃ LỚP";
            this.MA_LOP.MinimumWidth = 6;
            this.MA_LOP.Name = "MA_LOP";
            this.MA_LOP.Width = 125;
            // 
            // TEN_LOP
            // 
            this.TEN_LOP.DataPropertyName = "TEN_LOP";
            this.TEN_LOP.HeaderText = "TÊN LỚP";
            this.TEN_LOP.MinimumWidth = 6;
            this.TEN_LOP.Name = "TEN_LOP";
            this.TEN_LOP.Width = 125;
            // 
            // SI_SO
            // 
            this.SI_SO.DataPropertyName = "SI_SO";
            this.SI_SO.HeaderText = "SỈ SỐ";
            this.SI_SO.MinimumWidth = 6;
            this.SI_SO.Name = "SI_SO";
            this.SI_SO.Width = 125;
            // 
            // form_nhapLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 771);
            this.Controls.Add(this.dgv_LOP);
            this.Controls.Add(this.grb_nhapD);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_nhapLop";
            this.Text = "form_nhapLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_nhapLop_Load);
            this.grb_nhapD.ResumeLayout(false);
            this.grb_nhapD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nhapLOP;
        private System.Windows.Forms.GroupBox grb_nhapD;
        private System.Windows.Forms.DataGridView dgv_LOP;
        private System.Windows.Forms.TextBox txt_SISO;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tenLop;
        private System.Windows.Forms.Label lbl_maLop;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_timTheoMALOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_LOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_LOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SI_SO;
    }
}