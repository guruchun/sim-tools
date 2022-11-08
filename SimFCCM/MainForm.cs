using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinFormsUI.Docking;
using log4net;
using System.Reflection;
using System.Collections.Generic;
using FcpTools;

namespace CBoxSim
{
    public partial class MainForm : Form
    {
        //private bool m_bSaveLayout = true;
        private FormHelp _HelpView;
        private FormCBox _CBoxView;

        private List<FormLog> _ViewLogs;
        private static readonly ILog log = LogManager.GetLogger("Console");
        //private DeserializeDockContent deserializeDockContent;

        public MainForm()
        {
            log.Debug("initialize main form");
            InitializeComponent();
            _ViewLogs = new List<FormLog>();

            log.Debug("create form documents");
            InitializeDockings();
            //deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
            log.Debug("initialize main form -> OK");
        }

        #region Methods
        public DockPanel GetDockingPanel()
        {
            return dockPanel;
        }

        public void ShowHelp(string url)
        {
            if (_HelpView == null || _HelpView.IsDisposed) {
                _HelpView = new FormHelp();
                _HelpView.Show(dockPanel, new Rectangle(200, 200, 800, 600));
            }
            _HelpView.showHelp(url);
        }

        private void InitializeDockings()
        {
            _CBoxView = new FormCBox();

            List<string> logs = ConfigInfo.GetInstance().config.logView;
            for (int i = 0; i < logs.Count; i++)
                _ViewLogs.Add(new FormLog(logs[i]));
        }

        // TODO create more LRUs
        private void CreateDocuments()
        {
            DockContent leftDoc;
            leftDoc = CreateNewDocument("CLI");
            leftDoc.Show(dockPanel, DockState.Document);
            
            // log view
            foreach (var f in _ViewLogs)
                f.Show(dockPanel, DockState.DockBottom);

            // tool
            //if (_ViewLogs.Count > 0)
            //    m_tool.Show(_ViewLogs[0].Pane, DockAlignment.Right, 0.3);
            //else
            //    m_tool.Show(dockPanel, DockState.DockBottom);
        }

        private DockContent CreateNewDocument(String docName)
        {
            DockContent tempDoc;
            tempDoc = (DockContent)FindDocument(docName);
            if (tempDoc != null)
            {
                // already existed
                // TODO activated
                return (DockContent)tempDoc;
            }

            // create new doucment
            switch (docName)
            {
                case "CLI":
                    tempDoc = new FormCBox();
                    break;
            }
            //if (tempDoc != null)
            //    tempDoc.Text = docName;

            return tempDoc;
        }

        private IDockContent FindDocument(string text)
        {
            foreach (IDockContent content in dockPanel.Documents)
                if (content.DockHandler.TabText == text)
                    return content;

            return null;
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            log.Debug("GetContentFromPersistString, " + persistString);

            if (persistString == typeof(FormHelp).ToString())
                return _HelpView;
            else if (persistString == typeof(FormCBox).ToString())
                return _CBoxView;
            else
                return null;
        }
        
        #endregion

        #region Event Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            log.Debug("loading " + this.Name);
            this.Text += " - Version " + Assembly.GetEntryAssembly().GetName().Version.Major;
            this.Text += "." + Assembly.GetEntryAssembly().GetName().Version.Minor;
            this.Text += "." + Assembly.GetEntryAssembly().GetName().Version.Build;

            // load docking configuration
            this.Size = Properties.Settings.Default.Size;

            //string configFile = Path.Combine(Application.StartupPath, "config\\client.layout");
            //if (File.Exists(configFile))
            //    dockPanel.LoadFromXml(configFile, deserializeDockContent);
            //else
            CreateDocuments();

            // create logfile directory
            string logPath = Application.StartupPath + "\\log";
            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);
        }
        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //DockContent content = (DockContent)this.dockPanel.ActivePane.ActiveContent;
            //if (content != null)
            //    content.HelpRequested;

            ShowHelp("GuideOverview");
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Size = this.Size;
            Properties.Settings.Default.Save();

            //string configFile = Path.Combine(Application.StartupPath, "config\\client.layout");
            //dockPanel.SaveAsXml(configFile);
        }

        #endregion

    }
}