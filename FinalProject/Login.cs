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
        public static Account NV;
        public Login()
        {
            InitializeComponent();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            //comment
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String txtUsername = tbTaiKhoan.Text;
            String txtPass = tbMatKhau.Text;
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
                    NV = ac;
                    if(ac.role == 0)
                    {
                        Main main = new Main();
                        this.Hide();
                        main.ShowDialog();
                        this.Show();
                    }else if(ac.role == 1)
                    {
                        MainThuNgan mainThuNgan = new MainThuNgan();
                        this.Hide();
                        mainThuNgan.ShowDialog();
                        this.Show();
                    }else if(ac.role == 2)
                    {
                        MainNV mainNV = new MainNV();
                        this.Hide();
                        mainNV.ShowDialog();
                        this.Show();

                    }else
                    {

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
