using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_editor_edition
{
    public partial class Form1 : Form
    {
        private DataWrapper data;
        private MyFile file;

        private string menuItem1 = "Открыть";
        private string menuItem2 = "Сохранить как";
        private bool flag_for_button = true;

        public OpenFileDialog openFileDialog1;
        public TextBox textBox1;
        public SaveFileDialog saveFileDialog1;
        public Button buttonFile;
        public ContextMenuStrip contextMenuStrip1;
        public Form1()
        {
            InitializeComponent();

            Text = "SQL text compiler";
            this.BackColor = Color.Azure;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = SystemInformation.VirtualScreen.Width / 2;
            this.Height = SystemInformation.VirtualScreen.Height / 2;

            textBox1 = new TextBox();
            textBox1.Location = new Point(this.Width / 5, 20);
            textBox1.Width = 3 * this.Width / 5;
            textBox1.Height = this.Height - 45;
            textBox1.BackColor = Color.White;
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            this.Controls.Add(textBox1);

            buttonFile = new Button();
            buttonFile.Size = new Size(45, 20);
            buttonFile.Location = new Point(0, 0);
            buttonFile.Text = "Файл";
            this.Controls.Add(buttonFile);
            buttonFile.Click += new EventHandler(buttonFile_Click);

            contextMenuStrip1 = new ContextMenuStrip();
            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add(menuItem1);
            contextMenuStrip1.Items.Add(menuItem2);
            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contexMenu_ItemClicked);

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "My SQL Browser";
            openFileDialog1.Filter = "SQL files(*.pdc)|*.pdc|All files(*.*)|*.*";

            saveFileDialog1 = new SaveFileDialog();
        }

        private void OpenToolStripMenuItem_Click()
        {
            this.Activate();
            openFileDialog1.ShowDialog();
            string[] names = openFileDialog1.FileNames;
            if (names == Array.Empty<string>()) return;
            try
            {
                file = new MyFile(names);
                data = new DataWrapper(names, file.Data);
                textBox1.Text = data.getResultString();
            }
            //if (openFileDialog1.FileName == String.Empty) return;
            /*try
            {
                textBox1.Text = "";
                foreach (var fileF in openFileDialog1.FileNames)
                {
                    var reader = new System.IO.StreamReader(
                    fileF, Encoding.GetEncoding(1251));
                    textBox1.Text += reader.ReadToEnd();
                    reader.Close();
                }
            }*/
            catch (System.IO.FileNotFoundException Ex)
            {
                MessageBox.Show(Ex.Message + "\nНет такого файла",
                         "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveAsToolStripMenuItem_Click()
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var writer = new System.IO.StreamWriter(
                    saveFileDialog1.FileName, false,
                                        System.Text.Encoding.GetEncoding(1251));
                    writer.Write(textBox1.Text);
                    writer.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            openFileDialog1.FileName = @"data\Text2.txt";
            openFileDialog1.Filter =
                     "SQL files(*.pdc)|*.pdc|All files(*.*)|*.*";
            saveFileDialog1.Filter =
                     "SQL files(*.pdc)|*.pdc|All files(*.*)|*.*";
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (flag_for_button)
            {
                contextMenuStrip1.Show(buttonFile, new Point(buttonFile.Location.X, buttonFile.Height));
                flag_for_button = false;
            }
            else
            {
                contextMenuStrip1.Hide();
                flag_for_button = true;
            }
        }
        private void contexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
              
            if (e.ClickedItem.Text == menuItem1)
            {
                contextMenuStrip1.Hide();
                flag_for_button = true;
                OpenToolStripMenuItem_Click();
            }
            else if (e.ClickedItem.Text == menuItem2)
            {
                contextMenuStrip1.Hide();
                flag_for_button = true;
                SaveAsToolStripMenuItem_Click();
            }
        }
    }
}
