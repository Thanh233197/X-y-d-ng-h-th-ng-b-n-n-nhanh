namespace QLBDAN
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);    
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelMenu = new Panel();
            btnNV = new Button();
            btnNhaKho = new Button();
            btnNhabep = new Button();
            btnDangxuat = new Button();
            btnThoat = new Button();
            btnKH = new Button();
            btnThucDon = new Button();
            btnBanHang = new Button();
            panelLogo = new Panel();
            lblNguoidung = new Label();
            label1 = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.RosyBrown;
            panelMenu.Controls.Add(btnNV);
            panelMenu.Controls.Add(btnNhaKho);
            panelMenu.Controls.Add(btnNhabep);
            panelMenu.Controls.Add(btnDangxuat);
            panelMenu.Controls.Add(btnThoat);
            panelMenu.Controls.Add(btnKH);
            panelMenu.Controls.Add(btnThucDon);
            panelMenu.Controls.Add(btnBanHang);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 579);
            panelMenu.TabIndex = 0;
            // 
            // btnNV
            // 
            btnNV.BackColor = Color.RosyBrown;
            btnNV.Dock = DockStyle.Top;
            btnNV.FlatAppearance.BorderSize = 0;
            btnNV.FlatStyle = FlatStyle.Flat;
            btnNV.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNV.ForeColor = Color.Gainsboro;
            btnNV.Location = new Point(0, 380);
            btnNV.Name = "btnNV";
            btnNV.Padding = new Padding(12, 0, 0, 0);
            btnNV.Size = new Size(220, 60);
            btnNV.TabIndex = 6;
            btnNV.Text = "  Nhân viên";
            btnNV.TextAlign = ContentAlignment.MiddleLeft;
            btnNV.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNV.UseVisualStyleBackColor = false;
            btnNV.Click += btnNV_Click;
            // 
            // btnNhaKho
            // 
            btnNhaKho.BackColor = Color.RosyBrown;
            btnNhaKho.Dock = DockStyle.Top;
            btnNhaKho.FlatAppearance.BorderSize = 0;
            btnNhaKho.FlatStyle = FlatStyle.Flat;
            btnNhaKho.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNhaKho.ForeColor = Color.Gainsboro;
            btnNhaKho.Location = new Point(0, 320);
            btnNhaKho.Name = "btnNhaKho";
            btnNhaKho.Padding = new Padding(12, 0, 0, 0);
            btnNhaKho.Size = new Size(220, 60);
            btnNhaKho.TabIndex = 9;
            btnNhaKho.Text = "  Nhà kho";
            btnNhaKho.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaKho.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhaKho.UseVisualStyleBackColor = false;
            btnNhaKho.Click += btnNhaKho_Click;
            // 
            // btnNhabep
            // 
            btnNhabep.BackColor = Color.RosyBrown;
            btnNhabep.Dock = DockStyle.Top;
            btnNhabep.FlatAppearance.BorderSize = 0;
            btnNhabep.FlatStyle = FlatStyle.Flat;
            btnNhabep.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNhabep.ForeColor = Color.Gainsboro;
            btnNhabep.Location = new Point(0, 260);
            btnNhabep.Name = "btnNhabep";
            btnNhabep.Padding = new Padding(12, 0, 0, 0);
            btnNhabep.Size = new Size(220, 60);
            btnNhabep.TabIndex = 8;
            btnNhabep.Text = "  Nhà bếp";
            btnNhabep.TextAlign = ContentAlignment.MiddleLeft;
            btnNhabep.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhabep.UseVisualStyleBackColor = false;
            btnNhabep.Click += btnNhabep_Click;
            // 
            // btnDangxuat
            // 
            btnDangxuat.BackColor = Color.RosyBrown;
            btnDangxuat.Dock = DockStyle.Bottom;
            btnDangxuat.FlatAppearance.BorderSize = 0;
            btnDangxuat.FlatStyle = FlatStyle.Flat;
            btnDangxuat.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangxuat.ForeColor = Color.Gainsboro;
            btnDangxuat.Location = new Point(0, 459);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Padding = new Padding(12, 0, 0, 0);
            btnDangxuat.Size = new Size(220, 60);
            btnDangxuat.TabIndex = 7;
            btnDangxuat.Text = "   Đăng xuất";
            btnDangxuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangxuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangxuat.UseVisualStyleBackColor = false;
            btnDangxuat.Click += btnDangxuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.RosyBrown;
            btnThoat.Dock = DockStyle.Bottom;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.Gainsboro;
            btnThoat.Location = new Point(0, 519);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(12, 0, 0, 0);
            btnThoat.Size = new Size(220, 60);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "   Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleLeft;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // btnKH
            // 
            btnKH.BackColor = Color.RosyBrown;
            btnKH.Dock = DockStyle.Top;
            btnKH.FlatAppearance.BorderSize = 0;
            btnKH.FlatStyle = FlatStyle.Flat;
            btnKH.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKH.ForeColor = Color.Gainsboro;
            btnKH.Location = new Point(0, 200);
            btnKH.Name = "btnKH";
            btnKH.Padding = new Padding(12, 0, 0, 0);
            btnKH.Size = new Size(220, 60);
            btnKH.TabIndex = 4;
            btnKH.Text = "  Khách hàng";
            btnKH.TextAlign = ContentAlignment.MiddleLeft;
            btnKH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKH.UseVisualStyleBackColor = false;
            btnKH.Click += btnKH_Click;
            // 
            // btnThucDon
            // 
            btnThucDon.BackColor = Color.RosyBrown;
            btnThucDon.Dock = DockStyle.Top;
            btnThucDon.FlatAppearance.BorderSize = 0;
            btnThucDon.FlatStyle = FlatStyle.Flat;
            btnThucDon.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThucDon.ForeColor = Color.Gainsboro;
            btnThucDon.Location = new Point(0, 140);
            btnThucDon.Name = "btnThucDon";
            btnThucDon.Padding = new Padding(12, 0, 0, 0);
            btnThucDon.Size = new Size(220, 60);
            btnThucDon.TabIndex = 3;
            btnThucDon.Text = "  Thực đơn";
            btnThucDon.TextAlign = ContentAlignment.MiddleLeft;
            btnThucDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThucDon.UseVisualStyleBackColor = false;
            btnThucDon.Click += btnThucDon_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = Color.RosyBrown;
            btnBanHang.Dock = DockStyle.Top;
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBanHang.ForeColor = Color.Gainsboro;
            btnBanHang.Location = new Point(0, 80);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(12, 0, 0, 0);
            btnBanHang.Size = new Size(220, 60);
            btnBanHang.TabIndex = 2;
            btnBanHang.Text = "  Bán hàng";
            btnBanHang.TextAlign = ContentAlignment.MiddleLeft;
            btnBanHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBanHang.UseVisualStyleBackColor = false;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(lblNguoidung);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // lblNguoidung
            // 
            lblNguoidung.AutoSize = true;
            lblNguoidung.Location = new Point(3, 0);
            lblNguoidung.Name = "lblNguoidung";
            lblNguoidung.Size = new Size(0, 20);
            lblNguoidung.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = Color.Maroon;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 80);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(762, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Brown;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(762, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TRANG CHỦ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(762, 499);
            panelDesktop.TabIndex = 2;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // FormMain
            // 
            ClientSize = new Size(982, 579);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm Quản lý";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnThucDon;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnNV;
        private Button btnDangxuat;
        private Button btnNhabep;
        private Label lblNguoidung;
        private Button btnNhaKho;
    }
}