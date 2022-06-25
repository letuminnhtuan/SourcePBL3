using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAL
{
    [Table("ThanhVien")]
    public class tThanhVien
    {
        [Key]
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string LoaiThanhVien { get; set; }
        public string TenThanhVien { get; set; }
        public DateTime NgayLamViec { get; set; }
        public decimal Luong { get; set; }
        public string SDT { get; set; }
        public tThanhVien()
        {
            this.HoaDons = new HashSet<tHoaDon>();
        }
        // Navigation
        public virtual ICollection<tHoaDon> HoaDons { get; set; }
    }
}
