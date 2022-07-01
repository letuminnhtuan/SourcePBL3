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
    public partial class fMonAn1 : Form
    {
        public fMonAn1()
        {
            InitializeComponent();
            LoadComboBox();
            ShowDSMonAn();
        }
        public void LoadComboBox()
        {
            this.cbbLoaiMonAn.Items.Add(new CBBItem { Key = "All", Value = "All" });
            this.cbbLoaiMonAn.Items.AddRange(BLL_QLMA.Instance.GetCBBLoaiMonAn().ToArray());
            this.cbbLoaiMonAn.SelectedIndex = 0;

        }
        public void ShowDSMonAn()
        {
            if (cbbLoaiMonAn.SelectedIndex >= 0)
            {
                string MaLoaiMonAn = ((CBBItem)(this.cbbLoaiMonAn.SelectedItem)).Key;
                string txtSearch = this.txtSearchMA.Text;
                this.dataMonAn.DataSource = BLL_QLMA.Instance.GetDSMonAn(MaLoaiMonAn, txtSearch);
            }
        }
        private void cbbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbLoaiMonAn.SelectedIndex >= 0)
            {
                ShowDSMonAn();
            }
        }
        private void btnSearchMonAn_Click(object sender, EventArgs e)
        {
            ShowDSMonAn();
        }
        private void btnDelMonAn_Click(object sender, EventArgs e)
        {
            if (this.dataMonAn.SelectedRows.Count == 1)
            {
                string MaMonAn = this.dataMonAn.SelectedRows[0].Cells["MaMonAn"].Value.ToString();
                BLL_QLMA.Instance.DeleteMonAn(MaMonAn);
                string MaLoai = ((CBBItem)(this.cbbLoaiMonAn.SelectedItem)).Key;
                string txt = this.txtSearchMA.Text;
                ShowDSMonAn();
            }
        }
        private void btnAddMonAn_Click(object sender, EventArgs e)
        {
            fMonAn2 f = new fMonAn2("");
            f.MyDel = new fMonAn2.Del(ShowDSMonAn);
            f.ShowDialog();
        }
        private void btnUpdateMonAn_Click(object sender, EventArgs e)
        {
            if (this.dataMonAn.SelectedRows.Count == 1)
            {
                string MaMonAn = this.dataMonAn.SelectedRows[0].Cells["MaMonAn"].Value.ToString();
                fMonAn2 f = new fMonAn2(MaMonAn);
                f.MyDel = new fMonAn2.Del(ShowDSMonAn);
                f.ShowDialog();
            }
        }
        private void cbbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbSort.SelectedIndex >= 0)
            {
                string txtSort = this.cbbSort.Text;
                string MaLoaiMonAn = ((CBBItem)(this.cbbLoaiMonAn.SelectedItem)).Key;
                string txtSearch = this.txtSearchMA.Text;
                this.dataMonAn.DataSource = BLL_QLMA.Instance.SortMonAn(txtSort, MaLoaiMonAn, txtSearch);
            }
        }
    }
}
