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
    public partial class AddProjectForm : Form
    {
        SQLConfig config = new SQLConfig();
        usefulFunctions functions = new usefulFunctions();
        string leader_id = String.Empty;

        private bool mouseDown;
        private Point lastLocation;

        public AddProjectForm()
        {
            InitializeComponent();
            config.GetServerName();

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

        private void AddProjectForm_Load(object sender, EventArgs e)
        {
            config.fill_CBO("select a.Name from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ListOfScientist') as a", participantCombobox);
            config.fill_CBO("select a.Name from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ListOfApparatus') as a", aprtCombobox);

            functions.show_data_on_DTG(functions.participants, participantGridview);
            functions.show_data_on_DTG(functions.apparatuses, takenaprtGridview);

            participantGridview.RowsAdded += ParticipantGridview_RowsAdded;

        }

        private void addmemBtn_Click(object sender, EventArgs e)
        {
            string name = participantCombobox.Text;
            config.GetSingleResult("select a.ID, a.Position from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_TakeParticipants N''" + name + "''') as a");
            string id = config.dt.Rows[0].Field<string>("ID");
            string position = config.dt.Rows[0].Field<string>("Position");

            if (leaderCheckbox.Checked)
            {
                leader_id = id;
            }

            functions.add_row_DTG(functions.participants, id, name, position);
        }

        private void addaprtBtn_Click(object sender, EventArgs e)
        {
            string name = aprtCombobox.Text;
            string quantity = quantityTextbox.Text;
            config.GetSingleResult("select a.ID from openquery([" + config.SERVERNAME + "], 'exec Laboratory.dbo.sp_ListOfApparatus') as a");
            string id = config.dt.Rows[0].Field<int>("ID").ToString();
            //config.Execute_Query("exec sp_TakeApparatus '" + name + "', '" + quantity + "' ");
            functions.add_row_DTG(functions.apparatuses, id, name, quantity);

        }

        private void ParticipantGridview_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            participantCount.Text = participantGridview.Rows.Count.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in participantGridview.Rows)
            //{
            //    config.Execute_Query
            //        (@"declare @sctdata as [UDT_Participation]
            //            insert into @sctdata select '" + expidTextbox.Text + "', '" + row.Cells[0].Value + "' ");
            //}
            string q = "exec sp_AddProject '" + expidTextbox.Text + "', '" + exptdescriptTextbox +
                "', '" + startTimepicker.Text + "', '" + endTimepicker +
                "', '" + leader_id + "', '" + participantCount.Text + "', ";
            config.Execute_CUD(q, "Failed", "Success");
        }
    }
}
