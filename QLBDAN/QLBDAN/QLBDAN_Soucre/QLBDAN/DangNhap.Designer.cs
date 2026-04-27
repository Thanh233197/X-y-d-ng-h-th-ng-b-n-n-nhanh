namespace QLBDAN
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbMK = new CheckBox();
            txt2 = new TextBox();
            txt1 = new TextBox();
            lblMK = new Label();
            lblDN = new Label();
            btnQuenMK = new Button();
            btnDN = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 81);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(132, 9);
            label1.Name = "label1";
            label1.Size = new Size(527, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản lý bán đồ ăn nhanh YUMMY";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbMK);
            groupBox1.Controls.Add(txt2);
            groupBox1.Controls.Add(txt1);
            groupBox1.Controls.Add(lblMK);
            groupBox1.Controls.Add(lblDN);
            groupBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 253);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài khoản đăng nhập";
            // 
            // cbMK
            // 
            cbMK.AutoSize = true;
            cbMK.ForeColor = SystemColors.ControlText;
            cbMK.Location = new Point(239, 150);
            cbMK.Margin = new Padding(4, 3, 4, 3);
            cbMK.Name = "cbMK";
            cbMK.Size = new Size(173, 24);
            cbMK.TabIndex = 9;
            cbMK.Text = "Hiển thị mật khẩu";
            cbMK.UseVisualStyleBackColor = true;
            cbMK.CheckedChanged += cbMK_CheckedChanged;
            // 
            // txt2
            // 
            txt2.Location = new Point(239, 118);
            txt2.Margin = new Padding(4, 3, 4, 3);
            txt2.Name = "txt2";
            txt2.Size = new Size(386, 28);
            txt2.TabIndex = 8;
            txt2.UseSystemPasswordChar = true;
            // 
            // txt1
            // 
            txt1.Location = new Point(239, 84);
            txt1.Margin = new Padding(4, 3, 4, 3);
            txt1.Name = "txt1";
            txt1.Size = new Size(386, 28);
            txt1.TabIndex = 7;
            // 
            // lblMK
            // 
            lblMK.AutoSize = true;
            lblMK.Location = new Point(131, 124);
            lblMK.Margin = new Padding(4, 0, 4, 0);
            lblMK.Name = "lblMK";
            lblMK.Size = new Size(90, 20);
            lblMK.TabIndex = 6;
            lblMK.Text = "Mật khẩu:";
            // 
            // lblDN
            // 
            lblDN.AutoSize = true;
            lblDN.Location = new Point(91, 87);
            lblDN.Margin = new Padding(4, 0, 4, 0);
            lblDN.Name = "lblDN";
            lblDN.Size = new Size(130, 20);
            lblDN.TabIndex = 5;
            lblDN.Text = "Tên đăng nhập:";
            // 
            // btnQuenMK
            // 
            btnQuenMK.BackColor = Color.Firebrick;
            btnQuenMK.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuenMK.ForeColor = Color.White;
            btnQuenMK.Location = new Point(133, 346);
            btnQuenMK.Margin = new Padding(4, 3, 4, 3);
            btnQuenMK.Name = "btnQuenMK";
            btnQuenMK.Size = new Size(184, 51);
            btnQuenMK.TabIndex = 8;
            btnQuenMK.Text = "Quên mật khẩu";
            btnQuenMK.UseVisualStyleBackColor = false;
            // 
            // btnDN
            // 
            btnDN.BackColor = Color.Firebrick;
            btnDN.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDN.ForeColor = Color.White;
            btnDN.Location = new Point(455, 346);
            btnDN.Margin = new Padding(4, 3, 4, 3);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(182, 51);
            btnDN.TabIndex = 7;
            btnDN.Text = "Đăng Nhập";
            btnDN.UseVisualStyleBackColor = false;
            btnDN.Click += btnDN_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuenMK);
            Controls.Add(btnDN);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DangNhap";
            Text = "Đăng nhập";
            FormClosed += Dangnhap_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private CheckBox cbMK;
        private TextBox txt2;
        private TextBox txt1;
        private Label lblMK;
        private Label lblDN;
        private Button btnQuenMK;
        private Button btnDN;
    }
}
