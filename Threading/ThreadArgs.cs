#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-11-21 10:33:31
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

namespace SourcePro.Csharp.Lab.Threading
{
    /// <summary>
    /// <para>
    /// 线程参数。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Threading"/>
    /// </para>
    /// <para>
    /// Type : <see cref="ThreadArgs"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 4.0
    /// </para>
    /// <para>
    /// Can not inherit from <see cref="ThreadArgs"/> !
    /// </para>
    /// </summary>
    /// <seealso cref="SourcePro.Csharp.Lab.Threading"/>
    /// <remarks>
    /// Can not inherit from <see cref="ThreadArgs"/> !
    /// </remarks>
    public sealed class ThreadArgs
    {
        private Actions _action;
        private ProgressDescriptionUpdater _updater;
        private AssemblyInformation _information;
        private string _path;

        #region Action
        /// <summary>
        /// 设置或获取操作类型。
        /// </summary>
        public Actions Action
        {
            get { return _action; }
            set { _action = value; }
        }
        #endregion

        #region Updater
        /// <summary>
        /// 设置或获取用于跨线程更新进度信息的委托。
        /// </summary>
        public ProgressDescriptionUpdater Updater
        {
            get { return _updater; }
            set { _updater = value; }
        }
        #endregion

        #region Information
        /// <summary>
        /// 设置或获取程序集信息。
        /// </summary>
        public AssemblyInformation Information
        {
            get { return _information; }
            set { _information = value; }
        }
        #endregion

        #region Path
        /// <summary>
        /// 设置或获取程序集信息文件或目录路径。
        /// </summary>
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        #endregion

        #region ThreadArgs Constructors

        /// <summary>
        /// <para>
        /// 用于初始化一个<see cref="ThreadArgs" />对象实例。
        /// </para>
        /// </summary>
        public ThreadArgs()
        { }

        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */