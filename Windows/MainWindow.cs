using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SourcePro.Csharp.Lab.Entity;
using SourcePro.Csharp.Lab.Globalization;
using SourcePro.Csharp.Lab.Resources;

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
    }
}
