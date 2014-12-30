#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-25 15:05:47
 * Common Language Runtime : 4.0.30319.18444
 * Minimum .Net Framework Version : 3.5
 * 
 * SourcePro Studio 2014
 * Project Url : https://github.com/SourceproStudio/CodeTemplates
 * Home Page Url : https://github.com/SourceproStudio
 * E-mail Address : MasterDuner@yeah.net or Yucai.Wang-Public@outlook.com
 * QQ : 180261899
 */

#endregion

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using SourcePro.Csharp.Lab.Commons;
using SourcePro.Csharp.Lab.Commons.Entity;

namespace SourcePro.Csharp.Lab.Forms
{
    /// <summary>
    /// <para>
    /// 用于处理主窗体的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Forms"/>
    /// </para>
    /// <para>
    /// Type : <see cref="MainForm"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Forms"/>
    partial class MainForm
    {
        #region InitializeFormIcon
        private void InitializeFormIcon()
        {
            this.Icon = base.GetIconFromManifestResource();
        }
        #endregion

        #region InitializeControls
        protected override void InitializeControls()
        {
            base.InitializeControls();
            this.InitializeFormIcon();
            this.SetCopyrightDescription();
            this.SetVersionDescription();
            this.SetMenuStripItemsEnabled(false, this.CtrlMenuStripItem_Save, this.CtrlMenuStripItem_SaveAs, this.CtrlMenuStripItem_Recently, this.CtrlMenuStripItem_Build, this.CtrlMenuStripItem_Start);
            this.InitializeRecently();
        }
        #endregion

        #region SetCopyrightDescription
        private void SetCopyrightDescription()
        {
            this.CtrlStatusLabel_Copyright.Text = string.Format("Copyright © 2014{0} Wang Yucai.", this.Now.Year > 2014 ? "-" + this.Now.Year.ToString() : string.Empty);
        }
        #endregion

        #region SetVersionDescription
        private void SetVersionDescription()
        {
            this.CtrlStatusLabel_Version.Text = string.Format(".NET ASSEMBLYINFO EDITOR {0}", Assembly.GetExecutingAssembly().GetName().Version);
        }
        #endregion

        #region SetMenuStripItemsEnabled
        private void SetMenuStripItemsEnabled(bool enabled, params ToolStripMenuItem[] items)
        {
            foreach (var item in items) item.Enabled = enabled;
        }
        #endregion

        #region InitializeRecently
        private void InitializeRecently()
        {
            try
            {
                this._history = HistoryObject.Get();
                this.SetMenuStripItemsEnabled(this._history.Files.Count > 0, this.CtrlMenuStripItem_Recently);
                foreach (var item in this._history.Files)
                {
                    ToolStripMenuItem menustripItem = new ToolStripMenuItem(item) { Tag = item };
                    menustripItem.Click += (
                            (sender, e) =>
                            {
                                this.OpenProject((sender as ToolStripMenuItem).Tag.ToString());
                            }
                        );
                    this.CtrlMenuStripItem_Recently.DropDownItems.Add(menustripItem);
                }
            }
            catch
            { }
        }
        #endregion

        #region RegisterControlsEventHandlers
        protected override void RegisterControlsEventHandlers()
        {
            base.RegisterControlsEventHandlers();
            this.CtrlMenuStripItem_CreateNew.Click += new EventHandler(DoCreateNew);
            this.CtrlMenuStripItem_Save.Click += new EventHandler(DoSave);
            this.CtrlMenuStripItem_Open.Click += new EventHandler(DoOpenProject);
            this.CtrlMenuStripItem_ClearRecently.Click += new EventHandler(DoClearRecently);
            this.CtrlMenuStripItem_Start.Click += new EventHandler(DoBuild);
        }
        #endregion

        #region DoBuild
        private void DoBuild(object sender, EventArgs e)
        {
            using (BuildForm buildFrm = new BuildForm()
            {
                AssemblyInformation = this.CtrlPropertyGrid_Main.SelectedObject as AssemblyInformation,
                Size = this.Size
            })
            {
                buildFrm.ShowDialog(this);
            }
        }
        #endregion

        #region CtrlMenuStripItem_ClearRecently Click Event Handler : DoClearRecently
        private void DoClearRecently(object sender, EventArgs e)
        {
            this._history.Files.Clear();
            this._history.Save();
            this.CtrlMenuStripItem_Recently.DropDownItems.Clear();
            this.CtrlMenuStripItem_Recently.Enabled = false;
        }
        #endregion

        #region CtrlMenuStripItem_Open Click Event Handler : DoOpenProject
        private void DoOpenProject(object sender, EventArgs e)
        {
            if (this.CtrlOpenFileDialog_OpenProject.ShowDialog() == DialogResult.OK)
            {
                this.OpenProject(this.CtrlOpenFileDialog_OpenProject.FileName);
            }
        }
        #endregion

        #region CtrlMenuStripItem_Save Click Event Handler : DoSave
        private void DoSave(object sender, EventArgs e)
        {
            AssemblyInformation information = this.CtrlPropertyGrid_Main.SelectedObject as AssemblyInformation;
            string path = information.StoragePath;
            if (this._isCreateNew && this.CtrlSaveFileDialog_SaveProject.ShowDialog() == DialogResult.OK)
                path = this.CtrlSaveFileDialog_SaveProject.FileName;
            if (!string.IsNullOrEmpty(path))
            {
                information.Version.SetRawValues();
                information.FileVersion.SetRawValues();
                information.Save(path, this._isCreateNew);
                this.SaveHistory(path);
            }
        }
        #endregion

        #region CtrlMenuStripItem_CreateNew Click Event Handler : DoCreateNew
        private void DoCreateNew(object sender, EventArgs e)
        {
            this.CtrlPropertyGrid_Main.SelectedObject = new AssemblyInformation();
            this._isCreateNew = true;
            this.SetMenuStripItemsEnabled(true, this.CtrlMenuStripItem_Save, this.CtrlMenuStripItem_SaveAs, this.CtrlMenuStripItem_Start, this.CtrlMenuStripItem_Build);
        }
        #endregion

        #region OpenProject
        private void OpenProject(string file)
        {
            if (File.Exists(file))
            {
                using (Stream destinationStream = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        this._isCreateNew = false;
                        this.CtrlPropertyGrid_Main.SelectedObject = AssemblyInformation.Deserialize<AssemblyInformation>(destinationStream);
                        this.SetMenuStripItemsEnabled(true, this.CtrlMenuStripItem_Save, this.CtrlMenuStripItem_SaveAs, this.CtrlMenuStripItem_Start, this.CtrlMenuStripItem_Build);
                    }
                    catch { MessageBox.Show("Unable to open project file!", MessageBoxCaptions.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    finally { destinationStream.Close(); }
                }
            }
            else MessageBox.Show("The project not found!", MessageBoxCaptions.Warning, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region SaveHistory
        private void SaveHistory(string path)
        {
            var enumerator = from item in this._history.Files where item.ToLower().Equals(path.ToLower()) select item;
            if (enumerator.Count<string>().Equals(0))
            {
                this._history.Files.Add(path);
                this._history.Save();
            }
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */