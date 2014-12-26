#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-26 11:02:27
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
using System.Xml.Serialization;
using System.ComponentModel;
using SourcePro.Csharp.Lab.ComponentModel.Design;
using System.Drawing.Design;

namespace SourcePro.Csharp.Lab.Commons.Entity
{
    /// <summary>
    /// <para>
    /// 提供了访问文件夹属性信息的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Commons.Entity"/>
    /// </para>
    /// <para>
    /// Type : <see cref="FolderProperty"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Commons.Entity"/>
    [XmlRoot(ElementName = "folder", Namespace = XNamespaces.NameSpace), Serializable, DefaultProperty("SelectedPath")]
    public class FolderProperty
    {
        private string _selectedPath = string.Empty;
        private bool _includeSubDirectories = true;

        #region IncludeSubDirectories
        [Category("Path"), Description("Set or get whether to search subdirectories."), DisplayName("Search Sub Directories Requried"), DefaultValue(true)]
        [XmlElement(ElementName = "includeSubDirectoriesRequired", Namespace = XNamespaces.NameSpace)]
        public bool IncludeSubDirectories
        {
            get { return _includeSubDirectories; }
            set { _includeSubDirectories = value; }
        }
        #endregion

        #region SelectedPath
        [Editor(typeof(FolderSelectionEditor), typeof(UITypeEditor))]
        [Category("Path"), Description("Set or get the folder's directory."), DisplayName("Folder Directory")]
        [XmlElement(ElementName = "selectedPath", Namespace = XNamespaces.NameSpace)]
        public string SelectedPath
        {
            get { return _selectedPath; }
            set { _selectedPath = value; }
        }
        #endregion

        #region FolderProperty Constructors

        /// <summary>
        /// 用于初始化一个<see cref="FolderProperty" />对象实例。
        /// </summary>
        public FolderProperty()
        { }

        #endregion

        #region ToString
        public override string ToString()
        {
            return this.SelectedPath;
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */