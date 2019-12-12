namespace SQL_editor_edition
{
    partial class EditorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        /// 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.headMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFiles = new System.Windows.Forms.OpenFileDialog();
            this.saveResultFile = new System.Windows.Forms.SaveFileDialog();
            this.skriptTextField = new FastColoredTextBoxNS.FastColoredTextBox();
            this.headMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skriptTextField)).BeginInit();
            this.SuspendLayout();
            // 
            // headMenu
            // 
            this.headMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.headMenu.Location = new System.Drawing.Point(0, 0);
            this.headMenu.Name = "headMenu";
            this.headMenu.Size = new System.Drawing.Size(1016, 24);
            this.headMenu.TabIndex = 0;
            this.headMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.AutoSize = false;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            // 
            // OpenFiles
            // 
            this.OpenFiles.FileName = "OpenFiles";
            this.OpenFiles.Multiselect = true;
            // 
            // skriptTextField
            // 
            this.skriptTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skriptTextField.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.skriptTextField.AutoIndentCharsPatterns = "";
            this.skriptTextField.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.skriptTextField.BackBrush = null;
            this.skriptTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skriptTextField.CharHeight = 14;
            this.skriptTextField.CharWidth = 8;
            this.skriptTextField.CommentPrefix = "--";
            this.skriptTextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.skriptTextField.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.skriptTextField.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.skriptTextField.HighlightingRangeType = FastColoredTextBoxNS.HighlightingRangeType.VisibleRange;
            this.skriptTextField.IsReplaceMode = false;
            this.skriptTextField.LeftBracket = '(';
            this.skriptTextField.Location = new System.Drawing.Point(0, 27);
            this.skriptTextField.Name = "skriptTextField";
            this.skriptTextField.Paddings = new System.Windows.Forms.Padding(0);
            this.skriptTextField.RightBracket = ')';
            this.skriptTextField.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.skriptTextField.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("skriptTextField.ServiceColors")));
            this.skriptTextField.Size = new System.Drawing.Size(1016, 422);
            this.skriptTextField.SourceTextBox = this.skriptTextField;
            this.skriptTextField.TabIndex = 3;
            this.skriptTextField.Zoom = 100;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.skriptTextField);
            this.Controls.Add(this.headMenu);
            this.MainMenuStrip = this.headMenu;
            this.Name = "EditorForm";
            this.RightToLeftLayout = true;
            this.Text = "SQL editor";
            this.headMenu.ResumeLayout(false);
            this.headMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skriptTextField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip headMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFiles;
        private System.Windows.Forms.SaveFileDialog saveResultFile;
        private FastColoredTextBoxNS.FastColoredTextBox skriptTextField;
    }
}

