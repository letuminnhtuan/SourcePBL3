using SourceCode.BLL;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode.GUI
{
    public partial class fNhanVien2 : Form
    {
        public delegate void Del();
        public Del D;
        private string TenDangNhap;
        public fNhanVien2(string TenDangNhap)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.cbbLoaiNhanVien.Items.Add(new CBBItem { Key = "ADMIN", Value = "Quan li" });
            this.cbbLoaiNhanVien.Items.Add(new CBBItem { Key = "NHANVIEN", Value = "Nhan vien" });
            SetGUI();
        }
        public void SetGUI()
        {
            if (BLL_QLNV.Instance.GetThanhVienByTenDangNhap(this.TenDangNhap) != null)
            {
                ThanhVien data = BLL_QLNV.Instance.GetThanhVienByTenDangNhap(this.TenDangNhap);
                foreach (CBBItem i in this.cbbLoaiNhanVien.Items)
                {
                    if (i.Key.Equals(data.LoaiThanhVien))
                    {
                        this.cbbLoaiNhanVien.SelectedItem = i;
                        break;
                    }
                }
                this.txtTenNhanVien.Text = data.TenThanhVien;
                this.txtTK.Text = data.TenDangNhap;
                this.txtTK.Enabled = false;
                this.txtMK.Text = data.MatKhau;
                this.txtLuong.Text = String.Format("{0:0.##}", data.Luong);
                this.dateLamViec.Value = data.NgayLamViec;
                this.txtSDT.Text = data.SDT;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.cbbLoaiNhanVien.SelectedIndex >= 0)
            {
                if(this.txtLuong.Text == "")
                {
                    MessageBox.Show("Không để trống tiền lương!!", "Error!");
                    return;
                }
                if (!BLL_ValidateData.Instance.CheckSDT(this.txtSDT.Text))
                {
                    MessageBox.Show("Lỗi dữ liệu số điện thoại!!", "Error!");
                    return;
                }
                ThanhVien data = new ThanhVien
                {
                    TenDangNhap = this.txtTK.Text,
                    MatKhau = this.txtMK.Text,
                    LoaiThanhVien = ((CBBItem)this.cbbLoaiNhanVien.SelectedItem).Key,
                    TenThanhVien = this.txtTenNhanVien.Text,
                    Luong = Convert.ToDecimal(this.txtLuong.Text),
                    SDT = this.txtSDT.Text,
                    NgayLamViec = this.dateLamViec.Value,
                };
                if (BLL_ValidateData.Instance.ChechNhanVien(data) != "") MessageBox.Show(BLL_ValidateData.Instance.ChechNhanVien(data), "Error!!");
                else
                {
                    if (this.txtTK.Enabled) // => ADD
                    {
                        if (BLL_QLNV.Instance.GetThanhVienByTenDangNhap(data.TenDangNhap) != null)
                        {
                            MessageBox.Show("Nhân viên đã tồn tại!", "Tồn tại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                            return;
                        }
                    }
                    BLL_QLNV.Instance.AddUpdateThanhVien(data);
                    D();
                }
            }
            else MessageBox.Show("Chọn loại nhân viên!!", "Error!!");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.PasswordChar = CheckMK.Checked ? '\0' : '●';
        }
    }
}
