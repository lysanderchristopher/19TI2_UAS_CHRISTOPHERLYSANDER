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
    public partial class FormLaporanPenjualan : Form
    {
        List<Stok> dataStok = new List<Stok>();
        List<LaporanPenjualan> dataLaporan = new List<LaporanPenjualan>();
        public FormLaporanPenjualan()
        {
            InitializeComponent();
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            dgvReport.Rows.Clear();
            dgvReport.Refresh();
            string selected_date = laporan_dtp.Value.ToString("dd/MM/yyyy");
            for(int i = 0; i < dataStok.Count(); i = i + 1)
            {
                for(int j = 0; j < dataLaporan.Count(); j = j + 1)
                {
                    if(dataStok[i].Item == dataLaporan[j].Item && dataLaporan[j].Tanggal == selected_date )
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgvReport);
                        row.Cells[0].Value = dataStok[i].Item;
                        row.Cells[1].Value = dataLaporan[j].Quantity;
                        row.Cells[2].Value = dataLaporan[j].Price / dataLaporan[j].Quantity;
                        row.Cells[3].Value = dataLaporan[j].Price;

                        dgvReport.Rows.Add(row);
                    }
                }
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            Stok a = new Stok();
            dataStok = a.loadStock();
            LaporanPenjualan b = new LaporanPenjualan();
            dataLaporan = b.loadHistory();
        }
    }
}
