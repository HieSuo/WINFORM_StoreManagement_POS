using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using StoreManagement.DAO;
using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;

namespace StoreManagement.GUI.ModuleForm
{
    public partial class F_TrangChu : Form
    {
        private List<HoaDon> listHoaDon;
        private List<ThongSoSanPhamDTO> listTSSP = new List<ThongSoSanPhamDTO>();
        private Dictionary<DateTime, int> icomePerDay = new Dictionary<DateTime, int>();
        private Dictionary<DateTime, int> chiTieuPerDay = new Dictionary<DateTime, int>();
        private Dictionary<String, double> tyleLoaiSanPham = new Dictionary<string, double>();
        public F_TrangChu()
        {
            InitializeComponent();
            LoadDataMacDinh();
            LoadBieuDoThiPhan();
        }
        public void LoadDataMacDinh()
        {
            int tongThuNhap = HoaDonDAO.Instance.GetTongThu();
            lbTongThu.Text = tongThuNhap.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbTongChi.Text = PhieuNhapDAO.Instance.GetTongChi().ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbSoLuonSP.Text = SanPhamDAO.Instance.GetSoLuongSanPham() + "";

            listHoaDon = HoaDonDAO.Instance.GetAllHoaDon();
            icomePerDay = HoaDonDAO.Instance.GetIncomePerDay();
            chiTieuPerDay = PhieuNhapDAO.Instance.GetChiTieuPerDay();

            
            LoadTSSP();
            LoadBieuDoThuChi();
        }
        public void LoadTSSP()
        {
            listTSSP.Clear();
            dgvThongSoSanPham.Rows.Clear();
            listTSSP = SanPhamDAO.Instance.GetListThongSoSanPham();
            if(listTSSP.Count <= 0)
            {
                return;
            }
            foreach(ThongSoSanPhamDTO ts in listTSSP)
            {
                dgvThongSoSanPham.Rows.Add(ts.MaSanPham, ts.TenSanPham, ts.SoLuongTonKho, ts.GiaBan.ToString("C", CultureInfo.GetCultureInfo("vi-VN")), ts.GiaNhapGanNhat.ToString("C",  CultureInfo.GetCultureInfo("vi-VN")), ts.DaBan, ts.DaNhap);
            }
        }
        public void LoadDataByDatePicker(DateTime dayFrom, DateTime dayTo)
        {
            int tongThuNhap = HoaDonDAO.Instance.GetTongThuByDay(dayFrom, dayTo);
            lbTongThu.Text = tongThuNhap.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbTongChi.Text = PhieuNhapDAO.Instance.GetTongChiByDate(dayFrom, dayTo).ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbSoLuonSP.Text = SanPhamDAO.Instance.GetSoLuongSanPham() + "";

            listHoaDon = HoaDonDAO.Instance.GetAllHoaDon();
            icomePerDay = HoaDonDAO.Instance.GetIncomePerDayByDate(dayFrom, dayTo);
            chiTieuPerDay = PhieuNhapDAO.Instance.GetChiTieuPerDayByDate(dayFrom, dayTo);
            LoadBieuDoThuChi();
        }
        public void LoadBieuDoThuChi()
        {
            chartThongKe.AxisX.Clear();
            chartThongKe.AxisY.Clear();
            SeriesCollection seriesCollection = new SeriesCollection();
            LineSeries thuSeries = new LineSeries
            {
                Title = "Tiền thu",
                Values = new ChartValues<int>()
            };

            // Tạo một đối tượng Series cho tiền chi
            LineSeries chiSeries = new LineSeries
            {
                Title = "Tiền chi",
                Values = new ChartValues<int>()
            };

            List<string> days = new List<string>();
            // Thêm dữ liệu từ dictionary vào series tương ứng
            foreach (var pair in icomePerDay)
            {
                thuSeries.Values.Add(pair.Value);
                // Kiểm tra xem pairPhieuChi có ngày tương ứng không
                if (chiTieuPerDay.ContainsKey(pair.Key))
                {
                    chiSeries.Values.Add(chiTieuPerDay[pair.Key]);
                }
                else
                {
                    // Nếu không có dữ liệu chi cho ngày này, gán giá trị 0
                    chiSeries.Values.Add(0);
                }
                // Thêm ngày vào danh sách nhãn
                days.Add(pair.Key.ToString("dd/MM/yyyy"));
            }

            // Gán danh sách nhãn vào trục x


            // Thêm series vào biểu đồ
            seriesCollection.Add(thuSeries);
            seriesCollection.Add(chiSeries);

            chartThongKe.AxisX.Add(new Axis
            {
                Title = "Ngày",
                Labels = days.ToArray() // Thiết lập nhãn trục x là các ngày
            });
            chartThongKe.AxisY.Add(new Axis
            {
                Title = "Số tiền",
                LabelFormatter = value => value.ToString("C", CultureInfo.GetCultureInfo("vi-VN"))
            });
            // Gán series cho biểu đồ
            chartThongKe.Series = seriesCollection;
        }
        public void LoadBieuDoThiPhan()
        {
            tyleLoaiSanPham = LoaiSanPhamDAO.Instance.GetRatioLoaiSanPhamBanRa();
            var loaiSPSeries = new SeriesCollection();

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            foreach (var pair in tyleLoaiSanPham)
            {
                loaiSPSeries.Add(new PieSeries
                {
                    Title = pair.Key,
                    Values = new ChartValues<double> { pair.Value },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }
            chartThiPhan.Series = loaiSPSeries;


            chartThiPhan.LegendLocation = LegendLocation.Bottom;
        }
        public void LoadBieuDoTyLeLoaiSanPham()
        {
            tyleLoaiSanPham = LoaiSanPhamDAO.Instance.GetRatioLoaiSanPham();
            var loaiSPSeries = new SeriesCollection();

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            foreach (var pair in tyleLoaiSanPham)
            {
                loaiSPSeries.Add(new PieSeries
                {
                    Title = pair.Key,
                    Values = new ChartValues<double> { pair.Value },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }
            chartThiPhan.Series = loaiSPSeries;


            chartThiPhan.LegendLocation = LegendLocation.Bottom;
        }
       

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DateTime dayFrom = dpkDayFrom.Value;
            DateTime dayTo = dpkDayTo.Value;
            if (dayFrom > dayTo)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadDataByDatePicker(dayFrom, dayTo);
        }

        private void cbThiPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int luaChon = cbThiPhan.SelectedIndex;

            switch (luaChon)
            {
                case 0:
                    LoadBieuDoThiPhan();
                    break;
                case 1:
                    LoadBieuDoTyLeLoaiSanPham();
                    break;
            }
        }

        private void cbChonThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            int luaChon = cbChonThoiGian.SelectedIndex;
            DateTime today = DateTime.Now;
            DateTime dayFrom = today.AddDays(-30);
            switch (luaChon)
            {
                case 0:
                    LoadDataMacDinh();
                    break;
                case 1:
                   dayFrom = today.AddDays(-7);
                    LoadDataByDatePicker(dayFrom, today);
                    break;
                case 2:
                    dayFrom = today.AddDays(-30);
                    LoadDataByDatePicker(dayFrom, today);
                    break;
                case 3:
                    dayFrom = today.AddDays(-365);
                    LoadDataByDatePicker(dayFrom, today);
                    break;

            }
        }

		private void dgvThongSoSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
