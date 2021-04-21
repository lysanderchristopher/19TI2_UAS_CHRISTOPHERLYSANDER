using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Inventory
{
    class LaporanPembelian
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/Database.accdb;Persist Security Info=False;";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public List<LaporanPembelian> loadHistory()
        {
            List<LaporanPembelian> dataLaporan = new List<LaporanPembelian>();
            try
            {
                String sql = "SELECT * FROM HistoryPembelian";
                cmd = new OleDbCommand(sql, dbConn);

                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    LaporanPembelian obj = new LaporanPembelian();
                    obj.Item = row[1].ToString();
                    obj.Tanggal = row[2].ToString();
                    obj.Quantity = Int32.Parse(row[3].ToString());
                    obj.Price = Int32.Parse(row[4].ToString());
                    dataLaporan.Add(obj);
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
            return dataLaporan;
        }

        public void updateHistory(List<LaporanPembelian> dataLaporan)
        {
            //delete old data on Access
            dbConn.Open();
            OleDbCommand tempCmd = new OleDbCommand("DELETE FROM HistoryPembelian", dbConn);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.DeleteCommand = tempCmd;

            foreach (DataRow row in dt.Rows)
            {
                row.Delete();
            }
            tempCmd.ExecuteNonQuery();
            dbConn.Close();

            //re-input new data into Access
            for (int i = 0; i < dataLaporan.Count(); i = i + 1)
            {
                String Item = dataLaporan[i].Item;
                String Tanggal = dataLaporan[i].Tanggal;
                String Price = dataLaporan[i].Price.ToString();
                String Quantity = dataLaporan[i].Quantity.ToString();

                OleDbCommand cmd = new OleDbCommand("INSERT INTO HistoryPembelian (Item, [Purchased Date], [Quantity], [Price]) Values(@Item, @Tanggal, @Quantity, @Price)");
                cmd.Connection = dbConn;

                dbConn.Open();

                if (dbConn.State == ConnectionState.Open)
                {
                    cmd.Parameters.Add("@Item", OleDbType.VarChar).Value = Item;
                    cmd.Parameters.Add("@Tanggal", OleDbType.VarChar).Value = Tanggal;
                    cmd.Parameters.Add("@Quantity", OleDbType.VarChar).Value = Quantity;
                    cmd.Parameters.Add("@Price", OleDbType.VarChar).Value = Price;

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

        String item,tanggal;
        int price, quantity;

        public string Item { get => item; set => item = value; }

        public string Tanggal { get => tanggal; set => tanggal = value; }

        public int Price { get => price; set => price = value; }

        public int Quantity { get => quantity; set => quantity = value; }
    }
}
