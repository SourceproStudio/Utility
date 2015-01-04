#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-30 13:37:12
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

using System.Threading;
using SourcePro.Csharp.Lab.Commons.Entity;
using SourcePro.Csharp.Lab.ComponentModel.Trace;

namespace SourcePro.Csharp.Lab.Forms
{
    /// <summary>
    /// <para>
    /// 定义了<see cref="BuildForm"/>所需的变量和属性。
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
        private AssemblyInformation _assemblyInformation;
        private TraceManager _trace;
        private Thread _backgroundJob;

        #region BackgroundJob
        private Thread BackgroundJob
        {
            get { return _backgroundJob; }
            set { _backgroundJob = value; }
        }
        #endregion

        #region AssemblyInformation
        public AssemblyInformation AssemblyInformation
        {
            get { return _assemblyInformation; }
            set { _assemblyInformation = value; }
        }
        #endregion

        #region Trace
        private TraceManager Trace
        {
            get { return _trace; }
            set { _trace = value; }
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */