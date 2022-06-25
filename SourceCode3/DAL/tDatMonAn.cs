using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAL
{
    [Table("DatMonAn")]
    public class tDatMonAn
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDatMonAn { get; set; }
        public int MaHoaDon { get; set; }
        public string MaMonAn { get; set; }
        public int SoLuong { get; set; }
        public decimal TongTien { get; set; }
        // Navigation
        [ForeignKey("MaMonAn")]
        public virtual tMonAn MonAn { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual tHoaDon HoaDon { get; set; }
    }
}
