#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-26 11:04:36
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
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace SourcePro.Csharp.Lab.ComponentModel.Design
{
    /// <summary>
    /// <para>
    /// 文件夹选择编辑器。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.ComponentModel.Design"/>
    /// </para>
    /// <para>
    /// Type : <see cref="FolderSelectionEditor"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.ComponentModel.Design"/>
    public class FolderSelectionEditor : UITypeEditor
    {
        #region FolderSelectionEditor Constructors

        /// <summary>
        /// 用于初始化一个<see cref="FolderSelectionEditor" />对象实例。
        /// </summary>
        public FolderSelectionEditor()
        { }

        #endregion

        #region GetEditStyle
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        #endregion

        #region EditValue
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog() { Description = "Select a folder", RootFolder = Environment.SpecialFolder.Desktop, ShowNewFolderButton = false })
            {
                if (dialog.ShowDialog() == DialogResult.OK) return dialog.SelectedPath;
                else return value;
            }
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */