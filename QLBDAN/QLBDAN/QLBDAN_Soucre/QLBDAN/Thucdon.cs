using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLBDAN
{
    public partial class Thucdon : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";

        public Thucdon()
        {
            InitializeComponent();
            this.Load += Thucdon_Load;
            this.dgvData.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dgvData_CellFormatting);
            this.dgvData.CellClick += new DataGridViewCellEventHandler(this.dgvData_CellClick);
        }
        
        private void ExecuteQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    
private void Thucdon_Load(object sender, EventArgs e)
        {
            LoadDataFromSQL();
        }

        private void LoadDataFromSQL()
        {
            string query = "SELECT TenMon, HinhAnh, Dongia, Trangthai FROM MonAn";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                bindingSource.DataSource = dt;
                dgvData.AutoGenerateColumns = false;
                dgvData.Columns.Clear();
                dgvData.DataSource = bindingSource;

                // Thêm các cột vào DataGridView
                dgvData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenMon", HeaderText = "Tên Món" });

                // Cột Hình Ảnh hiển thị trực tiếp trong lưới
                dgvData.Columns.Add(new DataGridViewImageColumn
                {
                    Name = "HinhAnh",
                    HeaderText = "Hình Ảnh",
                    DataPropertyName = "HinhAnh",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 100
                });

                dgvData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Dongia", HeaderText = "Đơn Giá", DefaultCellStyle = { Format = "N0" } });
                dgvData.Columns.Add(new DataGridViewCheckBoxColumn { Name = "TrangThai", HeaderText = "Còn hàng", DataPropertyName = "Trangthai", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });

                dgvData.RowTemplate.Height = 80;
            }
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Hiển thị ảnh trong cột HinhAnh
            if (dgvData.Columns[e.ColumnIndex].Name == "HinhAnh" && e.Value != null)
            {
                string imagePath = e.Value.ToString();
                if (File.Exists(imagePath))
                {
                    try
                    {
                        // Sử dụng MemoryStream để tránh khóa tệp (file locking)
                        using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            e.Value = Image.FromStream(fs);
                        }
                    }
                    catch { e.Value = null; }
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                // Đẩy dữ liệu vào các ô nhập liệu (TextBox/CheckBox)
                txtTenMon.Text = row.Cells[0].Value?.ToString();
                txtDonGia.Text = row.Cells[2].Value?.ToString();
                txtImagePath.Text = row.Cells[1].Value?.ToString();
                chkTrangThai.Checked = Convert.ToBoolean(row.Cells["TrangThai"].Value ?? false);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.png;*.bmp" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = ofd.FileName;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO MonAn (TenMon, HinhAnh, Dongia, Trangthai) VALUES (@Ten, @Anh, @Gia, @TT)";
            SqlParameter[] paras = {
        new SqlParameter("@Ten", txtTenMon.Text),
        new SqlParameter("@Anh", txtImagePath.Text),
        new SqlParameter("@Gia", decimal.Parse(txtDonGia.Text)),
        new SqlParameter("@TT", chkTrangThai.Checked)
    };
            ExecuteQuery(query, paras);
            LoadDataFromSQL();
        }

        // --- HÀM SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE MonAn SET HinhAnh = @Anh, Dongia = @Gia, Trangthai = @TT WHERE TenMon = @Ten";
            SqlParameter[] paras = {
        new SqlParameter("@Ten", txtTenMon.Text),
        new SqlParameter("@Anh", txtImagePath.Text),
        new SqlParameter("@Gia", decimal.Parse(txtDonGia.Text)),
        new SqlParameter("@TT", chkTrangThai.Checked)
    };
            ExecuteQuery(query, paras);
            LoadDataFromSQL();
        }

        // --- HÀM XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM MonAn WHERE TenMon = @Ten";
                SqlParameter[] paras = { new SqlParameter("@Ten", txtTenMon.Text) };
                ExecuteQuery(query, paras);
                LoadDataFromSQL();
            }
        }
    }
}