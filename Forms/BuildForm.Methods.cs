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
using SourcePro.Csharp.Lab.ComponentModel.Trace;
using System.ComponentModel;
using SourcePro.Csharp.Lab.Commons;

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
            this.InitializeVariables();
            this.StartBackgroundJob();
        }
        #endregion

        #region RegisterControlsEventHandlers
        protected override void RegisterControlsEventHandlers()
        {
            this.CtrlBackgroundWorker_BuildJob.DoWork += new DoWorkEventHandler(CaptureBackgroundProgress);
        }
        #endregion

        #region CaptureBackgroundProgress
        private void CaptureBackgroundProgress(object sender, DoWorkEventArgs e)
        {
            this.Trace.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Start, Message = "AIEDITOR search operation is starting!" });
        }
        #endregion

        #region StartBackgroundJob
        private void StartBackgroundJob()
        {
            this.CtrlBackgroundWorker_BuildJob.RunWorkerAsync();
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */