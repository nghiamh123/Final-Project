using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManagerSevice;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DanhSachMon : Form
    {
        public DanhSachMon()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            FoodService foodService = new FoodService();
            dtgFood.DataSource = foodService.getAllFood();
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            String txtFoodName = tbFoodname.Text;
            int idCategory = Int32.Parse(tbCategoryFood.Text);
            float price = float.Parse(tbPrice.Text);

            if(txtFoodName == "" || idCategory == 0 || price == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
            else
            {
                Food food = new Food { foodname = txtFoodName, id_category = idCategory, price = price };
                FoodService foodService = new FoodService();
                foodService.addFood(food);
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txtFoodName = tbFoodname.Text;
            int idCategory = Int32.Parse(tbCategoryFood.Text);
            float price = float.Parse(tbPrice.Text);
            int id_food = Int32.Parse(tbID.Text);
            if (txtFoodName == "" || idCategory == 0 || price == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
            else
            {
                FoodService foodService = new FoodService();
                foodService.deleteFood(id_food);
                LoadData();
            }
        }

        private void dtgFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dtgFood.RowCount)
            {
                return;
            }

            DataGridViewRow row = dtgFood.Rows[index];
            String food_name = Convert.ToString(row.Cells[1].Value);
            String id_foodname = Convert.ToString(row.Cells[0].Value);
            String id_category = Convert.ToString(row.Cells[2].Value);
            String price = Convert.ToString(row.Cells[3].Value);

            // update UI
            tbID.Text = id_foodname;
            tbFoodname.Text = food_name;
            tbCategoryFood.Text = id_category;
            tbPrice.Text = price;
        }

        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            String txtFoodName = tbFoodname.Text;
            int idCategory = Int32.Parse(tbCategoryFood.Text);
            float price = float.Parse(tbPrice.Text);
            int id_food = Int32.Parse(tbID.Text);
            if (txtFoodName == "" || idCategory == 0 || price == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
            else
            {
                Food food = new Food { id_food = id_food, foodname = txtFoodName, id_category = idCategory, price = price };
                FoodService foodService = new FoodService();
                foodService.updateFood(food);
                LoadData();
            }
        }


    }
}
