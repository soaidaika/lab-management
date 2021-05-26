using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Laboratory.Includes
{
    class usefulFunctions
    {
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
