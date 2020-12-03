using System;
 using RestaurantManagerSevice;
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
    public partial class Informations : Form
    {
        public Informations()
        {
            InitializeComponent();
        }

        private void Informations_Load(object sender, EventArgs e)
        {
            Account ac = Login.NV;
            tbHoTen.Text = ac.name;
            tbEmail.Text = ac.email;
            tbMatKhau.Text = ac.pass;
            tbSDT.Text = ac.phone;
            tbTaiKhoan.Text = ac.username;
        }
    }
}
