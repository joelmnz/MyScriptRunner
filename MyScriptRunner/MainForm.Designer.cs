namespace MyScriptRunner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ScriptPathTsl = new System.Windows.Forms.ToolStripStatusLabel();
            this.VersionNumberTsl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScriptFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExtensionHandlesFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.ScriptsListBox = new System.Windows.Forms.ListBox();
            this.ScriptTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.runScriptAsAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblScriptName = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScriptPathTsl,
            this.VersionNumberTsl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(979, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ScriptPathTsl
            // 
            this.ScriptPathTsl.Name = "ScriptPathTsl";
            this.ScriptPathTsl.Size = new System.Drawing.Size(917, 17);
            this.ScriptPathTsl.Spring = true;
            this.ScriptPathTsl.Text = "Script Path:";
            this.ScriptPathTsl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScriptPathTsl.Click += new System.EventHandler(this.ScriptPathTsl_Click);
            // 
            // VersionNumberTsl
            // 
            this.VersionNumberTsl.Name = "VersionNumberTsl";
            this.VersionNumberTsl.Size = new System.Drawing.Size(43, 17);
            this.VersionNumberTsl.Text = "v1.x.x.x";
            this.VersionNumberTsl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openScriptFolderToolStripMenuItem,
            this.openExtensionHandlesFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openScriptFolderToolStripMenuItem
            // 
            this.openScriptFolderToolStripMenuItem.Name = "openScriptFolderToolStripMenuItem";
            this.openScriptFolderToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.openScriptFolderToolStripMenuItem.Text = "&Open Script Folder";
            this.openScriptFolderToolStripMenuItem.Click += new System.EventHandler(this.openScriptFolderToolStripMenuItem_Click);
            // 
            // openExtensionHandlesFileToolStripMenuItem
            // 
            this.openExtensionHandlesFileToolStripMenuItem.Name = "openExtensionHandlesFileToolStripMenuItem";
            this.openExtensionHandlesFileToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.openExtensionHandlesFileToolStripMenuItem.Text = "Open Extension Handles File";
            this.openExtensionHandlesFileToolStripMenuItem.Click += new System.EventHandler(this.openExtensionHandlesFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.runScriptAsAdminToolStripMenuItem,
            this.editScriptToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "&Actions";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.runToolStripMenuItem.Text = "&Run Script";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // editScriptToolStripMenuItem
            // 
            this.editScriptToolStripMenuItem.Name = "editScriptToolStripMenuItem";
            this.editScriptToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.editScriptToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.editScriptToolStripMenuItem.Text = "&Edit Script";
            this.editScriptToolStripMenuItem.Click += new System.EventHandler(this.editScriptToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(79, 38);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(301, 22);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // ScriptsListBox
            // 
            this.ScriptsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ScriptsListBox.FormattingEnabled = true;
            this.ScriptsListBox.ItemHeight = 16;
            this.ScriptsListBox.Location = new System.Drawing.Point(19, 70);
            this.ScriptsListBox.Name = "ScriptsListBox";
            this.ScriptsListBox.Size = new System.Drawing.Size(359, 452);
            this.ScriptsListBox.TabIndex = 2;
            this.ScriptsListBox.SelectedValueChanged += new System.EventHandler(this.ScriptsListBox_SelectedValueChanged);
            this.ScriptsListBox.DoubleClick += new System.EventHandler(this.ScriptsListBox_DoubleClick);
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptTextBox.Location = new System.Drawing.Point(410, 91);
            this.ScriptTextBox.Multiline = true;
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.ReadOnly = true;
            this.ScriptTextBox.Size = new System.Drawing.Size(551, 431);
            this.ScriptTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preview (F4 = Edit, F5 = Run)";
            // 
            // runScriptAsAdminToolStripMenuItem
            // 
            this.runScriptAsAdminToolStripMenuItem.Name = "runScriptAsAdminToolStripMenuItem";
            this.runScriptAsAdminToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.runScriptAsAdminToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.runScriptAsAdminToolStripMenuItem.Text = "Run Script as Admin";
            this.runScriptAsAdminToolStripMenuItem.Click += new System.EventHandler(this.runScriptAsAdminToolStripMenuItem_Click);
            // 
            // lblScriptName
            // 
            this.lblScriptName.AutoSize = true;
            this.lblScriptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScriptName.Location = new System.Drawing.Point(407, 70);
            this.lblScriptName.Name = "lblScriptName";
            this.lblScriptName.Size = new System.Drawing.Size(23, 18);
            this.lblScriptName.TabIndex = 7;
            this.lblScriptName.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 561);
            this.Controls.Add(this.lblScriptName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.ScriptsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ScriptPathTsl;
        private System.Windows.Forms.ToolStripStatusLabel VersionNumberTsl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScriptTextBox;
        private System.Windows.Forms.ListBox ScriptsListBox;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem editScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScriptFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExtensionHandlesFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runScriptAsAdminToolStripMenuItem;
        private System.Windows.Forms.Label lblScriptName;
    }
}

