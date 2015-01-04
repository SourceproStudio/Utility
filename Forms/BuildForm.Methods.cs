#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-30 13:39:06
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
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SourcePro.Csharp.Lab.Commons;
using SourcePro.Csharp.Lab.Commons.Entity;
using SourcePro.Csharp.Lab.Commons.RegularExpressions;
using SourcePro.Csharp.Lab.ComponentModel.Trace;

namespace SourcePro.Csharp.Lab.Forms
{
    /// <summary>
    /// <para>
    /// 提供了处理BuildForm逻辑的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Forms"/>
    /// </para>
    /// <para>
    /// Type : <see cref="BuildForm"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Forms"/>
    partial class BuildForm
    {
        private Regex _regex;

        #region InitializeVariables
        private void InitializeVariables()
        {
            this.Trace = new TraceManager() { Console = this.CtrlRichTextBox_Progress };
        }
        #endregion

        #region InitializeControls
        protected override void InitializeControls()
        {
            base.InitializeControls();
            this.SetProgressImageVisible(true);
            this.InitializeVariables();
            this._regex = new Regex(this.AssemblyInformation.PlatformID);
            this.StartBackgroundJob();
        }
        #endregion

        #region RegisterControlsEventHandlers
        protected override void RegisterControlsEventHandlers()
        {
            this.CtrlButton_Cancel.Click += new EventHandler(RequestCancelBackgroundJob);
            this.CtrlButton_Close.Click += new EventHandler(CloseThisForm);
        }
        #endregion

        #region CloseThisForm
        private void CloseThisForm(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region RequestCancelBackgroundJob
        private void RequestCancelBackgroundJob(object sender, EventArgs e)
        {
            this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Cancel, Message = "Try cancel !" });
            try
            {
                this.BackgroundJob.Abort();
                this.CtrlButton_Cancel.Enabled = false;
                this.CtrlButton_Close.Enabled = true;
                this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Abort, Message = "The background job was abort !" });
            }
            catch (Exception)
            {
                this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Failed, Message = "Unabled to cancel background job !" });
            }
        }
        #endregion

        #region CaptureBackgroundProgress
        private void CaptureBackgroundProgress()
        {
            this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Start, Message = "AIEDITOR search operation is starting!" });
            if (this.AssemblyInformation.IncludeFolders.Count > 0)
            {
                foreach (FolderProperty item in this.AssemblyInformation.IncludeFolders)
                {
                    this.SearchIncludedFolder(new DirectoryInfo(item.SelectedPath), item.IncludeSubDirectories);
                }
            }
            else this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Skip, Message = "You do not set the folder you want to search!" });
            this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.End, Message = "AIEDITOR search opeartion is completed !" });
            new MethodInvoker(this.AfterCompletedCallback).Invoke();
        }
        #endregion

        #region AfterCompletedCallback
        private void AfterCompletedCallback()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(this.AfterCompletedCallback));
            else
            {
                this.CtrlButton_Close.Enabled = true;
                this.CtrlButton_Cancel.Enabled = false;
            }
        }
        #endregion

        #region StartBackgroundJob
        private void StartBackgroundJob()
        {
            this.BackgroundJob = new Thread(new ThreadStart(this.CaptureBackgroundProgress));
            this.BackgroundJob.Start();
        }
        #endregion

        #region SetProgressImageVisible
        private void SetProgressImageVisible(bool visible)
        {
            this.CtrlPictureBox_Progress.Visible = visible;
        }
        #endregion

        #region SearchIncludedFolder
        private void SearchIncludedFolder(DirectoryInfo folder, bool includeSubs)
        {
            this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Searching, Message = string.Format("Now searching the folder [{0}]", folder.FullName) });
            if (!this.IsExcludedFolder(folder.FullName))
            {
                this.ScanEveryFile(folder);
                DirectoryInfo[] subs = folder.GetDirectories();
                if (includeSubs && subs.Length > 0)
                {
                    foreach (DirectoryInfo item in subs) this.SearchIncludedFolder(item, includeSubs);
                }
            }
            else this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Skip, Message = string.Format("This folder [{0}] is excluded outside the search scope!", folder.FullName) });
        }
        #endregion

        #region IsExcludedFolder
        private bool IsExcludedFolder(string path)
        {
            var enumerator = from item in this.AssemblyInformation.ExcludeFolders where item.SelectedPath.ToLower().Equals(path.ToLower()) select item;
            return enumerator.Count<FolderProperty>() > 0;
        }
        #endregion

        #region ScanEveryFile
        private void ScanEveryFile(DirectoryInfo directory)
        {
            FileInfo[] files = directory.GetFiles();
            foreach (var item in files)
            {
                if (this._regex.ValidateFileExtensionName(item, this.Trace))
                {
                    bool error = false;
                    string content = this.ReadAndReplace(item, out error);
                    if (!error)
                    {
                        this.Save(item, content);
                        this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Successful | JobProgress.Writing, Message = "Update completed !" });
                    }
                    else this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Skip, Message = string.Format("Skip the file [{0}] !", item.FullName) });
                }
            }
        }
        #endregion

        #region ReadAndReplace
        private string ReadAndReplace(FileInfo file, out bool error)
        {
            StringBuilder str = new StringBuilder();
            error = false;
            using (Stream stream = file.OpenRead())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    try
                    {
                        str.Append(this._regex.MatchAndReplace(file.Extension.TrimStart('.').ToLower().Equals("vb"), reader.ReadToEnd(), this.Trace, this.AssemblyInformation));
                    }
                    catch (Exception)
                    {
                        this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Failed, Message = string.Format("Exception thrown when reading the file [{0}]!", file.FullName) });
                        error = true;
                    }
                    finally
                    {
                        reader.Close();
                        stream.Close();
                    }
                }
            }
            return str.ToString();
        }
        #endregion

        #region Save
        private void Save(FileInfo destination, string text)
        {
            this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Writing | JobProgress.Doing, Message = string.Format("Updating file [{0}] !", destination.FullName) });
            using (Stream stream = new FileStream(destination.FullName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    try
                    {
                        writer.Write(text);
                    }
                    catch (Exception)
                    {
                        this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Failed | JobProgress.Writing, Message = "Update failed !" });
                    }
                    finally
                    {
                        writer.Close();
                        stream.Close();
                    }
                }
            }
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */