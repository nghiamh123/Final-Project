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
    public partial class ThongTinNV : Form
    {
        public ThongTinNV()
        {
            InitializeComponent();
            LoadListNV();
        }

        private void LoadListNV()
        {
            AccountSevice account = new AccountSevice();
            List<Account> list = account.getALLNV();
            dtgNV.DataSource = list;
        }

     
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            String txtUser = tbUsername.Text;
            String pass = tbPass.Text;
            int role = Int32.Parse(tbRole.Text);
            String txtName = tbNameNV.Text;
            String phone = tbSDT.Text;
            String address = tbDiaChi.Text;
            String email = tbEmail.Text;
            bool gioitinh;
            if (rbFemale.Checked)
            {
                gioitinh = false;
            }
            else
            {
                gioitinh = true;
            }

            DateTime birthday = dtNgaySinh.Value;

            if(txtUser == "" || pass == "" || txtName == "" || phone == "" || address == "" || email == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
            else
            {
                AccountSevice accountSevice = new AccountSevice();
                Account account = new Account { username = txtUser, pass = pass, role = role, name = txtName, phone = phone, address = address, email = email, gioitinh = gioitinh, ngaysinh = birthday };
                accountSevice.addNV(account);
                LoadListNV();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPass.Text = "";
            tbNameNV.Text = "";
            tbRole.Text = "";
            tbDiaChi.Text = "";
            tbEmail.Text = "";
            tbSDT.Text = "";
        }

        private void dtgNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dtgNV.RowCount)
            {
                return;
            }

            DataGridViewRow row = dtgNV.Rows[index];
            String username = Convert.ToString(row.Cells[0].Value);
            String pass = Convert.ToString(row.Cells[1].Value);
            int role = Convert.ToInt32(row.Cells[2].Value);
            String name = Convert.ToString(row.Cells[3].Value);
            String phone = Convert.ToString(row.Cells[4].Value);
            String address = Convert.ToString(row.Cells[5].Value);
            String email = Convert.ToString(row.Cells[6].Value);
            DateTime birtday = Convert.ToDateTime(row.Cells[8].Value);
            // update UI

            tbUsername.Text = username;
            tbPass.Text = pass;
            tbNameNV.Text = name;
            tbSDT.Text = phone;
            tbDiaChi.Text = address;
            tbEmail.Text = email;
            dtNgaySinh.Value = birtday;
            if (Convert.ToBoolean(row.Cells[7].Value) == true)
            {
                rdMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }

            if(role == 1) {
                tbRole.Text = "Thu ngân";
            }
            else if(role == 2)
            {
                tbRole.Text = "Phục vụ";
            }
            else
            {
                tbRole.Text = "Đầu bếp";
            }


        }

    }
}
