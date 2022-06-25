using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.BLL
{
    public class BLL_ValidateData
    {
        private static BLL_ValidateData _Instance;
        public static BLL_ValidateData Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_ValidateData();
                return _Instance;
            }
            private set { }
        }
        private BLL_ValidateData()
        {

        }
        public string CheckMonAn(MonAn data)
        {
            string mess = "";
            if (data.MaMonAn == "") mess += "Không để trống mã món ăn\n";
            if (data.MaLoaiMonAn == "") mess += "Không để trống mã loại món ăn\n";
            if (data.TenMonAn == "") mess += "Không để trống tên món ăn\n";
            return mess;
        }
        public bool CheckNum(string txt)
        {
            foreach (char i in txt.ToArray())
            {
                if (i > '9' || i < '0') return false;
            }
            return true;
        }
        public string ChechNhanVien(ThanhVien data)
        {
            string mess = "";
            if (data.TenDangNhap == "") mess += "Không để trống tên đăng nhập\n";
            if (data.MatKhau == "") mess += "Không để trống mật khẩu\n";
            if (data.TenThanhVien == "") mess += "Không để trống tên thành viên\n";
            if (data.SDT == "") mess += "Không để trống số điện thoại\n";
            return mess;
        }
        public bool CheckSDT(string txt)
        {
            if (!txt.StartsWith("0") || txt.Length != 10) return false;
            foreach (char i in txt.ToArray())
            {
                if (i > '9' || i < '0') return false;
            }
            return true;
        }
    }
}
