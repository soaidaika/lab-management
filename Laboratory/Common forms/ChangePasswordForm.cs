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
    public partial class ChangePasswordForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        SQLConfig config = new SQLConfig();
        private string query = String.Empty;
        private string scientist_id = String.Empty;

        public ChangePasswordForm(string id)
        {
            InitializeComponent();

            scientist_id = id;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangePasswordForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ChangePasswordForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ChangePasswordForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ChangePasswordForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                            this.DisplayRectangle);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            query = "exec sp_ChangePassword '" + scientist_id + "', '" + oldpassTextbox.Text + "', '" + newpassTextbox.Text + "', '" + confirmpassTextbox.Text + "' ";
            config.Execute_CUD(query, "No data saved.", "Data has been saved in the database.");
            Close();
        }

        private void ChangePasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            config.Execute_Query("drop table temp");
        }
    }
}
