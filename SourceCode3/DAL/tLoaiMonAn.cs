using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAL
{
    [Table("LoaiMonAn")]
    public class tLoaiMonAn
    {
        [Key]
        public string MaLoaiMonAn { get; set; }
        public string TenLoaiMonAn { get; set; }
        public tLoaiMonAn()
        {
            this.MonAns = new HashSet<tMonAn>();
        }
        // Navigation
        public virtual ICollection<tMonAn> MonAns { get; set; }
    }
}
