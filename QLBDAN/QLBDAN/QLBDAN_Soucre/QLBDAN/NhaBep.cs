using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBDAN
{
    public partial class NhaBep : Form
    {
        string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";
        public NhaBep()
        {
            InitializeComponent();
        }

        private void NhaBep_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadDonHangCho();

            // Đăng ký sự kiện Timer để tự động làm mới màn hình sau mỗi 5 giây
            timerRefresh.Tick += TimerRefresh_Tick;
            timerRefresh.Start();
        }
        private void SetupDataGridView()
        {
            dgvNhaBep.AutoGenerateColumns = false;
            dgvNhaBep.Columns.Clear();
            dgvNhaBep.RowTemplate.Height = 40;

            // THÊM THUỘC TÍNH Name CHO TẤT CẢ CÁC CỘT
            dgvNhaBep.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaHD", DataPropertyName = "MaHD", HeaderText = "Mã HĐ", Width = 80 });
            dgvNhaBep.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenMon", DataPropertyName = "TenMon", HeaderText = "Tên Món", Width = 200 });
            dgvNhaBep.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoLuong", DataPropertyName = "SoLuong", HeaderText = "SL", Width = 50 });
            dgvNhaBep.Columns.Add(new DataGridViewTextBoxColumn { Name = "GhiChu", DataPropertyName = "GhiChu", HeaderText = "Ghi Chú (Ít đá, cay...)", Width = 150 });

            // Cột ẩn chứa MaMon (Cột này bài trước mình đã để Name rồi)
            dgvNhaBep.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaMon", DataPropertyName = "MaMon", Visible = false });

            // Nút "Xong"
            DataGridViewButtonColumn btnXong = new DataGridViewButtonColumn();
            btnXong.Name = "btnXong";
            btnXong.HeaderText = "Trạng Thái";
            btnXong.Text = "Xong ✔️";
            btnXong.UseColumnTextForButtonValue = true;
            btnXong.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            dgvNhaBep.Columns.Add(btnXong);
        }
        private void LoadDonHangCho()
        {
            // Lấy những món có TrangThaiLam = 0 (Hoặc IS NULL nếu dữ liệu cũ chưa có)
            string query = @"
                SELECT CT.MaHD, CT.MaMon, M.TenMon, CT.SoLuong, CT.GhiChu 
                FROM ChiTietHoaDon CT
                INNER JOIN MonAn M ON CT.MaMon = M.MaMon
                WHERE CT.TrangThaiLam = 0 OR CT.TrangThaiLam IS NULL
                ORDER BY CT.MaHD ASC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNhaBep.DataSource = dt;
            }
        }
        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            // Tự động load lại dữ liệu mỗi 5 giây
            LoadDonHangCho();
        }

        private void dgvNhaBep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu bấm vào cột nút "Xong"
            if (e.RowIndex >= 0 && dgvNhaBep.Columns[e.ColumnIndex].Name == "btnXong")
            {
                int maHD = Convert.ToInt32(dgvNhaBep.Rows[e.RowIndex].Cells["MaHD"].Value);
                string maMon = dgvNhaBep.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();

                CapNhatTrangThaiXong(maHD, maMon);
            }
        }
        private void CapNhatTrangThaiXong(int maHD, string maMon)
        {
            string query = "UPDATE ChiTietHoaDon SET TrangThaiLam = 1 WHERE MaHD = @mahd AND MaMon = @mamon";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mahd", maHD);
                cmd.Parameters.AddWithValue("@mamon", maMon);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadDonHangCho();
        }
    }
}
    

