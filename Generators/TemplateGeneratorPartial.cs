#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-21 16:03:24
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
using SourcePro.Csharp.Lab.Entity;
using System.IO;

namespace SourcePro.Csharp.Lab.Generators
{
    /// <summary>
    /// <para>
    /// Description
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Generators"/>
    /// </para>
    /// <para>
    /// Type : <see cref="TemplateGeneratorPartial"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Generators"/>
    partial class TemplateGenerator
    {
        private AssemblyInformation _templateObject;
        private static readonly DirectoryInfo TemplatesDir = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"SourcePro Studio\AssemblyInfoManager\Templates"));

        #region TemplateObject
        internal AssemblyInformation TemplateObject
        {
            get { return _templateObject; }
            set { _templateObject = value; }
        }
        #endregion

        #region Generate
        /// <summary>
        /// 生成模板文件。
        /// </summary>
        internal void Generate()
        {
            if (!TemplatesDir.Exists) TemplatesDir.Create();
            using (Stream templateStream = new FileStream(Path.Combine(TemplatesDir.FullName, DateTime.Now.Ticks.GetHashCode().ToString("X") + ".t"), FileMode.CreateNew, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(templateStream))
                {
                    try
                    {
                        writer.Write(this.TransformText());
                    }
                    finally
                    {
                        writer.Close();
                        templateStream.Close();
                    }
                }
            }
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */