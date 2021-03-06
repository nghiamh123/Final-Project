﻿using RestaurantManagerSevice;
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
        public static Account account;
        public MainThuNgan()
        {
            InitializeComponent();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu thongKeDoanhThu = new ThongKeDoanhThu();
            this.Hide();
            thongKeDoanhThu.ShowDialog();
            this.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            this.Hide();
            thanhToan.ShowDialog();
            this.Show();
        }

        private void MainThuNgan_Load(object sender, EventArgs e)
        {
            account = Login.NV;
            lbNameTN.Text = account.name;
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
