using System;
using System.Windows.Forms;

namespace SQL_editor_edition
{
    public partial class EditorForm : Form
    {
        private DataSet data;
        public EditorForm()
        {
            InitializeComponent();

            this.OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click; 
            this.SaveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
        }
        private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        //open data dialog and show processed text
        {
            this.Activate();
            OpenFiles.ShowDialog();
            string[] names = OpenFiles.FileNames;
            if (names == Array.Empty<string>()) return;
            try
            //get text from data output glued data on the screen 
            {
                data = new DataSet(names);
                skriptTextField.Text = data.getResultData();
            }
            catch (System.IO.FileNotFoundException Ex)
            //handles data expetions
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
        //save as file text from the screen
        {
            saveResultFile.FileName = data.fileName;
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
