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
    internal class SinhVienBUS
    {
        SinhVienDAO sv= new SinhVienDAO();
        public  DataTable LaySSSV()
        {
            return sv.LayDATA();
        }
        public bool ThemSV(SinhVienDTO dto)
        {
            return sv.InsertSV(dto);
        }
    }
}
