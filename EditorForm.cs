using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace SQL_editor_edition
{
    public partial class EditorForm : Form
    {
        private FilesSet file;
        public EditorForm()
        {
            InitializeComponent();

            this.OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            this.SaveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;

        }
        private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        //open file dialog and show processed text
        {
            this.Activate();
            OpenFiles.ShowDialog();
            string[] names = OpenFiles.FileNames;
            if (names == Array.Empty<string>()) return;
            try
            //get text from file output glued file on the screen 
            {
                file = new FilesSet(names);
                skriptTextField.Lines = file.getResultFile().ToArray();
            }
            catch (System.IO.FileNotFoundException Ex)
            //handles file expetions
            {
                MessageBox.Show(Ex.Message + "\nНет такого файла",
                         "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Ex)
            //handles other expetions
            {
                MessageBox.Show(Ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void SaveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        //save to file text from the screen
        {
            saveResultFile.FileName = OpenFiles.FileName;
            if (saveResultFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var writer = new System.IO.StreamWriter(
                    saveResultFile.FileName, false,
                                        System.Text.Encoding.GetEncoding(1251));
                    writer.Write(skriptTextField.Text);
                    writer.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

    }
}
