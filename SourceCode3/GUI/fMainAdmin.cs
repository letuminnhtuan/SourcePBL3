using Guna.UI2.WinForms;
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
    public partial class fMainAdmin : Form
    {
        private Form activeForm;
        public string Role = "";
        public string TenDangNhap = "";
        private Guna2Button currentButton;
        private Guna2Button previousButton;
        public fMainAdmin(string Role, string TenDangNhap)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.Role = Role;
            this.TenDangNhap = TenDangNhap;
            InitGUI();
        }
        public void InitGUI()
        {
            fHome f = new fHome(Role, TenDangNhap);
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(f);
            this.panelDesktop.Tag = f;
            f.BringToFront();
            f.Show();
            this.btnHome.FillColor = Color.LightGray;
            this.previousButton = this.btnHome;
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (Guna2Button)sender)
                {
                    DisableButton(previousButton);
                    currentButton = (Guna2Button)sender;
                    currentButton.FillColor = Color.LightGray;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    previousButton = (Guna2Button)sender;
                }
            }
        }
        private void DisableButton(Guna2Button previousBtn)
        {
            if (previousBtn != null)
            {
                previousBtn.FillColor = Color.White;
                previousButton.ForeColor = Color.Black;
                previousBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fHome(Role,TenDangNhap), sender); 
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fThongKe(), sender);
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fMonAn1(), sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fNhanVien1(), sender);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fTaiKhoan(TenDangNhap), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
