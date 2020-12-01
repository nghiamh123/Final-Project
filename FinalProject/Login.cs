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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            this.Hide();
            dangKy.ShowDialog();
            this.Show();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            //comment
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String txtUsername = tbTaiKhoan.Text.ToString();
            String txtPass = tbMatKhau.Text.ToString();
            if(txtUsername == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
            }else if(txtPass == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");

            }
            else
            {
                AccountSevice account = new AccountSevice();
                Account ac = account.login(txtUsername, txtPass);
                if(ac != null)
                {
                    if(ac.role == 0)
                    {
                        Main main = new Main();
                        this.Hide();
                        main.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
        }
    }
}
