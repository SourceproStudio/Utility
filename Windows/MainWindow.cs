using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SourcePro.Csharp.Lab.Entity;
using SourcePro.Csharp.Lab.Globalization;
using SourcePro.Csharp.Lab.Resources;
using SourcePro.Csharp.Lab.Threading;
using SourcePro.Csharp.Lab.Generators;

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
            this.CtrlOpenTemplateMenuItem.Text = this.CurrentCultureResources["Open"];
            this.CtrlRecentlyTemplateMenuItem.Text = this.CurrentCultureResources["Recently"];
            this.CtrlLanguageMenuItem.Text = this.CurrentCultureResources["Language"];
            this.CtrlChineseMenuItem.Text = this.CurrentCultureResources["Chinese"];
            this.CtrlEnglishMenuItem.Text = this.CurrentCultureResources["English"];
            this.CtrlSaveAsTemplateMenuItem.Text = this.CurrentCultureResources["Save"];
            this.CtrlUpdateAssemblyInfoFileMenuItem.Text = this.CurrentCultureResources["Update"];
            this.CtrlUpdateAssemblyInfoDirectoryMenuItem.Text = this.CurrentCultureResources["Update2"];
            this.CtrlCopyVersionMenuItem.Text = this.CurrentCultureResources["Copy"];
            this.CtrlClearTemplatesMenuItem.Text = this.CurrentCultureResources["Clear"];
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
    }
}
