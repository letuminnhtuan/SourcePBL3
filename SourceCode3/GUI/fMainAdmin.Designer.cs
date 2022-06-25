namespace SourceCode.GUI
{
    partial class fMainAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainAdmin));
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.guna2PictureBox1);
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnTaiKhoan);
            this.panelMenu.Controls.Add(this.btnNhanVien);
            this.panelMenu.Controls.Add(this.btnThongKe);
            this.panelMenu.Controls.Add(this.btnMonAn);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(192, 642);
            this.panelMenu.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-1, 337);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(195, 113);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BorderRadius = 8;
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.FillColor = System.Drawing.Color.White;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 258);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(192, 45);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BorderRadius = 8;
            this.btnTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaiKhoan.FillColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 207);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(192, 45);
            this.btnTaiKhoan.TabIndex = 4;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BorderRadius = 8;
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.FillColor = System.Drawing.Color.White;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 156);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(192, 45);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BorderRadius = 8;
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.White;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.Location = new System.Drawing.Point(0, 51);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(192, 45);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnMonAn
            // 
            this.btnMonAn.BorderRadius = 8;
            this.btnMonAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonAn.FillColor = System.Drawing.Color.White;
            this.btnMonAn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonAn.ForeColor = System.Drawing.Color.Black;
            this.btnMonAn.Image = ((System.Drawing.Image)(resources.GetObject("btnMonAn.Image")));
            this.btnMonAn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMonAn.Location = new System.Drawing.Point(0, 105);
            this.btnMonAn.Name = "btnMonAn";
            this.btnMonAn.Size = new System.Drawing.Size(192, 45);
            this.btnMonAn.TabIndex = 1;
            this.btnMonAn.Text = "Món ăn";
            this.btnMonAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMonAn.Click += new System.EventHandler(this.btnMonAn_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BorderRadius = 8;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(192, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(192, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(978, 642);
            this.panelDesktop.TabIndex = 1;
            // 
            // fMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 642);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Name = "fMainAdmin";
            this.Text = "fMain2";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2Button btnMonAn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panelDesktop;
    }
}