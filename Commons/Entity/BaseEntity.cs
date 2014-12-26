#region README

/*
 * README
 * 
 * Current Thread User : GUOCOLAND\wangyucai
 * Machine Name : GLCHQWYCWINW7
 * Visual Studio : Microsoft Visual Studio 2010 Ultimate Edition
 * Create Time : 2014-12-25 16:19:57
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

using System.IO;
using System.Xml.Serialization;

namespace SourcePro.Csharp.Lab.Commons.Entity
{
    /// <summary>
    /// <para>
    /// 提供了基本实体方法。
    /// </para>
    /// <para>
    /// Namespace : <see cref="SourcePro.Csharp.Lab.Commons.Entity"/>
    /// </para>
    /// <para>
    /// Type : <see cref="BaseEntity"/>
    /// </para>
    /// <para>
    /// The minimum .Net Framework version requirements : 3.5
    /// </para>
    /// <para>
    /// <see cref="BaseEntity"/> is an abstract type !
    /// </para>
    /// </summary>
    /// <remarks>
    /// <see cref="BaseEntity"/> is an abstract type !
    /// </remarks>
    /// <seealso cref="SourcePro.Csharp.Lab.Commons.Entity"/>
    public abstract class BaseEntity
    {
        private XmlSerializer _baseSerializer;
        private XmlSerializerNamespaces _baseNamespaces;

        #region BaseSerializer
        protected virtual XmlSerializer BaseSerializer
        {
            get { return _baseSerializer; }
            set { _baseSerializer = value; }
        }
        #endregion

        #region BaseNamespaces
        protected virtual XmlSerializerNamespaces BaseNamespaces
        {
            get { return _baseNamespaces; }
            set { _baseNamespaces = value; }
        }
        #endregion

        #region BaseEntity Constructors

        /// <summary>
        /// 用于初始化一个<see cref="BaseEntity" />对象实例。
        /// </summary>
        protected BaseEntity()
        {
            this.BaseSerializer = new XmlSerializer(this.GetType());
            this.BaseNamespaces = new XmlSerializerNamespaces();
            this.BaseNamespaces.Add("wyc", XNamespaces.NameSpace);
        }

        #endregion

        #region Serialize
        public virtual void Serialize(Stream destinationStream)
        {
            this.BaseSerializer.Serialize(destinationStream, this, this.BaseNamespaces);
        }
        #endregion

        #region Deserialize
        static public T Deserialize<T>(Stream destinationStream)
            where T : BaseEntity
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(destinationStream);
        }
        #endregion
    }
}

/*
 * Copyright © 2014 Wang Yucai. All rights reserved.
 */