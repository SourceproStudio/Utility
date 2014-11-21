#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-21 10:02:01
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

using SourcePro.Csharp.Lab.Entity;

namespace SourcePro.Csharp.Lab.Threading
{
    /// <summary>
    /// <para>
    /// 用于跨线程更新进度描述的委托类型。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Threading"/>
    /// </para>
    /// <para>
    /// Type : <see cref="ProgressDescriptionUpdater"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// </summary>
    /// <param name="message">进度描述消息。</param>
    /// <param name="status">进度状态。</param>
    /// <seealso cref="SourcePro.Csharp.Lab.Threading"/>
    public delegate void ProgressDescriptionUpdater(string message, ProgressStatus status);
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */