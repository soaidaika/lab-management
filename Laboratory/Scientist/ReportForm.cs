using Laboratory.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class ReportForm : Form
    {
        SQLConfig config = new SQLConfig();
        usefulFunctions functions = new usefulFunctions();
        string exp_id = String.Empty;
        string sct_id = String.Empty;
        string get_author = String.Empty;
        string tmpFile = String.Empty;
        DateTime dateTime;

        public ReportForm(string expid, string sctid)
        {
            InitializeComponent();

            sct_id = sctid;
            exp_id = expid;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            config.Load_DTG("exec sp_ShowReportsInExp " + exp_id + " ", reportGridview);
            reportGridview.Columns["Author"].Visible = false;
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Multiselect = false, Filter = "Word Document|*.doc;*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] bytes = File.ReadAllBytes(dialog.FileName);

                    string hex = BitConverter.ToString(bytes).Replace("-", String.Empty);

                    config.Execute_CUD("exec sp_AddReport '" + exp_id + "', '" + sct_id + "', '0x" + hex + "' ", "Failed to add report file.", "Report file is successfully added.");
                    config.Load_DTG("exec sp_ShowReportsInExp " + exp_id + " ", reportGridview);
                    reportGridview.Columns["Author"].Visible = false;
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            get_author = reportGridview.CurrentRow.Cells["Author"].Value.ToString();
            dateTime = (DateTime)reportGridview.CurrentRow.Cells[0].Value;
            string r = dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            if (sct_id == get_author)
            {
                config.Execute_CUD("exec sp_RemoveReport '" + exp_id + "', '" + r + "' , '" + sct_id + "' ", "Failed to remove report.", "Report is successfully removed.");
                get_author = String.Empty;
                showreportRTextbox.Clear();
            }
            else
            {
                MessageBox.Show("You cannot remove another scientist's report.");
            }
            config.Load_DTG("exec sp_ShowReportsInExp " + exp_id + " ", reportGridview);
            reportGridview.Columns["Author"].Visible = false;
        }

        private static string GetTempReportFilePathWithExtension(string extension)
        {
            var path = Path.GetTempPath();
            var filename = Guid.NewGuid().ToString() + "." + extension;
            return Path.Combine(path, filename);
        }

        private void reportGridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            get_author = reportGridview.CurrentRow.Cells["Author"].Value.ToString();
            dateTime = (DateTime)reportGridview.CurrentRow.Cells[0].Value;
            string r = dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            config.GetSingleResult("select ReportFile from Report where ExpID = '" + exp_id + "' and Author = '" + get_author + "' and ReportTime = '" + r + "' ");
            byte[] bytes = config.dt.Rows[0].Field<byte[]>("ReportFile");

            tmpFile = GetTempReportFilePathWithExtension("docx");

            File.WriteAllBytes(tmpFile, bytes);
            functions.ImportReport(tmpFile, showreportRTextbox);
        }
    }
}
