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
    public partial class FormUser : Form
    {
        Boolean updateInitiated = false;
        Int32 cellIdx = 0;
        List<User> dataUser = new List<User>();
        public FormUser()
        {
            InitializeComponent();
        }
        private bool checkUser(List<User> dataUser, String username)
        {
            /* true = username already exist in dataUser
             * false = username does not exist in dataUser
             */
            bool result = false;
            for (int i = 0; i < dataUser.Count(); i = i + 1)
            {
                if (dataUser[i].UserName == username)
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
                MessageBox.Show("Please Clicked Reset Button to Save New Data", "Information");
            }
            else if (usernameTxt.Text == "" || passwordTxt.Text == "" || authorityTxt.Text == "")
            {
                MessageBox.Show("Please Fill all the Blank Column", "Information");
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Do You Want to Save Data?", "Save Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes )
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgvUser);
                        row.Cells[0].Value = usernameTxt.Text.Trim();
                        row.Cells[1].Value = passwordTxt.Text.Trim();
                        row.Cells[2].Value = authorityTxt.Text.Trim();

                        dgvUser.Rows.Add(row);
                        MessageBox.Show("Data Successfully Saved!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        User temp = new User();
                        temp.UserName = usernameTxt.Text.Trim();
                        temp.Password = passwordTxt.Text.Trim();
                        temp.Authority = authorityTxt.Text.Trim();
                        dataUser.Add(temp);
                        temp.updateUser(dataUser);

                        usernameTxt.Clear();
                        passwordTxt.Clear();
                        authorityTxt.Text = "";
                        usernameTxt.Focus();
                    }
                    else if (checkUser(dataUser, usernameTxt.Text.Trim()))
                    {
                        MessageBox.Show("Username Already Existed!!", "Information");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, Please Input Number in Price Column!!", "Information");
                    usernameTxt.Clear();
                    passwordTxt.Clear();
                    authorityTxt.Text = "";
                    usernameTxt.Focus();
                };
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                updateInitiated = true;
                cellIdx = e.RowIndex;
                DataGridViewRow row = this.dgvUser.Rows[e.RowIndex];
                usernameTxt.Text = row.Cells[0].Value.ToString();
                passwordTxt.Text = row.Cells[1].Value.ToString();
                authorityTxt.Text = row.Cells[2].Value.ToString();

            }
            catch (Exception ex) { };
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            updateInitiated = false;
            cellIdx = 0;
            usernameTxt.Clear();
            passwordTxt.Clear();
            authorityTxt.Text = "";
            usernameTxt.Focus();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (updateInitiated)
            {
                String updateUsername = dgvUser.Rows[cellIdx].Cells[0].Value.ToString();
                for (int i = 0; i < dataUser.Count(); i = i + 1)
                {
                    if (dataUser[i].UserName == updateUsername)
                    {
                        dataUser.RemoveAt(i);
                        break;
                    }
                }
                dataUser[0].updateUser(dataUser);

                dgvUser.Rows.RemoveAt(cellIdx);
                usernameTxt.Clear();
                passwordTxt.Clear();
                authorityTxt.Text = "";
                usernameTxt.Focus();
                updateInitiated = false;
            }
            else
            {
                MessageBox.Show("Please Clicked a Cell to Delete", "Information");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (updateInitiated)
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Do You Want to Update Data?", "Update Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        String updateUsername = dgvUser.Rows[cellIdx].Cells[0].Value.ToString();
                        for (int i = 0; i < dataUser.Count(); i = i + 1)
                        {
                            if (dataUser[i].UserName == updateUsername)
                            {
                                dataUser[i].UserName = usernameTxt.Text.Trim();
                                dataUser[i].Password = passwordTxt.Text.Trim();
                                dataUser[i].Authority = authorityTxt.Text.Trim();
                                break;
                            }
                        }
                        dataUser[0].updateUser(dataUser);

                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgvUser);
                        row.Cells[0].Value = usernameTxt.Text.Trim();
                        row.Cells[1].Value = passwordTxt.Text.Trim();
                        row.Cells[2].Value = authorityTxt.Text.Trim();

                        dgvUser.Rows.RemoveAt(cellIdx);
                        dgvUser.Rows.Insert(cellIdx, row);
                        MessageBox.Show("Data Successfully Updated!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usernameTxt.Clear();
                        passwordTxt.Clear();
                        authorityTxt.Text = "";
                        usernameTxt.Focus();

                        updateInitiated = false;
                        cellIdx = 0;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, Please Input Number in Price Column!!", "Information");
                    usernameTxt.Clear();
                    passwordTxt.Clear();
                    authorityTxt.Text = "";
                    usernameTxt.Focus();
                };
            }
            else
            {
                MessageBox.Show("Please Clicked a Cell to Update", "Information");
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            User a = new User();
            dataUser = a.loadUser();
            for (int i = 0; i < dataUser.Count(); i = i + 1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvUser);
                row.Cells[0].Value = dataUser[i].UserName;
                row.Cells[1].Value = dataUser[i].Password;
                row.Cells[2].Value = dataUser[i].Authority;
                dgvUser.Rows.Add(row);
            }
        }
    }
}
