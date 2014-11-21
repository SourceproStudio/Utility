#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-21 9:57:49
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

namespace SourcePro.Csharp.Lab.Entity
{
    /// <summary>
    /// <para>
    /// 定义了更新动作。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Entity"/>
    /// </para>
    /// <para>
    /// Type : <see cref="Actions"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Entity"/>
    [Serializable]
    public enum Actions : int
    {
        /// <summary>
        /// 仅更新单一程序集信息文件。
        /// </summary>
        SingleAssemblyInfoFile = 1,
        /// <summary>
        /// 更新指定目录下的所有程序集信息文件。
        /// </summary>
        AllAssemblyInfoFiles = 2
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */