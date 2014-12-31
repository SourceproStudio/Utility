#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-31 11:28:21
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

namespace SourcePro.Csharp.Lab.Commons.RegularExpressions
{
    /// <summary>
    /// <para>
    /// 定义了正则表达式类别。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Commons.RegularExpressions"/>
    /// </para>
    /// <para>
    /// Type : <see cref="RegexCategory"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Commons.RegularExpressions"/>
    [Serializable]
    public enum RegexCategory : int
    {
        FileFilter = 1,
        AssemblyTitle,
        AssemblyDescription,
        AssemblyCompany,
        AssemblyProduct,
        AssemblyCopyright,
        AssemblyTrademark,
        AssemblyVersion,
        AssemblyFileVersion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */