using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace QLBDAN
{
    public partial class KhachHang : Form
    {
        string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";
        public KhachHang()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            // 1. Chuỗi kết nối (Thay đổi server và database theo máy của bạn)
            string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";

            // 2. Câu lệnh SQL
            string query = "SELECT MaKH AS [Mã KH], TenKH AS [Họ Tên], SoDienThoai AS [SĐT] FROM KhachHang";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    // 3. Đổ dữ liệu vào DataTable
                    da.Fill(dt);

                    // 4. Gán nguồn dữ liệu cho DataGridView
                    dgvData.DataSource = dt;

                    // Tùy chỉnh giao diện một chút
                    dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            // 1. Lấy từ khóa từ TextBox và xóa khoảng trắng thừa
            string keyword = txtTimKiem.Text.Trim();

            // 3. Câu lệnh SQL sử dụng LIKE để tìm kiếm gần đúng
            // N'%' giúp tìm kiếm tiếng Việt có dấu và khớp một phần chuỗi
            string query = "SELECT MaKH, TenKH, SoDienThoai FROM KhachHang " +
                           "WHERE TenKH LIKE @keyword OR SoDienThoai LIKE @keyword";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // 4. Sử dụng Parameter để chống tấn công SQL Injection
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 5. Hiển thị kết quả lên DataGridView
                    dgvData.DataSource = dt;

                    // Thông báo nếu không tìm thấy
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng nào phù hợp!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";
            // 1. Kiểm tra dữ liệu đầu vào cơ bản
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!");
                return;
            }

            string query = "INSERT INTO KhachHang (TenKH, SoDienThoai) VALUES (@hoten, @sdt)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // 2. Truyền tham số để tránh SQL Injection
                    cmd.Parameters.AddWithValue("@hoten", txtTen.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);

                    cmd.ExecuteNonQuery(); // Thực thi lệnh

                    MessageBox.Show("Thêm khách hàng thành công!");
                    LoadData(); // Gọi lại hàm nạp dữ liệu để cập nhật GridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào trên DataGridView chưa
            if (dgvData.CurrentRow == null || dgvData.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa trên bảng!");
                return;
            }

            // 2. Hỏi xác nhận
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";

                // Lấy Mã KH từ cột đầu tiên (Mã KH) của dòng đang được chọn
                string maKH = dgvData.CurrentRow.Cells["Mã KH"].Value.ToString();

                string query = "DELETE FROM KhachHang WHERE MaKH = @makh";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@makh", maKH);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa khách hàng thành công!");
                        LoadData(); // Load lại GridView sau khi xóa
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                // Lấy ra toàn bộ dữ liệu của dòng vừa được click
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                txtTen.Text = row.Cells["Họ Tên"].Value?.ToString();
                txtSDT.Text = row.Cells["SĐT"].Value?.ToString();

                
            }
        }
    }
}
