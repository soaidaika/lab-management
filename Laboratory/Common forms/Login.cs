using Laboratory.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class Login : Form
    {
        string query;
        SQLConfig config = new SQLConfig();
        
        public Login()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void login()
        {
            string username = usnTxtBox.Text;
            string password = passTxtBox.Text;
            query = "select * from LoginInfo where Username = N'" + username + "' and Password = N'" + password + "' ";

            config.GetSingleResult(query);
            config.GetRole(query);

            if (config.dt.Rows.Count > 0)
            {
                if (config.role == "manager")
                {
                    MainPage_Manager a = new MainPage_Manager(usnTxtBox.Text);
                    this.Hide();
                    a.ShowDialog();
                    this.Show();
                }
                else if (config.role == "scientist")
                {
                    MainPage_Scientist b = new MainPage_Scientist(usnTxtBox.Text);
                    this.Hide();
                    b.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3), this.DisplayRectangle);
        }

        private void usnTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void passTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
