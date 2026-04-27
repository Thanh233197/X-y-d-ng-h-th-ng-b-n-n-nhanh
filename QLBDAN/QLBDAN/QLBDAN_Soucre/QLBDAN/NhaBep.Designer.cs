namespace QLBDAN
{
    partial class NhaBep
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
            components = new System.ComponentModel.Container();
            dgvNhaBep = new DataGridView();
            timerRefresh = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvNhaBep).BeginInit();
            SuspendLayout();
            // 
            // dgvNhaBep
            // 
            dgvNhaBep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaBep.Location = new Point(12, 12);
            dgvNhaBep.Name = "dgvNhaBep";
            dgvNhaBep.RowHeadersWidth = 51;
            dgvNhaBep.Size = new Size(776, 426);
            dgvNhaBep.TabIndex = 0;
            dgvNhaBep.CellContentClick += dgvNhaBep_CellContentClick;
            // 
            // NhaBep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvNhaBep);
            Name = "NhaBep";
            Text = "NhaBep";
            Load += NhaBep_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhaBep).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNhaBep;
        private System.Windows.Forms.Timer timerRefresh;
    }
}