using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAL
{
    [Table("Kho")]
    public class tKho
    {
        [ForeignKey("MonAn")]
        [Key]
        public string MaMonAn { get; set; }
        public int SoLuong { get; set; }
        // Navigation
        public virtual tMonAn MonAn { get; set; }
    }
}
