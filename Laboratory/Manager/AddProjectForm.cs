using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class AddProjectForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public AddProjectForm()
        {
            InitializeComponent();
        }

        private void AddProjectForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                            this.DisplayRectangle);
        }

        private void AddProjectForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AddProjectForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AddProjectForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
