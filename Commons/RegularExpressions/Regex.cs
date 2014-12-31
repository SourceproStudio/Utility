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
using System.Xml;
using System.IO;

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

        #region Regex Constructors

        /// <summary>
        /// 用于初始化一个<see cref="Regex" />对象实例。
        /// </summary>
        /// <param name="platform"><see cref="Platform"/>中的一个值。</param>
        public Regex(Platform platform)
        {
            this.InitializeXmlnsPrefix(platform);
            this.Expressions = new Dictionary<RegexCategory, string>();
            if (!File.Exists(ConfigFile)) throw new FileNotFoundException("The regularexpressions config file not found!", ConfigFile);
            this.XConfigure = new XmlDocument();
            this.XConfigure.Load(ConfigFile);
            this.XNamespaces = new XmlNamespaceManager(this.XConfigure.NameTable);
            this.XNamespaces.AddNamespace("wyc", "https://github.com/SourceproStudio");
            this.XNamespaces.AddNamespace(this.Xmlns, string.Format("urn:{0}", platform));
        }

        #endregion

        #region InitializeXmlnsPrefix
        private void InitializeXmlnsPrefix(Platform platform)
        {
            switch (platform)
            {
                case Platform.CsharpAndVB: this.Xmlns = "all"; break;
                case Platform.Csharp: this.Xmlns = "cs"; break;
                case Platform.VisualBasic: this.Xmlns = "vb"; break;
            }
        }
        #endregion

        #region InitializeExpressions
        private void InitializeExpressions()
        {
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */