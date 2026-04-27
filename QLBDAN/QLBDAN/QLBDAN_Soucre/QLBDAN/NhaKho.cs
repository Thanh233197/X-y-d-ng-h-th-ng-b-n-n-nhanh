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
    public partial class NhaKho : Form
    {
        // Chuỗi kết nối (Thay đổi server name và database name của bạn)
        string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";
        SqlDataAdapter adapter;
        DataTable dtNguyenLieu;
        public NhaKho()
        {
            InitializeComponent();
        }

        private void NhaKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // 1. Hàm nạp dữ liệu từ SQL vào DataGridView
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM NguyenLieu";

                // SỬA Ở ĐÂY: Truyền trực tiếp connectionString vào Adapter
                adapter = new SqlDataAdapter(query, connectionString);

                // Tạo SqlCommandBuilder để tự động phát sinh code Thêm/Sửa/Xóa
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                dtNguyenLieu = new DataTable();
                adapter.Fill(dtNguyenLieu);

                dgvKhoHang.DataSource = dtNguyenLieu;

                // Tùy chỉnh tiêu đề cột cho đẹp
                dgvKhoHang.Columns["idnguyenlieu"].HeaderText = "ID";
                dgvKhoHang.Columns["tennguyenlieu"].HeaderText = "Tên Nguyên Liệu";
                dgvKhoHang.Columns["soluongton"].HeaderText = "Tồn Kho";
                dgvKhoHang.Columns["donvitinh"].HeaderText = "ĐVT (Kg/Cái)";
                dgvKhoHang.Columns["trangthai"].HeaderText = "Trạng thái";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(dtNguyenLieu);
                MessageBox.Show("Cập nhật kho thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtNguyenLieu.DefaultView;
            dv.RowFilter = string.Format("tennguyenlieu LIKE '%{0}%'", txtTK.Text);
            dgvKhoHang.DataSource = dv;
        }
    }
}
