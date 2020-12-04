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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
            LoadBill();
        }

        private void dtgBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HoaDonService hoaDonService = new HoaDonService();
            int index = e.RowIndex;
            if (index < 0 || index >= dtgBill.RowCount)
            {
                return;
            }

            DataGridViewRow row = dtgBill.Rows[index];
            int id_bill = Convert.ToInt32(row.Cells[0].Value);
            DateTime checkin = Convert.ToDateTime(row.Cells[1].Value);
            String table = Convert.ToString(row.Cells[3].Value);
            

            tbIDBill.Text = id_bill.ToString();
            dtCheckIN.Value = checkin;
            tbTable.Text = table;

            getBillInfoByID(id_bill);

            tbSum.Text = hoaDonService.getSumPrice(id_bill).ToString();
        }

        private void dtgBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dtgBillInfo.RowCount)
            {
                return;
            }

            DataGridViewRow row = dtgBillInfo.Rows[index];
            int id_bill = Convert.ToInt32(row.Cells[0].Value);

            String nameNV = Convert.ToString(row.Cells[3].Value);
            String nameKH = Convert.ToString(row.Cells[2].Value);

            tbNameNV.Text = nameNV;
            tbNameKH.Text = nameKH;
        }

        private void getBillInfoByID(int id_bill)
        {
            HoaDonService hoaDonService = new HoaDonService();
            dtgBillInfo.DataSource = hoaDonService.getBillInfoByid(id_bill);
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            HoaDonService hoaDonService = new HoaDonService();
            TableService tableService = new TableService();

            int id_bill = Int32.Parse(tbIDBill.Text);
            DateTime checkin = dtCheckIN.Value;
            DateTime checkout = dtCheckOUT.Value;
            int id_table = Int32.Parse(tbTable.Text);


            Bill bill = new Bill { id_bill = id_bill, Datecheckin = checkin, Datecheckout = checkout, id_table = id_table, status = 1 };
            TalbleFood talble = new TalbleFood { id_table = id_table, status = false };
            hoaDonService.updateBill(bill);
            tableService.updateStatus(talble);

            LoadBill();
            dtgBillInfo.DataSource = null;

        }


        private void LoadBill()
        {
            HoaDonService hoaDonService = new HoaDonService();
            dtgBill.DataSource = hoaDonService.getBillStatus(0);
        }

        private void getBillByTable(int id_table)
        {
            HoaDonService hoaDonService = new HoaDonService();
            dtgBill.DataSource =  hoaDonService.GetBillsByTable(id_table);
        }

        private void tbSerachTable_TextChanged(object sender, EventArgs e)
        {
            if(tbSerachTable.Text == "")
            {
                LoadBill();
            }
            else
            {
                getBillByTable(Int32.Parse(tbSerachTable.Text));
            }
        }
    }
}
