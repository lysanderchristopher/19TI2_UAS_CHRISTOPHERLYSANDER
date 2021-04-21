using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }


        public void user(int i)
        {
            int userIndex = i;
            User a = new User();
            List<User> dataUser = new List<User>();
            dataUser = a.loadUser();

            if(dataUser[i].Authority == "ADMINISTRATOR")
            {
                configureAccountToolStripMenuItem.Enabled = true;
                sellStripMenuItem.Enabled = true;
                buyToolStripMenuItem.Enabled = true;
                reportpembelianToolStripMenuItem.Enabled = true;
                reportpenjualanToolStripMenuItem.Enabled = true;
            }
            else if (dataUser[i].Authority == "PENJUALAN")
            {
                configureAccountToolStripMenuItem.Enabled = false;
                stockListToolStripMenuItem.Enabled = false;
                sellStripMenuItem.Enabled = true;
                buyToolStripMenuItem.Enabled = false;
                reportpembelianToolStripMenuItem.Enabled = false;
                reportpenjualanToolStripMenuItem.Enabled = true;
            }
            else if (dataUser[i].Authority == "PEMBELIAN")
            {
                configureAccountToolStripMenuItem.Enabled = false;
                stockListToolStripMenuItem.Enabled = false;
                sellStripMenuItem.Enabled = false;
                buyToolStripMenuItem.Enabled = true;
                reportpembelianToolStripMenuItem.Enabled = true;
                reportpenjualanToolStripMenuItem.Enabled = false;
            }
            else if (dataUser[i].Authority == "STOK")
            {
                configureAccountToolStripMenuItem.Enabled = false;
                stockListToolStripMenuItem.Enabled = true;
                sellStripMenuItem.Enabled = true;
                buyToolStripMenuItem.Enabled = true;
                reportpembelianToolStripMenuItem.Enabled = true;
                reportpenjualanToolStripMenuItem.Enabled = true;
            }

        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPenjualan fp = new FormPenjualan();
            fp.MdiParent = this;
            fp.Show();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPembelian fs = new FormPembelian();
            fs.MdiParent = this;
            fs.Show();
        }

        private void reportpembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaporanPembelian fl = new FormLaporanPembelian();
            fl.MdiParent = this;
            fl.Show();

        }

        private void reportpenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaporanPenjualan fl = new FormLaporanPenjualan();
            fl.MdiParent = this;
            fl.Show();

        }

        private void configureAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser fu = new FormUser();
            fu.MdiParent = this;
            fu.Show();
        }

        private void stockListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStok fs = new FormStok();
            fs.MdiParent = this;
            fs.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin fs = new FormLogin();
            fs.Show();
            this.Hide();
        }
    }
}
