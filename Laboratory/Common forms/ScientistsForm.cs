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
    public partial class ScientistsForm : Form
    {
        SQLConfig config = new SQLConfig();
        string query = String.Empty;
        string selected_id = String.Empty;

        public ScientistsForm()
        {
            InitializeComponent();
            config.GetServerName();
        }
        private void load_all_scientist(string q)
        {
            config.Load_DTG(q, scientistGridview);

            // Hide unnecessary columns
            scientistGridview.Columns["ID"].Visible = false;
            
        }
        private void ScientistsForm_Load(object sender, EventArgs e)
        {
            load_all_scientist("select a.ID, a.Name, a.Position, a.Department, a.Phone from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ListOfScientist') as a ");
        }

        private void scientistGridview_Click(object sender, EventArgs e)
        {
            selected_id = scientistGridview.CurrentRow.Cells["ID"].Value.ToString();
            query = "select a.* from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ListOfScientist') as a where a.ID = '" + selected_id + "' ";
            config.GetSingleResult(query);
            if (config.dt.Rows.Count > 0)
            {
                config.GetImage("select ProfilePic from Scientist where ID = '" + selected_id + "' ", selected_id, profilepicBox, "ProfilePic");

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

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            query = "select a.ID, a.Name, a.Position, a.Department, a.Phone from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ListOfScientist') as a where a.Name like '" + searchTextbox.Text + "%' ";
            load_all_scientist(query);
        }
    }
}
