// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Legendigital.Framework.Common.BaseFramework.Entity.Tables
{
	/// <summary>
	///	System Application
	/// </summary>
	public partial class SystemApplicationEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemApplicationEntity";
		public static readonly string PROPERTY_NAME_SYSTEMAPPLICATIONID = "SystemApplicationID";
		public static readonly string PROPERTY_NAME_SYSTEMAPPLICATIONNAME = "SystemApplicationName";
		public static readonly string PROPERTY_NAME_SYSTEMAPPLICATIONDESCRIPTION = "SystemApplicationDescription";
		public static readonly string PROPERTY_NAME_SYSTEMAPPLICATIONURL = "SystemApplicationUrl";
		public static readonly string PROPERTY_NAME_SYSTEMAPPLICATIONISSYSTEMAPPLICATION = "SystemApplicationIsSystemApplication";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _systemApplicationID;
		private string _systemApplicationName;
		private string _systemApplicationDescription;
		private string _systemApplicationUrl;
		private bool? _systemApplicationIsSystemApplication;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemApplicationEntity()
		{
			_systemApplicationID = 0;
			_systemApplicationName = String.Empty;
			_systemApplicationDescription = null;
			_systemApplicationUrl = null;
			_systemApplicationIsSystemApplication = false;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemApplicationEntity( int systemApplicationID, string systemApplicationName, string systemApplicationDescription, string systemApplicationUrl, bool? systemApplicationIsSystemApplication)
		{
			_systemApplicationID = systemApplicationID;
			_systemApplicationName = systemApplicationName;
			_systemApplicationDescription = systemApplicationDescription;
			_systemApplicationUrl = systemApplicationUrl;
			_systemApplicationIsSystemApplication = systemApplicationIsSystemApplication;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// Primary Key
		/// </summary>
		[DataMember]
		public virtual int SystemApplicationID
		{
			get { return _systemApplicationID; }

			set	
			{
				_isChanged |= (_systemApplicationID != value); _systemApplicationID = value;
			}
		}

		/// <summary>
		/// Application Name
		/// </summary>
		[DataMember]
		public virtual string SystemApplicationName
		{
			get { return _systemApplicationName; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for SystemApplicationName", value, value.ToString());
				_isChanged |= (_systemApplicationName != value); _systemApplicationName = value;
			}
		}

		/// <summary>
		/// Application Description
		/// </summary>
		[DataMember]
		public virtual string SystemApplicationDescription
		{
			get { return _systemApplicationDescription; }

			set	
			{

				if( value != null && value.Length > 4000)
					throw new ArgumentOutOfRangeException("Invalid value for SystemApplicationDescription", value, value.ToString());
				_isChanged |= (_systemApplicationDescription != value); _systemApplicationDescription = value;
			}
		}

		/// <summary>
		/// Appilcation Url
		/// </summary>
		[DataMember]
		public virtual string SystemApplicationUrl
		{
			get { return _systemApplicationUrl; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for SystemApplicationUrl", value, value.ToString());
				_isChanged |= (_systemApplicationUrl != value); _systemApplicationUrl = value;
			}
		}

		/// <summary>
		/// {$DisplayName:"Is System Application"} Test description
		/// </summary>
		[DataMember]
		public virtual bool? SystemApplicationIsSystemApplication
		{
			get { return _systemApplicationIsSystemApplication; }

			set	
			{
				_isChanged |= (_systemApplicationIsSystemApplication != value); _systemApplicationIsSystemApplication = value;
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
			
			SystemApplicationEntity castObj = (SystemApplicationEntity)obj;
			
			return ( castObj != null ) && ( this._systemApplicationID == castObj.SystemApplicationID );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _systemApplicationID.GetHashCode();

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
