namespace QLBDAN
{
    partial class GioHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GioHang));
            dgvCheckOut = new DataGridView();
            lblTongTienNhan = new Label();
            btnXacNhan = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvCheckOut
            // 
            dgvCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckOut.Location = new Point(12, 12);
            dgvCheckOut.Name = "dgvCheckOut";
            dgvCheckOut.RowHeadersWidth = 51;
            dgvCheckOut.Size = new Size(776, 184);
            dgvCheckOut.TabIndex = 0;
            // 
            // lblTongTienNhan
            // 
            lblTongTienNhan.AutoSize = true;
            lblTongTienNhan.Location = new Point(34, 397);
            lblTongTienNhan.Name = "lblTongTienNhan";
            lblTongTienNhan.Size = new Size(50, 20);
            lblTongTienNhan.TabIndex = 1;
            lblTongTienNhan.Text = "label1";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(658, 397);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(130, 41);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 202);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(776, 152);
            dgvData.TabIndex = 3;
            // 
            // GioHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvData);
            Controls.Add(btnXacNhan);
            Controls.Add(lblTongTienNhan);
            Controls.Add(dgvCheckOut);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GioHang";
            Text = "GioHang";
            Load += GioHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCheckOut;
        private Label lblTongTienNhan;
        private Button btnXacNhan;
        private DataGridView dgvData;
    }
}