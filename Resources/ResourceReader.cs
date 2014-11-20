#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-20 10:49:12
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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using SourcePro.Csharp.Lab.Globalization;
using Reader = System.Resources.ResourceReader;

namespace SourcePro.Csharp.Lab.Resources
{
    /// <summary>
    /// <para>
    /// 提供了读取资源文件的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Resources"/>
    /// </para>
    /// <para>
    /// Type : <see cref="ResourceReader"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// <para>
    /// <see cref="ResourceReader"/> is a static type !
    /// </para>
    /// </summary>
    /// <remarks>
    /// <see cref="ResourceReader"/> is a static type !
    /// </remarks>
    /// <seealso cref="SourcePro.Csharp.Lab.Resources"/>
    public static class ResourceReader
    {
        private static readonly string RunningDirectory = AppDomain.CurrentDomain.BaseDirectory;

        #region GetCultureResource
        /// <summary>
        /// 获取当前<see cref="CultureInfo"/>的资源配置。
        /// </summary>
        /// <param name="resourceName">资源名称。</param>
        /// <returns></returns>
        static public Dictionary<string, string> GetCultureResource(string resourceName)
        {
            Dictionary<string, string> resources = new Dictionary<string, string>();
            string fileName = Path.Combine(RunningDirectory, Culture.GetCurrentCultureInfo().LCID.ToString(), string.Format("{0}.resources", resourceName));
            using (Stream resourceStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (Reader reader = new Reader(resourceStream))
                {
                    try
                    {
                        IDictionaryEnumerator enumerator = reader.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            resources.Add(enumerator.Key.ToString(), enumerator.Value.ToString());
                        }
                    }
                    catch (Exception ex) { throw ex; }
                    finally
                    {
                        reader.Close();
                        resourceStream.Close();
                    }
                }
            }
            return resources;
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */