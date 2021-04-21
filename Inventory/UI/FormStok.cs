using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace Inventory
{
    public partial class FormStok : Form
    {
        Boolean updateInitiated = false;
        Int32 cellIdx = 0;
        List<Stok> dataStok = new List<Stok>();

        void updateDgv(List<Stok> dataStok)
        {
            for (int i=0; i < dataStok.Count(); i = i + 1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvBarang);
                row.Cells[0].Value = dataStok[i].Item;
                row.Cells[1].Value = dataStok[i].Quantity;
                row.Cells[2].Value = dataStok[i].Price;
                dgvBarang.Rows.Add(row);
            }
        }
        public FormStok()
        {
            InitializeComponent();
        }

        private bool checkItem(List<Stok> dataStok, String item)
        {
            /* true = item already exist in dataStok
             * false = item does not exist in dataStok
             */
            bool result = false;
            for(int i = 0; i < dataStok.Count(); i = i + 1)
            {
                if(dataStok[i].Item == item)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (updateInitiated)
            {
                MessageBox.Show("Please Clicked Reset Button to Add New Item", "Information");
            }
            else if (itemTxt.Text == "" || qttyTxt.Text == "" || priceTxt.Text == "")
            {
                MessageBox.Show("Please Fill all the Blank Column", "Information");
            }
            else
            {
                try
                {
                    Int32 harga = Int32.Parse(qttyTxt.Text.Trim());
                    Int32 kuantitas = Int32.Parse(priceTxt.Text.Trim());
                    DialogResult dr = MessageBox.Show("Do You Want to Add New Item?", "Add Item", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes && checkItem(dataStok, itemTxt.Text.Trim())==false)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgvBarang);
                        row.Cells[0].Value = itemTxt.Text.Trim();
                        row.Cells[1].Value = qttyTxt.Text.Trim();
                        row.Cells[2].Value = priceTxt.Text.Trim();

                        dgvBarang.Rows.Add(row);
                        MessageBox.Show("New Item Successfully Added!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Stok temp = new Stok();
                        temp.Item = itemTxt.Text.Trim();
                        temp.Price = Int32.Parse(priceTxt.Text.Trim());
                        temp.Quantity = Int32.Parse(qttyTxt.Text.Trim());
                        dataStok.Add(temp);
                        temp.updateStock(dataStok);

                        itemTxt.Clear();
                        qttyTxt.Clear();
                        priceTxt.Clear();
                        itemTxt.Focus();
                    }
                    else if (checkItem(dataStok, itemTxt.Text.Trim()))
                    {
                        MessageBox.Show("Add New Item Aborted Because Item Already Existed!!", "Information");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, Please Input Number in Price Column!!", "Information");
                    itemTxt.Clear();
                    qttyTxt.Clear();
                    priceTxt.Clear();
                    itemTxt.Focus();
                };
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (updateInitiated)
            {
                try
                {
                    Int32 harga = Int32.Parse(qttyTxt.Text.Trim());
                    Int32 kuantitas = Int32.Parse(priceTxt.Text.Trim());
                    DialogResult dr = MessageBox.Show("Do You Want to Update Item?", "Update Item", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        String updateItem = dgvBarang.Rows[cellIdx].Cells[0].Value.ToString();
                        for (int i = 0; i < dataStok.Count(); i = i + 1)
                        {
                            if(dataStok[i].Item == updateItem)
                            {
                                dataStok[i].Item = itemTxt.Text.Trim();
                                dataStok[i].Price = Int32.Parse(priceTxt.Text.Trim());
                                dataStok[i].Quantity = Int32.Parse(qttyTxt.Text.Trim());
                                break;
                            }
                        }
                        dataStok[0].updateStock(dataStok);

                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgvBarang);
                        row.Cells[0].Value = itemTxt.Text.Trim();
                        row.Cells[1].Value = qttyTxt.Text.Trim();
                        row.Cells[2].Value = priceTxt.Text.Trim();

                        dgvBarang.Rows.RemoveAt(cellIdx);
                        dgvBarang.Rows.Insert(cellIdx, row);
                        MessageBox.Show("Item Successfully Updated!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        itemTxt.Clear();
                        qttyTxt.Clear();
                        priceTxt.Clear();
                        itemTxt.Focus();

                        updateInitiated = false;
                        cellIdx = 0;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, Please Input Number in Price Column!!", "Information");
                    itemTxt.Clear();
                    qttyTxt.Clear();
                    priceTxt.Clear();
                    itemTxt.Focus();
                };
            }
            else
            {
                MessageBox.Show("Please Clicked a Cell to Update", "Information");
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            updateInitiated = false;
            cellIdx = 0;
            itemTxt.Clear();
            qttyTxt.Clear();
            priceTxt.Clear();
            itemTxt.Focus();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (updateInitiated)
            {
                String updateItem = dgvBarang.Rows[cellIdx].Cells[0].Value.ToString();
                for (int i = 0; i < dataStok.Count(); i = i + 1)
                {
                    if (dataStok[i].Item == updateItem)
                    {
                        dataStok.RemoveAt(i);
                        break;
                    }
                }
                if(dataStok.Count() == 0)
                {
                    Stok a = new Stok();
                    a.deleteStock();
                }
                else
                {
                    dataStok[0].updateStock(dataStok);
                }
                

                dgvBarang.Rows.RemoveAt(cellIdx);
                itemTxt.Clear();
                qttyTxt.Clear();
                priceTxt.Clear();
                itemTxt.Focus();
                updateInitiated = false;
            }
            else
            {
                MessageBox.Show("Please Clicked a Cell to Delete", "Information");
            }
        }

        private void dgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cellIdx = e.RowIndex;
                DataGridViewRow row = this.dgvBarang.Rows[e.RowIndex];
                itemTxt.Text = row.Cells[0].Value.ToString();
                qttyTxt.Text = row.Cells[1].Value.ToString();
                priceTxt.Text = row.Cells[2].Value.ToString();
                updateInitiated = true;

            }
            catch (Exception ex) { };
        }

        private void FormStok_Load(object sender, EventArgs e)
        {
            Stok a = new Stok();
            dataStok = a.loadStock();
            updateDgv(dataStok);

        }
    }
}
