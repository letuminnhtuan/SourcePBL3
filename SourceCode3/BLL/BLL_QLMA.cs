using SourceCode.DAL;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.BLL
{
    class BLL_QLMA
    {
        QLTS db;
        private static BLL_QLMA _Instance;
        public static BLL_QLMA Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_QLMA(new QLTS());
                return _Instance;
            }
            private set { }
        }
        private BLL_QLMA(QLTS db)
        {
            this.db = db;
        }
        public List<CBBItem> GetCBBLoaiMonAn()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (tLoaiMonAn i in db._LoaiMonAn)
            {
                data.Add(new CBBItem { Key = i.MaLoaiMonAn, Value = i.TenLoaiMonAn });
            }
            return data;
        }
        public List<CBBItem> GetCBBMonAnByLoaiMonAn(string MaLoaiMonAn)
        {
            List<CBBItem> data = new List<CBBItem>();
            var list = db._MonAn.Where(p => p.MaLoaiMonAn.Equals(MaLoaiMonAn));
            foreach (tMonAn i in list)
            {
                data.Add(new CBBItem
                {
                    Key = i.MaMonAn,
                    Value = i.TenMonAn
                });
            }
            return data;
        }
        public List<MonAn> GetDSMonAn(string MaLoaiMonAn, string txtSearch)
        {
            List<MonAn> data = new List<MonAn>();
            var list = db._MonAn.Select(p => new { p.MaLoaiMonAn, p.MaMonAn, p.TenMonAn, p.GiaTien, p.Kho.SoLuong });
            if (txtSearch.Equals(""))
            {
                if (!MaLoaiMonAn.Equals("All"))
                {
                    list = list.Where(p => p.MaLoaiMonAn.Equals(MaLoaiMonAn));
                }
            }
            else
            {
                if (!MaLoaiMonAn.Equals("All"))
                {
                    list = list.Where(p => p.MaLoaiMonAn.Equals(MaLoaiMonAn));
                }
                list = list.Where(p => p.TenMonAn.Contains(txtSearch));
            }
            foreach (var i in list)
            {
                MonAn MA = new MonAn
                {
                    MaLoaiMonAn = i.MaLoaiMonAn,
                    MaMonAn = i.MaMonAn,
                    TenMonAn = i.TenMonAn,
                    GiaTien = i.GiaTien,
                    SoLuong = i.SoLuong,
                };
                data.Add(MA);
            }
            return data;
        }
        public MonAn GetMonAnByMaMonAn(string MaMonAn)
        {
            tMonAn data = db._MonAn.Find(MaMonAn);
            MonAn MA = null;
            if (data != null)
            {
                MA = new MonAn
                {
                    MaLoaiMonAn = data.MaLoaiMonAn,
                    MaMonAn = data.MaMonAn,
                    TenMonAn = data.TenMonAn,
                    GiaTien = data.GiaTien,
                    SoLuong = data.Kho.SoLuong,
                };
            }
            return MA;
        }
        public void AddUpdateMonAn(MonAn MonAn)
        {
            if (GetMonAnByMaMonAn(MonAn.MaMonAn) == null)
            {
                AddMonAn(MonAn);
            }
            else
            {
                UpdateMonAn(MonAn);
            }
        }
        public void AddMonAn(MonAn MonAn)
        {
            tMonAn data = new tMonAn
            {
                MaMonAn = MonAn.MaMonAn,
                MaLoaiMonAn = MonAn.MaLoaiMonAn,
                TenMonAn = MonAn.TenMonAn,
                GiaTien = MonAn.GiaTien
            };
            db._MonAn.Add(data);
            db._Kho.Add(new tKho { MaMonAn = data.MaMonAn, SoLuong = MonAn.SoLuong });
            db.SaveChanges();
        }
        public void UpdateMonAn(MonAn MonAn)
        {
            var i = db._MonAn.Find(MonAn.MaMonAn);
            i.MaLoaiMonAn = MonAn.MaLoaiMonAn;
            i.TenMonAn = MonAn.TenMonAn;
            i.GiaTien = MonAn.GiaTien;
            var j = db._Kho.Find(MonAn.MaMonAn);
            j.SoLuong = MonAn.SoLuong;
            db.SaveChanges();
        }
        public void DeleteMonAn(string MaMonAn)
        {
            var data = db._MonAn.Find(MaMonAn);
            db._MonAn.Remove(data);
            db.SaveChanges();
        }
        public List<MonAn> SortMonAn(string txtSort, string MaLoaiMonAn, string txtSearch)
        {
            List<MonAn> data = GetDSMonAn(MaLoaiMonAn, txtSearch);
            if (txtSort.Equals("Ten mon an")) data.Sort(delegate (MonAn MA1, MonAn MA2) { return MA1.TenMonAn.CompareTo(MA2.TenMonAn); });
            else if (txtSort.Equals("Gia tien")) data.Sort(delegate (MonAn MA1, MonAn MA2) { return MA1.GiaTien.CompareTo(MA2.GiaTien); });
            else if (txtSort.Equals("So luong")) data.Sort(delegate (MonAn MA1, MonAn MA2) { return MA1.SoLuong.CompareTo(MA2.SoLuong); });
            return data;
        }
    }
}