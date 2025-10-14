using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;
using System.Data.SqlClient;

namespace WindowsFormsApp1.GUI
{

    public partial class form_nhapLop : Form
    {
        static string Strconn = "Data Source=LAPTOP-PURJA2KD\\MINHKHA;Initial Catalog=DB_QuanLySInhVien;Integrated Security=true;";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        LopBUS lop = new LopBUS();
        public form_nhapLop()
        {
            InitializeComponent();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            form_thongtin ThongTin = new form_thongtin();
            ThongTin.Show();
            this.Hide();
        }

        private void form_nhapLop_Load(object sender, EventArgs e)
        {
            dgv_LOP.DataSource = lop.LayLop();
            cbb_timTheoMALOP.DataSource = dataloadLOP("Select * from LOP");
            cbb_timTheoMALOP.DisplayMember = "MA_LOP";
            cbb_timTheoMALOP.ValueMember = "MA_LOP";
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
           
            LopDTO themlop = new LopDTO();
            themlop.Malop=int.Parse(txt_MaLop.Text);
            themlop.tenLop = txt_TenLop.Text;
            themlop.SiSo = int.Parse(txt_SISO.Text);
            if (lop.ThemLop(themlop))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thành công!");
            }


            dgv_LOP.DataSource = lop.LayLop();
        }

        private void dgv_LOP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dgv_LOP.Rows[index];
                txt_MaLop.Text = row.Cells[0].Value.ToString();
                txt_TenLop.Text = row.Cells[1].Value.ToString();
                txt_SISO.Text = row.Cells[2].Value.ToString();
                cbb_timTheoMALOP.Text = row.Cells[0].Value.ToString();
            }
        }
        private DataTable dataloadLOP(string query)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(Strconn);
            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            return dt;

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {

            String MALOP = cbb_timTheoMALOP.SelectedValue.ToString();
            dgv_LOP.DataSource = dataloadLOP("Select * from LOP Where MA_LOP=" + MALOP);
            MessageBox.Show("Tìm thành công!");
        }
        private void ResetONhap()
        {
            txt_MaLop.Clear();
            txt_TenLop.Clear();
            txt_SISO.Clear();
            cbb_timTheoMALOP.ResetText();
            cbb_timTheoMALOP.SelectedIndex = -1;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetONhap();
            dgv_LOP.DataSource = lop.LayLop();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (dgv_LOP.CurrentRow != null)
            {
                int rowIndex = dgv_LOP.CurrentCell.RowIndex;

                string maSV = dgv_LOP.Rows[rowIndex].Cells["MA_LOP"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM LOP WHERE MA_LOP = @MA_LOP";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MA_LOP", maSV);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            dgv_LOP.Rows.RemoveAt(rowIndex);
                            MessageBox.Show("Đã xóa thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy MSSV trong cơ sở dữ liệu!", "Lỗi");
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
            if (dgv_LOP.CurrentRow != null)
            {
                int rowIndex = dgv_LOP.CurrentCell.RowIndex;
                string maSV = dgv_LOP.Rows[rowIndex].Cells[0].Value.ToString();

                try
                {
                    string query = @"UPDATE LOP 
                             SET MA_LOP = @Ho_Ten, 
                             Ten_Lop=@Ten_Lop
                             Si_So=@Si_So
                             WHERE Ma_Lop = @Ma_Lop";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MA_LOP", txt_MaLop.Text);
                    cmd.Parameters.AddWithValue("@Ten_Lop", txt_TenLop.Text);
                    cmd.Parameters.AddWithValue("@MA_LOP", txt_SISO.Text);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        dgv_LOP.Rows[rowIndex].Cells[1].Value = txt_MaLop.Text;
                        dgv_LOP.Rows[rowIndex].Cells[2].Value = txt_TenLop.Text;
                        dgv_LOP.Rows[rowIndex].Cells[3].Value = txt_SISO.Text;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy MA_LOP để cập nhật!", "Lỗi");
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
    }
}

