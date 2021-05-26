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
    public partial class DepartmentForm : Form
    {
        SQLConfig config = new SQLConfig();
        public DepartmentForm()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);

        }
        private void load_department_members()
        {
            config.Load_DTG("exec sp_ShowScientistInDep cmt123", cmtmemGridview);
            config.Load_DTG("exec sp_ShowScientistInDep ctl789", ctlmemGridview);
            config.Load_DTG("exec sp_ShowScientistInDep hmt567", hmtmemGridview);
            config.Load_DTG("exec sp_ShowScientistInDep mcb345", mcbmemGridview);

            config.GetSingleResult("exec sp_NumOfMemInDep cmt123");
            numofmemLabel.Text = config.dt.Rows[0].Field<int>("Members").ToString();

            config.GetSingleResult("exec sp_NumOfMemInDep ctl789");
            numofmemLabel1.Text = config.dt.Rows[0].Field<int>("Members").ToString();

            config.GetSingleResult("exec sp_NumOfMemInDep hmt567");
            numofmemLabel2.Text = config.dt.Rows[0].Field<int>("Members").ToString();

            config.GetSingleResult("exec sp_NumOfMemInDep mcb345");
            numofmemLabel3.Text = config.dt.Rows[0].Field<int>("Members").ToString();

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

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            load_department_members();
        }
    }
}
