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
    }
}
