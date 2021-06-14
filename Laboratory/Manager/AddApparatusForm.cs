using Laboratory.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class AddApparatusForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        SQLConfig config = new SQLConfig();
        string hex = String.Empty;

        public AddApparatusForm()
        {
            InitializeComponent();
        }

        private void AddApparatusForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                            this.DisplayRectangle);
        }

        private void AddApparatusForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AddApparatusForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AddApparatusForm_MouseMove(object sender, MouseEventArgs e)
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

        private void addaprtpicBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "";
                dlg.Title = "Choose one image";
                dlg.Multiselect = false;

                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                string sep = string.Empty;

                foreach (var c in codecs)
                {
                    string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                    dlg.Filter = String.Format("{0}{1}{2} ({3})|{3}", dlg.Filter, sep, codecName, c.FilenameExtension);
                    sep = "|";
                }

                dlg.Filter = String.Format("{0}{1}{2} ({3})|{3}", dlg.Filter, sep, "All Files", "*.*");

                dlg.DefaultExt = ".png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Read the bytes from the chosen image
                    byte[] image_bytes = File.ReadAllBytes(dlg.FileName);

                    // Convert it into hexadecimal string
                    hex = BitConverter.ToString(image_bytes).Replace("-", String.Empty);

                    // Show image in the picture box
                    aprtpicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    MemoryStream ms = new MemoryStream(image_bytes);
                    aprtpicBox.Image = new Bitmap(ms);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            config.Execute_CUD("exec sp_AddApparatus '" + aprtnameTextbox.Text + "', '" + aprtdescriptTextbox.Text + "', '" + quantityTextbox.Text + "', '0x" + hex + " ' ", "Failed to add apparatus.", "Successfully added apparatus.");
            Close();
        }
    }
}
