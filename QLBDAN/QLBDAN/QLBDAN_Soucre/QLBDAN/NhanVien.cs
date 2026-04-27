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
    public partial class NhanVien : Form
    {
        string chuoiKetNoi = @"Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dtNhanVien;

        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiKetNoi);
            LoadData();
            ClearForm();
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT MaNV, TenNV, ChucVu, TenDangNhap, MatKhau, TrangThai FROM NhanVien";
                da = new SqlDataAdapter(query, conn);
                dtNhanVien = new DataTable();
                da.Fill(dtNhanVien);
                dgvNV.DataSource = dtNhanVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            cmbChucVu.SelectedIndex = -1;
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cmbTrangThai.SelectedIndex = -1;
            txtTenNV.Focus();
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                cmbChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                cmbTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO NhanVien (TenNV, ChucVu, TenDangNhap, MatKhau, TrangThai) VALUES (@TenNV, @ChucVu, @TenDangNhap, @MatKhau, @TrangThai)";
            ThucThiTruyVan(query, "Thêm nhân viên thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE NhanVien SET TenNV=@TenNV, ChucVu=@ChucVu, TenDangNhap=@TenDangNhap, MatKhau=@MatKhau, TrangThai=@TrangThai WHERE MaNV=@MaNV";
            ThucThiTruyVan(query, "Cập nhật nhân viên thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = "DELETE FROM NhanVien WHERE MaNV=@MaNV";
                ThucThiTruyVan(query, "Xóa nhân viên thành công!");
            }
        }

        private void ThucThiTruyVan(string query, string successMessage)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(chuoiKetNoi))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Hàm truyền tham số - Nếu câu query không chứa @MaNV (như lúc thêm), SQL sẽ tự động bỏ qua dòng này, không bị lỗi
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", cmbChucVu.Text);
                        cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", cmbTrangThai.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show(successMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadData();
                ClearForm();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("Lỗi: Dữ liệu bị trùng lặp!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi CSDL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
