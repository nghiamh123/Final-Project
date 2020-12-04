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
    public partial class XemHoaDon : Form
    {
        public XemHoaDon()
        {
            InitializeComponent();
            LoadBill();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[index];
            int id_bill = Convert.ToInt32(row.Cells[0].Value);
            getBillInfoByID(id_bill);
        }

        private void getBillInfoByID(int id_bill)
        {
            HoaDonService hoaDonService = new HoaDonService();
            dataGridView2.DataSource = hoaDonService.getBillInfoByid(id_bill);
        }

        private void LoadBill()
        {
            HoaDonService hoaDonService = new HoaDonService();
            dataGridView1.DataSource=hoaDonService.getBillStatus(0);
        }
    }
}
