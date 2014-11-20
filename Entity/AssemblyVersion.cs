#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-20 15:27:41
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
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace SourcePro.Csharp.Lab.Entity
{
    /// <summary>
    /// <para>
    /// 定义了程序集版本信息。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Entity"/>
    /// </para>
    /// <para>
    /// Type : <see cref="AssemblyVersion"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// <para>
    /// Can not inherit from <see cref="AssemblyVersion"/> !
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Entity"/>
    /// <remarks>
    /// Can not inherit from <see cref="AssemblyVersion"/> !
    /// </remarks>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public sealed class AssemblyVersion
    {
        private int _major;
        private int _minor;
        private int _build;
        private bool _autoGenerateBuildNumber;
        private int _revision;
        private bool _autoGenerateRevisionNumber;
        private DateTime TodayZero = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0, 0);
        private static readonly DateTime _20000101 = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        private bool _updateAssemblyVersion;
        private bool _updateAssemblyFileVersion;
        private const string AutoBuildAndRevision = @"^\[assembly\s?:\s*AssemblyVersion\(\""(?<Major>\d+)\.(?<Minor>\d+).\*\""\)\]$";
        private const string AutoRevision = @"^\[assembly\s?:\s*AssemblyVersion\(\""(?<Major>\d+)\.(?<Minor>\d+).(?<Build>\d+).\*\""\)\]$";
        private const string AssemblyVersionStr = @"^\[assembly\s?:\s*AssemblyVersion\(\""(?<Major>\d+)\.(?<Minor>\d+).(?<Build>\d+).(?<Revision>\d+)\""\)\]$";
        private const string AssemblyFileVersionStr = @"^\[assembly\s?:\s*AssemblyFileVersion\(\""(?<Major>\d+)\.(?<Minor>\d+).(?<Build>\d+).(?<Revision>\d+)\""\)\]$";


        #region AssemblyVersion Constructors

        /// <summary>
        /// <para>
        /// 用于初始化一个<see cref="AssemblyVersion" />对象实例。
        /// </para>
        /// </summary>
        public AssemblyVersion()
        {
            this.Major = 1;
            this.Minor = 0;
            this.AutoGenerateBuildNumber = false;
            this.AutoGenerateRevisionNumber = false;
            this.Build = 0;
            this.Revision = 0;
            this.UpdateAssemblyVersion = false;
            this.UpdateAssemblyFileVersion = true;
        }

        #endregion

        #region Major
        /// <summary>
        /// 设置或获取主要版本号。
        /// </summary>
        [Description("Set or get the assembly's major version number.")]
        [Category("Version")]
        public int Major
        {
            get { return _major; }
            set { _major = value; }
        }
        #endregion

        #region Minor
        /// <summary>
        /// 设置或获取次要版本号。
        /// </summary>
        [Description("Set or get the assembly's minor version number.")]
        [Category("Version")]
        public int Minor
        {
            get { return _minor; }
            set { _minor = value; }
        }
        #endregion

        #region Build
        /// <summary>
        /// 设置或获取内部版本号。
        /// </summary>
        [Description("Set or get the assembly's build version number.")]
        [Category("Version")]
        public int Build
        {
            get { return _build; }
            set { _build = value; }
        }
        #endregion

        #region AutoGenerateBuildNumber
        [Description("Sets or gets whether to automatically generate the build number.")]
        [Category("Generate")]
        public bool AutoGenerateBuildNumber
        {
            get { return _autoGenerateBuildNumber; }
            set { _autoGenerateBuildNumber = value; }
        }
        #endregion

        #region Revision
        /// <summary>
        /// 设置或获取修正版本号。
        /// </summary>
        [Description("Set or get the assembly's revision version number.")]
        [Category("Version")]
        public int Revision
        {
            get { return _revision; }
            set { _revision = value; }
        }
        #endregion

        #region AutoGenerateRevisionNumber
        /// <summary>
        /// 设置或获取是否自动生成修正版本号。
        /// </summary>
        [Description("Sets or gets whether to automatically generate the revision number.")]
        [Category("Generate")]
        public bool AutoGenerateRevisionNumber
        {
            get { return _autoGenerateRevisionNumber; }
            set { _autoGenerateRevisionNumber = value; }
        }
        #endregion

        #region UpdateAssemblyVersion
        /// <summary>
        /// 设置或获取是否需要更新程序集版本。
        /// </summary>
        [Description("Sets or gets whether to need to update the assembly version.")]
        [Category("Update")]
        public bool UpdateAssemblyVersion
        {
            get { return _updateAssemblyVersion; }
            set { _updateAssemblyVersion = value; }
        }
        #endregion

        #region UpdateAssemblyFileVersion
        /// <summary>
        /// 设置或获取是否需要更新程序集文件版本。
        /// </summary>
        [Category("Update")]
        [Description("Sets or gets whether to need to update the assembly file version.")]
        public bool UpdateAssemblyFileVersion
        {
            get { return _updateAssemblyFileVersion; }
            set { _updateAssemblyFileVersion = value; }
        }
        #endregion

        #region GenerateBuildVersion
        /// <summary>
        /// 生成内部版本号。
        /// </summary>
        /// <returns>内部版本号。</returns>
        private int GenerateBuildVersion()
        {
            if (this.AutoGenerateBuildNumber)
            {
                this.Build = (int)(DateTime.Now - _20000101).TotalDays;
            }
            return this.Build;
        }
        #endregion

        #region GenerateRevisionVersion
        /// <summary>
        /// 生成修订版本号。
        /// </summary>
        /// <returns>修订版本号。</returns>
        private int GenerateRevisionVersion()
        {
            if (this.AutoGenerateRevisionNumber)
                this.Revision = (int)(DateTime.Now - TodayZero).TotalSeconds;
            return this.Revision;
        }
        #endregion

        #region GetVersion
        /// <summary>
        /// 获取版本信息。
        /// </summary>
        /// <returns><see cref="Version"/>对象实例。</returns>
        public Version GetVersion()
        {
            return new Version(this.Major, this.Minor, this.GenerateBuildVersion(), this.GenerateRevisionVersion());
        }
        #endregion

        #region ToString
        /// <summary>
        /// 获取版本号等效的字符串表达式。
        /// </summary>
        /// <returns>版本号字符串。</returns>
        public override string ToString()
        {
            return this.GetVersion().ToString();
        }
        #endregion

        #region Create
        /// <summary>
        /// 使用字符串创建一个<see cref="AssemblyVersion"/>对象实例。
        /// </summary>
        /// <param name="s">字符串。</param>
        /// <returns><see cref="AssemblyVersion"/>对象实例。</returns>
        static public AssemblyVersion Create(string s)
        {
            Match match = null;
            if (Regex.IsMatch(s, AutoBuildAndRevision))
            {
                match = Regex.Match(s, AutoBuildAndRevision);
                return new AssemblyVersion()
                {
                    Major = int.Parse(match.Groups["Major"].Value),
                    Minor = int.Parse(match.Groups["Minor"].Value),
                    AutoGenerateBuildNumber = true,
                    AutoGenerateRevisionNumber = true
                };
            }
            else if (Regex.IsMatch(s, AutoRevision))
            {
                match = Regex.Match(s, AutoRevision);
                return new AssemblyVersion()
                {
                    Major = int.Parse(match.Groups["Major"].Value),
                    Minor = int.Parse(match.Groups["Minor"].Value),
                    Build = int.Parse(match.Groups["Build"].Value),
                    AutoGenerateRevisionNumber = true,
                    AutoGenerateBuildNumber = false
                };
            }
            else if (Regex.IsMatch(s, AssemblyVersionStr))
            {
                match = Regex.Match(s, AssemblyVersionStr);
                return new AssemblyVersion()
                {
                    Major = int.Parse(match.Groups["Major"].Value),
                    Minor = int.Parse(match.Groups["Minor"].Value),
                    Build = int.Parse(match.Groups["Build"].Value),
                    Revision = int.Parse(match.Groups["Revision"].Value),
                    AutoGenerateRevisionNumber = false,
                    AutoGenerateBuildNumber = false
                };
            }
            else return new AssemblyVersion();
        }
        #endregion

        #region IsMatchAssemblyVersion
        /// <summary>
        /// 验证字符串<paramref name="s"/>是否是匹配的程序集版本描述表达式。
        /// </summary>
        /// <param name="s">字符串。</param>
        /// <returns>是否匹配。</returns>
        static public bool IsMatchAssemblyVersion(string s)
        {
            return !string.IsNullOrWhiteSpace(s) && (Regex.IsMatch(s, AutoBuildAndRevision) || Regex.IsMatch(s, AutoRevision) || Regex.IsMatch(s, AssemblyVersionStr));
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */