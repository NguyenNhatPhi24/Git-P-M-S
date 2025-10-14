using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using static WindowsFormsApp1.DTO.SinhVienDTO;

namespace WindowsFormsApp1.GUI
{
    public partial class form_nhapMONHOC : Form
    {
        static string Strconn = "Data Source=LAPTOP-PURJA2KD\\MINHKHA;Initial Catalog=DB_QuanLySInhVien;Integrated Security=true;";
        SqlConnection conn = new SqlConnection(Strconn);
        SqlDataAdapter adapter = null;
        MonHocBUS mh = new MonHocBUS();
        DiemBUS sv = new DiemBUS();
        public form_nhapMONHOC()
        {

            InitializeComponent();
        }

        private void btn_QuayLai_Click_1(object sender, EventArgs e)
        {
            form_thongtin ThongTin = new form_thongtin();
            ThongTin.Show();
            this.Hide();
        }

        private void form_nhapMONHOC_Load(object sender, EventArgs e)
        {
            dgv_MonHoc.DataSource = mh.LMH();
            cbb_TimMa_MH.DisplayMember = "MA_MH";
            cbb_TimMa_MH.ValueMember = "Ma_MH";
            cbb_TimMa_MH.DataSource = dataload("Select * from Mon_Hoc");


        }

        private void btn_Them_Click(object sender, EventArgs e)
        {


            DiemDTO diem = new DiemDTO();
            MonHocDTO MH = new MonHocDTO();
            MH.MaMonHoc = int.Parse(txt_MAMONHOC.Text);
            MH.TenMonHoc = txt_TENMONHOC.Text;
            MH.SoHocPhan = int.Parse(nud_SOHP.Text);
            MH.MaKhoaHoc = int.Parse(txt_maKH.Text);
            

            if (mh.ThemMH(MH))
            {
                MessageBox.Show("Thêm thành công!");

            }
            else
            {
                MessageBox.Show("Thêm thành công!");
            }
          
            dgv_MonHoc.DataSource = mh.LMH();
         
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (dgv_MonHoc.CurrentRow != null)
            {
                int rowIndex = dgv_MonHoc.CurrentCell.RowIndex;

                string maMH = dgv_MonHoc.Rows[rowIndex].Cells["Ma_MH"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM Mon_Hoc WHERE Ma_MH = @Ma_MH";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Ma_MH", maMH);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            dgv_MonHoc.Rows.RemoveAt(rowIndex);
                            MessageBox.Show("Đã xóa thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy trong cơ sở dữ liệu!", "Lỗi");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_MonHoc.CurrentRow != null)
            {
                int rowIndex = dgv_MonHoc.CurrentCell.RowIndex;
                string maSV = dgv_MonHoc.Rows[rowIndex].Cells[0].Value.ToString();

                try
                {
                    string query = @"UPDATE Mon_Hoc
                             SET MA_MH = @Ma_MH, 
                                 Ten_MH = @Ten_MH, 
                                 So_Hoc_Phan = @So_Hoc_Phan, 
                                 Ma_Khoa_Hoc = @Ma_Khoa_Hoc,
                                 where MA_MH=@MA_MH
                             ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MA_MH", txt_maKH.Enabled=false);
                    cmd.Parameters.AddWithValue("@Ten_MH", txt_TENMONHOC.Text);
                    cmd.Parameters.AddWithValue("@So_Hoc_Phan", nud_SOHP.Text);
                    cmd.Parameters.AddWithValue("@Ma_Khoa_hoc", txt_maKH.Text);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        dgv_MonHoc.Rows[rowIndex].Cells[0].Value = txt_maKH.Enabled=false;
                        dgv_MonHoc.Rows[rowIndex].Cells[1].Value = txt_TENMONHOC.Text;
                        dgv_MonHoc.Rows[rowIndex].Cells[2].Value = nud_SOHP.Text;
                        dgv_MonHoc.Rows[rowIndex].Cells[3].Value = txt_maKH.Text;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy để cập nhật!", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo");
            }
        }


        private DataTable dataload(string query)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(Strconn);
            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            return dt;


        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            
            String MA_MH = cbb_TimMa_MH.SelectedValue.ToString();
            dgv_MonHoc.DataSource = dataload("Select * from Mon_Hoc Where Ma_MH=" + MA_MH);
            MessageBox.Show("Tìm thành công!");
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetONhapMH();
            dgv_MonHoc.DataSource = mh.LMH();

        }
        private void ResetONhapMH()
        {
            txt_maKH.Clear();
            txt_TENMONHOC.Clear();
            nud_SOHP.Value = 0;
            txt_MAMONHOC.Clear();
            cbb_TimMa_MH.Text = string.Empty;

        }

        private void dgv_MonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dgv_MonHoc.Rows[index];
                txt_MAMONHOC.Text = row.Cells[0].Value.ToString();
                txt_TENMONHOC.Text = row.Cells[1].Value.ToString();
                nud_SOHP.Value = Convert.ToDecimal(row.Cells[2].Value);
                txt_maKH.Text = row.Cells[3].Value.ToString();
                cbb_TimMa_MH.Text = row.Cells[0].Value.ToString();

            }
        }

   
    }
}

