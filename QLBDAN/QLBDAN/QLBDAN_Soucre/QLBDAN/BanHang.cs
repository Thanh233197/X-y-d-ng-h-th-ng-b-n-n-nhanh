using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static QLBDAN.BanHang;

namespace QLBDAN
{
    public partial class BanHang : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public BanHang()
        {
            InitializeComponent();
            this.Load += BanHang_Load;
            // Thêm dòng này để đăng ký sự kiện nếu chưa làm trong Designer
            this.dgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvData_CellFormatting);
            LoadKhachHang();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            // Chỉ cần gọi hàm này là xong, không cần tạo list thủ công nữa
            LoadDataFromSQL();
        }
        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra cột Hình Ảnh
            if (dgvData.Columns[e.ColumnIndex].Name == "HinhAnh" && e.Value != null)
            {
                string path = e.Value.ToString();
                if (System.IO.File.Exists(path))
                {
                    try
                    {
                        // Giải pháp tránh lỗi "File đang được sử dụng": tạo bản copy từ stream
                        using (var fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            e.Value = Image.FromStream(fs);
                        }
                        e.FormattingApplied = true;
                    }
                    catch { e.Value = null; }
                }
            }

            // Kiểm tra cột Trạng Thái (Tách riêng ra khỏi khối if trên)
            if (dgvData.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value != null)
            {
                // Kiểm tra an toàn trước khi ép kiểu
                if (bool.TryParse(e.Value.ToString(), out bool isAvailable))
                {
                    e.Value = isAvailable ? "Còn hàng" : "Hết hàng";
                    e.CellStyle.ForeColor = isAvailable ? Color.Green : Color.Red;
                    e.FormattingApplied = true;
                }
            }
            if (e.RowIndex < 0 || e.Value == null) return;

            // Xử lý hiển thị Hình Ảnh (Tránh lỗi file đang mở)
            if (dgvData.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                string path = e.Value.ToString();
                if (File.Exists(path))
                {
                    try
                    {
                        using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                        {
                            e.Value = Image.FromStream(fs);
                        }
                        e.FormattingApplied = true;
                    }
                    catch { e.Value = null; }
                }
            }

            // Xử lý hiển thị Trạng Thái
            if (dgvData.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                if (bool.TryParse(e.Value.ToString(), out bool isAvailable))
                {
                    e.Value = isAvailable ? "Còn hàng" : "Hết hàng";
                    e.CellStyle.ForeColor = isAvailable ? Color.Green : Color.Red;
                    e.FormattingApplied = true;
                }
            }
        }

        private void LoadDataFromSQL()
        {
            string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";
            string query = "SELECT MaMon, TenMon, HinhAnh, Dongia, Trangthai FROM MonAn";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // 1. THÊM CỘT SỐ LƯỢNG VÀO DATATABLE
                DataColumn colSoLuong = new DataColumn("SoLuong", typeof(int));
                colSoLuong.DefaultValue = 0; // Giá trị mặc định tự động là 0
                dt.Columns.Add(colSoLuong);

                // 2. NẠP DỮ LIỆU VÀO BINDING SOURCE
                bindingSource.DataSource = dt;

                // 3. CẤU HÌNH DATAGRIDVIEW
                dgvData.AutoGenerateColumns = false;
                dgvData.Columns.Clear();
                dgvData.RowTemplate.Height = 80;

                // Cột Tên Món
                DataGridViewTextBoxColumn colTen = new DataGridViewTextBoxColumn();
                colTen.DataPropertyName = "TenMon";
                colTen.HeaderText = "Tên Món";
                dgvData.Columns.Add(colTen);

                // Cột Hình Ảnh
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "HinhAnh";
                imgCol.HeaderText = "Hình Minh Họa";
                imgCol.DataPropertyName = "HinhAnh";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.Width = 100;
                dgvData.Columns.Add(imgCol);

                // Cột Đơn Giá
                DataGridViewTextBoxColumn colGia = new DataGridViewTextBoxColumn();
                colGia.DataPropertyName = "Dongia";
                colGia.HeaderText = "Đơn Giá";
                colGia.DefaultCellStyle.Format = "N0";
                dgvData.Columns.Add(colGia);

                // Cột Trạng Thái
                DataGridViewTextBoxColumn colTrangThai = new DataGridViewTextBoxColumn();
                colTrangThai.Name = "TrangThai";
                colTrangThai.DataPropertyName = "Trangthai";
                colTrangThai.HeaderText = "Trạng Thái";
                dgvData.Columns.Add(colTrangThai);

                DataGridViewButtonColumn btnGiam = new DataGridViewButtonColumn();
                btnGiam.Name = "btnGiam";
                btnGiam.HeaderText = "";
                btnGiam.Text = "-";
                btnGiam.UseColumnTextForButtonValue = true;
                btnGiam.Width = 40;
                dgvData.Columns.Add(btnGiam);

                // . Cột Số Lượng
                DataGridViewTextBoxColumn colGridSoLuong = new DataGridViewTextBoxColumn();
                colGridSoLuong.Name = "SoLuong";
                colGridSoLuong.DataPropertyName = "SoLuong"; // Map với DataTable
                colGridSoLuong.HeaderText = "SL";
                colGridSoLuong.Width = 50;
                colGridSoLuong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colGridSoLuong.ReadOnly = true; // Không cho tự gõ, phải bấm nút
                dgvData.Columns.Add(colGridSoLuong);

                // . Cột Nút Tăng (+)
                DataGridViewButtonColumn btnTang = new DataGridViewButtonColumn();
                btnTang.Name = "btnTang";
                btnTang.HeaderText = "";
                btnTang.Text = "+";
                btnTang.UseColumnTextForButtonValue = true;
                btnTang.Width = 40;
                dgvData.Columns.Add(btnTang);

                // Gán nguồn dữ liệu cuối cùng
                dgvData.DataSource = bindingSource;
            }
        }

        private void TangGiamSoLuong(int giaTriTang)
        {
            if (bindingSource.Current is DataRowView rowView)
            {
                int currentVal = Convert.ToInt32(rowView["SoLuong"]);
                int newVal = currentVal + giaTriTang;
                if (newVal < 0) newVal = 0;

                rowView["SoLuong"] = newVal; // Tự động cập nhật vào lưới
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô tìm kiếm trống thì hiển thị toàn bộ
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                bindingSource.Filter = null;
            }
            else
            {
                // Lọc dựa trên cột "TenMon" trong DataTable
                // LIKE '%{0}%' nghĩa là tìm kiếm chuỗi chứa từ khóa ở bất kỳ vị trí nào
                bindingSource.Filter = string.Format("TenMon LIKE '%{0}%'", txtSearch.Text.Replace("'", "''"));
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu người dùng click vào tiêu đề cột
            if (e.RowIndex < 0) return;

            string columnName = dgvData.Columns[e.ColumnIndex].Name;

            // Xử lý khi bấm nút Tăng (+) hoặc Giảm (-)
            if (columnName == "btnTang" || columnName == "btnGiam")
            {
                DataRowView rowView = (DataRowView)bindingSource[e.RowIndex];
                int currentVal = Convert.ToInt32(rowView["SoLuong"]);

                if (columnName == "btnTang")
                {
                    currentVal++;
                }
                else if (columnName == "btnGiam" && currentVal > 0)
                {
                    currentVal--;
                }

                // Cập nhật giá trị vào dữ liệu nền
                rowView["SoLuong"] = currentVal;
                bindingSource.EndEdit();
                dgvData.Refresh(); // Làm mới lưới để hiện số mới ngay lập tức


            }
        }
        private DataTable GetDataTableKhachHang()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";

            // Câu lệnh SQL lấy Mã và Tên khách hàng
            string query = "SELECT MaKH, TenKH FROM KhachHang";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy danh sách khách hàng: " + ex.Message);
                }
            }
            return dt;
        }
        private void LoadKhachHang()
        {
            
            DataTable dtKH = GetDataTableKhachHang();
            cboKhachHang.DataSource = dtKH;
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.SelectedIndex = -1;
        }
        
        private void btnGioHang_Click(object sender, EventArgs e)
        {
            // 1. Lấy MaKH từ ComboBox (đã sửa ở bước trước)
            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }
            string maKH = cboKhachHang.SelectedValue.ToString();

            // 2. Lấy MaNV từ FormMain
            string maNV = FormMain.CurrentMaNV;

            // Kiểm tra xem maNV có bị trống không
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Lỗi: Không tìm thấy thông tin nhân viên đăng nhập!");
                return;
            }

            // 3. Lọc danh sách món đã chọn
            DataTable dt = (DataTable)bindingSource.DataSource;
            List<CartItem> itemsToCkeckout = new List<CartItem>();

            foreach (DataRow row in dt.Rows)
            {
                int qty = Convert.ToInt32(row["SoLuong"]);
                if (qty > 0)
                {
                    itemsToCkeckout.Add(new CartItem
                    {
                        MaMon = row["MaMon"].ToString(),
                        TenMon = row["TenMon"].ToString(),
                        DonGia = Convert.ToDouble(row["Dongia"]),
                        SoLuong = qty,
                        GhiChu = txtGhiChu.Text
                    });
                }
            }

            if (itemsToCkeckout.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn!");
                return;
            }

            // 4. Mở form Giỏ Hàng và truyền tham số
            // Đảm bảo Form GioHang của bạn nhận đủ 3 tham số này
            GioHang frm = new GioHang(itemsToCkeckout, maNV, maKH);
            frm.ShowDialog();
        }

    }
}
