using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1.DAO
{
    internal class MonHocDAO:DataProvider
    {
        public DataTable LayMH()
        {
            DataTable dataT = new DataTable();
            string strQuery = "Select * from Mon_Hoc";
            SqlDataAdapter adapter = new SqlDataAdapter(strQuery, conn);
            adapter.Fill(dataT);
            return dataT;
        }

        public bool InsertMH(MonHocDTO sv)
        {
            string strQue = string.Format("Insert Into Mon_Hoc Values({0},N'{1}',{2},{3})",sv.MaMonHoc,sv.TenMonHoc,sv.SoHocPhan,sv.MaKhoaHoc);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strQue;
            cmd.Connection = conn;
            conn.Open();
            int n = cmd.ExecuteNonQuery();
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
