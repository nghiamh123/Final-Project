using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagerSevice;

namespace FinalProject
{
    public partial class ThongKeDoanhThu : Form
    {
        public ThongKeDoanhThu()
        {
            InitializeComponent();
            LoadBill();
        }

        public void LoadBill()
        {
            HoaDonService hoaDonService = new HoaDonService();
            dtgBill.DataSource = hoaDonService.getBillStatus(1);

            tbTongBill.Text = hoaDonService.getSumBill().ToString();
            tbTongDoanhThu.Text = hoaDonService.getSumPriceAllBill().ToString();
        }

        private void dtgBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dtgBill.RowCount)
            {
                return;
            }

            DataGridViewRow row = dtgBill.Rows[index];
            int id_bill = Convert.ToInt32(row.Cells[0].Value);

            HoaDonService hoaDonService = new HoaDonService();
            tbDoanhThuDon.Text = hoaDonService.getSumPrice(id_bill).ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DateTime from = dtFrom.Value;
            DateTime to = dtTo.Value;

            HoaDonService hoaDonService = new HoaDonService();
            if(from > to)
            {
                MessageBox.Show("Điều kiện lọc sai");
            }
            else
            {
                dtgBill.DataSource = hoaDonService.filterBill(from, to);
                tbTongBill.Text = hoaDonService.sumBillFilter(from, to).ToString();
                tbTongDoanhThu.Text = hoaDonService.getSumFriceFilter(from, to).ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadBill();
            tbDoanhThuDon.Text = "";
        }
    }
}
