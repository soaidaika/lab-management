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
    public partial class ViewParticipantForm : Form
    {
        SQLConfig config = new SQLConfig();
        private bool mouseDown;
        private Point lastLocation;
        string cur = String.Empty;

        public ViewParticipantForm(string current)
        {
            InitializeComponent();
            cur = current;
        }
        private void load_current_selected_participant()
        {
            config.GetSingleResult("exec sp_ShowScientificInfo '" + cur + "'");
            if (config.dt.Rows.Count > 0)
            {
                config.GetImage("select ProfilePic from Scientist where ID = '" + cur + "' ", cur, profilepicBox, "ProfilePic");

                sctidLabel.Text = config.dt.Rows[0].Field<string>("ID");
                fnameLabel.Text = config.dt.Rows[0].Field<string>("Name");
                sctposLabel.Text = config.dt.Rows[0].Field<string>("Position");
                sctdepLabel.Text = config.dt.Rows[0].Field<string>("Department");
                genderLabel.Text = config.dt.Rows[0].Field<string>("Gender");
                nationalityLabel.Text = config.dt.Rows[0].Field<string>("Nationality");
                phoneLabel.Text = config.dt.Rows[0].Field<string>("Phone");
                emailLabel.Text = config.dt.Rows[0].Field<string>("Email");
            }
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewParticipantForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                           this.DisplayRectangle);
        }

        private void ViewParticipantForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ViewParticipantForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ViewParticipantForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ViewParticipantForm_Load(object sender, EventArgs e)
        {
            load_current_selected_participant();
        }
    }
}
