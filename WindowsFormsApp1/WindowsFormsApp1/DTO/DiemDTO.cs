using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class DiemDTO
    {
        public float DiemTB { get; set; }
        public float DiemL1 { get; set; }
        public float DiemL2 { get; set; }
        public string MSSV_mh { get; set; }
        public int maMH_mh { get; set; }
        public DiemDTO()
        {
            DiemTB = 0;
            DiemL1 = 0;
            DiemL2 = 0;
            MSSV_mh = string.Empty;
            maMH_mh = 0;
        }
    }
}
