using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAL
{
    public class CreateDB : DropCreateDatabaseIfModelChanges<QLTS>
    {
        protected override void Seed(QLTS context)
        {
            // => LoaiMonAn
            context._LoaiMonAn.Add(new tLoaiMonAn { MaLoaiMonAn = "DU01", TenLoaiMonAn = "Tra sua"});
            context._LoaiMonAn.Add(new tLoaiMonAn { MaLoaiMonAn = "DU02", TenLoaiMonAn = "Nuoc ep" });
            context._LoaiMonAn.Add(new tLoaiMonAn { MaLoaiMonAn = "DU03", TenLoaiMonAn = "Da xay" });
            context._LoaiMonAn.Add(new tLoaiMonAn { MaLoaiMonAn = "DU04", TenLoaiMonAn = "Sua chua" });
            context._LoaiMonAn.Add(new tLoaiMonAn { MaLoaiMonAn = "DA01", TenLoaiMonAn = "An vat" });
            context._LoaiMonAn.Add(new tLoaiMonAn { MaLoaiMonAn = "TP", TenLoaiMonAn = "Topping" });
            // => ThanhVien
            context._ThanhVien.Add(new tThanhVien { LoaiThanhVien = "ADMIN", TenThanhVien = "Quan li A", TenDangNhap = "admin", MatKhau = "admin", NgayLamViec = DateTime.Now, Luong = 2000000, SDT = "0905111111" });
            context._ThanhVien.Add(new tThanhVien { LoaiThanhVien = "NHANVIEN", TenThanhVien = "Nguyen B", TenDangNhap = "user1", MatKhau = "user", NgayLamViec = DateTime.Now, Luong = 1500000, SDT = "0905111112" });
        }
    }
}
