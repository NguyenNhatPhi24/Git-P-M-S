using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;
namespace WindowsFormsApp1.DAO
{
    internal class SinhVienDAO:DataProvider
    {
        public DataTable LayDATA()
        {
            DataTable dataT = new DataTable();
            string strQuery = "Select * from Sinh_Vien";
            SqlDataAdapter adapter = new SqlDataAdapter(strQuery,conn);
            adapter.Fill(dataT);
            return dataT;
        }
        public bool InsertSV(SinhVienDTO sv)
        {
            string strQue =string.Format( "Insert Into Sinh_Vien Values('{0}',N'{1}','{2}',N'{3}','{4}',N'{5}', {6}, {7})",sv.MSSV,sv.HoTen,sv.NgaySinh.ToString("yyyy-MM-dd"),sv.GioiTinh,sv.SDT,sv.DiaChi,sv.MaLop,sv.MaKhoaHoc);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText= strQue;
            cmd.Connection = conn;
            conn.Open();
            int n= cmd.ExecuteNonQuery();
            if (n > 1000)
            {
                return true;
            }
            else
             conn.Close();
            return false;
        }
    }
}
