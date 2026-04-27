using Azure.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using QLBDAN;

namespace QLBDAN
{
    public partial class FormMain : Form
    {
        // Biến để lưu trữ form con đang hoạt động
        public static string CurrentMaNV = "";
        private Form activeForm = null; // Sử dụng null để biểu thị không có form nào đang mở
        private string tenNhanVien;
        private string quyenHan;
        private string _maNV;
        public FormMain(string maNV, string tenNV, string chucVu)
        {
            InitializeComponent();
            this._maNV = maNV;       // Nhận mã nhân viên
            this.tenNhanVien = tenNV;
            this.quyenHan = chucVu;
            CurrentMaNV = maNV;
        }

        // Một phương thức chung để mở các form con trong panel chính
        private void OpenChildForm(Form childForm)
        {
            // Nếu đã có form đang mở, hãy đóng nó lại
            if (activeForm != null)
            {
                panelDesktop.Controls.Remove(activeForm);
            }

            // Gán form mới là form đang hoạt động
            activeForm = childForm; // Cập nhật form đang hoạt động

            // Cấu hình cho form con
            childForm.TopLevel = false; // Form con không phải là cửa sổ cấp cao nhất
            childForm.FormBorderStyle = FormBorderStyle.None; // Bỏ viền của form con
            childForm.Dock = DockStyle.Fill; // Lấp đầy panel chính

            // Thêm form con vào panel chính và hiển thị
            this.panelDesktop.Controls.Add(childForm); // Thêm form con vào panel
            this.panelDesktop.Tag = childForm;// Gán form con vào Tag của panel (không bắt buộc)
            childForm.BringToFront();// Đưa form con lên trên cùng
            childForm.Show();// Hiển thị form con
            lblTitle.Text = childForm.Text; // Cập nhật tiêu đề
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang());
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?",
         "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BanHang());
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Thucdon());
        }
        private void btnNhabep_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhaBep());
        }
        private void btnNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
        }
        private void btnNhaKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhaKho());
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Gán tên hiển thị
            lblNguoidung.Text = "Xin chào: " + tenNhanVien;

            // Gọi hàm phân quyền (mọi logic ẩn/hiện nút đã nằm trong này rồi)
            PhanQuyen();
        }
        private void PhanQuyen()
        {
            MessageBox.Show("Quyền của tài khoản này là: [" + quyenHan + "]");

            // Thêm .Trim() để cắt hết các dấu cách bị dư đi
            if (quyenHan != null && quyenHan.Trim() == "Nhanvien")
            {
                btnThucDon.Visible = false;
                btnNhaKho.Visible = false;
                btnNV.Visible = false;
            }
            else if (quyenHan != null && quyenHan.Trim() == "Admin")
            {
                btnThucDon.Visible = true;
                btnNhaKho.Visible = true;
                btnNV.Visible = true;
            }
        }
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Gỡ bỏ sự kiện FormClosed để tránh tắt luôn cả ứng dụng
                this.FormClosed -= FormMain_FormClosed;

                this.Close(); // Đóng FormMain

                // Chú ý: Cần viết đúng chính xác tên class Form Đăng nhập của bạn (ở đây mình để là DangNhap)
                Form login = Application.OpenForms["DangNhap"];

                if (login != null)
                {
                    login.Show();
                }
                else
                {
                    // Nếu không tìm thấy form cũ, tạo luôn form mới
                    DangNhap newLogin = new DangNhap();
                    newLogin.Show();
                }
            }
        }
        public void HienThiTenNhanVien(string maNV)
        {

            // Cập nhật lại chuỗi kết nối giống với các form khác của bạn
            string connString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";

            // Truy vấn lấy tên nhân viên (sửa 'HoTen' thành tên cột tương ứng trong DB của bạn nếu cần)
            string query = "SELECT TenNV FROM NhanVien WHERE MaNV = @MaNV";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", maNV); // Tránh lỗi SQL Injection

                    // LƯU MÃ NHÂN VIÊN VÀO BIẾN TĨNH ĐỂ CÁC FORM KHÁC CÙNG DÙNG
                    CurrentMaNV = maNV;

                    // Thực thi và lấy kết quả
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        lblNguoidung.Text = "Xin chào: " + result.ToString();
                    }
                    else
                    {
                        lblNguoidung.Text = "Không tìm thấy nhân viên";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy tên nhân viên: " + ex.Message);
                }
            }
        }
        
    }
}
