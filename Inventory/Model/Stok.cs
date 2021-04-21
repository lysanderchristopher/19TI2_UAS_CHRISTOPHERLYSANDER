using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Inventory
{
    class Stok
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/Database.accdb;Persist Security Info=False;";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public List<Stok> loadStock()
        {
            List<Stok> dataStok = new List<Stok>();
            try
            {
                String sql = "SELECT * FROM Stock";
                cmd = new OleDbCommand(sql, dbConn);

                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Stok obj = new Stok();
                    obj.Item = row[1].ToString();
                    obj.Price = Int32.Parse(row[2].ToString());
                    obj.Quantity = Int32.Parse(row[3].ToString());
                    dataStok.Add(obj);
                }
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
            return dataStok;
        }

        public void deleteStock()
        {
            //delete old data on Access
            dbConn.Open();
            OleDbCommand tempCmd = new OleDbCommand("DELETE FROM Stock", dbConn);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.DeleteCommand = tempCmd;

            foreach (DataRow row in dt.Rows)
            {
                row.Delete();
            }
            tempCmd.ExecuteNonQuery();
            dbConn.Close();
        }

        public void updateStock(List<Stok> dataStok)
        {
            //delete old data on Access
            dbConn.Open();
            OleDbCommand tempCmd = new OleDbCommand("DELETE FROM Stock", dbConn);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.DeleteCommand = tempCmd;

            foreach (DataRow row in dt.Rows)
            {
                row.Delete();
            }
            tempCmd.ExecuteNonQuery();
            dbConn.Close();

            //re-input new data into Access
            for (int i = 0; i < dataStok.Count(); i = i + 1)
            {
                String Item = dataStok[i].Item;
                String Price = dataStok[i].Price.ToString();
                String Quantity = dataStok[i].Quantity.ToString();

                OleDbCommand cmd = new OleDbCommand("INSERT INTO Stock (Item, Price, Quantity) Values(@Item, @Price, @Quantity)");
                cmd.Connection = dbConn;

                dbConn.Open();

                if (dbConn.State == ConnectionState.Open)
                {
                    cmd.Parameters.Add("@Item", OleDbType.VarChar).Value = Item;
                    cmd.Parameters.Add("@Price", OleDbType.VarChar).Value = Price;
                    cmd.Parameters.Add("@Quantity", OleDbType.VarChar).Value = Quantity;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        dbConn.Close();
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.Source);
                        dbConn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Connection Failed");
                }
            }
        }

        String item;
        int price, quantity;

        public string Item { get => item; set => item = value; }

        public int Price { get => price; set => price = value; }

        public int Quantity { get => quantity; set => quantity = value; }

    }
}
