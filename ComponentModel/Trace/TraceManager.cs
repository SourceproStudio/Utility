#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-30 16:31:23
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
using System.Windows.Forms;
using SourcePro.Csharp.Lab.Commons;

namespace SourcePro.Csharp.Lab.ComponentModel.Trace
{
    /// <summary>
    /// <para>
    /// 提供了输出状态信息的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.ComponentModel.Trace"/>
    /// </para>
    /// <para>
    /// Type : <see cref="TraceManager"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.ComponentModel.Trace"/>
    public class TraceManager
    {
        private RichTextBox _console;
        private TraceViewerInvoker _event;

        #region Console
        public RichTextBox Console
        {
            get { return _console; }
            set { _console = value; }
        }
        #endregion

        #region Event
        private TraceViewerInvoker Event
        {
            get { return _event; }
            set { _event = value; }
        }
        #endregion

        #region TraceManager Constructors

        /// <summary>
        /// 用于初始化一个<see cref="TraceManager" />对象实例。
        /// </summary>
        public TraceManager()
        {
            this.Event = new TraceViewerInvoker(this.InternalOutput);
        }

        #endregion

        #region Output
        public void Output(TraceViewerInvokerArgs args)
        {
            this.Event.Invoke(args);
        }
        #endregion

        #region InternalOutput
        private void InternalOutput(TraceViewerInvokerArgs args)
        {
            if (this.Console.InvokeRequired) this.Console.Invoke(this.Event, args);
            else
            {
                this.Console.AppendText(args.ToString());
                this.Console.ScrollToCaret();
            }
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */