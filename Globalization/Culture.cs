#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-20 10:44:36
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
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Xml;

namespace SourcePro.Csharp.Lab.Globalization
{
    /// <summary>
    /// <para>
    /// 提供了访问当前线程<see cref="CultureInfo"/>的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Globalization"/>
    /// </para>
    /// <para>
    /// Type : <see cref="Culture"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// <para>
    /// <see cref="Culture"/> is a static type !
    /// </para>
    /// </summary>
    /// <remarks>
    /// <see cref="Culture"/> is a static type !
    /// </remarks>
    /// <seealso cref="SourcePro.Csharp.Lab.Globalization"/>
    public static class Culture
    {
        private static CultureInfo _currentCulture = null;

        #region GetCurrentCultureInfo
        /// <summary>
        /// 获取当前配置的<see cref="CultureInfo"/>对象实例。
        /// </summary>
        /// <returns><see cref="CultureInfo"/>对象实例。</returns>
        static public CultureInfo GetCurrentCultureInfo()
        {
            if (object.ReferenceEquals(_currentCulture, null))
            {
                int lcid = int.Parse(ConfigurationManager.AppSettings["Culture"]);
                _currentCulture = new CultureInfo(lcid);
            }
            return _currentCulture;
        }
        #endregion

        #region ChangeCultureInfo
        /// <summary>
        /// 更新当前线程的<see cref="CultureInfo"/>信息。
        /// </summary>
        /// <param name="culture">LCID。</param>
        static public void ChangeCultureInfo(int culture)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assinfo.exe.config");
            XmlDocument xDocument = new XmlDocument();
            xDocument.Load(path);
            xDocument.SelectSingleNode("configuration/appSettings/add[@key=\"Culture\"]").Attributes["value"].Value = culture.ToString();
            xDocument.Save(path);
            _currentCulture = new CultureInfo(culture);
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */