using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class form_thongtin : Form
    {
        bool iThoat = true;
        public form_thongtin()
        {
            InitializeComponent();
        }

        private void btn_thoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            bool iThoat = false;
            this.Close();
            form_dangNhap f1 = new form_dangNhap();
            f1.Show();
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất!", "Cảnh báo!", MessageBoxButtons.YesNo) != DialogResult.Yes) 
            {
                e.Cancel = true;
         
            }
 
        }
        private void lbl_nhapThongTin_Click(object sender, EventArgs e)
        {
            form_nhapThongTin k=new form_nhapThongTin();
            k.Show();
            this.Hide();
        }

        private void ptb_hinhGiaoDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                ptb_hinhGiaoDien.Image=Image.FromFile(ofd.FileName);
                ptb_hinhGiaoDien.SizeMode=PictureBoxSizeMode.StretchImage;
            }
        }

        private void lbl_nhapMONHOCvaDiem_Click(object sender, EventArgs e)
        {
            form_nhapMONHOC monhoc= new form_nhapMONHOC();
            monhoc.Show();
            this.Hide();
        }

        private void lbl_nhapDiem_Click(object sender, EventArgs e)
        {
            form_nhapDiem ThongTin = new form_nhapDiem();   
            ThongTin.Show();
            this.Hide();
        }

        private void lbl_Lop_Click(object sender, EventArgs e)
        {
            form_nhapLop nhapLop = new form_nhapLop();
            nhapLop.Show();
            this.Hide();
        }

        private void form_thongtin_Load(object sender, EventArgs e)
        {

        }

        private void grb_HinhAnhTrangTri_Enter(object sender, EventArgs e)
        {

        }
    }
}
