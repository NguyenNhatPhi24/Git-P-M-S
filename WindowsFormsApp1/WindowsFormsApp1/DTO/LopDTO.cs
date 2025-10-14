using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class LopDTO
    {
        public int Malop {  get; set; }
        public string tenLop {  get; set; }
        public int SiSo {  get; set; }
        public LopDTO() { 
            Malop = 0;
            tenLop = string.Empty;
            SiSo = 0;
        }
    }
}
