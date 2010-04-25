// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Legendigital.Framework.Common.BaseFramework.Entity.Tables
{
	/// <summary>
	///	角色权限分配
	/// </summary>
	public partial class SystemPrivilegeInRolesEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemPrivilegeInRolesEntity";
		public static readonly string PROPERTY_NAME_PRIVILEGEROLEID = "PrivilegeRoleID";
		public static readonly string PROPERTY_NAME_ROLEID = "RoleID";
		public static readonly string PROPERTY_NAME_PRIVILEGEID = "PrivilegeID";
		public static readonly string PROPERTY_NAME_PRIVILEGEROLEVALUETYPE = "PrivilegeRoleValueType";
		public static readonly string PROPERTY_NAME_ENABLETYPE = "EnableType";
		public static readonly string PROPERTY_NAME_CREATETIME = "CreateTime";
		public static readonly string PROPERTY_NAME_UPDATETIME = "UpdateTime";
		public static readonly string PROPERTY_NAME_EXPIRYTIME = "ExpiryTime";
		public static readonly string PROPERTY_NAME_ENABLEPARAMETER = "EnableParameter";
		public static readonly string PROPERTY_NAME_PRIVILEGEROLEVALUE = "PrivilegeRoleValue";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _privilegeRoleID;
		private SystemRoleEntity _roleID;
		private SystemPrivilegeEntity _privilegeID;
		private string _privilegeRoleValueType;
		private string _enableType;
		private DateTime _createTime;
		private DateTime _updateTime;
		private DateTime _expiryTime;
		private bool _enableParameter;
		private byte[] _privilegeRoleValue;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemPrivilegeInRolesEntity()
		{
			_privilegeRoleID = 0;
			_roleID = null;
			_privilegeID = null;
			_privilegeRoleValueType = null;
			_enableType = String.Empty;
			_createTime = DateTime.MinValue;
			_updateTime = DateTime.MinValue;
			_expiryTime = DateTime.MinValue;
			_enableParameter = false;
			_privilegeRoleValue = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemPrivilegeInRolesEntity( int privilegeRoleID, SystemRoleEntity roleID, SystemPrivilegeEntity privilegeID, string privilegeRoleValueType, string enableType, DateTime createTime, DateTime updateTime, DateTime expiryTime, bool enableParameter, byte[] privilegeRoleValue)
		{
			_privilegeRoleID = privilegeRoleID;
			_roleID = roleID;
			_privilegeID = privilegeID;
			_privilegeRoleValueType = privilegeRoleValueType;
			_enableType = enableType;
			_createTime = createTime;
			_updateTime = updateTime;
			_expiryTime = expiryTime;
			_enableParameter = enableParameter;
			_privilegeRoleValue = privilegeRoleValue;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// 主键
		/// </summary>
		[DataMember]
		public virtual int PrivilegeRoleID
		{
			get { return _privilegeRoleID; }

			set	
			{
				_isChanged |= (_privilegeRoleID != value); _privilegeRoleID = value;
			}
		}

		/// <summary>
		/// 角色ID
		/// </summary>
		[DataMember]
		public virtual SystemRoleEntity RoleID
		{
			get { return _roleID; }

			set	
			{
				_isChanged |= (_roleID != value); _roleID = value;
			}
		}

		/// <summary>
		/// 权限ID
		/// </summary>
		[DataMember]
		public virtual SystemPrivilegeEntity PrivilegeID
		{
			get { return _privilegeID; }

			set	
			{
				_isChanged |= (_privilegeID != value); _privilegeID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string PrivilegeRoleValueType
		{
			get { return _privilegeRoleValueType; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for PrivilegeRoleValueType", value, value.ToString());
				_isChanged |= (_privilegeRoleValueType != value); _privilegeRoleValueType = value;
			}
		}

		/// <summary>
		/// 授权类型
		/// </summary>
		[DataMember]
		public virtual string EnableType
		{
			get { return _enableType; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for EnableType", value, value.ToString());
				_isChanged |= (_enableType != value); _enableType = value;
			}
		}

		/// <summary>
		/// 创建时间
		/// </summary>
		[DataMember]
		public virtual DateTime CreateTime
		{
			get { return _createTime; }

			set	
			{
				_isChanged |= (_createTime != value); _createTime = value;
			}
		}

		/// <summary>
		/// 最后更新时间
		/// </summary>
		[DataMember]
		public virtual DateTime UpdateTime
		{
			get { return _updateTime; }

			set	
			{
				_isChanged |= (_updateTime != value); _updateTime = value;
			}
		}

		/// <summary>
		/// 过期时间
		/// </summary>
		[DataMember]
		public virtual DateTime ExpiryTime
		{
			get { return _expiryTime; }

			set	
			{
				_isChanged |= (_expiryTime != value); _expiryTime = value;
			}
		}

		/// <summary>
		/// 是否允许参数
		/// </summary>
		[DataMember]
		public virtual bool EnableParameter
		{
			get { return _enableParameter; }

			set	
			{
				_isChanged |= (_enableParameter != value); _enableParameter = value;
			}
		}

		/// <summary>
		/// 权限分配值
		/// </summary>
		[DataMember]
		public virtual byte[] PrivilegeRoleValue
		{
			get { return _privilegeRoleValue; }

			set	
			{

				if( value != null && value.Length > 2147483647)
					throw new ArgumentOutOfRangeException("Invalid value for PrivilegeRoleValue", value, value.ToString());
				_isChanged |= (_privilegeRoleValue != value); _privilegeRoleValue = value;
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
			
			SystemPrivilegeInRolesEntity castObj = (SystemPrivilegeInRolesEntity)obj;
			
			return ( castObj != null ) && ( this._privilegeRoleID == castObj.PrivilegeRoleID );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _privilegeRoleID.GetHashCode();

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
