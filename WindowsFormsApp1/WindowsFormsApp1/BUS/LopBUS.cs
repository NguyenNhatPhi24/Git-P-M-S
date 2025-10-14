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
    internal class LopBUS
    {
        LopDAO lop = new LopDAO();
        public DataTable LayLop()
        {
            return lop.LayDATALOP();
        }
        public bool ThemLop(LopDTO dto)
        {
            return lop.InsertLOP(dto);
        }
    }
}
