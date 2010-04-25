// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Legendigital.Framework.Common.BaseFramework.Entity.Tables
{
	/// <summary>
	///	
	/// </summary>
	public partial class SystemPersonalizationSettingsEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemPersonalizationSettingsEntity";
		public static readonly string PROPERTY_NAME_PERSONALIZATIONID = "PersonalizationID";
		public static readonly string PROPERTY_NAME_APPLICATIONID = "ApplicationID";
		public static readonly string PROPERTY_NAME_USERID = "UserId";
		public static readonly string PROPERTY_NAME_PATH = "Path";
		public static readonly string PROPERTY_NAME_PAGESETTINGS = "PageSettings";
		public static readonly string PROPERTY_NAME_LASTUPDATEDDATE = "LastUpdatedDate";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _personalizationID;
		private SystemApplicationEntity _applicationID;
		private SystemUserEntity _userId;
		private string _path;
		private byte[] _pageSettings;
		private DateTime? _lastUpdatedDate;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemPersonalizationSettingsEntity()
		{
			_personalizationID = 0;
			_applicationID = null;
			_userId = null;
			_path = String.Empty;
			_pageSettings = new byte[1];
			_lastUpdatedDate = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemPersonalizationSettingsEntity( int personalizationID, SystemApplicationEntity applicationID, SystemUserEntity userId, string path, byte[] pageSettings, DateTime? lastUpdatedDate)
		{
			_personalizationID = personalizationID;
			_applicationID = applicationID;
			_userId = userId;
			_path = path;
			_pageSettings = pageSettings;
			_lastUpdatedDate = lastUpdatedDate;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int PersonalizationID
		{
			get { return _personalizationID; }

			set	
			{
				_isChanged |= (_personalizationID != value); _personalizationID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual SystemApplicationEntity ApplicationID
		{
			get { return _applicationID; }

			set	
			{
				_isChanged |= (_applicationID != value); _applicationID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual SystemUserEntity UserId
		{
			get { return _userId; }

			set	
			{
				_isChanged |= (_userId != value); _userId = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string Path
		{
			get { return _path; }

			set	
			{

				if( value != null && value.Length > 1000)
					throw new ArgumentOutOfRangeException("Invalid value for Path", value, value.ToString());
				_isChanged |= (_path != value); _path = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual byte[] PageSettings
		{
			get { return _pageSettings; }

			set	
			{

				if( value != null && value.Length > 2147483647)
					throw new ArgumentOutOfRangeException("Invalid value for PageSettings", value, value.ToString());
				_isChanged |= (_pageSettings != value); _pageSettings = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual DateTime? LastUpdatedDate
		{
			get { return _lastUpdatedDate; }

			set	
			{
				_isChanged |= (_lastUpdatedDate != value); _lastUpdatedDate = value;
			}
		}
		/// <summary>
		/// 返回对象是否被改变。
		/// </summary>
		public virtual bool IsChanged
		{
			get { return _isChanged; }
		}
		
		/// <summary>
		/// Returns whether or not the object has changed it's values.
		/// </summary>
		public virtual bool IsDeleted
		{
			get { return _isDeleted; }
		}
		
		#endregion 

        #region 公共方法
		
		/// <summary>
		/// mark the item as deleted
		/// </summary>
		public virtual void MarkAsDeleted()
		{
			_isDeleted = true;
			_isChanged = true;
		}
		
		#endregion

		#region Equals 和 HashCode 方法覆盖
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			
			SystemPersonalizationSettingsEntity castObj = (SystemPersonalizationSettingsEntity)obj;
			
			return ( castObj != null ) && ( this._personalizationID == castObj.PersonalizationID );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _personalizationID.GetHashCode();

			return hash; 
		}
		#endregion
	
		#region ICloneable methods
		
		public virtual object Clone()
		{
			return this.MemberwiseClone();
		}
		
		#endregion
	
	}
}
