using SourceCode.DAL;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.BLL
{
    class BLL_QLNV
    {
        QLTS db;
        private static BLL_QLNV _Instance;
        public static BLL_QLNV Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_QLNV(new QLTS());
                return _Instance;
            }
            private set { }
        }
        private BLL_QLNV(QLTS db)
        {
            this.db = db;
        }
        public tThanhVien LogIn(string TenDangNhap, string MatKhau)
        {
            tThanhVien data = db._ThanhVien.Find(TenDangNhap);
            if (data != null && data.MatKhau.Equals(MatKhau)) return data;
            return null;
        }
        public List<ThanhVien> GetDSThanhVien(string LoaiThanhVien, string txtSearch)
        {
            List<ThanhVien> data = new List<ThanhVien>();
            var list = db._ThanhVien.Select(p => p);
            if (txtSearch.Equals(""))
            {
                if (!LoaiThanhVien.Equals("All"))
                {
                    list = list.Where(p => p.LoaiThanhVien.Equals(LoaiThanhVien));
                }
            }
            else
            {
                if (!LoaiThanhVien.Equals("All"))
                {
                    list = list.Where(p => p.LoaiThanhVien.Equals(LoaiThanhVien));
                }
                list = list.Where(p => p.TenThanhVien.Contains(txtSearch));
            }
            foreach (tThanhVien i in list)
            {
                data.Add(new ThanhVien
                {
                    LoaiThanhVien = i.LoaiThanhVien,
                    TenDangNhap = i.TenDangNhap,
                    MatKhau = i.MatKhau,
                    TenThanhVien = i.TenThanhVien,
                    SDT = i.SDT,
                    Luong = i.Luong,
                    NgayLamViec = i.NgayLamViec
                });
            }
            return data;
        }
        public ThanhVien GetThanhVienByTenDangNhap(string TenDangNhap)
        {
            tThanhVien data = db._ThanhVien.Find(TenDangNhap);
            ThanhVien TV = null;
            if (data != null)
            {
                TV = new ThanhVien
                {
                    LoaiThanhVien = data.LoaiThanhVien,
                    TenThanhVien = data.TenThanhVien,
                    TenDangNhap = data.TenDangNhap,
                    MatKhau = data.MatKhau,
                    Luong = data.Luong,
                    NgayLamViec = data.NgayLamViec,
                    SDT = data.SDT,
                };
            }
            return TV;
        }
        public void AddUpdateThanhVien(ThanhVien ThanhVien)
        {
            if (GetThanhVienByTenDangNhap(ThanhVien.TenDangNhap) == null)
            {
                AddThanhVien(ThanhVien);
            }
            else
            {
                UpdateThanhVien(ThanhVien);
            }
        }
        public void AddThanhVien(ThanhVien ThanhVien)
        {
            tThanhVien data = new tThanhVien
            {
                TenDangNhap = ThanhVien.TenDangNhap,
                MatKhau = ThanhVien.MatKhau,
                TenThanhVien = ThanhVien.TenThanhVien,
                LoaiThanhVien = ThanhVien.LoaiThanhVien,
                NgayLamViec = ThanhVien.NgayLamViec,
                Luong = ThanhVien.Luong,
                SDT = ThanhVien.SDT
            };
            db._ThanhVien.Add(data);
            db.SaveChanges();
        }
        public void UpdateThanhVien(ThanhVien ThanhVien)
        {
            var i = db._ThanhVien.Find(ThanhVien.TenDangNhap);
            i.LoaiThanhVien = ThanhVien.LoaiThanhVien;
            i.TenThanhVien = ThanhVien.TenThanhVien;
            i.MatKhau = ThanhVien.MatKhau;
            i.NgayLamViec = ThanhVien.NgayLamViec;
            i.Luong = ThanhVien.Luong;
            i.SDT = ThanhVien.SDT;
            db.SaveChanges();
        }
        public void DeleteThanhVien(string TenDangNhap)
        {
            var data = db._ThanhVien.Find(TenDangNhap);
            db._ThanhVien.Remove(data);
            db.SaveChanges();
        }
        public List<ThanhVien> SortThanhVien(string txtSort, string LoaiThanhVien, string txtSearch)
        {
            List<ThanhVien> data = GetDSThanhVien(LoaiThanhVien, txtSearch);
            if (txtSort.Equals("Ten nhan vien")) data.Sort(delegate (ThanhVien TV1, ThanhVien TV2) { return TV1.TenThanhVien.CompareTo(TV2.TenThanhVien); });
            else if (txtSort.Equals("Luong")) data.Sort(delegate (ThanhVien TV1, ThanhVien TV2) { return TV1.Luong.CompareTo(TV2.Luong); });
            else if (txtSort.Equals("Ngay lam viec")) data.Sort(delegate (ThanhVien TV1, ThanhVien TV2) { return TV1.NgayLamViec.CompareTo(TV2.NgayLamViec); });
            return data;
        }
    }
}