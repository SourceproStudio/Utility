#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-24 9:39:52
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
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SourcePro.Csharp.Lab.Templates
{
    /// <summary>
    /// <para>
    /// 提供了用于查找模板的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Templates"/>
    /// </para>
    /// <para>
    /// Type : <see cref="TemplateFinder"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// <para>
    /// <see cref="TemplateFinder"/> is a static type !
    /// </para>
    /// </summary>
    /// <remarks>
    /// <see cref="TemplateFinder"/> is a static type !
    /// </remarks>
    /// <seealso cref="SourcePro.Csharp.Lab.Templates"/>
    public static class TemplateFinder
    {
        private static readonly DirectoryInfo TemplatesDir = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"SourcePro Studio\AssemblyInfoManager\Templates"));

        #region GetAllTemplates
        /// <summary>
        /// 获取所有模板。
        /// </summary>
        /// <returns>动态类型数组。</returns>
        static public dynamic[] GetAllTemplates()
        {
            List<dynamic> output = new List<dynamic>();
            if (TemplatesDir.Exists)
            {
                var enumerator = from item in TemplatesDir.GetFiles("*.t", SearchOption.TopDirectoryOnly)
                                 orderby item.CreationTime descending
                                 select item;
                foreach (var item in enumerator)
                    output.Add(new
                    {
                        Name = item.Name,
                        Path = item.FullName,
                        CreateTime = item.CreationTime
                    });
            }
            return output.ToArray();
        }
        #endregion

        #region DeleteAll
        /// <summary>
        /// 删除所有模板文件。
        /// </summary>
        static public void DeleteAll()
        {
            try
            {
                FileInfo[] files = TemplatesDir.GetFiles("*.t");
                for (var i = 0; i < files.Length; i++)
                {
                    files[i].Delete();
                }
            }
            catch { }
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */