using SourceCode.DAL;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.BLL
{
    class BLL_QLHoaDon
    {
        QLTS db;
        private static BLL_QLHoaDon _Instance;
        public static BLL_QLHoaDon Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_QLHoaDon(new QLTS());
                return _Instance;
            }
            private set { }
        }
        private BLL_QLHoaDon(QLTS db)
        {
            this.db = db;
        }
        public List<HoaDon> GetAllHoaDon(ref decimal value)
        {
            List<HoaDon> data = new List<HoaDon>();
            var list = db._HoaDon.Select(p => p);
            foreach (tHoaDon i in list)
            {
                data.Add(new HoaDon
                {
                    MaHoaDon = i.MaHoaDon,
                    MaBanAn = i.MaBanAn,
                    MaNVOrder = i.MaNVOrder,
                    NgayThanhToan = i.NgayThanhToan,
                    TrangThaiTT = i.TrangThaiTT,
                    TongTien = i.TongTien,
                    HinhThucTT = i.HinhThucTT
                });
                value += i.TongTien;
            }
            return data;
        }
        public List<HoaDon> GetDSHoaDon(DateTime dateStart, DateTime dateEnd, ref decimal value)
        {
            List<HoaDon> data = new List<HoaDon>();
            var list = db._HoaDon.Select(p => p).Where(p => p.NgayThanhToan.CompareTo(dateStart) == 1 && p.NgayThanhToan.CompareTo(dateEnd) == -1);
            foreach (tHoaDon i in list)
            {
                data.Add(new HoaDon
                {
                    MaHoaDon = i.MaHoaDon,
                    MaBanAn = i.MaBanAn,
                    MaNVOrder = i.MaNVOrder,
                    NgayThanhToan = i.NgayThanhToan,
                    TrangThaiTT = i.TrangThaiTT,
                    TongTien = i.TongTien,
                    HinhThucTT = i.HinhThucTT
                });
                value += i.TongTien;
            }
            return data;
        }
        public List<DatMonAn> GetHoaDonHienTaiByMaBan(string MaBanAn)
        {
            List<DatMonAn> data = new List<DatMonAn>();
            int last = db._HoaDon.Select(p => p).Where(p => p.MaBanAn.Equals(MaBanAn)).Max(p => p.MaHoaDon);
            var list = db._DatMonAn.Select(p => p).Where(p => p.MaHoaDon == last);
            foreach (tDatMonAn i in list)
            {
                data.Add(new DatMonAn
                {
                    MaHoaDon = i.MaHoaDon,
                    MaMonAn = i.MaMonAn,
                    SoLuong = i.SoLuong,
                    TongTien = i.TongTien
                });
            }
            return data;
        }
        public List<DatMonAn> GetHoaDonByMaHoaDon(int MaHoaDon)
        {
            List<DatMonAn> data = new List<DatMonAn>();
            var list = db._DatMonAn.Select(p => p).Where(p => p.MaHoaDon == MaHoaDon);
            foreach (tDatMonAn i in list)
            {
                data.Add(new DatMonAn
                {
                    MaHoaDon = i.MaHoaDon,
                    MaMonAn = i.MaMonAn,
                    SoLuong = i.SoLuong,
                    TongTien = i.TongTien
                });
            }
            return data;
        }
    }
}
