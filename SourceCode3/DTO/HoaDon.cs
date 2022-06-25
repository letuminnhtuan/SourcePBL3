using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public string MaBanAn { get; set; }
        public string MaNVOrder { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public decimal TongTien { get; set; }
        public bool TrangThaiTT { get; set; }
        public string HinhThucTT { get; set; }
    }
}
