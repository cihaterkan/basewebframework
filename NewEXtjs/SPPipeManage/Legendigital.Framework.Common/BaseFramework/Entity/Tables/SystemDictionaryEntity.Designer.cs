// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Legendigital.Framework.Common.BaseFramework.Entity.Tables
{
	/// <summary>
	///	System Dictionary
	/// </summary>
	[DataContract]
	public partial class SystemDictionaryEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemDictionaryEntity";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYID = "SystemDictionaryID";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYCATEGORYID = "SystemDictionaryCategoryID";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYKEY = "SystemDictionaryKey";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYVALUE = "SystemDictionaryValue";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYDESCIPTION = "SystemDictionaryDesciption";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYORDER = "SystemDictionaryOrder";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYISENABLE = "SystemDictionaryIsEnable";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _systemDictionaryID;
		private string _systemDictionaryCategoryID;
		private string _systemDictionaryKey;
		private string _systemDictionaryValue;
		private string _systemDictionaryDesciption;
		private int? _systemDictionaryOrder;
		private bool? _systemDictionaryIsEnable;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemDictionaryEntity()
		{
			_systemDictionaryID = 0;
			_systemDictionaryCategoryID = null;
			_systemDictionaryKey = null;
			_systemDictionaryValue = null;
			_systemDictionaryDesciption = null;
			_systemDictionaryOrder = null;
			_systemDictionaryIsEnable = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemDictionaryEntity( int systemDictionaryID, string systemDictionaryCategoryID, string systemDictionaryKey, string systemDictionaryValue, string systemDictionaryDesciption, int? systemDictionaryOrder, bool? systemDictionaryIsEnable)
		{
			_systemDictionaryID = systemDictionaryID;
			_systemDictionaryCategoryID = systemDictionaryCategoryID;
			_systemDictionaryKey = systemDictionaryKey;
			_systemDictionaryValue = systemDictionaryValue;
			_systemDictionaryDesciption = systemDictionaryDesciption;
			_systemDictionaryOrder = systemDictionaryOrder;
			_systemDictionaryIsEnable = systemDictionaryIsEnable;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// Primary Key
		/// </summary>
		[DataMember]
		public virtual int SystemDictionaryID
		{
			get { return _systemDictionaryID; }

			set	
			{
				_isChanged |= (_systemDictionaryID != value); _systemDictionaryID = value;
			}
		}

		/// <summary>
		/// Category Name
		/// </summary>
		[DataMember]
		public virtual string SystemDictionaryCategoryID
		{
			get { return _systemDictionaryCategoryID; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for SystemDictionaryCategoryID", value, value.ToString());
				_isChanged |= (_systemDictionaryCategoryID != value); _systemDictionaryCategoryID = value;
			}
		}

		/// <summary>
		/// Key
		/// </summary>
		[DataMember]
		public virtual string SystemDictionaryKey
		{
			get { return _systemDictionaryKey; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for SystemDictionaryKey", value, value.ToString());
				_isChanged |= (_systemDictionaryKey != value); _systemDictionaryKey = value;
			}
		}

		/// <summary>
		/// Value
		/// </summary>
		[DataMember]
		public virtual string SystemDictionaryValue
		{
			get { return _systemDictionaryValue; }

			set	
			{

				if( value != null && value.Length > 4000)
					throw new ArgumentOutOfRangeException("Invalid value for SystemDictionaryValue", value, value.ToString());
				_isChanged |= (_systemDictionaryValue != value); _systemDictionaryValue = value;
			}
		}

		/// <summary>
		/// Description
		/// </summary>
		[DataMember]
		public virtual string SystemDictionaryDesciption
		{
			get { return _systemDictionaryDesciption; }

			set	
			{

				if( value != null && value.Length > 4000)
					throw new ArgumentOutOfRangeException("Invalid value for SystemDictionaryDesciption", value, value.ToString());
				_isChanged |= (_systemDictionaryDesciption != value); _systemDictionaryDesciption = value;
			}
		}

		/// <summary>
		/// Order Index
		/// </summary>
		[DataMember]
		public virtual int? SystemDictionaryOrder
		{
			get { return _systemDictionaryOrder; }

			set	
			{
				_isChanged |= (_systemDictionaryOrder != value); _systemDictionaryOrder = value;
			}
		}

		/// <summary>
		/// Is Enable
		/// </summary>
		[DataMember]
		public virtual bool? SystemDictionaryIsEnable
		{
			get { return _systemDictionaryIsEnable; }

			set	
			{
				_isChanged |= (_systemDictionaryIsEnable != value); _systemDictionaryIsEnable = value;
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
			
			SystemDictionaryEntity castObj = (SystemDictionaryEntity)obj;
			
			return ( castObj != null ) && ( this._systemDictionaryID == castObj.SystemDictionaryID );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _systemDictionaryID.GetHashCode();

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
