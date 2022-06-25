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
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }

        private void btnThK_Click(object sender, EventArgs e)
        {
            if (this.dateStart.Value.CompareTo(this.dateEnd.Value) != 1)
            {
                decimal TongTien = 0;
                DateTime dateStart = this.dateStart.Value;
                DateTime dateEnd = this.dateEnd.Value;
                this.dataHoaDon.DataSource = BLL_QLHoaDon.Instance.GetDSHoaDon(dateStart, dateEnd, ref TongTien);
                this.txtTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", TongTien);
            }
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            if (this.dataHoaDon.SelectedRows.Count == 1)
            {
                int MaHoaDon = Convert.ToInt32(this.dataHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value.ToString());
                fHoaDon f = new fHoaDon(MaHoaDon);
                f.ShowDialog();
            }
        }
    }

}
