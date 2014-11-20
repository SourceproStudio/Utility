#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-20 10:11:52
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

using System.IO;
using System.Reflection;

namespace SourcePro.Csharp.Lab.Resources
{
    /// <summary>
    /// <para>
    /// 提供了访问资源的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Resources"/>
    /// </para>
    /// <para>
    /// Type : <see cref="Resource"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// <para>
    /// <see cref="Resource"/> is a static type !
    /// </para>
    /// </summary>
    /// <remarks>
    /// <see cref="Resource"/> is a static type !
    /// </remarks>
    /// <seealso cref="SourcePro.Csharp.Lab.Resources"/>
    public static class Resource
    {
        private static readonly Assembly Current = typeof(Resource).Assembly;

        #region GetManifestResourceStream
        /// <summary>
        /// 从资源清单中获取资源流。
        /// </summary>
        /// <param name="resourceName">资源名称。</param>
        /// <returns><see cref="Stream"/>对象实例。</returns>
        static public Stream GetManifestResourceStream(string resourceName)
        {
            return Resource.Current.GetManifestResourceStream(resourceName);
        }
        #endregion

        #region GetIconManifestResourceStream
        /// <summary>
        /// 获取图标文件的资源流。
        /// </summary>
        /// <returns><see cref="Stream"/>对象实例。</returns>
        static public Stream GetIconManifestResourceStream()
        {
            return Resource.GetManifestResourceStream("SourcePro.Csharp.Lab.Resources.Icon.ico");
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */