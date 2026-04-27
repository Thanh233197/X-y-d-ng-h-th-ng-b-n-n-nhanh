using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using QLBDAN;
namespace QLBDAN
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";

        private void cbMK_CheckedChanged(object sender, EventArgs e)
        {
            txt2.UseSystemPasswordChar = !cbMK.Checked;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string username = txt1.Text.Trim();
            string password = txt2.Text;

            // Kiểm tra rỗng trên giao diện trước khi gọi DB
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "SELECT MaNV, TenNV, ChucVu FROM NhanVien WHERE TenDangNhap=@user AND MatKhau=@pass";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    conn.Open();

                    // Sử dụng SqlDataReader để đọc được nhiều cột
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Nếu có dữ liệu trả về -> Đăng nhập đúng
                        {
                            // 2. LẤY MÃ NHÂN VIÊN TỪ DATABASE RA BIẾN
                            string maNV = reader["MaNV"].ToString();
                            string hoTen = reader["TenNV"].ToString();
                            string chucVu = reader["ChucVu"].ToString();

                            MessageBox.Show("Đăng nhập thành công!\nChào mừng " + hoTen, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Truyền đủ 3 tham số sang FormMain
                            FormMain mainForm = new FormMain(maNV, hoTen, chucVu);
                            mainForm.Show();
                            this.Hide();
                        }
                        else // Không có dòng nào -> Sai thông tin
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Dangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}