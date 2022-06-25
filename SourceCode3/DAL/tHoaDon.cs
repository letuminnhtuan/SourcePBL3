using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAL
{
    [Table("HoaDon")]
    public class tHoaDon
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHoaDon { get; set; }
        public string MaBanAn { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public decimal TongTien { get; set; }
        [ForeignKey("ThanhVien")]
        public string MaNVOrder { get; set; }
        public bool TrangThaiTT { get; set; }
        public string HinhThucTT { get; set; }
        public tHoaDon()
        {
            this.DatMonAns = new HashSet<tDatMonAn>();
        }
        public virtual ICollection<tDatMonAn> DatMonAns { get; set; }
        public virtual tThanhVien ThanhVien { get; set; }
        [ForeignKey("MaBanAn")]
        public virtual tBanAn BanAn { get; set; }
    }
}
