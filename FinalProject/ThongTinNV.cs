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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
