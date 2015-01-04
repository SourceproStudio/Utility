#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-31 11:31:49
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
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;
using SourcePro.Csharp.Lab.Commons.Entity;
using SourcePro.Csharp.Lab.ComponentModel.Trace;
using Ex = System.Text.RegularExpressions.Regex;

namespace SourcePro.Csharp.Lab.Commons.RegularExpressions
{
    /// <summary>
    /// <para>
    /// 提供了正则表达式匹配的基本方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Commons.RegularExpressions"/>
    /// </para>
    /// <para>
    /// Type : <see cref="Regex"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Commons.RegularExpressions"/>
    public class Regex
    {
        private Dictionary<RegexCategory, string> _expressions;
        private XmlDocument _xConfigure;
        private static readonly string ConfigFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "aieditor.regex.xml");
        private XmlNamespaceManager _xNamespaces;
        private string _xmlns;
        private string _specifiedFileName;
        private Platform _platform;
        private string _commentRegexpr;

        #region CommentRegexpr
        private string CommentRegexpr
        {
            get { return _commentRegexpr; }
            set { _commentRegexpr = value; }
        }
        #endregion

        #region SpecifiedFileName
        private string SpecifiedFileName
        {
            get { return _specifiedFileName; }
            set { _specifiedFileName = value; }
        }
        #endregion

        #region Expressions
        private Dictionary<RegexCategory, string> Expressions
        {
            get { return _expressions; }
            set { _expressions = value; }
        }
        #endregion

        #region XConfigure
        private XmlDocument XConfigure
        {
            get { return _xConfigure; }
            set { _xConfigure = value; }
        }
        #endregion

        #region XNamespaces
        private XmlNamespaceManager XNamespaces
        {
            get { return _xNamespaces; }
            set { _xNamespaces = value; }
        }
        #endregion

        #region Xmlns
        private string Xmlns
        {
            get { return _xmlns; }
            set { _xmlns = value; }
        }
        #endregion

        #region Platform
        private Platform Platform
        {
            get { return _platform; }
            set { _platform = value; }
        }
        #endregion

        #region Regex Constructors

        /// <summary>
        /// 用于初始化一个<see cref="Regex" />对象实例。
        /// </summary>
        /// <param name="platform"><see cref="Platform"/>中的一个值。</param>
        public Regex(Platform platform)
        {
            this.Platform = platform;
            this.InitializeXmlnsPrefix(platform);
            this.Expressions = new Dictionary<RegexCategory, string>();
            if (!File.Exists(ConfigFile)) throw new FileNotFoundException("The regularexpressions config file not found!", ConfigFile);
            this.XConfigure = new XmlDocument();
            this.XConfigure.Load(ConfigFile);
            this.XNamespaces = new XmlNamespaceManager(this.XConfigure.NameTable);
            this.XNamespaces.AddNamespace("wyc", "https://github.com/SourceproStudio");
            this.XNamespaces.AddNamespace(this.Xmlns, string.Format("urn:{0}", platform));
            this.InitializeExpressions();
        }

        #endregion

        #region InitializeXmlnsPrefix
        private void InitializeXmlnsPrefix(Platform platform)
        {
            switch (platform)
            {
                case Platform.CsharpAndVB:
                    this.Xmlns = "all";
                    this.SpecifiedFileName = "AssemblyInfo.cs or AssemblyInfo.vb";
                    break;
                case Platform.Csharp:
                    this.Xmlns = "cs";
                    this.SpecifiedFileName = "AssemblyInfo.cs";
                    break;
                case Platform.VisualBasic:
                    this.Xmlns = "vb";
                    this.SpecifiedFileName = "AssemblyInfo.vb";
                    break;
            }
        }
        #endregion

        #region InitializeExpressions
        private void InitializeExpressions()
        {
            XmlNodeList xNodes = this.XConfigure.SelectNodes(string.Format("{0}:sourcepro.utility.aieditor/{0}:regularExpressions/{0}:regex", "wyc"), this.XNamespaces);
            foreach (XmlNode item in xNodes)
            {
                RegexCategory category = (RegexCategory)Enum.Parse(typeof(RegexCategory), item.Attributes["wyc:category"].Value);
                this.Expressions.Add(category,
                    item.SelectSingleNode(string.Format("{0}:text", this.Xmlns), this.XNamespaces).InnerText);
            }
            this.CommentRegexpr = this.XConfigure.SelectSingleNode(string.Format("{0}:sourcepro.utility.aieditor/{0}:regularExpressions", "wyc"), this.XNamespaces).Attributes["all:comment"].Value;
        }
        #endregion

        #region ValidateFileExtensionName
        public bool ValidateFileExtensionName(FileInfo file, TraceManager output)
        {
            output.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Doing, Message = string.Format("Validating the [{0}] extension.", file.FullName) });
            bool isMatch = Ex.IsMatch(file.Name, this.Expressions[RegexCategory.FileFilter], RegexOptions.IgnoreCase);
            if (!isMatch)
                output.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Skip, Message = string.Format("The file name [{0}] is not equal to {1}, so skip it!", file.FullName, this.SpecifiedFileName) });
            return isMatch;
        }
        #endregion

        #region MatchAndReplace
        public string MatchAndReplace(bool isVisualBasic, string text, TraceManager output, AssemblyInformation info)
        {
            output.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Reading | JobProgress.Doing, Message = "Reading files, and perform the matching and replacement!" });
            string expr = this.Expressions[RegexCategory.AssemblyTitle];
            string template = isVisualBasic ? "<Assembly: {0}(\"{1}\")>" : "[assembly: {0}(\"{1}\")]";
            if (Ex.IsMatch(text, expr))
                text = Ex.Replace(text, expr, string.Format(template, RegexCategory.AssemblyTitle, info.Title));
            expr = this.Expressions[RegexCategory.AssemblyDescription];
            if (Ex.IsMatch(text, expr))
                text = Ex.Replace(text, expr, string.Format(template, RegexCategory.AssemblyDescription, info.Description));
            expr = this.Expressions[RegexCategory.AssemblyCompany];
            if (Ex.IsMatch(text, expr))
                text = Ex.Replace(text, expr, string.Format(template, RegexCategory.AssemblyCompany, info.Manufacturer));
            expr = this.Expressions[RegexCategory.AssemblyProduct];
            if (Ex.IsMatch(text, expr))
                text = Ex.Replace(text, expr, string.Format(template, RegexCategory.AssemblyProduct, info.ProductName));
            expr = this.Expressions[RegexCategory.AssemblyCopyright];
            if (Ex.IsMatch(text, expr))
                text = Ex.Replace(text, expr, string.Format(template, RegexCategory.AssemblyCopyright, info.CopyrightDeclaration));
            expr = this.Expressions[RegexCategory.AssemblyTrademark];
            if (Ex.IsMatch(text, expr))
                text = Ex.Replace(text, expr, string.Format(template, RegexCategory.AssemblyTrademark, info.Trademark));
            expr = this.Expressions[RegexCategory.AssemblyVersion];
            if (info.GenerateAssemblyVersion && Ex.IsMatch(text, expr))
                text = Ex.Replace(text, expr, string.Format(template, RegexCategory.AssemblyVersion, info.Version.ToString()));
            expr = this.Expressions[RegexCategory.AssemblyFileVersion];
            if (info.GenerateAssemblyFileVersion && Ex.IsMatch(text, expr))
                text = Ex.Replace(text, expr, string.Format(template, RegexCategory.AssemblyFileVersion, info.FileVersion.ToString()));
            string comment = string.Format("/*Generate By AssemblyInfo Editor {0}, Update Time {1}*/", Assembly.GetExecutingAssembly().GetName().Version, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            if (Ex.IsMatch(text, this.CommentRegexpr))
                text = Ex.Replace(text, this.CommentRegexpr, comment);
            else text = string.Format("{0}{1}{1}{2}", text, Environment.NewLine, comment);
            output.Output(new TraceViewerInvokerArgs() { Status = JobProgress.Successful, Message = "Matching and replacement complete!" });
            return text;
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */