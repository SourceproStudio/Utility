using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SourcePro.Csharp.Lab.Entity;
using SourcePro.Csharp.Lab.Generators;
using SourcePro.Csharp.Lab.Globalization;
using SourcePro.Csharp.Lab.Resources;
using SourcePro.Csharp.Lab.Templates;
using SourcePro.Csharp.Lab.Threading;

namespace SourcePro.Csharp.Lab.Windows
{
    public partial class MainWindow : Form
    {
        private Dictionary<string, string> _currentCultureResources;

        #region CurrentCultureResources
        /// <summary>
        /// 设置或获取当前<see cref="CultureInfo"/>的资源。
        /// </summary>
        public Dictionary<string, string> CurrentCultureResources
        {
            get { return _currentCultureResources; }
            set { _currentCultureResources = value; }
        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        #region InitializeResource
        /// <summary>
        /// 初始化当前窗体资源。
        /// </summary>
        private void InitializeResource()
        {
            try
            {
                this.CurrentCultureResources = ResourceReader.GetCultureResource("MainWindow");
            }
            catch { }
        }
        #endregion

        #region InitializeFormIcon
        /// <summary>
        /// 初始化窗体的图标。
        /// </summary>
        private void InitializeFormIcon()
        {
            using (Stream iconStream = Resource.GetIconManifestResourceStream())
            {
                try
                {
                    this.Icon = new Icon(iconStream);
                }
                finally
                {
                    iconStream.Close();
                }
            }
        }
        #endregion

        #region InitializeMenuStripItems
        /// <summary>
        /// 初始化主菜单的所有条目。
        /// </summary>
        private void InitializeMenuStripItems()
        {
            this.CtrlFeaturesMenuItem.Text = this.CurrentCultureResources["Features"];
            this.CtrlCreateMenuItem.Text = this.CurrentCultureResources["Create"];
            this.CtrlExitMenuItem.Text = this.CurrentCultureResources["Exit"];
            this.CtrlRecentlyTemplateMenuItem.Text = this.CurrentCultureResources["Recently"];
            this.CtrlLanguageMenuItem.Text = this.CurrentCultureResources["Language"];
            this.CtrlChineseMenuItem.Text = this.CurrentCultureResources["Chinese"];
            this.CtrlEnglishMenuItem.Text = this.CurrentCultureResources["English"];
            this.CtrlSaveAsTemplateMenuItem.Text = this.CurrentCultureResources["Save"];
            this.CtrlUpdateAssemblyInfoFileMenuItem.Text = this.CurrentCultureResources["Update"];
            this.CtrlUpdateAssemblyInfoDirectoryMenuItem.Text = this.CurrentCultureResources["Update2"];
            this.CtrlCopyVersionMenuItem.Text = this.CurrentCultureResources["Copy"];
            this.CtrlClearTemplatesMenuItem.Text = this.CurrentCultureResources["Clear"];
            this.InitializeRecentlyMenuStripItems();
        }
        #endregion

        #region InitializeRecentlyMenuStripItems
        /// <summary>
        /// 初始化最近的模板菜单。
        /// </summary>
        private void InitializeRecentlyMenuStripItems()
        {
            dynamic[] templates = TemplateFinder.GetAllTemplates();
            if (templates.Length > 0)
            {
                this.CtrlClearTemplatesMenuItem.Enabled = true;
                foreach (var item in templates)
                {
                    ToolStripMenuItem menuItem = new ToolStripMenuItem(string.Format("{0} ({1})", item.Name, item.CreateTime.ToString("yyyy-MM-dd")))
                    {
                        ToolTipText = item.Path,
                        Tag = item.Path
                    };
                    menuItem.Click += new EventHandler(this.RecentlyTemplateMenuItem_Click);
                    this.CtrlRecentlyTemplateMenuItem.DropDownItems.Add(menuItem);
                }
            }
            else
            {
                this.CtrlClearTemplatesMenuItem.Enabled = false;
            }
        }
        #endregion

        #region InitializeControls
        /// <summary>
        /// 初始化控件。
        /// </summary>
        private void InitializeControls()
        {
            this.InitializeMenuStripItems();
            this.CtrlAssemblyInfoPropertiesGrid.SelectedObject = new AssemblyInformation();
            this.CtrlProgressPanel.Visible = false;
            this.CtrlOpenAssemblyInfo.Title = this.CurrentCultureResources["OpenDialogTitle"];
            this.CtrlFoldersBrowser.Description = this.CurrentCultureResources["FolderBrowser"];
        }
        #endregion

        #region InitializeForm
        /// <summary>
        /// 初始化当前窗体。
        /// </summary>
        private void InitializeForm()
        {
            this.InitializeFormIcon();
            this.InitializeResource();
            this.Text = this.CurrentCultureResources["FormTitle"];
        }
        #endregion

        #region MainWindow_Load
        /// <summary>
        /// 窗体初次加载事件处理函数。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.InitializeForm();
            this.InitializeControls();
        }
        #endregion

        #region CtrlChineseMenuItem_Click
        private void CtrlChineseMenuItem_Click(object sender, EventArgs e)
        {
            Culture.ChangeCultureInfo(2052);
            this.InitializeForm();
            this.InitializeControls();
        }
        #endregion

        #region CtrlEnglishMenuItem_Click
        private void CtrlEnglishMenuItem_Click(object sender, EventArgs e)
        {
            Culture.ChangeCultureInfo(1033);
            this.InitializeForm();
            this.InitializeControls();
        }
        #endregion

        #region CtrlUpdateAssemblyInfoFileMenuItem_Click
        private void CtrlUpdateAssemblyInfoFileMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CtrlOpenAssemblyInfo.ShowDialog() == DialogResult.OK)
            {
                this.ShowOrHideProgressPanel();
                new ThreadPoolHelper()
                {
                    Arguments = new ThreadArgs()
                    {
                        Action = Actions.SingleAssemblyInfoFile,
                        Information = this.CtrlAssemblyInfoPropertiesGrid.SelectedObject as AssemblyInformation,
                        Path = this.CtrlOpenAssemblyInfo.FileName,
                        Updater = new ProgressDescriptionUpdater(this.UpdateProgressDescription)
                    }
                }.Start();
            }
        }
        #endregion

        #region ShowOrHideProgressPanel
        /// <summary>
        /// 显示或隐藏进度描述组件。
        /// </summary>
        /// <param name="showOrHide">是否显示。</param>
        private void ShowOrHideProgressPanel(bool showOrHide = true)
        {
            this.CtrlProgressPanel.Visible = showOrHide;
        }
        #endregion

        #region UpdateProgressDescription
        /// <summary>
        /// 更新进度描述信息。
        /// </summary>
        /// <param name="message">进度描述消息。</param>
        /// <param name="status">进度状态值。</param>
        private void UpdateProgressDescription(string message, ProgressStatus status)
        {
            if (!this.CtrlRunningLog.InvokeRequired)
            {
                this.CtrlRunningLog.AppendText(string.Format("Status {0} : {1}{2}", status, message, Environment.NewLine));
            }
            else
            {
                ProgressDescriptionUpdater updater = new ProgressDescriptionUpdater(this.UpdateProgressDescription);
                this.CtrlRunningLog.Invoke(updater, message, status);
            }
        }
        #endregion

        #region CtrlUpdateAssemblyInfoDirectoryMenuItem_Click
        private void CtrlUpdateAssemblyInfoDirectoryMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CtrlFoldersBrowser.ShowDialog() == DialogResult.OK)
            {
                this.ShowOrHideProgressPanel();
                new ThreadPoolHelper()
                {
                    Arguments = new ThreadArgs()
                    {
                        Action = Actions.AllAssemblyInfoFiles,
                        Information = this.CtrlAssemblyInfoPropertiesGrid.SelectedObject as AssemblyInformation,
                        Path = this.CtrlFoldersBrowser.SelectedPath,
                        Updater = new ProgressDescriptionUpdater(this.UpdateProgressDescription)
                    }
                }.Start();
            }
        }
        #endregion

        #region CtrlCopyVersionMenuItem_Click
        private void CtrlCopyVersionMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText((this.CtrlAssemblyInfoPropertiesGrid.SelectedObject as AssemblyInformation).Version.ToString());
            this.ShowOrHideProgressPanel();
            this.UpdateProgressDescription(this.CurrentCultureResources["CopyCompleted"], ProgressStatus.Completed);
        }
        #endregion

        #region CtrlSaveAsTemplateMenuItem_Click
        private void CtrlSaveAsTemplateMenuItem_Click(object sender, EventArgs e)
        {
            new TemplateGenerator() { TemplateObject = (this.CtrlAssemblyInfoPropertiesGrid.SelectedObject as AssemblyInformation) }.Generate();
        }
        #endregion

        #region CtrlClearTemplatesMenuItem_Click
        private void CtrlClearTemplatesMenuItem_Click(object sender, EventArgs e)
        {
            TemplateFinder.DeleteAll();
            this.CtrlRecentlyTemplateMenuItem.DropDownItems.Clear();
            this.CtrlClearTemplatesMenuItem.Enabled = false;
        }
        #endregion

        #region RecentlyTemplateMenuItem_Click
        private void RecentlyTemplateMenuItem_Click(object sender, EventArgs e)
        {
            string path = (sender as ToolStripMenuItem).Tag.ToString();
            if (File.Exists(path))
            {
                try
                {
                    this.CtrlAssemblyInfoPropertiesGrid.SelectedObject = AssemblyInformation.Create(path);
                }
                catch { }
            }
        }
        #endregion

        #region CtrlCreateMenuItem_Click
        private void CtrlCreateMenuItem_Click(object sender, EventArgs e)
        {
            this.CtrlAssemblyInfoPropertiesGrid.SelectedObject = new AssemblyInformation();
        }
        #endregion

        #region CtrlExitMenuItem_Click
        private void CtrlExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
