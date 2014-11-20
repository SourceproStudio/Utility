#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-20 16:23:34
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

using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;

namespace SourcePro.Csharp.Lab.Entity
{
    /// <summary>
    /// <para>
    /// 定义了程序集信息实体。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Entity"/>
    /// </para>
    /// <para>
    /// Type : <see cref="AssemblyInformation"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// <para>
    /// Can not inherit from <see cref="AssemblyInformation"/> !
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Entity"/>
    /// <remarks>
    /// Can not inherit from <see cref="AssemblyInformation"/> !
    /// </remarks>
    public sealed class AssemblyInformation
    {
        private AssemblyVersion _version;
        private string _title;
        private string _description;
        private string _companyName;
        private string _productName;
        private string _copyright;
        private string _trademark;
        private const string AssemblyTitle = @"^\[assembly\s?:\s*AssemblyTitle\(\""(?<AssemblyTitle>[\u0020\u0021\u0023-\uFFFF]*)\""\)]";
        private const string AssemblyDescription = @"^\[assembly\s?:\s*AssemblyDescription\(\""(?<AssemblyDescription>[\u0020\u0021\u0023-\uFFFF]*)\""\)]";
        private const string AssemblyCompany = @"^\[assembly\s?:\s*AssemblyCompany\(\""(?<AssemblyCompany>[\u0020\u0021\u0023-\uFFFF]*)\""\)]";
        private const string AssemblyProduct = @"^\[assembly\s?:\s*AssemblyProduct\(\""(?<AssemblyProduct>[\u0020\u0021\u0023-\uFFFF]*)\""\)]";
        private const string AssemblyCopyright = @"^\[assembly\s?:\s*AssemblyCopyright\(\""(?<AssemblyCopyright>[\u0020\u0021\u0023-\uFFFF]*)\""\)]";
        private const string AssemblyTrademark = @"^\[assembly\s?:\s*AssemblyTrademark\(\""(?<AssemblyTrademark>[\u0020\u0021\u0023-\uFFFF]*)\""\)]";

        #region AssemblyInformation Constructors

        /// <summary>
        /// <para>
        /// 用于初始化一个<see cref="AssemblyInformation" />对象实例。
        /// </para>
        /// </summary>
        public AssemblyInformation()
        {
            this.Version = new AssemblyVersion();
        }

        #endregion

        #region Version
        /// <summary>
        /// 设置或获取程序集版本信息。
        /// </summary>
        [Description("Set or get the assembly's version information.")]
        [Category("Base Information")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public AssemblyVersion Version
        {
            get { return _version; }
            set { _version = value; }
        }
        #endregion

        #region Title
        /// <summary>
        /// 设置或获取程序集标题。
        /// </summary>
        [Description("Set or get the assembly's title.")]
        [Category("Base Information")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        #endregion

        #region Description
        /// <summary>
        /// 设置或获取程序集的描述信息。
        /// </summary>
        [Description("Set or get the assembly's description.")]
        [Category("Base Information")]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        #endregion

        #region CompanyName
        /// <summary>
        /// 设置或获取发布程序集的公司名称。
        /// </summary>
        [Description("Set or get the publishing company name of the assembly.")]
        [Category("Base Information")]
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        #endregion

        #region ProductName
        /// <summary>
        /// 设置或获取产品名称。
        /// </summary>
        [Description("Set or set product name of the assembly.")]
        [Category("Base Information")]
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        #endregion

        #region Copyright
        /// <summary>
        /// 设置或获取程序集的版权声明。
        /// </summary>
        [Description("Set or get copyright declaration of the assembly.")]
        [Category("Base Information")]
        public string Copyright
        {
            get { return _copyright; }
            set { _copyright = value; }
        }
        #endregion

        #region Trademark
        /// <summary>
        /// 设置或获取程序集的商标。
        /// </summary>
        [Description("Set or get trademark of the assembly.")]
        [Category("Base Information")]
        public string Trademark
        {
            get { return _trademark; }
            set { _trademark = value; }
        }
        #endregion

        #region Create
        /// <summary>
        /// 从模板文件创建<see cref="AssemblyInformation"/>对象实例。
        /// </summary>
        /// <param name="fileName">模板文件名称。</param>
        /// <returns><see cref="AssemblyInformation"/>对象实例。</returns>
        static public AssemblyInformation Create(string fileName)
        {
            AssemblyInformation info = new AssemblyInformation();
            if (!File.Exists(fileName))
            {
                return info;
            }
            else
            {
                using (Stream templateStream = File.OpenRead(fileName))
                {
                    using (StreamReader reader = new StreamReader(templateStream))
                    {
                        try
                        {
                            while (!reader.EndOfStream)
                            {
                                SetProperties(reader.ReadLine(), info);
                            }
                        }
                        finally
                        {
                            reader.Close();
                            templateStream.Close();
                        }
                    }
                }
            }
            return info;
        }
        #endregion

        #region SetProperties
        /// <summary>
        /// 设置属性值。
        /// </summary>
        /// <param name="s">当前行的文本内容。</param>
        /// <param name="instance">新创建的<see cref="AssemblyInformation"/>对象实例。</param>
        private static void SetProperties(string s, AssemblyInformation instance)
        {
            if (!string.IsNullOrWhiteSpace(s))
            {
                if (Regex.IsMatch(s, AssemblyTitle)) instance.Title = Regex.Match(s, AssemblyTitle).Groups["AssemblyTitle"].Value;
                if (Regex.IsMatch(s, AssemblyDescription)) instance.Description = Regex.Match(s, AssemblyDescription).Groups["AssemblyDescription"].Value;
                if (Regex.IsMatch(s, AssemblyCompany)) instance.CompanyName = Regex.Match(s, AssemblyCompany).Groups["AssemblyCompany"].Value;
                if (Regex.IsMatch(s, AssemblyProduct)) instance.ProductName = Regex.Match(s, AssemblyProduct).Groups["AssemblyProduct"].Value;
                if (Regex.IsMatch(s, AssemblyCopyright)) instance.Copyright = Regex.Match(s, AssemblyCopyright).Groups["AssemblyCopyright"].Value;
                if (Regex.IsMatch(s, AssemblyTrademark)) instance.Trademark = Regex.Match(s, AssemblyTrademark).Groups["AssemblyTrademark"].Value;
                if (AssemblyVersion.IsMatchAssemblyVersion(s)) instance.Version = AssemblyVersion.Create(s);
            }
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */