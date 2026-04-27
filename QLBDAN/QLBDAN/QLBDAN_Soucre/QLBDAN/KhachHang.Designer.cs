namespace QLBDAN
{
    partial class KhachHang
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
            dgvData = new DataGridView();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnTK = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 178);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(776, 260);
            dgvData.TabIndex = 0;
            dgvData.CellClick += dgvData_CellClick;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(134, 82);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(381, 27);
            txtTen.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(134, 125);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(381, 27);
            txtSDT.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 82);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên KH\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 128);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 5;
            label2.Text = "SDT";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(134, 16);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(381, 27);
            txtTimKiem.TabIndex = 6;
            // 
            // btnTK
            // 
            btnTK.Location = new Point(563, 16);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(94, 29);
            btnTK.TabIndex = 7;
            btnTK.Text = "Tìm kiếm";
            btnTK.UseVisualStyleBackColor = true;
            btnTK.Click += btnTK_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(563, 80);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(563, 124);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(btnTK);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(dgvData);
            Name = "KhachHang";
            Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private TextBox txtTen;
        private TextBox txtSDT;
        private Label label1;
        private Label label2;
        private TextBox txtTimKiem;
        private Button btnTK;
        private Button btnThem;
        private Button btnXoa;
    }
}