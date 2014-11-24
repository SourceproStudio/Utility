#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-21 10:38:48
 * Common Language Runtime : 4.0.30319.18444
 * Minimum .Net Framework Version : 4.0
 * 
 * SourcePro Studio 2014
 * Project Url : https://github.com/SourceproStudio/CodeTemplates
 * Home Page Url : https://github.com/SourceproStudio
 * E-mail Address : MasterDuner@yeah.net or Yucai.Wang-Public@outlook.com
 * QQ : 180261899
 */

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using SourcePro.Csharp.Lab.Entity;
using SourcePro.Csharp.Lab.Resources;

namespace SourcePro.Csharp.Lab.Threading
{
    /// <summary>
    /// <para>
    /// 提供了管理线程的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Threading"/>
    /// </para>
    /// <para>
    /// Type : <see cref="ThreadPoolHelper"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// <para>
    /// Can not inherit from <see cref="ThreadPoolHelper"/> !
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Threading"/>
    /// <remarks>
    /// Can not inherit from <see cref="ThreadPoolHelper"/> !
    /// </remarks>
    public sealed class ThreadPoolHelper
    {
        private ThreadArgs _arguments;
        private Dictionary<string, string> _threadMessageTemplates;

        #region ThreadMessageTemplates
        /// <summary>
        /// 获取线程消息模板。
        /// </summary>
        public Dictionary<string, string> ThreadMessageTemplates
        {
            get { return _threadMessageTemplates; }
            private set { _threadMessageTemplates = value; }
        }
        #endregion

        #region Arguments
        /// <summary>
        /// 设置或获取线程参数。
        /// </summary>
        public ThreadArgs Arguments
        {
            get { return _arguments; }
            set { _arguments = value; }
        }
        #endregion

        #region ThreadPoolHelper Constructors

        /// <summary>
        /// <para>
        /// 用于初始化一个<see cref="ThreadPoolHelper" />对象实例。
        /// </para>
        /// </summary>
        public ThreadPoolHelper()
        {
            this.ThreadMessageTemplates = ResourceReader.GetCultureResource("Thread");
        }

        #endregion

        #region Start
        /// <summary>
        /// 启动线程。
        /// </summary>
        public void Start()
        {
            if (this.Arguments.Action == Actions.SingleAssemblyInfoFile)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.UpdateSingleFile), this.Arguments.Path);
            }
            else
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.UpdateFolderFiles), this.Arguments.Path);
            }
        }
        #endregion

        #region UpdateSingleFile
        /// <summary>
        /// 更新单一程序集文件。
        /// </summary>
        /// <param name="state">状态参数。</param>
        private void UpdateSingleFile(object state)
        {
            this.Arguments.Updater.Invoke(string.Format(this.ThreadMessageTemplates["Preparing"], state), ProgressStatus.Preparing);
            StringBuilder data = new StringBuilder();
            using (FileStream fileStream = new FileStream(state.ToString(), FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                this.Arguments.Updater.Invoke(string.Format(this.ThreadMessageTemplates["Begin"], state), ProgressStatus.Begin);
                try
                {
                    this.Read(data, fileStream);
                    this.Arguments.Updater.Invoke(this.ThreadMessageTemplates["ReadEnd"], ProgressStatus.End);
                    this.Write(state.ToString(), data.ToString());
                    this.Arguments.Updater.Invoke(this.ThreadMessageTemplates["WriteEnd"], ProgressStatus.End);
                    if (this.Arguments.Action == Actions.SingleAssemblyInfoFile)
                        this.Arguments.Updater.Invoke(this.ThreadMessageTemplates["Completed"], ProgressStatus.Completed);
                }
                catch
                {
                    this.Arguments.Updater.Invoke(string.Format(this.ThreadMessageTemplates["OverwriteError"], state), ProgressStatus.Failed);
                }
                finally
                {
                    fileStream.Close();
                }
            }
        }
        #endregion

        #region UpdateFolderFiles
        /// <summary>
        /// 更新指定文件夹下所有程序集信息文件。
        /// </summary>
        /// <param name="state">目录。</param>
        private void UpdateFolderFiles(object state)
        {
            var enumerator = from item in Directory.GetFiles(state.ToString())
                             where item.ToLower().EndsWith("assemblyinfo.cs")
                             select item;
            if (enumerator.Count<string>() > 0)
            {
                foreach (string item in enumerator)
                    this.UpdateSingleFile(item);
            }
            string[] subDirectories = Directory.GetDirectories(state.ToString());
            foreach (string item in subDirectories)
                this.UpdateFolderFiles(item);
        }
        #endregion

        #region Read
        /// <summary>
        /// 读取并替换文本到<paramref name="output"/>中。
        /// </summary>
        /// <param name="output">输出文本。</param>
        /// <param name="inputStream">文件流。</param>
        private void Read(StringBuilder output, FileStream inputStream)
        {
            string version = this.Arguments.Information.Version.ToString();
            using (StreamReader reader = new StreamReader(inputStream))
            {
                try
                {
                    string line = string.Empty;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            output.Append(Environment.NewLine);
                            continue;
                        }
                        if (Regex.IsMatch(line, AssemblyInformation.GeneratorComments)) continue;
                        if (Regex.IsMatch(line, AssemblyInformation.AssemblyTitle))
                        {
                            line = string.Format("[assembly: AssemblyTitle(\"{0}\")]", this.Arguments.Information.Title);
                            output.AppendLine(line);
                            continue;
                        }
                        if (Regex.IsMatch(line, AssemblyInformation.AssemblyDescription))
                        {
                            line = string.Format("[assembly: AssemblyDescription(\"{0}\")]", this.Arguments.Information.Description);
                            output.AppendLine(line);
                            continue;
                        }
                        if (Regex.IsMatch(line, AssemblyInformation.AssemblyCompany))
                        {
                            line = string.Format("[assembly: AssemblyCompany(\"{0}\")]", this.Arguments.Information.CompanyName);
                            output.AppendLine(line);
                            continue;
                        }
                        if (Regex.IsMatch(line, AssemblyInformation.AssemblyProduct))
                        {
                            line = string.Format("[assembly: AssemblyProduct(\"{0}\")]", this.Arguments.Information.ProductName);
                            output.AppendLine(line);
                            continue;
                        }
                        if (Regex.IsMatch(line, AssemblyInformation.AssemblyCopyright))
                        {
                            line = string.Format("[assembly: AssemblyCopyright(\"{0}\")]", this.Arguments.Information.Copyright);
                            output.AppendLine(line);
                            continue;
                        }
                        if (Regex.IsMatch(line, AssemblyInformation.AssemblyTrademark))
                        {
                            line = string.Format("[assembly: AssemblyTrademark(\"{0}\")]", this.Arguments.Information.Trademark);
                            output.AppendLine(line);
                            continue;
                        }
                        if (this.Arguments.Information.Version.UpdateAssemblyVersion && AssemblyVersion.IsMatchAssemblyVersion(line))
                        {
                            line = string.Format("[assembly: AssemblyVersion(\"{0}\")]", version);
                            output.AppendLine(line);
                            continue;
                        }
                        if (this.Arguments.Information.Version.UpdateAssemblyFileVersion && Regex.IsMatch(line, AssemblyVersion.AssemblyFileVersionStr))
                        {
                            line = string.Format("[assembly: AssemblyFileVersion(\"{0}\")]", version);
                            output.AppendLine(line);
                            continue;
                        }
                        output.AppendLine(line);
                    }
                    output.AppendLine(string.Format("/*Generate By AssemblyInfoManager v{0}. Time: {1}*/",
                        typeof(ThreadPoolHelper).Assembly.GetName().Version.ToString(),
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        ));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    reader.Close();
                }
            }
        }
        #endregion

        #region Write
        /// <summary>
        /// 覆写文件。
        /// </summary>
        /// <param name="fileName">目标文件名称。</param>
        /// <param name="content">写入内容。</param>
        private void Write(string fileName, string content)
        {
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                try
                {
                    writer.Write(content);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    writer.Close();
                }
            }
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */