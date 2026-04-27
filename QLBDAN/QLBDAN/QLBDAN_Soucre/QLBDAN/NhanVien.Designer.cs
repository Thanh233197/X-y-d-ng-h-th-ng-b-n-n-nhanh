namespace QLBDAN
{
    partial class NhanVien
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
            dgvNV = new DataGridView();
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            cmbChucVu = new ComboBox();
            cmbTrangThai = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            SuspendLayout();
            // 
            // dgvNV
            // 
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.Location = new Point(12, 226);
            dgvNV.Name = "dgvNV";
            dgvNV.RowHeadersWidth = 51;
            dgvNV.Size = new Size(776, 208);
            dgvNV.TabIndex = 0;
            dgvNV.CellClick += dgvNV_CellClick;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(115, 25);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(174, 27);
            txtMaNV.TabIndex = 1;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(115, 58);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(174, 27);
            txtTenNV.TabIndex = 2;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(497, 28);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(125, 27);
            txtTenDangNhap.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(497, 62);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // cmbChucVu
            // 
            cmbChucVu.FormattingEnabled = true;
            cmbChucVu.Items.AddRange(new object[] { "Admin", "Nhanvien" });
            cmbChucVu.Location = new Point(115, 91);
            cmbChucVu.Name = "cmbChucVu";
            cmbChucVu.Size = new Size(151, 28);
            cmbChucVu.TabIndex = 5;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Items.AddRange(new object[] { "True", "False" });
            cmbTrangThai.Location = new Point(497, 95);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(151, 28);
            cmbTrangThai.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 7;
            label1.Text = "Mã NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 62);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 8;
            label2.Text = "Tên NV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 103);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 9;
            label3.Text = "Chức vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 32);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 10;
            label4.Text = "Tên DN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 65);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 11;
            label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 103);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 12;
            label6.Text = "Trạng thái";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(113, 163);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 37);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(282, 163);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 37);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(439, 164);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 37);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTrangThai);
            Controls.Add(cmbChucVu);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtTenNV);
            Controls.Add(txtMaNV);
            Controls.Add(dgvNV);
            Name = "NhanVien";
            Text = "NhanVien";
            Load += NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNV;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private ComboBox cmbChucVu;
        private ComboBox cmbTrangThai;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}