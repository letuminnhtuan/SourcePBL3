using Guna.UI2.WinForms;
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
    public partial class fHome : Form
    {
        private object o;
        public string Role = "";
        public string TenDangNhap = "";
        private List<DatMonAn> temp = new List<DatMonAn>();
        public fHome(string Role, string TenDangNhap)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.Role = Role;
            this.TenDangNhap = TenDangNhap;
            LoadCBB();
            LoadStatusBanAn();
        }
        public void LoadCBB()
        {
            this.cbbLoaiMonAn.Items.AddRange(BLL_QLMA.Instance.GetCBBLoaiMonAn().ToArray());
        }
        public void LoadStatusBanAn()
        {

            Guna2Button[] arr = new Guna2Button[]
            {
                this.guna2Button1, this.guna2Button2, this.guna2Button3, this.guna2Button4,
                this.guna2Button5, this.guna2Button6 ,this.guna2Button7,this.guna2Button8 ,
                this.guna2Button9,this.guna2Button10,this.guna2Button11,this.guna2Button12,
                this.guna2Button13,this.guna2Button14,this.guna2Button15,this.guna2Button16,
                this.guna2Button17,this.guna2Button18,this.guna2Button19,this.guna2Button20,
                this.guna2Button21,this.guna2Button22,this.guna2Button23,this.guna2Button24,
            };
            foreach (Guna2Button i in arr)
            {
                if (!BLL_QLDatmon.Instance.GetStatusBanAn(i.Text)) // => not complete
                {
                    i.FillColor = Color.FromArgb(255, 51, 51);
                }
            }
        }
        private void cbbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbLoaiMonAn.SelectedIndex >= 0)
            {
                this.cbbMonAn.Items.Clear();
                string MaLoaiMonAn = ((CBBItem)this.cbbLoaiMonAn.SelectedItem).Key;
                this.cbbMonAn.Text = "";
                this.cbbMonAn.Items.AddRange(BLL_QLMA.Instance.GetCBBMonAnByLoaiMonAn(MaLoaiMonAn).ToArray());
            }
        }
        private void cbbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbMonAn.SelectedIndex >= 0)
            {
                string MaMonAn = ((CBBItem)this.cbbMonAn.SelectedItem).Key;
                this.numMon.Maximum = BLL_QLMA.Instance.GetMonAnByMaMonAn(MaMonAn).SoLuong;
            }
        }
        public void Order(object o, EventArgs e)
        {
            this.dataDatMon.Rows.Clear();
            this.txtThe.Text = ((Guna2Button)o).Text;
            this.o = o;
            if (!BLL_QLDatmon.Instance.GetStatusBanAn(((Guna2Button)o).Text))
            {
                List<DatMonAn> data = BLL_QLHoaDon.Instance.GetHoaDonHienTaiByMaBan(((Guna2Button)o).Text);
                foreach (DatMonAn i in data)
                {
                    string TenMonAn = BLL_QLMA.Instance.GetMonAnByMaMonAn(i.MaMonAn).TenMonAn;
                    this.dataDatMon.Rows.Add(TenMonAn, i.SoLuong, string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", i.TongTien));
                }
                this.dataDatMon.Enabled = false;
            }
            else this.dataDatMon.Enabled = true;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DatMonAn data = new DatMonAn
            {
                MaMonAn = ((CBBItem)this.cbbMonAn.SelectedItem).Key,
                SoLuong = Convert.ToInt32(this.numMon.Value),
            };
            data.TongTien = BLL_QLMA.Instance.GetMonAnByMaMonAn(data.MaMonAn).GiaTien * data.SoLuong;
            if (Check(data.MaMonAn) && data.SoLuong != 0) temp.Add(data);
            else if (data.SoLuong != 0)
            {
                for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].MaMonAn.Equals(data.MaMonAn))
                    {
                        temp[i].SoLuong += data.SoLuong;
                        temp[i].TongTien += data.TongTien;
                        break;
                    }
                }
            }
            LoadDSDatMon();
            decimal Tong = 0;
            foreach (DatMonAn i in temp)
            {
                Tong += i.TongTien;
            }
            this.txtTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tong);
        }
        private bool Check(string MaMonAn)
        {
            foreach (DatMonAn i in temp)
            {
                if (i.MaMonAn.Equals(MaMonAn)) return false;
            }
            return true;
        }
        private void LoadDSDatMon()
        {
            this.dataDatMon.Rows.Clear();
            foreach (DatMonAn i in temp)
            {
                string TenMonAn = BLL_QLMA.Instance.GetMonAnByMaMonAn(i.MaMonAn).TenMonAn;
                this.dataDatMon.Rows.Add(TenMonAn, i.SoLuong, string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", i.TongTien));
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã xác nhận đặt món?", "Đặt món", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (cbbThanhToan.SelectedIndex >= 0)
                {
                    decimal Tong = 0;
                    foreach (DatMonAn i in temp)
                    {
                        Tong += i.TongTien;
                    }
                    HoaDon HD = new HoaDon
                    {
                        MaBanAn = this.txtThe.Text,
                        TongTien = Tong,
                        HinhThucTT = this.cbbThanhToan.Text,
                        TrangThaiTT = true,
                        MaNVOrder = this.TenDangNhap,
                        NgayThanhToan = this.dateTimePicker1.Value
                    };
                    BLL_QLDatmon.Instance.AddHoaDon(HD);
                    BLL_QLDatmon.Instance.AddDatMon(temp);
                    BLL_QLDatmon.Instance.SetStatusBanAn(HD.MaBanAn, false);
                    temp = new List<DatMonAn>();
                    ReloadForm();
                    ((Guna2Button)o).FillColor = Color.FromArgb(255, 51, 51);
                }
            }
        }
        public void ReloadForm()
        {
            this.dataDatMon.Rows.Clear();
            this.cbbLoaiMonAn.Text = "";
            this.cbbMonAn.Text = "";
            this.txtThe.Text = "";
            this.txtTien.Text = "";
            this.numMon.Maximum = 0;
            this.numMon.Value = 0;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReloadForm();
            temp = new List<DatMonAn>();
            LoadDSDatMon();
        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã xác nhận hoàn thành?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                string MaBanAn = ((Guna2Button)o).Text;
                if (!BLL_QLDatmon.Instance.GetStatusBanAn(MaBanAn))
                {
                    ((Guna2Button)o).FillColor = Color.PaleGreen;
                    BLL_QLDatmon.Instance.SetStatusBanAn(MaBanAn, true);
                }
            }
        }
        private void dataDatMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                string TenMonAn = this.dataDatMon.SelectedRows[0].Cells[0].Value.ToString();
                for (int i = 0; i < temp.Count; i++)
                {
                    MonAn s = BLL_QLMA.Instance.GetMonAnByMaMonAn(temp[i].MaMonAn);
                    if (s.TenMonAn.Equals(TenMonAn))
                    {
                        temp[i].SoLuong -= 1;
                        temp[i].TongTien -= s.GiaTien;
                        if (temp[i].SoLuong == 0) temp.RemoveAt(i);
                        break;
                    }
                }
                LoadDSDatMon();
                decimal Tong = 0;
                foreach (DatMonAn i in temp)
                {
                    Tong += i.TongTien;
                }
                this.txtTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tong);
            }
        }
        private void Infor_Click(object sender, EventArgs e)
        {
            ThanhVien data = BLL_QLNV.Instance.GetThanhVienByTenDangNhap(this.TenDangNhap);
            string Infor = String.Format("Tên thành viên: {0} \nNgày làm việc: {1} \nSố điện thoại: {2} \nLương: {3}",
                data.TenThanhVien, data.NgayLamViec, data.SDT, data.Luong);
            MessageBox.Show(Infor, "Thông tin nhân viên");
        }
    }
}
