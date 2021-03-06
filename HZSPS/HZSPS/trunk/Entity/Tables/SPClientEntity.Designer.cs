// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LD.SPPipeManage.Entity.Tables
{
	/// <summary>
	///	
	/// </summary>
	[DataContract]
	public partial class SPClientEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "LD.SPPipeManage.Entity.Tables.SPClientEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		public static readonly string PROPERTY_NAME_RECIEVEDATAURL = "RecieveDataUrl";
		public static readonly string PROPERTY_NAME_USERID = "UserID";
		public static readonly string PROPERTY_NAME_SYNCDATA = "SyncData";
		public static readonly string PROPERTY_NAME_OKMESSAGE = "OkMessage";
		public static readonly string PROPERTY_NAME_FAILEDMESSAGE = "FailedMessage";
		public static readonly string PROPERTY_NAME_SYNCTYPE = "SyncType";
		public static readonly string PROPERTY_NAME_SPCLIENTGROUPID = "SPClientGroupID";
		public static readonly string PROPERTY_NAME_ISDEFAULTCLIENT = "IsDefaultClient";
		public static readonly string PROPERTY_NAME_ALIAS = "Alias";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _id;
		private string _name;
		private string _description;
		private string _recieveDataUrl;
		private int? _userID;
		private bool? _syncData;
		private string _okMessage;
		private string _failedMessage;
		private string _syncType;
		private SPClientGroupEntity _sPClientGroupID;
		private bool? _isDefaultClient;
		private string _alias;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SPClientEntity()
		{
			_id = 0;
			_name = null;
			_description = null;
			_recieveDataUrl = null;
			_userID = null;
			_syncData = null;
			_okMessage = null;
			_failedMessage = null;
			_syncType = null;
			_sPClientGroupID = null;
			_isDefaultClient = null;
			_alias = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SPClientEntity( int id, string name, string description, string recieveDataUrl, int? userID, bool? syncData, string okMessage, string failedMessage, string syncType, SPClientGroupEntity sPClientGroupID, bool? isDefaultClient, string alias)
		{
			_id = id;
			_name = name;
			_description = description;
			_recieveDataUrl = recieveDataUrl;
			_userID = userID;
			_syncData = syncData;
			_okMessage = okMessage;
			_failedMessage = failedMessage;
			_syncType = syncType;
			_sPClientGroupID = sPClientGroupID;
			_isDefaultClient = isDefaultClient;
			_alias = alias;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int Id
		{
			get { return _id; }

			set	
			{
				_isChanged |= (_id != value); _id = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string Name
		{
			get { return _name; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for Name", value, value.ToString());
				_isChanged |= (_name != value); _name = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string Description
		{
			get { return _description; }

			set	
			{

				if( value != null && value.Length > 4000)
					throw new ArgumentOutOfRangeException("Invalid value for Description", value, value.ToString());
				_isChanged |= (_description != value); _description = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string RecieveDataUrl
		{
			get { return _recieveDataUrl; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for RecieveDataUrl", value, value.ToString());
				_isChanged |= (_recieveDataUrl != value); _recieveDataUrl = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? UserID
		{
			get { return _userID; }

			set	
			{
				_isChanged |= (_userID != value); _userID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual bool? SyncData
		{
			get { return _syncData; }

			set	
			{
				_isChanged |= (_syncData != value); _syncData = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string OkMessage
		{
			get { return _okMessage; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for OkMessage", value, value.ToString());
				_isChanged |= (_okMessage != value); _okMessage = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string FailedMessage
		{
			get { return _failedMessage; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for FailedMessage", value, value.ToString());
				_isChanged |= (_failedMessage != value); _failedMessage = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string SyncType
		{
			get { return _syncType; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for SyncType", value, value.ToString());
				_isChanged |= (_syncType != value); _syncType = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual SPClientGroupEntity SPClientGroupID
		{
			get { return _sPClientGroupID; }

			set	
			{
				_isChanged |= (_sPClientGroupID != value); _sPClientGroupID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual bool? IsDefaultClient
		{
			get { return _isDefaultClient; }

			set	
			{
				_isChanged |= (_isDefaultClient != value); _isDefaultClient = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string Alias
		{
			get { return _alias; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for Alias", value, value.ToString());
				_isChanged |= (_alias != value); _alias = value;
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
			
			SPClientEntity castObj = (SPClientEntity)obj;
			
			return ( castObj != null ) && ( this._id == castObj.Id );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id.GetHashCode();

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
