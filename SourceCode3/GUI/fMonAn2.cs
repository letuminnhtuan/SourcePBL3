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
    public partial class fMonAn2 : Form
    {
        public delegate void Del();
        private string MaMonAn;
        public Del MyDel;
        public fMonAn2(string MaMonAn)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.MaMonAn = MaMonAn;
            this.cbbLoaiMonAn.Items.AddRange(BLL_QLMA.Instance.GetCBBLoaiMonAn().ToArray());
            SetGUI();
        }
        public void SetGUI()
        {
            if (BLL_QLMA.Instance.GetMonAnByMaMonAn(this.MaMonAn) != null)
            {
                foreach (CBBItem i in this.cbbLoaiMonAn.Items)
                {
                    if (i.Key.Equals(BLL_QLMA.Instance.GetMonAnByMaMonAn(this.MaMonAn).MaLoaiMonAn))
                    {
                        this.cbbLoaiMonAn.Text = i.Value;
                        break;
                    }
                }
                this.txtMaMonAn.Text = BLL_QLMA.Instance.GetMonAnByMaMonAn(this.MaMonAn).MaMonAn;
                this.txtMaMonAn.Enabled = false;
                this.txtTenMonAn.Text = BLL_QLMA.Instance.GetMonAnByMaMonAn(this.MaMonAn).TenMonAn;
                this.txtGiaTien.Text = BLL_QLMA.Instance.GetMonAnByMaMonAn(this.MaMonAn).GiaTien.ToString();
                this.txtSoLuong.Text = BLL_QLMA.Instance.GetMonAnByMaMonAn(this.MaMonAn).SoLuong.ToString();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.cbbLoaiMonAn.SelectedIndex >= 0)
            {
                if (this.txtSoLuong.Text == "")
                {
                    MessageBox.Show("Nhập số lượng món ăn!!", "Error!");
                    return;
                }
                else
                {
                    if (!BLL_ValidateData.Instance.CheckNum(this.txtSoLuong.Text))
                    {
                        MessageBox.Show("Lỗi dữ liệu số lượng món ăn!!", "Error!");
                        return;
                    }
                }
                if (this.txtGiaTien.Text == "")
                {
                    MessageBox.Show("Nhập giá tiền món ăn!!", "Error!");
                    return;
                }
                else
                {
                    if (!BLL_ValidateData.Instance.CheckNum(this.txtGiaTien.Text))
                    {
                        MessageBox.Show("Lỗi dữ liệu giá tiền món ăn!!", "Error!");
                        return;
                    }
                }
                MonAn data = new MonAn
                {
                    MaLoaiMonAn = ((CBBItem)this.cbbLoaiMonAn.SelectedItem).Key,
                    MaMonAn = this.txtMaMonAn.Text,
                    TenMonAn = this.txtTenMonAn.Text,
                    GiaTien = Convert.ToDecimal(this.txtGiaTien.Text),
                    SoLuong = Convert.ToInt32(this.txtSoLuong.Text),
                };
                if (this.txtMaMonAn.Enabled) // => ADD
                {
                    if (BLL_QLMA.Instance.GetMonAnByMaMonAn(data.MaMonAn) != null)
                    {
                        MessageBox.Show("Món ăn đã tồn tại!", "Tồn tại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                        return;
                    }
                }
                if (BLL_ValidateData.Instance.CheckMonAn(data) != "") MessageBox.Show(BLL_ValidateData.Instance.CheckMonAn(data), "Error!");
                else BLL_QLMA.Instance.AddUpdateMonAn(data);
                MyDel();
            }
            else MessageBox.Show("Chọn loại món ăn!!", "Error!");
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
