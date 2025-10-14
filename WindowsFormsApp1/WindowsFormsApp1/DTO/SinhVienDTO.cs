using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class SinhVienDTO
    {
        public string MSSV {  get; set; }
        public string HoTen {  get; set; }
        public DateTime NgaySinh {  get; set; }
        public string GioiTinh {  get; set; }
        public string SDT {  get; set; }
        public string DiaChi {  get; set; }
        public int MaLop {  get; set; }
        public int MaKhoaHoc {  get; set; }  
        public SinhVienDTO()
        {
            MSSV = string.Empty;
            HoTen = string.Empty;
            NgaySinh = DateTime.Now;
            GioiTinh=string.Empty;
            SDT= string.Empty;
            DiaChi = string.Empty;
            MaLop = 0;
            MaKhoaHoc = 0;
        }
 
        

    }
}
