// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Legendigital.Framework.Common.BaseFramework.Entity.Tables
{
	/// <summary>
	///	权限参数
	/// </summary>
	public partial class SystemPrivilegeParameterEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemPrivilegeParameterEntity";
		public static readonly string PROPERTY_NAME_PRIVILEGEPARAMETERID = "PrivilegeParameterID";
		public static readonly string PROPERTY_NAME_ROLEID = "RoleID";
		public static readonly string PROPERTY_NAME_PRIVILEGEID = "PrivilegeID";
		public static readonly string PROPERTY_NAME_BIZPARAMETER = "BizParameter";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _privilegeParameterID;
		private SystemRoleEntity _roleID;
		private SystemPrivilegeEntity _privilegeID;
		private string _bizParameter;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemPrivilegeParameterEntity()
		{
			_privilegeParameterID = 0;
			_roleID = null;
			_privilegeID = null;
			_bizParameter = String.Empty;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemPrivilegeParameterEntity( int privilegeParameterID, SystemRoleEntity roleID, SystemPrivilegeEntity privilegeID, string bizParameter)
		{
			_privilegeParameterID = privilegeParameterID;
			_roleID = roleID;
			_privilegeID = privilegeID;
			_bizParameter = bizParameter;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// 主键
		/// </summary>
		[DataMember]
		public virtual int PrivilegeParameterID
		{
			get { return _privilegeParameterID; }

			set	
			{
				_isChanged |= (_privilegeParameterID != value); _privilegeParameterID = value;
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
		/// 参数
		/// </summary>
		[DataMember]
		public virtual string BizParameter
		{
			get { return _bizParameter; }

			set	
			{

				if( value != null && value.Length > 4000)
					throw new ArgumentOutOfRangeException("Invalid value for BizParameter", value, value.ToString());
				_isChanged |= (_bizParameter != value); _bizParameter = value;
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
			
			SystemPrivilegeParameterEntity castObj = (SystemPrivilegeParameterEntity)obj;
			
			return ( castObj != null ) && ( this._privilegeParameterID == castObj.PrivilegeParameterID );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _privilegeParameterID.GetHashCode();

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
