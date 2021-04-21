using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Inventory
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        List<User> dataUser = new List<User>();
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataUser.Count(); i = i + 1)
            {
                if (user_tb.Text == dataUser[i].UserName && pass_tb.Text == dataUser[i].Password)
                {
                    MessageBox.Show("Login Successful");
                    FormMenu fm = new FormMenu();
                    fm.user(i);
                    fm.Show();
                    this.Hide();
                    break;
                }
                else if (i == dataUser.Count() - 1)
                {
                    MessageBox.Show("Login Failed");
                    user_tb.Clear();
                    pass_tb.Clear();
                    user_tb.Focus();
                    break;
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            User a = new User();
            dataUser = a.loadUser();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
