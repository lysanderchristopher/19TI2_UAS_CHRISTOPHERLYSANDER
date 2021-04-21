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
    class User
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/Database.accdb;Persist Security Info=False;";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public List<User> loadUser()
        {
            List<User> dataUser = new List<User>();
            try
            {
                String sql = "SELECT * FROM UserData";
                cmd = new OleDbCommand(sql, dbConn);

                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    User obj = new User();
                    obj.UserName = row[1].ToString();
                    obj.Password = row[2].ToString();
                    obj.Authority = row[3].ToString();
                    dataUser.Add(obj);
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
            return dataUser;
        }

        public void updateUser(List<User> dataUser)
        {
            //delete old data on Access
            dbConn.Open();
            OleDbCommand tempCmd = new OleDbCommand("DELETE FROM UserData", dbConn);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.DeleteCommand = tempCmd;

            foreach (DataRow row in dt.Rows)
            {
                row.Delete();
            }
            tempCmd.ExecuteNonQuery();
            dbConn.Close();

            //re-input new data into Access

            for (int i = 0; i < dataUser.Count; i = i + 1)
            {
                String Username = dataUser[i].UserName;
                String Password = dataUser[i].Password;
                String Authority = dataUser[i].Authority;

                OleDbCommand cmd = new OleDbCommand("INSERT INTO UserData (Username, [Password], Authority) Values(@Username, @Password, @Authority)");
                cmd.Connection = dbConn;

                dbConn.Open();

                if (dbConn.State == ConnectionState.Open)
                {
                    cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = Username;
                    cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = Password;
                    cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = Authority;

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

        String userName, password, authority;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string Password { get => password; set => password = value; }
        public string Authority { get => authority; set => authority = value; }
    }
}
