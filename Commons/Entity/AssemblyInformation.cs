#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-26 10:23:05
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
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Xml.Serialization;
using SourcePro.Csharp.Lab.ComponentModel.Design;

namespace SourcePro.Csharp.Lab.Commons.Entity
{
    /// <summary>
    /// <para>
    /// 提供了访问程序集信息的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Commons.Entity"/>
    /// </para>
    /// <para>
    /// Type : <see cref="AssemblyInformation"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Commons.Entity"/>
    [XmlRoot(ElementName = "sourcepro.aieditor", Namespace = XNamespaces.NameSpace), Serializable, DefaultProperty("Title")]
    public class AssemblyInformation : BaseEntity
    {
        private string _title = string.Empty;
        private string _description = string.Empty;
        private string _manufacturer = string.Empty;
        private string _productName = string.Empty;
        private string _copyrightDeclaration = string.Empty;
        private string _trademark = string.Empty;
        private Platform _platformID = Platform.Csharp;
        private Version _version = new Version();
        private Version _fileVersion = new Version();
        private bool _generateAssemblyVersion = false;
        private bool _generateAssemblyFileVersion = true;
        private List<FolderProperty> _includeFolders = new List<FolderProperty>();
        private List<FolderProperty> _excludeFolders = new List<FolderProperty>();
        private string _name = string.Empty;
        private string _storagePath;
        private bool _keepAssemblyFileVersionSynchronized = false;

        #region KeepAssemblyFileVersionSynchronized
        [Category("Generate Actions"), Description("Set or get : Do you want to keep synchronized version of the file and the assembly version."), DisplayName("Synchronized"), Browsable(true), ReadOnly(false), DefaultValue(false)]
        [XmlIgnore]
        public bool KeepAssemblyFileVersionSynchronized
        {
            get { return _keepAssemblyFileVersionSynchronized; }
            set
            {
                _keepAssemblyFileVersionSynchronized = value;
                if (value)
                {
                    this.Version.Major = this.FileVersion.Major;
                    this.Version.Minor = this.FileVersion.Minor;
                    this.Version.Build = this.FileVersion.Build;
                    this.Version.Revision = this.FileVersion.Revision;
                }
            }
        }
        #endregion

        #region StoragePath
        [Category("Project"), Description("Set or get the project storage path."), DisplayName("Save Path"), Browsable(true), ReadOnly(true)]
        [XmlAttribute(AttributeName = "projSaveDirectory", Namespace = XNamespaces.NameSpace)]
        public string StoragePath
        {
            get { return _storagePath; }
            set { _storagePath = value; }
        }
        #endregion

        #region Name
        [Category("Project"), Description("Set or get the project's name."), DisplayName("Name"), Browsable(true), ReadOnly(false)]
        [XmlAttribute(AttributeName = "projName", Namespace = XNamespaces.NameSpace)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region ExcludeFolders
        [Category("Generate Actions"), Description("Set or get the collection of directories excluded from the search scope."), DisplayName("Exclude Folders"), Browsable(true), ReadOnly(false)]
        [XmlArray(ElementName = "excludeFolders", Namespace = XNamespaces.NameSpace)]
        [XmlArrayItem(ElementName = "folder", Namespace = XNamespaces.NameSpace)]
        [Editor(typeof(FolderCollectionEditor), typeof(CollectionEditor))]
        public List<FolderProperty> ExcludeFolders
        {
            get { return _excludeFolders; }
            set { _excludeFolders = value; }
        }
        #endregion

        #region IncludeFolders
        [Category("Generate Actions"), Description("Set or get whether the collection of directories to search."), DisplayName("Include Folders"), Browsable(true), ReadOnly(false)]
        [XmlArray(ElementName = "includeFolders", Namespace = XNamespaces.NameSpace)]
        [XmlArrayItem(ElementName = "folder", Namespace = XNamespaces.NameSpace)]
        [Editor(typeof(FolderCollectionEditor), typeof(CollectionEditor))]
        public List<FolderProperty> IncludeFolders
        {
            get { return _includeFolders; }
            set { _includeFolders = value; }
        }
        #endregion

        #region GenerateAssemblyFileVersion
        [Category("Generate Actions"), Description("Set or get whether to rebuild the assembly file version number."), DisplayName("Generate New Assembly File Version"), Browsable(true), ReadOnly(false), DefaultValue(true)]
        [XmlAttribute(AttributeName = "generateNewAssemblyFileVersion", Namespace = XNamespaces.NameSpace)]
        public bool GenerateAssemblyFileVersion
        {
            get { return _generateAssemblyFileVersion; }
            set { _generateAssemblyFileVersion = value; }
        }
        #endregion

        #region GenerateAssemblyVersion
        [Category("Generate Actions"), Description("Set or get whether to rebuild the assembly version number."), DisplayName("Generate New Assembly Version"), Browsable(true), ReadOnly(false), DefaultValue(false)]
        [XmlAttribute(AttributeName = "generateNewAssemblyVersion", Namespace = XNamespaces.NameSpace)]
        public bool GenerateAssemblyVersion
        {
            get { return _generateAssemblyVersion; }
            set { _generateAssemblyVersion = value; }
        }
        #endregion

        #region FileVersion
        [Category("Assembly Information"), Description("Set or get the assembly's file version."), DisplayName("Assembly File Version"), Browsable(true), ReadOnly(false)]
        [XmlElement(ElementName = "assemblyFileVersion", Namespace = XNamespaces.NameSpace)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Version FileVersion
        {
            get { return _fileVersion; }
            set { _fileVersion = value; }
        }
        #endregion

        #region Version
        [Category("Assembly Information"), Description("Set or get the assembly's version."), DisplayName("Assembly Version"), Browsable(true), ReadOnly(false)]
        [XmlElement(ElementName = "assemblyVersion", Namespace = XNamespaces.NameSpace)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Version Version
        {
            get { return _version; }
            set { _version = value; }
        }
        #endregion

        #region PlatformID
        [Category("Generate Actions"), Description("Set or get the target platform."), DisplayName("Target Platform"), Browsable(true), ReadOnly(false), DefaultValue(Platform.Csharp)]
        [XmlAttribute(AttributeName = "targetGeneratePlatform", Namespace = XNamespaces.NameSpace)]
        public Platform PlatformID
        {
            get { return _platformID; }
            set { _platformID = value; }
        }
        #endregion

        #region Trademark
        [Category("Assembly Information"), Description("Set or get the assembly's trademark."), DisplayName("Assembly Trademark"), Browsable(true), ReadOnly(false), DefaultValue(".NET AssemblyInfo Editor™")]
        [XmlElement(ElementName = "assemblyTrademark", Namespace = XNamespaces.NameSpace)]
        public string Trademark
        {
            get { return _trademark; }
            set { _trademark = value; }
        }
        #endregion

        #region CopyrightDeclaration
        [Category("Assembly Information"), Description("Set or get the assembly's copyright."), DisplayName("Assembly Copyright Declaration"), Browsable(true), ReadOnly(false), DefaultValue("Copyright © 2014 Wang Yucai. All rights reserved.")]
        [XmlElement(ElementName = "assemblyCopyright", Namespace = XNamespaces.NameSpace)]
        public string CopyrightDeclaration
        {
            get { return _copyrightDeclaration; }
            set { _copyrightDeclaration = value; }
        }
        #endregion

        #region ProductName
        [Category("Assembly Information"), Description("Set or get the assembly's product name."), DisplayName("Assembly ProductName"), Browsable(true), ReadOnly(false)]
        [XmlElement(ElementName = "assemblyProductName", Namespace = XNamespaces.NameSpace)]
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        #endregion

        #region Manufacturer
        [Category("Assembly Information"), Description("Set or get the assembly's manufacturer."), DisplayName("Assembly Manufacturer"), Browsable(true), ReadOnly(false), DefaultValue("SourcePro Studio")]
        [XmlElement(ElementName = "assemblyManufacturer", Namespace = XNamespaces.NameSpace)]
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
        #endregion

        #region Description
        [Category("Assembly Information"), Description("Set or get the assembly's description."), DisplayName("Assembly Description"), Browsable(true), ReadOnly(false)]
        [XmlElement(ElementName = "assemblyDescription", Namespace = XNamespaces.NameSpace)]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        #endregion

        #region Title
        [Category("Assembly Information"), Description("Set or get the assembly's title."), DisplayName("Assembly Title"), Browsable(true), ReadOnly(false)]
        [XmlElement(ElementName = "assemblyTitle", Namespace = XNamespaces.NameSpace)]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        #endregion

        #region AssemblyInformation Constructors

        /// <summary>
        /// 用于初始化一个<see cref="AssemblyInformation" />对象实例。
        /// </summary>
        public AssemblyInformation()
            : base()
        { }

        #endregion

        #region Save
        public void Save(string path, bool isCreate)
        {
            if (isCreate) this.StoragePath = path;
            using (Stream outputStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                try
                { this.Serialize(outputStream); }
                finally { outputStream.Close(); }
            }
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */