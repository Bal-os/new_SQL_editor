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
            this.headMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skriptTextField = new System.Windows.Forms.RichTextBox();
            this.OpenFiles = new System.Windows.Forms.OpenFileDialog();
            this.saveResultFile = new System.Windows.Forms.SaveFileDialog();
            this.headMenu.SuspendLayout();
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
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            // 
            // skriptTextField
            // 
            this.skriptTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skriptTextField.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.skriptTextField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skriptTextField.Location = new System.Drawing.Point(0, 24);
            this.skriptTextField.Name = "skriptTextField";
            this.skriptTextField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.skriptTextField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.skriptTextField.Size = new System.Drawing.Size(1016, 426);
            this.skriptTextField.TabIndex = 2;
            this.skriptTextField.Text = "";
            this.skriptTextField.UseWaitCursor = true;
            // 
            // OpenFiles
            // 
            this.OpenFiles.FileName = "OpenFiles";
            this.OpenFiles.Multiselect = true;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip headMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox skriptTextField;
        private System.Windows.Forms.OpenFileDialog OpenFiles;
        private System.Windows.Forms.SaveFileDialog saveResultFile;
    }
}

