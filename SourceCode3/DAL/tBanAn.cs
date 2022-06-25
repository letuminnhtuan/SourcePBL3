using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAL
{
    [Table("BanAn")]
    public class tBanAn
    {
        [Key]
        public string MaBanAn { get; set; }
        public bool TrangThai { get; set; }
        // Navigation
        public virtual ICollection<tHoaDon> HoaDons { get; set; }
    }
}
