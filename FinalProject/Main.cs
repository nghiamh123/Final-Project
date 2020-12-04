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
    public partial class Main : Form
    {
        public static Account ac;
        public Main()
        {
            InitializeComponent();
            
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinNV thongTinNV = new ThongTinNV();
            this.Hide();
            thongTinNV.ShowDialog();
            this.Show();
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu thongKeDoanhThu = new ThongKeDoanhThu();
            this.Hide();
            thongKeDoanhThu.ShowDialog();
            this.Show();
        }

        private void danhSáchMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachMon danhSachMon = new DanhSachMon();
            danhSachMon.ShowDialog();
            this.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ac = Login.NV;
            lbName.Text = ac.name;
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informations informations = new Informations();
            this.Hide();
            informations.ShowDialog();
            this.Show();
        }
    }
}
