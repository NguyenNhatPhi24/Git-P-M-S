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
    internal class DiemBUS
    {
        DiemDAO sv= new DiemDAO();
        public DataTable LD()
        {
            return sv.LayDiem();
        }
        public bool ThemDiem(DiemDTO dto)
        {
            return sv.InsertDiem(dto); 
        }

        internal object ThemDiem()
        {
            throw new NotImplementedException();
        }
    }
}
