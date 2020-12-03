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
    public partial class MainNV : Form
    {
        public static Account account;
        public MainNV()
        {
            InitializeComponent();
        }

        private void MainNV_Load(object sender, EventArgs e)
        {

            account = Login.NV;
            lbNameNV.Text = account.name;
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            this.Hide();
            order.ShowDialog();
            this.Show();
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informations informations = new Informations();
            this.Hide();
            informations.ShowDialog();
            this.Show();
        }
    }
}
