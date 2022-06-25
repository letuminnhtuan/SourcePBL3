using SourceCode.BLL;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode.GUI
{
    public partial class fHoaDon : Form
    {
        private int MaHoaDon;
        public fHoaDon(int MaHoaDon)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.MaHoaDon = MaHoaDon;
            this.txtMaHoaDon.Text = this.MaHoaDon.ToString();
            List<DatMonAn> data = BLL_QLHoaDon.Instance.GetHoaDonByMaHoaDon(this.MaHoaDon);
            foreach (DatMonAn i in data)
            {
                string TenMonAn = BLL_QLMA.Instance.GetMonAnByMaMonAn(i.MaMonAn).TenMonAn;
                this.dataDatMon.Rows.Add(TenMonAn, i.SoLuong, string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", i.TongTien));
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
