#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-25 16:33:53
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
using System.Xml.Serialization;

namespace SourcePro.Csharp.Lab.Commons.Entity
{
    /// <summary>
    /// <para>
    /// 提供了访问操作历史的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Commons.Entity"/>
    /// </para>
    /// <para>
    /// Type : <see cref="HistoryObject"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Commons.Entity"/>
    [XmlRoot(ElementName = "sourcepro.utility.assemblyinfoeditor", Namespace = XNamespaces.NameSpace)]
    public class HistoryObject : BaseEntity
    {
        private List<string> _files;
        private static readonly string OutputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "aieditor.his");

        #region Files
        [XmlArray(ElementName = "historyTraces", Namespace = XNamespaces.NameSpace)]
        [XmlArrayItem(ElementName = "trace", Namespace = XNamespaces.NameSpace)]
        public List<string> Files
        {
            get { return _files; }
            set { _files = value; }
        }
        #endregion

        #region HistoryObject Constructors

        /// <summary>
        /// 用于初始化一个<see cref="HistoryObject" />对象实例。
        /// </summary>
        public HistoryObject()
            : base()
        { }

        #endregion

        #region Get
        static public HistoryObject Get()
        {
            FileInfo file = new FileInfo(HistoryObject.OutputPath);
            if (!file.Exists) return new HistoryObject() { Files = new List<string>() };
            else
            {
                using (Stream destinationStream = file.OpenRead())
                {
                    try
                    {
                        destinationStream.Seek(0, SeekOrigin.Begin);
                        return HistoryObject.Deserialize<HistoryObject>(destinationStream);
                    }
                    finally
                    {
                        destinationStream.Close();
                    }
                }
            }
        }
        #endregion

        #region Save
        public void Save()
        {
            FileInfo file = new FileInfo(HistoryObject.OutputPath);
            using (Stream outputStream = new FileStream(file.FullName, FileMode.Create, FileAccess.Write))
            {
                try { base.Serialize(outputStream); }
                finally { outputStream.Close(); }
            }
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */