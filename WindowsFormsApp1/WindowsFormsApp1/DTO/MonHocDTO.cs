using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class MonHocDTO
    {


        public int MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int SoHocPhan { get; set; }
        public int MaKhoaHoc { get; set; }
       
        public MonHocDTO() { 
            MaMonHoc= 0;
            TenMonHoc = string.Empty;
            SoHocPhan= 0;
            MaKhoaHoc= 0;
          
        }

    }
}
