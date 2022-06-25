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
    public partial class fNhanVien1 : Form
    {
        public fNhanVien1()
        {
            InitializeComponent();
            LoadComboBox();
            ShowDSThanhVien();
        }
        public void LoadComboBox()
        {

            this.cbbLoaiNV.Items.AddRange(new CBBItem[]
            {
                 new CBBItem { Key = "All", Value = "All" },
                 new CBBItem { Key = "NHANVIEN", Value = "Nhan vien" },
                 new CBBItem { Key = "ADMIN", Value = "Admin" },
            });
            this.cbbLoaiNV.SelectedIndex = 0;
        }
        public void ShowDSThanhVien()
        {
            if (this.cbbLoaiNV.SelectedIndex >= 0)
            {
                string LoaiThanhVien = ((CBBItem)(this.cbbLoaiNV.SelectedItem)).Key;
                string txt = "";
                if (this.txtSearchNV.Text != "Tìm nhân viên") txt = this.txtSearchNV.Text;
                this.dataNV.DataSource = BLL_QLNV.Instance.GetDSThanhVien(LoaiThanhVien, txt);
            }
        }
        private void txtSearchNV_Click(object sender, EventArgs e)
        {
            if (this.txtSearchNV.Text == "Tìm nhân viên") this.txtSearchNV.Clear();
        }

        private void txtSearchNV_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchNV.Text == "") this.txtSearchNV.Text = "Tìm nhân viên";
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            ShowDSThanhVien();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            fNhanVien2 f = new fNhanVien2("");
            f.D = new fNhanVien2.Del(ShowDSThanhVien);
            f.Show();
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            if (this.dataNV.SelectedRows.Count == 1)
            {
                string TenDN = this.dataNV.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();
                fNhanVien2 f = new fNhanVien2(TenDN);
                f.D = new fNhanVien2.Del(ShowDSThanhVien);
                f.Show();
            }
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            if (this.dataNV.SelectedRows.Count == 1)
            {
                string TenDN = this.dataNV.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();
                BLL_QLNV.Instance.DeleteThanhVien(TenDN);
                string LoaiThanhVien = ((CBBItem)(this.cbbLoaiNV.SelectedItem)).Key;
                string txt = this.txtSearchNV.Text;
                ShowDSThanhVien();
            }
        }
        private void cbbSortNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbSortNV.SelectedIndex >= 0)
            {
                string txtSort = this.cbbSortNV.Text;
                string LoaiThanhVien = ((CBBItem)(this.cbbLoaiNV.SelectedItem)).Key;
                string txtSearch = "";
                if (!this.txtSearchNV.Text.Equals("Tìm nhân viên")) txtSearch = this.txtSearchNV.Text;
                this.dataNV.DataSource = BLL_QLNV.Instance.SortThanhVien(txtSort, LoaiThanhVien, txtSearch);
            }
        }

        private void cbbLoaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDSThanhVien();
        }
    }
}
