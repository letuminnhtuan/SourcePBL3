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
    public partial class fTaiKhoan : Form
    {
        private string TenDangNhap;
        public fTaiKhoan(string TenDangNhap)
        {
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
                this.txtMK.Text = data.MatKhau;
                this.txtMK.UseSystemPasswordChar = true;
                //this.txtMK.Enabled = true;
                //this.txtMK.PasswordChar = '●';
                this.txtMK.Enabled = false;
                this.txtLuong.Text = data.Luong.ToString();
                this.dateLamViec.Value = data.NgayLamViec;
                this.txtSDT.Text = data.SDT;
            }
        }

        private void CheckMK_CheckedChanged(object sender, EventArgs e)
        {
            this.txtMK.Enabled = true;
            this.txtMK.UseSystemPasswordChar = !(this.txtMK.UseSystemPasswordChar) ;
            // txtMK.PasswordChar = CheckMK.Checked ? '\0' : '●';
           
            this.txtMK.Enabled = false;
        }
    }
}
