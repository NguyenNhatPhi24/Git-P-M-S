using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;


namespace WindowsFormsApp1.DAO
{
    internal class DiemDAO:DataProvider
    {
        public DataTable LayDiem()
        {
            DataTable dataT = new DataTable();
            string strQuery = "Select * from Diemm";
            SqlDataAdapter adapter = new SqlDataAdapter(strQuery, conn);
            adapter.Fill(dataT);
            return dataT;
        }
        public bool InsertDiem(DiemDTO sv)
        {
            string strQue = string.Format("Insert Into Diemm Values({0},{1},{2},'{3}',{4})",sv.DiemTB,sv.DiemL1,sv.DiemL2,sv.MSSV_mh,sv.maMH_mh);
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
