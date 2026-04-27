namespace QLBDAN
{
    partial class Thucdon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thucdon));
            dgvData = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtTenMon = new TextBox();
            txtDonGia = new TextBox();
            txtImagePath = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnBrowse = new Button();
            chkTrangThai = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(10, 182);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(756, 243);
            dgvData.TabIndex = 0;
            dgvData.CellClick += dgvData_CellClick;
            dgvData.CellFormatting += dgvData_CellFormatting;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(672, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(672, 66);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(672, 108);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(185, 23);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(466, 27);
            txtTenMon.TabIndex = 4;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(185, 63);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(466, 27);
            txtDonGia.TabIndex = 5;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(185, 96);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(466, 27);
            txtImagePath.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 7;
            label1.Text = "Tên món";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 66);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 8;
            label2.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 9;
            label3.Text = "Hình ảnh";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(99, 130);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(80, 28);
            btnBrowse.TabIndex = 10;
            btnBrowse.Text = "Duyệt";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Location = new Point(185, 134);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(94, 24);
            chkTrangThai.TabIndex = 11;
            chkTrangThai.Text = "Còn hàng";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // Thucdon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkTrangThai);
            Controls.Add(btnBrowse);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtImagePath);
            Controls.Add(txtDonGia);
            Controls.Add(txtTenMon);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvData);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Thucdon";
            Text = "Thucdon";
            Load += Thucdon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtTenMon;
        private TextBox txtDonGia;
        private TextBox txtImagePath;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBrowse;
        private CheckBox chkTrangThai;
    }
}