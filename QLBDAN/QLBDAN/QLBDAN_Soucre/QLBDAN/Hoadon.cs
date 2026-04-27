using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBDAN
{
    public partial class Hoadon : Form
    {
        private string _maHoaDonCanIn = "";
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public Hoadon()
        {
            InitializeComponent();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
        }
        public Hoadon(string maHD) : this()
        {
            _maHoaDonCanIn = maHD;
        }
        private void Hoadon_Load(object sender, EventArgs e)
        {
            LoadReportHoaDon(_maHoaDonCanIn);
        }
        private void LoadReportHoaDon(string maHD)
        {
            string connectionString = "Data Source=LAPTOP-TU171M51;Initial Catalog=QL_BanDoAnNhanh;Integrated Security=True;Trust Server Certificate=True";
            string query = @"SELECT 
                            HD.MaHD, 
                            HD.MaNV, 
                            NV.TenNV,       
                            HD.MaKH, 
                            HD.NgayLap, 
                            HD.TongTien, 
                            HD.TrangThai,
                            M.TenMon,       
                            CT.SoLuong, 
                            CT.DonGia, 
                            (CT.SoLuong * CT.DonGia) AS ThanhTien
                        FROM HoaDon HD
                        INNER JOIN ChiTietHoaDon CT ON HD.MaHD = CT.MaHD
                        INNER JOIN MonAn M ON CT.MaMon = M.MaMon  
                        INNER JOIN NhanVien NV ON HD.MaNV = NV.MaNV  
                        WHERE HD.MaHD = @MaHD";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", maHD);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                reportViewer1.LocalReport.ReportPath = "rpBaoCao.rdlc";
                                ReportDataSource rds = new ReportDataSource("DS", dt);
                                reportViewer1.LocalReport.DataSources.Clear();
                                reportViewer1.LocalReport.DataSources.Add(rds);
                                reportViewer1.RefreshReport();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy dữ liệu!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}