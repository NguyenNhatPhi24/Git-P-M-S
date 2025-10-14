using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_dangNhap : Form
    {
        string tenTK = "admin";
        string matkhau = "123";
        public form_dangNhap()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if (kiemTraDangNhap(txt_taiKhoan.Text, txt_matKhau.Text) ){
                form_thongtin f2 = new form_thongtin();
                f2.Show();
                this.Hide();
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                txt_taiKhoan.Focus();
                txt_matKhau.Focus();
            }
        }
        bool kiemTraDangNhap(string tenTK,string matkhau)
        {
            if(tenTK==this.tenTK && matkhau==this.matkhau)
            {
                return true;
            }
            return false;
        }

        private void from_dangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng!", "Cảnh báo!", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void ptb_anhDangNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image=Image.FromFile(ofd.FileName);
                pictureBox.SizeMode= PictureBoxSizeMode.StretchImage;
            }
        }

        private void form_dangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
