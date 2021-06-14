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
    public partial class MainPage_Manager : Form
    {
        SQLConfig config = new SQLConfig();
        string query = String.Empty;
        string username = String.Empty;
        string id = String.Empty;
        string curr_scientist_id = String.Empty;
        string curr_appar_id = String.Empty;
        string curr_proj_id = String.Empty;

        public MainPage_Manager(string usrname)
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            config.GetServerName();
            username = usrname;
        }

        private void manager_record()
        {
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
        private void list_all_scientists(string q)
        {
            config.Load_DTG(q, scientistGridview);
            int maxcol = scientistGridview.Columns.Count - 1;
            scientistGridview.Columns[maxcol].Visible = false;
            // This is straight up stupid
            scientistGridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            scientistGridview.RowTemplate.Height = 50;
            scientistGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void list_all_apparatuses(string q)
        {
            config.Load_DTG(q, apparatusGridview);
            int maxcol = apparatusGridview.Columns.Count - 1;
            apparatusGridview.Columns[maxcol].Visible = false;
            // This is straight up stupid
            apparatusGridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            apparatusGridview.RowTemplate.Height = 50;
            apparatusGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void list_all_projects(string q)
        {
            config.Load_DTG(q, projectsGridview);
            int maxcol = projectsGridview.Columns.Count - 1;
            projectsGridview.Columns[maxcol].Visible = false;
            // This is straight up stupid
            projectsGridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            projectsGridview.RowTemplate.Height = 50;
            projectsGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
            form.FormClosed += new FormClosedEventHandler(MainPage_Manager_Load);
            form.ShowDialog();
        }

        private void changepassBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(sctidLabel.Text);
            form.FormClosed += new FormClosedEventHandler(MainPage_Manager_Load);
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

        private void addsctBtn_Click(object sender, EventArgs e)
        {
            AddScientistForm form = new AddScientistForm();
            form.FormClosed += new FormClosedEventHandler(MainPage_Manager_Load);
            form.ShowDialog();
        }

        private void removesctBtn_Click(object sender, EventArgs e)
        {
            curr_scientist_id = scientistGridview.CurrentRow.Cells["ID"].Value.ToString();
            config.Execute_CUD("exec sp_RemoveScientist '" + curr_scientist_id + "' ", "Cannot delete the selected scientist", "Scientist is deleted");
            pictureBox1.Image = null;
            list_all_scientists("exec sp_ListOfScientist");
        }

        private void addaprtBtn_Click(object sender, EventArgs e)
        {
            AddApparatusForm form = new AddApparatusForm();
            form.FormClosed += new FormClosedEventHandler(MainPage_Manager_Load);
            form.ShowDialog();
        }

        private void removeaprtBtn_Click(object sender, EventArgs e)
        {
            curr_appar_id = apparatusGridview.CurrentRow.Cells["ID"].Value.ToString();
            config.Execute_CUD("exec sp_RemoveApparatus '" + curr_appar_id + "' ", "Cannot delete the selected apparatus", "Apparatus is deleted");
            pictureBox2.Image = null;
            list_all_apparatuses("exec sp_ListOfApparatus");
        }

        private void addprjBtn_Click(object sender, EventArgs e)
        {
            AddProjectForm form = new AddProjectForm();
            form.ShowDialog();
        }

        private void MainPage_Manager_Load(object sender, EventArgs e)
        {
            manager_record();
            list_all_scientists("exec sp_ListOfScientist");
            list_all_projects("exec sp_ListOfProject");
            list_all_apparatuses("exec sp_ListOfApparatus");
        }

        private void searchsctTextbox_TextChanged(object sender, EventArgs e)
        {
            query = "select a.* from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ListOfScientist') as a where a.Name like '" + searchsctTextbox.Text + "%' ";
            list_all_scientists(query);
        }

        private void searchaprtTextbox_TextChanged(object sender, EventArgs e)
        {
            query = "select a.* from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ListOfApparatus') as a where a.Name like '" + searchaprtTextbox.Text + "%' ";
            list_all_apparatuses(query);
        }

        private void searchprjTextbox_TextChanged(object sender, EventArgs e)
        {
            query = "select a.* from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ListOfProject') as a where a.ID like '" + searchprjTextbox.Text + "%' ";
            list_all_projects(query);
        }

        private void scientistGridview_Click(object sender, EventArgs e)
        {
            curr_scientist_id = scientistGridview.CurrentRow.Cells["ID"].Value.ToString();
            config.GetImage("select a.ProfilePic from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ListOfScientist') as a where a.ID = '" + curr_scientist_id + "' ", curr_scientist_id, pictureBox1, "ProfilePic");
        }

        private void apparatusGridview_Click(object sender, EventArgs e)
        {
            curr_appar_id = apparatusGridview.CurrentRow.Cells["ID"].Value.ToString();
            config.GetImage("select a.Image from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ListOfApparatus') as a where a.ID = '" + curr_appar_id + "' ", curr_appar_id, pictureBox2, "Image");
        }

        private void projectsGridview_Click(object sender, EventArgs e)
        {
            curr_proj_id = projectsGridview.CurrentRow.Cells["ID"].Value.ToString();
            config.Load_DTG("exec sp_ShowParticipants " + curr_proj_id + " ", participantGridview);
            config.Load_DTG("exec sp_ShowApparatusInProject " + curr_proj_id + " ", takenaprtGridview);
            config.Load_DTG("exec sp_ShowReportsInExp " + curr_proj_id + " ", reportGridview);
        }

        private void changepicBtn_Click(object sender, EventArgs e)
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
