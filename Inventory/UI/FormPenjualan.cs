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
    public partial class FormPenjualan : Form
    {
        List<Stok> dataStok = new List<Stok>();
        List<LaporanPenjualan> dataLaporan = new List<LaporanPenjualan>();
        DateTime Date = DateTime.Now;

        public FormPenjualan()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
        {
            qtty_txt.Enabled = false;
            LaporanPenjualan a = new LaporanPenjualan();
            Stok b = new Stok();
            dataLaporan = a.loadHistory();
            dataStok = b.loadStock();

            for (int i = 0; i < dataStok.Count(); i = i + 1)
            {
                item_cb.Items.Add(dataStok[i].Item);
            }
            dgvJual.Rows.Clear();
            dgvJual.Refresh();
            for (int i = 0; i < dataLaporan.Count(); i = i + 1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvJual);
                row.Cells[0].Value = dataLaporan[i].Item;
                row.Cells[1].Value = dataLaporan[i].Tanggal;
                row.Cells[2].Value = dataLaporan[i].Quantity;
                row.Cells[3].Value = dataLaporan[i].Price;

                dgvJual.Rows.Add(row);
            }
        }

        public bool checkValue()
        {
            bool result = false;
            if (item_cb.Text == "")
            {
                MessageBox.Show("Please Select an Item!!", "Information");
                result = false;
            }
            else
            {
                try
                {
                    int temp = Int32.Parse(qtty_txt.Text);
                    result = true;
                } catch (Exception ex)
                {
                    result = false;
                }
            }
            return result;
        }

        private void sell_btn_Click(object sender, EventArgs e)
        {
            bool valueIsValid = checkValue();
            bool ableToSell = false;
            int itm_stok_index = 0;
            if (valueIsValid == true)
            {
                for (int i = 0; i < dataStok.Count(); i = i + 1)
                {
                    if (item_cb.Text == dataStok[i].Item)
                    {
                        int stok = dataStok[i].Quantity;
                        int sell = Int32.Parse(qtty_txt.Text);
                        if (stok - sell < 0)
                        {
                            ableToSell = false;
                            MessageBox.Show("Not Enough Stock to Sell!!", "Information");
                            break;
                        }
                        else
                        {
                            ableToSell = true;
                            break;
                        }
                    }
                    else if(i == dataStok.Count() - 1)
                    {
                        ableToSell = false;
                        MessageBox.Show("Please Select Correct Item Name!!", "Information");
                    }
                }
            }
            if (ableToSell == false && item_cb.Text == "" || qtty_txt.Text == "" || price_txt.Text == "")
            {
                MessageBox.Show("Please Fill all the Blank Column", "Information");
            }
            else if(ableToSell == true)
            {
                try
                {
                    Int32 harga = Int32.Parse(price_txt.Text.Trim());
                    Int32 kuantitas = Int32.Parse(qtty_txt.Text.Trim());
                    DialogResult dr = MessageBox.Show("Do you want to sell?", "Sell", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgvJual);
                        row.Cells[0].Value = item_cb.Text.Trim();
                        row.Cells[1].Value = Date.ToString("dd/MM/yyyy");
                        row.Cells[2].Value = qtty_txt.Text.Trim();
                        row.Cells[3].Value = price_txt.Text.Trim();

                        dgvJual.Rows.Add(row);

                        dataStok[itm_stok_index].Quantity = dataStok[itm_stok_index].Quantity - kuantitas;
                        dataStok[itm_stok_index].updateStock(dataStok);

                        LaporanPenjualan temp = new LaporanPenjualan();
                        temp.Item = item_cb.Text.Trim();
                        temp.Tanggal = Date.ToString("dd/MM/yyyy");
                        temp.Quantity = kuantitas;
                        temp.Price = Int32.Parse(price_txt.Text.Trim());
                        dataLaporan.Add(temp);
                        dataLaporan[0].updateHistory(dataLaporan);

                        price_txt.Clear();
                        qtty_txt.Clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Input Number in Price Column!!", "Information");
                    price_txt.Clear();
                    qtty_txt.Clear();
                };
            }
        }

        private void qtty_txt_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (qtty_txt.Text=="")
            {
                price_txt.Text = "0";
            }
            else
            {
                try
                {
                    int kuantitas = Int32.Parse(qtty_txt.Text);
                    for (int i = 0; i < dataStok.Count(); i = i + 1)
                    {
                        if (item_cb.Text == dataStok[i].Item)
                        {
                            int harga = dataStok[i].Price;
                            result = kuantitas * harga;
                            break;
                        }
                    }
                    price_txt.Text = result.ToString();
                }catch(Exception ex)
                {
                    price_txt.Text = "0";
                }
            }
            
        }

        private void item_cb_TextChanged(object sender, EventArgs e)
        {
            qtty_txt.Enabled = true;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            item_cb.Text = "";
            qtty_txt.Clear();
            qtty_txt.Enabled = false;
            price_txt.Clear();
            price_txt.Enabled = false;

        }
    } 
}
