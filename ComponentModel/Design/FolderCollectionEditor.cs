#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-26 11:13:47
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
using System.ComponentModel.Design;
using SourcePro.Csharp.Lab.Commons.Entity;

namespace SourcePro.Csharp.Lab.ComponentModel.Design
{
    /// <summary>
    /// <para>
    /// 文件夹属性信息集合编辑器。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.ComponentModel.Design"/>
    /// </para>
    /// <para>
    /// Type : <see cref="FolderCollectionEditor"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.ComponentModel.Design"/>
    public class FolderCollectionEditor : CollectionEditor
    {
        #region FolderCollectionEditor Constructors

        /// <summary>
        /// 用于初始化一个<see cref="FolderCollectionEditor" />对象实例。
        /// </summary>
        public FolderCollectionEditor()
            : base(typeof(FolderProperty))
        { }

        #endregion

        #region GetDisplayText
        protected override string GetDisplayText(object value)
        {
            return value.ToString();
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */