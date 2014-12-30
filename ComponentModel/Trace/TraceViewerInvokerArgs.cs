#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-30 14:19:07
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
using SourcePro.Csharp.Lab.Commons;
using System.Text;

namespace SourcePro.Csharp.Lab.ComponentModel.Trace
{
    /// <summary>
    /// <para>
    /// Description
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.ComponentModel.Trace"/>
    /// </para>
    /// <para>
    /// Type : <see cref="TraceViewerInvokerArgs"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.ComponentModel.Trace"/>
    public class TraceViewerInvokerArgs
    {
        private JobProgress _status;
        private string _message;

        #region Status
        public JobProgress Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        #region Message
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        #endregion

        #region ToString
        override public string ToString()
        {
            StringBuilder msgBuilder = new StringBuilder();
            msgBuilder.AppendFormat("Status : {0}{1}Message : {2}{1}Time : {3}{1}{1}", this.Status, Environment.NewLine, this.Message, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            return msgBuilder.ToString();
        }
        #endregion

        #region TraceViewerInvoker Constructors

        /// <summary>
        /// 用于初始化一个<see cref="TraceViewerInvokerArgs" />对象实例。
        /// </summary>
        public TraceViewerInvokerArgs()
        { }

        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */