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
    public partial class ApparatusForm : Form
    {
        string selected_id = String.Empty;
        SQLConfig config = new SQLConfig();
        public ApparatusForm()
        {
            InitializeComponent();
        }
        private void load_apparatus(string q)
        {
            config.Load_DTG(q, apparatusGridview);
        }
        private void ApparatusForm_Load(object sender, EventArgs e)
        {
            load_apparatus("select ID, Name from Equipment ");           
        }

        private void apparatusGridview_Click(object sender, EventArgs e)
        {
            selected_id = apparatusGridview.CurrentRow.Cells["ID"].Value.ToString();

            config.GetSingleResult("select * from Equipment where ID = '" + selected_id + "' ");
            if (config.dt.Rows.Count > 0)
            {
                config.GetImage("select Image from Equipment where ID = '" + selected_id + "' ", selected_id, apparatuspicBox, "Image");
                apparatusidLabel.Text = config.dt.Rows[0].Field<int>("ID").ToString();
                apparatusnameLabel.Text = config.dt.Rows[0].Field<string>("Name");
                apparatusdescriptTextbox.Text = config.dt.Rows[0].Field<string>("Description");
                apparatusQuantity.Text = config.dt.Rows[0].Field<int>("Quantity").ToString();
            }
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            string query = "select ID, Name from Equipment where Name like '" + searchTextbox.Text + "%' ";
            load_apparatus(query);
        }
    }
}
