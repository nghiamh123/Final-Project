using RestaurantManagerSevice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            LoadListFood();
        }

        private void LoadListFood()
        {
            FoodService fo = new FoodService();
            dtgList.DataSource = fo.getAllFood();
        }

        private void LoadListBill()
        {
            HoaDonService hoaDonService = new HoaDonService();
            dtgList.DataSource = hoaDonService.getAllBill();
        }

        private void LoadListTable()
        {
            TableService tableService = new TableService();
            dtgList.DataSource = tableService.getTable();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            Account ac = MainNV.account;
            tbNameNV.Text = ac.name;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            LoadListBill();
        }
        private void btnFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {

            DateTime checkIn = dtCheckin.Value;
            int table = Int32.Parse(tbTable.Text);

            Bill bill = new Bill { Datecheckin = checkIn, id_table = table, status = 0 };
            TalbleFood talble = new TalbleFood { id_table = table , status = true };

            HoaDonService hoaDonService = new HoaDonService();
            TableService tableService = new TableService();

            hoaDonService.addBill(bill);
            tableService.updateStatus(talble);
        }

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index < 0 || index >= dtgList.RowCount)
            {
                return;
            }

            DataGridViewRow row = dtgList.Rows[index];
            String food_name = Convert.ToString(row.Cells[1].Value);
            String id_foodname = Convert.ToString(row.Cells[0].Value);
            String id_category = Convert.ToString(row.Cells[2].Value);
            String price = Convert.ToString(row.Cells[3].Value);

            // update UI
            tbID.Text = id_foodname;
            tbTenMonAn.Text = food_name;
            tbLoaiMon.Text = id_category;
            tbGia.Text = price;
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            int id_bill = Int32.Parse(tbIDBill.Text);
            int id_food = Int32.Parse(tbID.Text);
            String name_nv = tbNameNV.Text;
            String name_kh = tbNameKH.Text;
            float soluong = Int32.Parse(tbSoLuong.Text);

            Bill_info bill_Info = new Bill_info { id_bill = id_bill, customer_name = name_kh, employee_name = name_nv, id_food = id_food, count_food = soluong };

            HoaDonService hoaDonService = new HoaDonService();
            hoaDonService.addBillInfo(bill_Info);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int id_bill = Int32.Parse(tbIDBill.Text);
            HoaDonService hoaDonService = new HoaDonService();
            tbTong.Text = hoaDonService.getSumPrice(id_bill).ToString();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            LoadListTable();    
        }
    }
}
