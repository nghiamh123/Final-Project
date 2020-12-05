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
            AccountSevice accountSevice = new AccountSevice();
            String txtUser = tbUsername.Text;
            String pass = tbPass.Text;
            String role = tbRole.Text;
            String txtName = tbNameNV.Text;
            String phone = tbSDT.Text;
            String address = tbDiaChi.Text;
            String email = tbEmail.Text;
            bool gioitinh;
            int type;
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
                if (role == "TN")
                {
                    type = 1;
                    Account account = new Account { username = txtUser, pass = pass, role = type, name = txtName, phone = phone, address = address, email = email, gioitinh = gioitinh, ngaysinh = birthday };
                    accountSevice.addNV(account);
                    LoadListNV();
                }
                else if (role == "PV")
                {
                    type = 2;

                    Account account = new Account { username = txtUser, pass = pass, role = type, name = txtName, phone = phone, address = address, email = email, gioitinh = gioitinh, ngaysinh = birthday };
                    accountSevice.addNV(account);
                    LoadListNV();
                }
                else if (role == "DB")
                {
                    type = 3;
                    Account account = new Account { username = txtUser, pass = pass, role = type, name = txtName, phone = phone, address = address, email = email, gioitinh = gioitinh, ngaysinh = birthday };
                    accountSevice.addNV(account);
                    LoadListNV();
                }
                else
                {
                    MessageBox.Show("Sai vị trí");
                }

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

            btnThemNhanVien.Enabled = true;
            btnUpdate.Enabled = false;
            btnXoaNV.Enabled = false;
        }

        private void dtgNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemNhanVien.Enabled = false;
            btnUpdate.Enabled = true;
            btnXoaNV.Enabled = true;

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
                tbRole.Text = "TN";
            }
            else if(role == 2)
            {
                tbRole.Text = "PV";
            }
            else
            {
                tbRole.Text = "DB";
            }


        }

        private void LoadListNVBySearch(String find)
        {
            AccountSevice accountSevice = new AccountSevice();
            dtgNV.DataSource = accountSevice.GetAccountsBySearch(find);
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(tbTimKiem.Text == "")
            {
                LoadListNV();
            }
            else
            {
                LoadListNVBySearch(tbTimKiem.Text);
            }
        }

        private void ThongTinNV_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AccountSevice accountSevice = new AccountSevice();

            String txtUser = tbUsername.Text;
            String pass = tbPass.Text;
            String role = tbRole.Text;
            String txtName = tbNameNV.Text;
            String phone = tbSDT.Text;
            String address = tbDiaChi.Text;
            String email = tbEmail.Text;
            bool gioitinh;
            int type;
            if (rbFemale.Checked)
            {
                gioitinh = false;
            }
            else
            {
                gioitinh = true;
            }

            DateTime birthday = dtNgaySinh.Value;

            if (txtUser == "" || pass == "" || txtName == "" || phone == "" || address == "" || email == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
            else
            {
                if (role == "TN")
                {
                    type = 1;
                    Account account = new Account { username = txtUser, pass = pass, role = type, name = txtName, phone = phone, address = address, email = email, gioitinh = gioitinh, ngaysinh = birthday };
                    accountSevice.updateAccount(account);
                    LoadListNV();
                }
                else if (role == "PV")
                {
                    type = 2;

                    Account account = new Account { username = txtUser, pass = pass, role = type, name = txtName, phone = phone, address = address, email = email, gioitinh = gioitinh, ngaysinh = birthday };
                    accountSevice.updateAccount(account);
                    LoadListNV();
                }
                else if (role == "DB")
                {
                    type = 3;
                    Account account = new Account { username = txtUser, pass = pass, role = type, name = txtName, phone = phone, address = address, email = email, gioitinh = gioitinh, ngaysinh = birthday };
                    accountSevice.updateAccount(account);
                    LoadListNV();
                }
                else
                {
                    MessageBox.Show("Sai vị trí");
                }


            }
        }

            private void btnXoaNV_Click(object sender, EventArgs e)
        {
            AccountSevice accountSevice = new AccountSevice();

            String txtUser = tbUsername.Text;
            String pass = tbPass.Text;
            String role = tbRole.Text;
            String txtName = tbNameNV.Text;
            String phone = tbSDT.Text;
            String address = tbDiaChi.Text;
            String email = tbEmail.Text;
            bool gioitinh;
            int type;
            if (rbFemale.Checked)
            {
                gioitinh = false;
            }
            else
            {
                gioitinh = true;
            }

            DateTime birthday = dtNgaySinh.Value;

            if (txtUser == "" || pass == "" || txtName == "" || phone == "" || address == "" || email == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
            else
            {
                if(role == "TN")
                {
                    type = 1;
                    Account account = new Account { username = txtUser, pass = pass, role = type, name = txtName, phone = phone, address = address, email = email, gioitinh = gioitinh, ngaysinh = birthday };
                    accountSevice.updateAccount(account);
                    LoadListNV();
                }
                else if(role == "PV")
                {
                    type = 2;
                   
                    Account account = new Account { username = txtUser, pass = pass, role = type, name = txtName, phone = phone, address = address, email = email, gioitinh = gioitinh, ngaysinh = birthday };
                    accountSevice.deleteAccount(account);
                    LoadListNV();
                }
                else if(role == "DB")
                {
                    type = 3;
                    Account account = new Account { username = txtUser, pass = pass, role = type, name = txtName, phone = phone, address = address, email = email, gioitinh = gioitinh, ngaysinh = birthday };
                    accountSevice.deleteAccount(account);
                    LoadListNV();
                }
                else
                {
                    MessageBox.Show("Sai vị trí");
                }
                
            }

        }
    }
}
