using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Oversight_Accumulator
{
    class SaveFile
    {
        public DataGridView DataView { get; set; }

        public void Save()
        {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Comma Seperate Value Files (*.csv) |*.csv|Text Documents (*.txt) |*.txt";
                saveFileDialog1.Title = "Save file..";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {

                    System.IO.FileStream fs =
                       (System.IO.FileStream)saveFileDialog1.OpenFile();
                    fs.Close();
                    System.Windows.Forms.IDataObject objectSave = Clipboard.GetDataObject();
                    DataView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    DataView.SelectAll();

                    Clipboard.SetDataObject(DataView.GetClipboardContent());
                     DataView.ClearSelection();

                        File.WriteAllText(saveFileDialog1.FileName, Clipboard.GetText(TextDataFormat.CommaSeparatedValue));
                if (objectSave != null)
                    {
                    Clipboard.SetDataObject(objectSave);
                    }
                }
            }

        }
    }

