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
    public partial class MainDauBep : Form
    {
        public MainDauBep()
        {
            InitializeComponent();
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informations informations = new Informations();
            this.Hide();
            informations.ShowDialog();
            this.Show();
        }

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemHoaDon xemHoaDon = new XemHoaDon();
            this.Hide();
            xemHoaDon.ShowDialog();
            this.Show();
        }
    }
}
