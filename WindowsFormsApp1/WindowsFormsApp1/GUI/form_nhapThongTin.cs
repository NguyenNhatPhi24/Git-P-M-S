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
using WindowsFormsApp1.DTO;
namespace WindowsFormsApp1
{
    public partial class form_nhapThongTin : Form
    {
        static string Strconn = "Data Source=LAPTOP-PURJA2KD\\MINHKHA;Initial Catalog=DB_QuanLySInhVien;Integrated Security=true;";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        SinhVienBUS sv= new SinhVienBUS();
        public form_nhapThongTin()
        {
            InitializeComponent();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            form_thongtin ThongTin = new form_thongtin();
            ThongTin.Show();
            this.Hide();

        }

        private void form_nhapThongTin_Load(object sender, EventArgs e)
        {
           
            cbb_Tim.DataSource = dataload("Select * from Sinh_Vien");
            cbb_Tim.DisplayMember = "MSSV";
            cbb_Tim.ValueMember = "MSSV";
            dgv_ThongTinSInhVien.DataSource = sv.LaySSSV();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MSSV.Text.Length < 1 || txt_MSSV.Text.Length > 10)
            {
                txt_MSSV.Focus();
                return;
            }

            if (rdb_Nam.Checked == true)
            {
                rdb_Nam.Text = "Nam";
            }
            else if (rdb_Nữ.Checked == true)
            {
                rdb_Nữ.Text = "Nữ";
            }
            SinhVienDTO themSV = new SinhVienDTO();
            themSV.MSSV = txt_MSSV.Text;
            themSV.HoTen = txt_HoTen.Text;
            themSV.NgaySinh = DateTime.Parse(dtp_NgaySinh.Value.ToString("yyyy-MM-dd"));
            themSV.GioiTinh = rdb_Nam.Checked ? "Nam" : "Nữ";
            themSV.SDT = txt_SDT.Text;
            themSV.DiaChi = txt_DiaChi.Text;
            themSV.MaLop = int.Parse(txt_MaLop.Text);
            themSV.MaKhoaHoc = int.Parse(txt_MaKhoaHoc.Text);
            if (sv.ThemSV(themSV))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thành công!");
            }
            
    
            dgv_ThongTinSInhVien.DataSource = sv.LaySSSV();
        }
        private DataTable dataload(string query)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(Strconn);
            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            return dt;


        }
        private void btn_Tim_Click_1(object sender, EventArgs e)
        {
            String MSSV = cbb_Tim.SelectedValue.ToString();
            dgv_ThongTinSInhVien.DataSource = dataload("Select * from Sinh_Vien Where MSSV=" + MSSV);
            MessageBox.Show("Tìm thành công!");
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (dgv_ThongTinSInhVien.CurrentRow != null)
            {
                 int rowIndex = dgv_ThongTinSInhVien.CurrentCell.RowIndex;

                 string maSV = dgv_ThongTinSInhVien.Rows[rowIndex].Cells["MSSV"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM Sinh_Vien WHERE MSSV = @MSSV";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MSSV", maSV);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            dgv_ThongTinSInhVien.Rows.RemoveAt(rowIndex);
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
            if (dgv_ThongTinSInhVien.CurrentRow != null)
            {
                int rowIndex = dgv_ThongTinSInhVien.CurrentCell.RowIndex;
                string maSV = dgv_ThongTinSInhVien.Rows[rowIndex].Cells[0].Value.ToString();

                try
                {
                    string query = @"UPDATE Sinh_Vien 
                             SET HoTen = @HoTen, 
                                 NgaySinh = @NgaySinh, 
                                 GioiTinh = @GioiTinh, 
                                 SDT = @SDT, 
                                 DiaChi = @DiaChi, 
                                 Ma_Lop = @MaLop, 
                                 Ma_Khoa_Hoc = @MaKhoaHoc
                             WHERE MSSV = @MSSV";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MSSV", txt_MSSV.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txt_HoTen.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtp_NgaySinh.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", rdb_Nam.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text);
                    cmd.Parameters.AddWithValue("@MaLop", txt_MaLop.Text);
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", txt_MaKhoaHoc.Text);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        dgv_ThongTinSInhVien.Rows[rowIndex].Cells[1].Value = txt_HoTen.Text;
                        dgv_ThongTinSInhVien.Rows[rowIndex].Cells[2].Value = dtp_NgaySinh.Text;
                        dgv_ThongTinSInhVien.Rows[rowIndex].Cells[3].Value = rdb_Nam.Checked ? "Nam" : "Nữ";
                        dgv_ThongTinSInhVien.Rows[rowIndex].Cells[4].Value = txt_SDT.Text;
                        dgv_ThongTinSInhVien.Rows[rowIndex].Cells[5].Value = txt_DiaChi.Text;
                        dgv_ThongTinSInhVien.Rows[rowIndex].Cells[6].Value = txt_MaLop.Text;
                        dgv_ThongTinSInhVien.Rows[rowIndex].Cells[7].Value = txt_MaKhoaHoc.Text;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy MSSV để cập nhật!", "Lỗi");
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
        private void ResetONhap()
        {
            txt_MSSV.Clear();
            txt_HoTen.Clear();
            txt_SDT.Clear();
            txt_DiaChi.Clear();
            txt_MaLop.Clear();
            txt_MaKhoaHoc.Clear();
            cbb_Tim.SelectedIndex = -1;
            rdb_Nam.Checked = false;
            rdb_Nữ.Checked = false;
            dtp_NgaySinh.Value = DateTime.Now;

        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetONhap();
            dgv_ThongTinSInhVien.DataSource = sv.LaySSSV();
           

        }
        private void dgv_ThongTinSInhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dgv_ThongTinSInhVien.Rows[index];
                txt_MSSV.Text = row.Cells[0].Value.ToString();
                txt_HoTen.Text = row.Cells[1].Value.ToString();
                dtp_NgaySinh.Text = row.Cells[2].Value.ToString();
                string gioiTinh = row.Cells[3].Value.ToString();
                rdb_Nam.Checked = gioiTinh == "Nam";
                rdb_Nữ.Checked = gioiTinh == "Nữ";
                txt_SDT.Text = row.Cells[4].Value.ToString();
                txt_DiaChi.Text = row.Cells[5].Value.ToString();
                txt_MaLop.Text = row.Cells[6].Value.ToString();
                txt_MaKhoaHoc.Text = row.Cells[7].Value.ToString();
                cbb_Tim.Text = row.Cells[0].Value.ToString();
            }
        }
    }

}


