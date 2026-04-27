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
    public partial class GioHang : Form
    {

        public GioHang()
        {
            InitializeComponent();
        }
        private List<CartItem> _selectedItems;
        private string _maNV; // Thêm biến lưu mã nhân viên
        private string _maKH; // Thêm biến lưu mã khách hàng

        // Sửa Constructor để nhận danh sách từ Form BanHang
        public GioHang(List<CartItem> items, string maNV, string maKH)
        {
            InitializeComponent();
            _selectedItems = items;
            _maNV = maNV;
            _maKH = maKH;
        }
        
        private void GioHang_Load(object sender, EventArgs e)
        {
            dgvCheckOut.AutoGenerateColumns = false;
            dgvCheckOut.Columns.Clear();

            // Thêm cột Tên món
            dgvCheckOut.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenMon", HeaderText = "Tên Món" });

            // Thêm cột Số lượng
            dgvCheckOut.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLuong", HeaderText = "SL" });

            // Thêm cột Ghi chú
            dgvCheckOut.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GhiChu", HeaderText = "Ghi Chú" });

            // Thêm cột Giảm giá (%)
            dgvCheckOut.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GiamGia", HeaderText = "Giảm (%)" });

            // Thêm cột Thành tiền (Sau giảm giá)
            dgvCheckOut.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ThanhTien",
                HeaderText = "Thành Tiền",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvCheckOut.DataSource = _selectedItems;
            TinhTongCuoiCung();
        }
        private void TinhTongCuoiCung()
        {
            double finalTotal = 0;
            foreach (var item in _selectedItems)
            {
                finalTotal += item.ThanhTien;
            }
            lblTongTienNhan.Text = $"Tổng sau giảm giá: {finalTotal:N0} VNĐ";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (_selectedItems == null || _selectedItems.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            // Chuỗi kết nối của bạn
            string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Chèn vào bảng HoaDon
                    string queryHD = @"INSERT INTO HoaDon (NgayLap, TongTien, MaNV, MaKH) 
                       VALUES (GETDATE(), @tong, @manv, @makh); 
                       SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdHD = new SqlCommand(queryHD, conn, transaction);
                    double total = _selectedItems.Sum(x => x.ThanhTien);

                    cmdHD.Parameters.AddWithValue("@tong", total);
                    cmdHD.Parameters.AddWithValue("@manv", string.IsNullOrEmpty(_maNV) ? (object)DBNull.Value : _maNV);
                    cmdHD.Parameters.AddWithValue("@makh", string.IsNullOrEmpty(_maKH) ? (object)DBNull.Value : _maKH);

                    // Lấy mã hóa đơn tự tăng (kiểu int) vừa được tạo
                    int maHD = Convert.ToInt32(cmdHD.ExecuteScalar());

                    // 2. Insert Chi tiết hóa đơn
                    foreach (var item in _selectedItems)
                    {
                        string queryCT = @"INSERT INTO ChiTietHoaDon (MaHD, MaMon, SoLuong, DonGia, GhiChu) 
                           VALUES (@mahd, @mamon, @sl, @gia, @note)";

                        SqlCommand cmdCT = new SqlCommand(queryCT, conn, transaction);
                        cmdCT.Parameters.AddWithValue("@mahd", maHD);
                        cmdCT.Parameters.AddWithValue("@mamon", item.MaMon);
                        cmdCT.Parameters.AddWithValue("@sl", item.SoLuong);
                        cmdCT.Parameters.AddWithValue("@gia", item.DonGia);
                        cmdCT.Parameters.AddWithValue("@note", string.IsNullOrEmpty(item.GhiChu) ? (object)DBNull.Value : item.GhiChu);

                        cmdCT.ExecuteNonQuery();
                    }

                    // Lưu thành công vào Database
                    transaction.Commit();
                    MessageBox.Show($"Thanh toán thành công!\nMã hóa đơn: {maHD}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hoadon frmIn = new Hoadon(maHD.ToString());

                    frmIn.ShowDialog();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public class CartItem
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
        public double GiamGia { get; set; }

        // Tính thành tiền sau khi trừ giảm giá
        public double ThanhTien => (DonGia * SoLuong) * (1 - GiamGia / 100);
    }
}

