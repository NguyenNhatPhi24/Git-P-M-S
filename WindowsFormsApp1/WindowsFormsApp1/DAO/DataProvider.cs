using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DAO
{
    internal class DataProvider
    {
        static string Strconn = "Data Source=LAPTOP-PURJA2KD\\MINHKHA;Initial Catalog=DB_QuanLySInhVien;Integrated Security=true;";
        protected SqlConnection conn= new SqlConnection(Strconn);

        public static object Instance { get; protected set; }
    }
}
