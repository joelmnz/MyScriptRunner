using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScriptRunner
{
    public partial class MainForm : Form
    {
        private const string FIELD_ScriptName = "ScriptName";
        private const string FIELD_FullPath = "FullPath";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = System.Windows.Forms.Application.ProductName;
            this.VersionNumberTsl.Text = System.Windows.Forms.Application.ProductVersion;
            this.ScriptPathTsl.Text = "Script Path: " + Program.ScriptFolder;
            this.fileSystemWatcher1.Path = Properties.Settings.Default.ScriptFolder;

            this.ScriptsListBox.ValueMember = FIELD_FullPath;
            this.ScriptsListBox.DisplayMember = FIELD_ScriptName;

            LoadScripts();

        }

        private void ScriptPathTsl_Click(object sender, EventArgs e)
        {
            Program.OpenScriptFolder();

        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // may do event handling later

            //this.fileSystemWatcher1.Created += this.fileSystemWatcher1_Changed;
            //this.fileSystemWatcher1.Changed += this.fileSystemWatcher1_Changed;
            //this.fileSystemWatcher1.Renamed += this.fileSystemWatcher1_Changed;
            //this.fileSystemWatcher1.Deleted += this.fileSystemWatcher1_Changed;

            //this.fileSystemWatcher1.EnableRaisingEvents = true;
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            // refresh list...

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunSelectedScript();
        }

        void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RunSelectedScript()
        {
            
            try
            {
                ScriptOpener.RunScript(this.SelectedScriptPath);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }

        }

        private void editScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedScript();
        }

        private void EditSelectedScript()
        {
            
            try
            {
                ScriptOpener.EditScript(this.SelectedScriptPath);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void LoadScripts()
        {
            // clear first
            this.DataSource = new DataView(this.GetScriptsTable());

            System.Threading.Tasks.Task.Run(() => { this.DataSource = new DataView(this.GetScriptsTable()); });
        }

        private DataView _DataSource = null;
        private DataView DataSource
        {
            get
            {
                return _DataSource;
            }
            set
            {

                _DataSource = value;
                if (this.ScriptsListBox.InvokeRequired)
                {
                    this.Invoke((Action)(() => this.ScriptsListBox.DataSource = value)
                   );

                }
                else {
                    this.ScriptsListBox.DataSource = value;
                }
                this.ApplySearchFilter();
            }

        }

        private string SearchText
        {
            get { return this.searchTextBox.Text; }
            set
            {
                this.searchTextBox.Text = value;
            }
        }

        private void ApplySearchFilter()
        {
            ApplySearchFilter(this.SearchText);
        }

        private void ApplySearchFilter(string searchText)
        {
            if (this.DataSource == null) { return; }
            if (string.IsNullOrEmpty(searchText))
            {
                this.DataSource.RowFilter = null; return;
            }
            this.DataSource.RowFilter = "[" + FIELD_ScriptName + "] LIKE '%" + searchText.Replace("'", "''") + "%'";

        }

        private DataTable GetScriptsTable()
        {
            DataTable dtScripts = new DataTable();

            dtScripts.Columns.Add(FIELD_ScriptName);
            dtScripts.Columns.Add(FIELD_FullPath);

            if (!System.IO.Directory.Exists(Program.ScriptFolder)) { return dtScripts; }

            var arFiles = System.IO.Directory.GetFiles(Program.ScriptFolder, "*.*", SearchOption.AllDirectories);

            dtScripts.BeginLoadData();
            foreach (var fileName in arFiles)
            {
                // strip off full path for name (what about nested folders?) to do later...
                dtScripts.Rows.Add(new object[] { System.IO.Path.GetFileName(fileName), fileName });
            }
            dtScripts.EndLoadData();

            dtScripts.AcceptChanges();
            return dtScripts;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ApplySearchFilter();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadScripts();
            ScriptOpener.Init();

        }

        private async void ScriptsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            await LoadScriptPreview(SelectedScriptPath);
        }

        async Task LoadScriptPreview(string scriptPath)
        {
            this.ScriptTextBox.Text = string.Empty;

            if (string.IsNullOrEmpty(scriptPath)) { return; }

            if (System.IO.File.Exists(scriptPath))
            {
                try
                {
                    //this.ScriptTextBox.Text = System.IO.File.ReadAllText(scriptPath);
                    using (var sr = new System.IO.StreamReader(scriptPath))
                    {
                        this.ScriptTextBox.Text = await sr.ReadToEndAsync();
                    }
                }
                catch (Exception ex)
                {
                    this.ScriptTextBox.Text = "ERROR:" + Environment.NewLine + ex.Message;

                }
            }
        }

        private string SelectedScriptPath
        {
            get
            {
                if (ScriptsListBox.SelectedValue == null) { return string.Empty; }
                return Convert.ToString(ScriptsListBox.SelectedValue);
            }
        }

        private void openScriptFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.OpenScriptFolder();
        }

        private void ScriptsListBox_DoubleClick(object sender, EventArgs e)
        {
            this.RunSelectedScript();
        }

        private void openExtensionHandlesFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ScriptOpener.OpenExtensionHandlerConfigFile();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
    } // class
} // ns
