using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;


namespace WindowsFormsApp1.BUS
{
    internal class MonHocBUS
    {

        MonHocDAO sv=new MonHocDAO();
        public DataTable LMH()
        {
            return sv.LayMH();
        }
        public bool ThemMH(MonHocDTO dto)
        {
            return sv.InsertMH(dto);
        }
    }
}

