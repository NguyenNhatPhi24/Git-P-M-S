namespace WindowsFormsApp1
{
    partial class form_dangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_dangNhap));
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_taiKhoan = new System.Windows.Forms.TextBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.ptb_anhDangNhap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangNhap.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.Location = new System.Drawing.Point(57, 407);
            this.btn_dangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(159, 36);
            this.btn_dangNhap.TabIndex = 0;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(327, 407);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(155, 36);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_taiKhoan
            // 
            this.txt_taiKhoan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taiKhoan.Location = new System.Drawing.Point(227, 185);
            this.txt_taiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_taiKhoan.Name = "txt_taiKhoan";
            this.txt_taiKhoan.Size = new System.Drawing.Size(255, 34);
            this.txt_taiKhoan.TabIndex = 4;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhau.Location = new System.Drawing.Point(227, 272);
            this.txt_matKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(255, 34);
            this.txt_matKhau.TabIndex = 5;
            // 
            // ptb_anhDangNhap
            // 
            this.ptb_anhDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_anhDangNhap.BackgroundImage")));
            this.ptb_anhDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_anhDangNhap.Location = new System.Drawing.Point(192, 12);
            this.ptb_anhDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_anhDangNhap.Name = "ptb_anhDangNhap";
            this.ptb_anhDangNhap.Size = new System.Drawing.Size(168, 135);
            this.ptb_anhDangNhap.TabIndex = 6;
            this.ptb_anhDangNhap.TabStop = false;
            this.ptb_anhDangNhap.Click += new System.EventHandler(this.ptb_anhDangNhap_Click);
            // 
            // form_dangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 500);
            this.Controls.Add(this.ptb_anhDangNhap);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.txt_taiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_dangNhap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_dangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.from_dangNhap_FormClosing);
            this.Load += new System.EventHandler(this.form_dangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_taiKhoan;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.PictureBox ptb_anhDangNhap;
    }
}

