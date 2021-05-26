using Laboratory.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class MainPage_Scientist : Form
    {
        SQLConfig config = new SQLConfig();
        string query = String.Empty;
        string username = String.Empty;
        string id = String.Empty;
        string curr_exp_id = String.Empty;

        public MainPage_Scientist(string usrname)
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            config.GetServerName();
            username = usrname;
        }
        private void scientist_record()
        {
            /* 
             * All is good now
             */

            // Retrieve scientist's ID
            config.GetSingleResult("select ID from Scientist s, LoginInfo where s.ID = LoginInfo.ScientistID and LoginInfo.Username = '" + username + "' ");
            id = config.dt.Rows[0].Field<string>("ID");

            // Get profile picture
            config.GetImage("select ProfilePic from Scientist where ID = '" + id + "' ", id, profilepicBox, "ProfilePic");

            // Scientist information
            config.GetSingleResult("exec sp_ShowScientificInfo '" + id + "' ");
            sctidLabel.Text = config.dt.Rows[0].Field<string>("ID");
            fnameLabel.Text = config.dt.Rows[0].Field<string>("Name");
            fnameLabel2.Text = config.dt.Rows[0].Field<string>("Name");
            sctposLabel.Text = config.dt.Rows[0].Field<string>("Position");
            sctdepLabel.Text = config.dt.Rows[0].Field<string>("Department");
            dobLabel.Text = config.dt.Rows[0].Field<DateTime>("DoB").ToString("dd/MM/yyyy");
            genderLabel.Text = config.dt.Rows[0].Field<string>("Gender");
            nationalityLabel.Text = config.dt.Rows[0].Field<string>("Nationality");
            cardLabel.Text = config.dt.Rows[0].Field<long>("CreditCard").ToString();
            addressLabel.Text = config.dt.Rows[0].Field<string>("Address");
            phoneLabel.Text = config.dt.Rows[0].Field<string>("Phone");
            emailLabel.Text = config.dt.Rows[0].Field<string>("Email");

            // Login information
            config.GetSingleResult("exec sp_ShowLoginInfo '" + id + "' ");
            usnLabel.Text = config.dt.Rows[0].Field<string>("Username");
            passLabel.Text = config.dt.Rows[0].Field<string>("Password");
            roleLabel.Text = config.dt.Rows[0].Field<string>("Role");
        }
        private void load_scientist_project()
        {
            query = "select a.ID from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ShowExpWorkingOn " + id + "') as a";
            config.Load_DTG(query, expidGridview);
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.LightSeaGreen);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Segoe UI", 10.0f, FontStyle.Bold, GraphicsUnit.Point);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void updateinfoBtn_Click(object sender, EventArgs e)
        {
            UpdateInfoForm form = new UpdateInfoForm(sctidLabel.Text, cardLabel.Text, addressLabel.Text, phoneLabel.Text, emailLabel.Text);
            form.FormClosed += new FormClosedEventHandler(MainPage_Scientist_Load);
            form.ShowDialog();
        }

        private void changepassBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(sctidLabel.Text);
            form.FormClosed += new FormClosedEventHandler(MainPage_Scientist_Load);
            form.ShowDialog();
        }

        private void viewreportLabel_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm(expidLabel.Text, sctidLabel.Text);
            form.ShowDialog();
        }

        private void depLabel_Click(object sender, EventArgs e)
        {
            DepartmentForm form = new DepartmentForm();
            form.ShowDialog();
        }

        private void scientistLabel_Click(object sender, EventArgs e)
        {
            ScientistsForm form = new ScientistsForm();
            form.ShowDialog();
        }

        private void apparatusLabel_Click(object sender, EventArgs e)
        {
            ApparatusForm form = new ApparatusForm();
            form.ShowDialog();
        }

        private void MainPage_Scientist_Load(object sender, EventArgs e)
        {
            scientist_record();
            load_scientist_project();
        }

        private void expidGridview_Click(object sender, EventArgs e)
        {
            //Get ID of chosen experiment
            curr_exp_id = expidGridview.CurrentRow.Cells[0].Value.ToString();

            query = "select a.* from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ShowExpWorkingOn " + id + "') as a where a.ID = '" + curr_exp_id + "' ";
            config.GetSingleResult(query);
            if (config.dt.Rows.Count > 0)
            {
                expidLabel.Text = config.dt.Rows[0].Field<string>("ID");
                descriptTextbox.Text = config.dt.Rows[0].Field<string>("Description");
                startdateLabel.Text = config.dt.Rows[0].Field<DateTime>("StartDate").ToString("dd/MM/yyyy");
                enddateLabel.Text = config.dt.Rows[0].Field<DateTime>("EndDate").ToString("dd/MM/yyyy");
                leadernameLabel.Text = config.dt.Rows[0].Field<string>("Leader");
                statusLabel.Text = config.dt.Rows[0].Field<string>("Status");
                label45.Text = config.dt.Rows[0].Field<int>("Participants").ToString();

                config.Load_DTG("exec sp_ShowParticipants '" + curr_exp_id + "' ", participantGridview);
                participantGridview.Columns[0].Visible = false;
            }
        }

        private void participantGridview_DoubleClick(object sender, EventArgs e)
        {
            string current = participantGridview.CurrentRow.Cells["ID"].Value.ToString();
            ViewParticipantForm form = new ViewParticipantForm(current);
            form.ShowDialog();
        }

        private void changepicBtn_Click(object sender, EventArgs e)
        {
            /*
             * Basically, it's just a normal open a file dialog, choose an image you want to change to profile picture
             */

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
                    /*
                     * It is a circus down here
                     */

                    // Read the bytes from the chosen image
                    byte[] image_bytes = File.ReadAllBytes(dlg.FileName);

                    // Convert it into hexadecimal string
                    string hex = BitConverter.ToString(image_bytes).Replace("-", String.Empty);

                    // Execute the stored procedure to update it in the database
                    config.Execute_Query("exec sp_ChangeProfilePic " + id + ", '0x" + hex + "' ");

                    // And show the new profile image
                    config.GetImage("select ProfilePic from Scientist where ID = '" + id + "' ", id, profilepicBox, "ProfilePic");
                }
            }
        }

    }
}
