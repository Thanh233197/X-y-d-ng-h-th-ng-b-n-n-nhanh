namespace QLBDAN
{
    partial class NhaKho
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
            dgvKhoHang = new DataGridView();
            btnLuu = new Button();
            txtTK = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvKhoHang).BeginInit();
            SuspendLayout();
            // 
            // dgvKhoHang
            // 
            dgvKhoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoHang.Location = new Point(12, 114);
            dgvKhoHang.Name = "dgvKhoHang";
            dgvKhoHang.RowHeadersWidth = 51;
            dgvKhoHang.Size = new Size(776, 324);
            dgvKhoHang.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(707, 31);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(69, 38);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(43, 37);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(592, 27);
            txtTK.TabIndex = 3;
            txtTK.TextChanged += txtTK_TextChanged;
            // 
            // NhaKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTK);
            Controls.Add(btnLuu);
            Controls.Add(dgvKhoHang);
            Name = "NhaKho";
            Text = "NhaKho";
            Load += NhaKho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhoHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKhoHang;
        private Button btnLuu;
        private TextBox txtTK;
    }
}