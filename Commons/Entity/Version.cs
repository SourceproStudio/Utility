#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-26 9:49:03
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
using System.ComponentModel;
using System.Xml.Serialization;

namespace SourcePro.Csharp.Lab.Commons.Entity
{
    /// <summary>
    /// <para>
    /// 提供了访问版本信息的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Commons.Entity"/>
    /// </para>
    /// <para>
    /// Type : <see cref="Version"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Commons.Entity"/>
    [XmlRoot(ElementName = "versionInfo", Namespace = XNamespaces.NameSpace), Serializable, DefaultProperty("Major")]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Version
    {
        private int _major = 1;
        private int _minor = 0;
        private int _build = 0;
        private int _rawBuild = 0;
        private int _revision = 0;
        private int _rawRevision = 0;
        private DateTime _2000Y = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        private static readonly DateTime _today = DateTime.Now;
        private static readonly DateTime _todayZero = new DateTime(_today.Year, _today.Month, _today.Day, 0, 0, 0, 0);
        private bool _autoGenerateBuild = false;
        private bool _autoGenerateRevision = false;

        #region AutoGenerateRevision
        [Category("Generate Action"), Description("Set or get whether to automatically generate the revision version number!"), Browsable(true), ReadOnly(false), DefaultValue(false), DisplayName("Auto Generate Revision Version")]
        [XmlElement(ElementName = "autoGenerateRevision", Namespace = XNamespaces.NameSpace)]
        public bool AutoGenerateRevision
        {
            get { return _autoGenerateRevision; }
            set
            {
                _autoGenerateRevision = value;
                if (value) this.Revision = (int)(DateTime.Now - _todayZero).TotalSeconds;
                else this.Revision = this.RawRevision;
            }
        }
        #endregion

        #region AutoGenerateBuild
        [Category("Generate Action"), Description("Set or get whether to automatically generate the build version number!"), Browsable(true), ReadOnly(false), DefaultValue(false), DisplayName("Auto Generate Build Version")]
        [XmlElement(ElementName = "autoGenerateBuild", Namespace = XNamespaces.NameSpace)]
        public bool AutoGenerateBuild
        {
            get { return _autoGenerateBuild; }
            set
            {
                _autoGenerateBuild = value;
                if (value) this.Build = (int)(_today - _2000Y).TotalDays;
                else this.Build = this.RawBuild;
            }
        }
        #endregion

        #region RawRevision
        [Category("Other"), Browsable(true), ReadOnly(true), DefaultValue(0), DisplayName("Raw Revision Version")]
        [XmlAttribute(AttributeName = "rawRevision", Namespace = XNamespaces.NameSpace)]
        public int RawRevision
        {
            get { return _rawRevision; }
            set { _rawRevision = value; }
        }
        #endregion

        #region Revision
        [Category("Version"), Description("Set or get the revision version number."), Browsable(true), ReadOnly(false), DefaultValue(0), DisplayName("Revision Version")]
        [XmlElement(ElementName = "revision", Namespace = XNamespaces.NameSpace)]
        public int Revision
        {
            get { return _revision; }
            set { _revision = value; }
        }
        #endregion

        #region RawBuild
        [Category("Other"), Browsable(true), ReadOnly(true), DefaultValue(0), DisplayName("Raw Build Version")]
        [XmlAttribute(AttributeName = "rawBuild", Namespace = XNamespaces.NameSpace)]
        public int RawBuild
        {
            get { return _rawBuild; }
            set { _rawBuild = value; }
        }
        #endregion

        #region Build
        [Category("Version"), Description("Set or get the build version number."), Browsable(true), ReadOnly(false), DefaultValue(0), DisplayName("Build Version")]
        [XmlElement(ElementName = "build", Namespace = XNamespaces.NameSpace)]
        public int Build
        {
            get { return _build; }
            set { _build = value; }
        }
        #endregion

        #region Minor
        [Category("Version"), Description("Set or get the minor version number."), Browsable(true), ReadOnly(false), DefaultValue(0), DisplayName("Minor Version")]
        [XmlElement(ElementName = "minor", Namespace = XNamespaces.NameSpace)]
        public int Minor
        {
            get { return _minor; }
            set { _minor = value; }
        }
        #endregion

        #region Major
        [Category("Version"), Description("Set or get the major version number."), Browsable(true), ReadOnly(false), DefaultValue(1), DisplayName("Major Version")]
        [XmlElement(ElementName = "major", Namespace = XNamespaces.NameSpace)]
        public int Major
        {
            get { return _major; }
            set { _major = value; }
        }
        #endregion

        #region Version Constructors

        /// <summary>
        /// 用于初始化一个<see cref="Version" />对象实例。
        /// </summary>
        public Version()
        { }

        #endregion

        #region ToString
        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}.{3}", this.Major, this.Minor, this.Build, this.Revision);
        }
        #endregion

        #region SetRawValues
        public void SetRawValues()
        {
            this.RawBuild = this.Build;
            this.RawRevision = this.Revision;
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */