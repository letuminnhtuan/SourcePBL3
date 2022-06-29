namespace SourceCode.GUI
{
    partial class fNhanVien1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoaiNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchNV = new Guna.UI2.WinForms.Guna2Button();
            this.dataNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDelNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNV = new Guna.UI2.WinForms.Guna2Button();
            this.cbbSortNV = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại nhân viên";
            // 
            // cbbLoaiNV
            // 
            this.cbbLoaiNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbLoaiNV.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiNV.BorderRadius = 8;
            this.cbbLoaiNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoaiNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbLoaiNV.ItemHeight = 30;
            this.cbbLoaiNV.Location = new System.Drawing.Point(113, 12);
            this.cbbLoaiNV.Name = "cbbLoaiNV";
            this.cbbLoaiNV.Size = new System.Drawing.Size(225, 36);
            this.cbbLoaiNV.TabIndex = 29;
            this.cbbLoaiNV.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiNV_SelectedIndexChanged);
            // 
            // txtSearchNV
            // 
            this.txtSearchNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchNV.Animated = true;
            this.txtSearchNV.BorderRadius = 8;
            this.txtSearchNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchNV.DefaultText = "Tìm nhân viên";
            this.txtSearchNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNV.Location = new System.Drawing.Point(578, 12);
            this.txtSearchNV.Name = "txtSearchNV";
            this.txtSearchNV.PasswordChar = '\0';
            this.txtSearchNV.PlaceholderText = "";
            this.txtSearchNV.SelectedText = "";
            this.txtSearchNV.Size = new System.Drawing.Size(225, 36);
            this.txtSearchNV.TabIndex = 32;
            this.txtSearchNV.Click += new System.EventHandler(this.txtSearchNV_Click);
            this.txtSearchNV.Leave += new System.EventHandler(this.txtSearchNV_Leave);
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchNV.BorderRadius = 16;
            this.btnSearchNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnSearchNV.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearchNV.ForeColor = System.Drawing.Color.Black;
            this.btnSearchNV.Location = new System.Drawing.Point(836, 12);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Size = new System.Drawing.Size(114, 35);
            this.btnSearchNV.TabIndex = 34;
            this.btnSearchNV.Text = "Tìm kiếm";
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // dataNV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNV.BackgroundColor = System.Drawing.Color.White;
            this.dataNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataNV.EnableHeadersVisualStyles = false;
            this.dataNV.GridColor = System.Drawing.Color.LightGray;
            this.dataNV.Location = new System.Drawing.Point(15, 54);
            this.dataNV.Name = "dataNV";
            this.dataNV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataNV.RowHeadersVisible = false;
            this.dataNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNV.Size = new System.Drawing.Size(935, 495);
            this.dataNV.TabIndex = 35;
            this.dataNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataNV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataNV.ThemeStyle.GridColor = System.Drawing.Color.LightGray;
            this.dataNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightGray;
            this.dataNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataNV.ThemeStyle.HeaderStyle.Height = 23;
            this.dataNV.ThemeStyle.ReadOnly = true;
            this.dataNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataNV.ThemeStyle.RowsStyle.Height = 22;
            this.dataNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnDelNV
            // 
            this.btnDelNV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelNV.AutoRoundedCorners = true;
            this.btnDelNV.BorderRadius = 16;
            this.btnDelNV.BorderThickness = 1;
            this.btnDelNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelNV.FillColor = System.Drawing.Color.LightGray;
            this.btnDelNV.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnDelNV.ForeColor = System.Drawing.Color.Black;
            this.btnDelNV.Location = new System.Drawing.Point(649, 555);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(93, 35);
            this.btnDelNV.TabIndex = 38;
            this.btnDelNV.Text = "Xóa";
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateNV.AutoRoundedCorners = true;
            this.btnUpdateNV.BorderRadius = 16;
            this.btnUpdateNV.BorderThickness = 1;
            this.btnUpdateNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateNV.FillColor = System.Drawing.Color.LightGray;
            this.btnUpdateNV.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnUpdateNV.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateNV.Location = new System.Drawing.Point(546, 555);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(97, 35);
            this.btnUpdateNV.TabIndex = 37;
            this.btnUpdateNV.Text = "Cập nhật";
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddNV.AutoRoundedCorners = true;
            this.btnAddNV.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNV.BorderRadius = 16;
            this.btnAddNV.BorderThickness = 1;
            this.btnAddNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNV.FillColor = System.Drawing.Color.LightGray;
            this.btnAddNV.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAddNV.ForeColor = System.Drawing.Color.Black;
            this.btnAddNV.Location = new System.Drawing.Point(444, 555);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(96, 35);
            this.btnAddNV.TabIndex = 36;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // cbbSortNV
            // 
            this.cbbSortNV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbbSortNV.BackColor = System.Drawing.Color.Transparent;
            this.cbbSortNV.BorderRadius = 8;
            this.cbbSortNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSortNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSortNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSortNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSortNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSortNV.ItemHeight = 30;
            this.cbbSortNV.Items.AddRange(new object[] {
            "Ten nhan vien",
            "Luong",
            "Ngay lam viec"});
            this.cbbSortNV.Location = new System.Drawing.Point(748, 555);
            this.cbbSortNV.Name = "cbbSortNV";
            this.cbbSortNV.Size = new System.Drawing.Size(202, 36);
            this.cbbSortNV.TabIndex = 39;
            this.cbbSortNV.SelectedIndexChanged += new System.EventHandler(this.cbbSortNV_SelectedIndexChanged);
            // 
            // fNhanVien1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 603);
            this.Controls.Add(this.cbbSortNV);
            this.Controls.Add(this.btnDelNV);
            this.Controls.Add(this.btnUpdateNV);
            this.Controls.Add(this.btnAddNV);
            this.Controls.Add(this.dataNV);
            this.Controls.Add(this.btnSearchNV);
            this.Controls.Add(this.txtSearchNV);
            this.Controls.Add(this.cbbLoaiNV);
            this.Controls.Add(this.label1);
            this.Name = "fNhanVien1";
            this.Text = "fNhanVien1";
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiNV;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchNV;
        private Guna.UI2.WinForms.Guna2Button btnSearchNV;
        private Guna.UI2.WinForms.Guna2DataGridView dataNV;
        private Guna.UI2.WinForms.Guna2Button btnDelNV;
        private Guna.UI2.WinForms.Guna2Button btnUpdateNV;
        private Guna.UI2.WinForms.Guna2Button btnAddNV;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSortNV;
    }
}