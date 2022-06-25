using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    public class ThanhVien
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string LoaiThanhVien { get; set; }
        public string TenThanhVien { get; set; }
        public DateTime NgayLamViec { get; set; }
        public decimal Luong { get; set; }
        public string SDT { get; set; }
    }
}
