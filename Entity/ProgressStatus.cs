#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-21 10:03:14
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
    /// 定义了进度状态。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Entity"/>
    /// </para>
    /// <para>
    /// Type : <see cref="ProgressStatus"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Entity"/>
    [Serializable, Flags]
    public enum ProgressStatus
    {
        /// <summary>
        /// 准备中。
        /// </summary>
        Preparing = 1,
        /// <summary>
        /// 开始。
        /// </summary>
        Begin = 2,
        /// <summary>
        /// 进行中。
        /// </summary>
        Working = 4,
        /// <summary>
        /// 结束。
        /// </summary>
        End = 8,
        /// <summary>
        /// 成功完成。
        /// </summary>
        Completed = 16,
        /// <summary>
        /// 失败。
        /// </summary>
        Failed = 32
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */