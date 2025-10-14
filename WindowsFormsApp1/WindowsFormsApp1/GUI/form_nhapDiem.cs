using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.BUS;
using System.Data.SqlClient;
using System.Collections;
using System.Data.SqlTypes;

namespace WindowsFormsApp1.GUI
{

    public partial class form_nhapDiem : Form
    {
        static string Strconn = "Data Source=LAPTOP-PURJA2KD\\MINHKHA;Initial Catalog=DB_QuanLySInhVien;Integrated Security=true;";
        SqlConnection conn = new SqlConnection(Strconn);
        SqlDataAdapter adapter = null;
        DiemBUS mh = new DiemBUS();
        DiemBUS sv = new DiemBUS();
        public form_nhapDiem()
        {
            InitializeComponent();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            form_thongtin ThongTin = new form_thongtin();
            ThongTin.Show();
            this.Hide();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            DiemDTO diem = new DiemDTO();
            diem.DiemL1 = float.Parse(nud_DiemL1.Text.ToString());
            diem.DiemL2 = float.Parse(nud_diemL2.Text.ToString());
            diem.DiemTB = (diem.DiemL1 + diem.DiemL2) / 2;
            diem.MSSV_mh = txt_MSSV.Text;
            diem.maMH_mh = int.Parse(txt_MaMonHoc.Text);
            sv.ThemDiem(diem);
            dgv_nhapDiem.DataSource = null;
            dgv_nhapDiem.DataSource = sv.LD();

            MessageBox.Show("Thêm thành công");
        }

        private void form_nhapDiem_Load(object sender, EventArgs e)
        {
            dgv_nhapDiem.DataSource = sv.LD();
            cbb_TimtheoMSSV.DisplayMember = "MSSV";
            cbb_TimtheoMSSV.ValueMember = "MSSV";
            cbb_TimtheoMSSV.DataSource = timMSSV("Select DISTINCT MSSV from Diemm");

        }
        private void btn_ql_Click(object sender, EventArgs e)
        {
            form_thongtin s = new form_thongtin();
            s.Show();
            this.Hide();
        }
        private void dgv_nhapDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dgv_nhapDiem.Rows[index];
                txt_diemtb.Text = row.Cells[0].Value.ToString();
                nud_DiemL1.Text = row.Cells[1].Value.ToString();
                nud_diemL2.Text = row.Cells[2].Value.ToString();
                txt_MSSV.Text = row.Cells[3].Value.ToString();
                txt_MaMonHoc.Text = row.Cells[4].Value.ToString();
                cbb_TimtheoMSSV.Text = row.Cells[3].Value.ToString();

            }
        }
        private void btn_rs_Click(object sender, EventArgs e)
        {
            txt_diemtb.Text = string.Empty;
            nud_DiemL1.Value = 0;
            nud_diemL2.Value = 0;
            txt_MSSV.Text = string.Empty;
            txt_MaMonHoc.Text = string.Empty;
            cbb_TimtheoMSSV.Text = string.Empty;
            dgv_nhapDiem.DataSource = sv.LD();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {


            if (dgv_nhapDiem.CurrentRow != null)
            {
                int rowIndex = dgv_nhapDiem.CurrentCell.RowIndex;

                string maMH = dgv_nhapDiem.Rows[rowIndex].Cells["MSSV"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM DIEMM WHERE MSSV = @MSSV";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MSSV", maMH);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            dgv_nhapDiem.Rows.RemoveAt(rowIndex);
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
        private DataTable timMSSV(string querry)
        {
            DataTable tim = new DataTable();
            conn = new SqlConnection(Strconn);
            adapter = new SqlDataAdapter(querry, conn);
            adapter.Fill(tim);
            return tim;


        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            String ms= cbb_TimtheoMSSV.SelectedValue.ToString();
            dgv_nhapDiem.DataSource = timMSSV("Select * from Diemm Where MSSV='" + ms + "'");
            MessageBox.Show("Tìm thành công!"); 
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_nhapDiem.CurrentRow != null)
            {
                int rowIndex = dgv_nhapDiem.CurrentCell.RowIndex;
                string maSV = dgv_nhapDiem.Rows[rowIndex].Cells[0].Value.ToString();

                try
                {
                    string query = @"UPDATE DIEMM
                                 SET DIEM_TRUNG_BINH = @DIEM_TRUNG_BINH,
                                 DIEM_LAN_1 = @DIEM_LAN_1,
                                 DIEM_LAN_2 = @DIEM_LAN_2,
                                 MSSV = @MSSV,
                                 MA_MON_HOC = @MA_MON_HOC
                                 WHERE MSSV = @MSSV";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DIEM_TB", txt_diemtb.Text);
                    cmd.Parameters.AddWithValue("@DIEM_L1", nud_DiemL1.Text);
                    cmd.Parameters.AddWithValue("@DIEM_L2", nud_diemL2.Text);
                    cmd.Parameters.AddWithValue("@MSSV", txt_MSSV.Text);
                    cmd.Parameters.AddWithValue("@MA_MON_HOC", txt_MaMonHoc.Text);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        dgv_nhapDiem.Rows[rowIndex].Cells[1].Value = txt_diemtb.Text;
                        dgv_nhapDiem.Rows[rowIndex].Cells[2].Value = nud_DiemL1.Text;
                        dgv_nhapDiem.Rows[rowIndex].Cells[5].Value = nud_diemL2.Text;
                        dgv_nhapDiem.Rows[rowIndex].Cells[6].Value = txt_MSSV.Text;
                        dgv_nhapDiem.Rows[rowIndex].Cells[7].Value = txt_MaMonHoc.Text;
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
    }

}

