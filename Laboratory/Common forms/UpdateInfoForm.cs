using Laboratory.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class UpdateInfoForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        SQLConfig config = new SQLConfig();
        private string query = String.Empty;
        private string scientist_id = String.Empty;
        public UpdateInfoForm(string id, string card, string address, string phone, string email)
        {
            InitializeComponent();

            scientist_id = id;
            cardTextbox.Text = card;
            addressTextbox.Text = address;
            phoneTextbox.Text = phone;
            emailTextbox.Text = email;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void UpdateInfoForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                            this.DisplayRectangle);
        }

        private void UpdateInfoForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void UpdateInfoForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void UpdateInfoForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            query = "exec sp_UpdateYourInfo '" + scientist_id + "', '" + cardTextbox.Text + "', '" + addressTextbox.Text + "', '" + phoneTextbox.Text + "', '" + emailTextbox.Text + "' ";
            config.Execute_CUD(query, "No data saved.", "Data has been saved in the database.");
            Close();
        }
    }
}
