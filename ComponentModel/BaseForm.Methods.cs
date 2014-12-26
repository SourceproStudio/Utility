#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-25 14:55:49
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
using System.Drawing;
using System.IO;
using System.Reflection;

namespace SourcePro.Csharp.Lab.ComponentModel
{
    /// <summary>
    /// <para>
    /// 用于定义基础窗体的方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.ComponentModel"/>
    /// </para>
    /// <para>
    /// Type : <see cref="BaseForm"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.ComponentModel"/>
    partial class BaseForm
    {
        #region InitializeThisForm
        protected virtual void InitializeThisForm()
        {
            this.InitializeControls();
            this.RegisterControlsEventHandlers();
        }
        #endregion

        #region InitializeControls
        protected virtual void InitializeControls()
        {
        }
        #endregion

        #region RegisterControlsEventHandlers
        protected virtual void RegisterControlsEventHandlers()
        {
        }
        #endregion

        #region GetIconFromManifestResource
        protected virtual Icon GetIconFromManifestResource()
        {
            Icon icon = null;
            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SourcePro.Csharp.Lab.Icon.ico"))
            {
                try { icon = new Icon(resourceStream); }
                finally { resourceStream.Close(); }
            }
            return icon;
        }
        #endregion

        #region OnLoad
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.InitializeThisForm();
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */