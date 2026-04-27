namespace QLBDAN
{
    partial class BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            dgvData = new DataGridView();
            txtSearch = new TextBox();
            btnTK = new Button();
            btnGioHang = new Button();
            txtGhiChu = new TextBox();
            txtGiamGia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cboKhachHang = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 64);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(671, 250);
            dgvData.TabIndex = 0;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(94, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(492, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnTK
            // 
            btnTK.Location = new Point(689, 12);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(99, 27);
            btnTK.TabIndex = 2;
            btnTK.Text = "Tìm kiếm";
            btnTK.UseVisualStyleBackColor = true;
            // 
            // btnGioHang
            // 
            btnGioHang.Location = new Point(689, 64);
            btnGioHang.Name = "btnGioHang";
            btnGioHang.Size = new Size(94, 74);
            btnGioHang.TabIndex = 3;
            btnGioHang.Text = "Giỏ hàng";
            btnGioHang.UseVisualStyleBackColor = true;
            btnGioHang.Click += btnGioHang_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(105, 364);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(578, 27);
            txtGhiChu.TabIndex = 4;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(105, 406);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(578, 27);
            txtGiamGia.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 367);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 6;
            label1.Text = "Ghi chú";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 409);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Giảm giá";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(105, 320);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(151, 28);
            cboKhachHang.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 323);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 9;
            label3.Text = "Khách hàng";
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(cboKhachHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGiamGia);
            Controls.Add(txtGhiChu);
            Controls.Add(btnGioHang);
            Controls.Add(btnTK);
            Controls.Add(txtSearch);
            Controls.Add(dgvData);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BanHang";
            Text = "BanHang";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private TextBox txtSearch;
        private Button btnTK;
        private Button btnGioHang;
        private TextBox txtGhiChu;
        private TextBox txtGiamGia;
        private Label label1;
        private Label label2;
        private ComboBox cboKhachHang;
        private Label label3;
    }
}