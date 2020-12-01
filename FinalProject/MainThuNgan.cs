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
    public partial class MainThuNgan : Form
    {
        public MainThuNgan()
        {
            InitializeComponent();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            this.Hide();
            thanhToan.ShowDialog();
            this.Show();
        }
    }
}
