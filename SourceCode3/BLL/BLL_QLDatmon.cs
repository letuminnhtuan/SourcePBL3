using SourceCode.DAL;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.BLL
{
    class BLL_QLDatmon
    {
        QLTS db;
        private static BLL_QLDatmon _Instance;
        public static BLL_QLDatmon Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_QLDatmon(new QLTS());
                return _Instance;
            }
            private set { }
        }
        private BLL_QLDatmon(QLTS db)
        {
            this.db = db;
        }
        public void AddHoaDon(HoaDon Hoa_Don)
        {
            tHoaDon HD = new tHoaDon
            {
                MaBanAn = Hoa_Don.MaBanAn,
                MaNVOrder = Hoa_Don.MaNVOrder,
                TongTien = Hoa_Don.TongTien,
                HinhThucTT = Hoa_Don.HinhThucTT,
                TrangThaiTT = Hoa_Don.TrangThaiTT,
                NgayThanhToan = Hoa_Don.NgayThanhToan,
            };
            db._HoaDon.Add(HD);
            db.SaveChanges();
        }
        public void AddDatMon(List<DatMonAn> data)
        {
            int MaHoaDon = 0;
            foreach(tHoaDon i in db._HoaDon)
            {
                MaHoaDon = i.MaHoaDon;
            }
            foreach(DatMonAn i in data)
            {
                tDatMonAn temp = new tDatMonAn
                {
                    MaHoaDon = MaHoaDon,
                    MaMonAn = i.MaMonAn,
                    SoLuong = i.SoLuong,
                    TongTien = i.TongTien,
                };
                db._DatMonAn.Add(temp);
                UpdateSoLuong(temp.MaMonAn, temp.SoLuong);
                db.SaveChanges();
            }
        }
        public void UpdateSoLuong(string MaMonAn, int SoLuong)
        {
            var i = db._Kho.Find(MaMonAn);
            i.SoLuong -= SoLuong;
            db.SaveChanges();
        }
        public void SetStatusBanAn(string MaBanAn, bool Status)
        {
            var i = db._BanAn.Find(MaBanAn);
            i.TrangThai = Status;
            db.SaveChanges();
        }
        public bool GetStatusBanAn(string MaBanAn)
        {
            var i = db._BanAn.Find(MaBanAn);
            return i.TrangThai;
        }
    }
}
