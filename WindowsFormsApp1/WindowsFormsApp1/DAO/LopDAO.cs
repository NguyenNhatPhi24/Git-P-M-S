using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApp1.DTO;
using System.Data;

namespace WindowsFormsApp1.DAO
{
    internal class LopDAO:DataProvider
    {
        public DataTable LayDATALOP()
        {
            DataTable dataT = new DataTable();
            string strQuery = "Select * from LOP";
            SqlDataAdapter adapter = new SqlDataAdapter(strQuery, conn);
            adapter.Fill(dataT);
            return dataT;
        }
        public bool InsertLOP(LopDTO lop)
        {
            string strQue = string.Format("Insert Into LOP Values({0},N'{1}','{2}')",lop.Malop,lop.tenLop,lop.SiSo);
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
