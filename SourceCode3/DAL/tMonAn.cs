using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAL
{
    [Table("MonAn")]
    public class tMonAn
    {
        [Key]
        public string MaMonAn { get; set; }
        public string MaLoaiMonAn { get; set; }
        public string TenMonAn { get; set; }
        public decimal GiaTien { get; set; }
        public tMonAn()
        {
            this.DatMonAns = new HashSet<tDatMonAn>();
        }
        // Navigation
        public virtual tKho Kho { get; set; }
        public virtual tLoaiMonAn LoaiMonAn { get; set; }
        public virtual ICollection<tDatMonAn> DatMonAns { get; set; }
    }
}
