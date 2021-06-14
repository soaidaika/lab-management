using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;

namespace Laboratory.Includes
{
    class usefulFunctions
    {
        public DataTable participants = dt_to_fill_DTG("ID", "Name", "Position");
        public DataTable apparatuses = dt_to_fill_DTG("ID", "Name", "Quantity");

        public static DataTable dt_to_fill_DTG(string col1, string col2, string col3)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[3]
            {
                new DataColumn(col1, typeof(string)),
                new DataColumn(col2, typeof(string)),
                new DataColumn(col3, typeof(string))
            });
            return dataTable;
        }
        public void add_row_DTG(DataTable dataTable, string val1, string val2, string val3)
        {
            dataTable.Rows.Add(val1, val2, val3);
        }
        public void show_data_on_DTG(DataTable dataTable, DataGridView dtg)
        {
            dtg.DataSource = dataTable;
            dtg.Update();
            dtg.Refresh();
        }
        public void ImportReport(string fileName, RichTextBox richTextBox)
        {
            object readOnly = true;
            object visible = true;
            object save = false;
            object file = fileName;
            object newTemplate = false;
            object docType = 0;
            object missing = Type.Missing;

            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application() { Visible = false };
            Microsoft.Office.Interop.Word.Document doc;

            doc = app.Documents.Open(ref file, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);

            doc.ActiveWindow.Selection.WholeStory();
            doc.ActiveWindow.Selection.Copy();
            IDataObject data = Clipboard.GetDataObject();
            richTextBox.Rtf = data.GetData(DataFormats.Rtf).ToString();
            app.Quit(ref missing, ref missing, ref missing);
        }
    }
}
