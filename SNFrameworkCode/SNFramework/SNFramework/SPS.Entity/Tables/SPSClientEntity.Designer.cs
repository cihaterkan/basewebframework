// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SPSClientEntity.Designer.cs">
//   Copyright (c) Foreveross Enterprises. All rights reserved.
// </copyright>
// <summary>
//   Generated by MyGeneration Version # (1.3.0.9)
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Legendigital.Framework.Common.Entity;

namespace SPS.Entity.Tables
{
	/// <summary>
	///	
	/// </summary>
	[DataContract]
	public partial class SPSClientEntity  : BaseTableEntity<int>,ICloneable
	{
      #region 公共常量

		public static readonly string CLASS_FULL_NAME = "SPS.Entity.Tables.SPSClientEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		public static readonly string PROPERTY_NAME_USERID = "UserID";
		public static readonly string PROPERTY_NAME_ISDEFAULTCLIENT = "IsDefaultClient";
		public static readonly string PROPERTY_NAME_SYNCDATA = "SyncData";
		public static readonly string PROPERTY_NAME_SYCNNOTINTERCEPTCOUNT = "SycnNotInterceptCount";
		public static readonly string PROPERTY_NAME_SYNCDATASETTING = "SyncDataSetting";
		public static readonly string PROPERTY_NAME_ALIAS = "Alias";
		public static readonly string PROPERTY_NAME_ISENABLE = "IsEnable";
		public static readonly string PROPERTY_NAME_INTERCEPTRATE = "InterceptRate";
		public static readonly string PROPERTY_NAME_DEFAULTPRICE = "DefaultPrice";
		public static readonly string PROPERTY_NAME_DEFAULTSHOWRECORDDAYS = "DefaultShowRecordDays";
		public static readonly string PROPERTY_NAME_CHANNELSTATUS = "ChannelStatus";
		public static readonly string PROPERTY_NAME_CREATEBY = "CreateBy";
		public static readonly string PROPERTY_NAME_CREATEAT = "CreateAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYBY = "LastModifyBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYAT = "LastModifyAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYCOMMENT = "LastModifyComment";
		
        #endregion
	
 
		#region syncDataSetting字段外键查询字段
        public const string PROPERTY_SYNCDATASETTING_ALIAS_NAME = "SyncDataSetting_SPSClientEntity_Alias";
		public const string PROPERTY_SYNCDATASETTING_ID = "SyncDataSetting_SPSClientEntity_Alias.Id";
		public const string PROPERTY_SYNCDATASETTING_SYCNRETRYTIMES = "SyncDataSetting_SPSClientEntity_Alias.SycnRetryTimes";
		public const string PROPERTY_SYNCDATASETTING_SYNCTYPE = "SyncDataSetting_SPSClientEntity_Alias.SyncType";
		public const string PROPERTY_SYNCDATASETTING_SYCNMO = "SyncDataSetting_SPSClientEntity_Alias.SycnMO";
		public const string PROPERTY_SYNCDATASETTING_SYCNMOURL = "SyncDataSetting_SPSClientEntity_Alias.SycnMOUrl";
		public const string PROPERTY_SYNCDATASETTING_SYCNMOOKMESSAGE = "SyncDataSetting_SPSClientEntity_Alias.SycnMOOkMessage";
		public const string PROPERTY_SYNCDATASETTING_SYCNMOFAILEDMESSAGE = "SyncDataSetting_SPSClientEntity_Alias.SycnMOFailedMessage";
		public const string PROPERTY_SYNCDATASETTING_SYCNMR = "SyncDataSetting_SPSClientEntity_Alias.SycnMR";
		public const string PROPERTY_SYNCDATASETTING_SYCNMRURL = "SyncDataSetting_SPSClientEntity_Alias.SycnMRUrl";
		public const string PROPERTY_SYNCDATASETTING_SYCNMROKMESSAGE = "SyncDataSetting_SPSClientEntity_Alias.SycnMROkMessage";
		public const string PROPERTY_SYNCDATASETTING_SYCNMRFAILEDMESSAGE = "SyncDataSetting_SPSClientEntity_Alias.SycnMRFailedMessage";
		public const string PROPERTY_SYNCDATASETTING_SYCNSATE = "SyncDataSetting_SPSClientEntity_Alias.SycnSate";
		public const string PROPERTY_SYNCDATASETTING_SYCNSATEURL = "SyncDataSetting_SPSClientEntity_Alias.SycnSateUrl";
		public const string PROPERTY_SYNCDATASETTING_SYCNSATEOKMESSAGE = "SyncDataSetting_SPSClientEntity_Alias.SycnSateOkMessage";
		public const string PROPERTY_SYNCDATASETTING_SYCNSATEFAILEDMESSAGE = "SyncDataSetting_SPSClientEntity_Alias.SycnSateFailedMessage";
		#endregion
      	
	
	
		 
		
		
		
		
	
        #region 私有成员变量

 
		
		private int _id;
		private string _name;
		private string _description;
		private int _userID;
		private bool? _isDefaultClient;
		private bool _syncData;
		private int? _sycnNotInterceptCount;
		private SPSDataSycnSettingEntity _syncDataSetting;
		private string _alias;
		private bool? _isEnable;
		private decimal _interceptRate;
		private decimal _defaultPrice;
		private int _defaultShowRecordDays;
		private string _channelStatus;
		private int? _createBy;
		private DateTime? _createAt;
		private int? _lastModifyBy;
		private DateTime? _lastModifyAt;
		private string _lastModifyComment;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SPSClientEntity()
		{
			_id = 0;
			_name = String.Empty;
			_description = String.Empty;
			_userID = 0;
			_isDefaultClient = null;
			_syncData = false;
			_sycnNotInterceptCount = null;
			_syncDataSetting = null;
			_alias = null;
			_isEnable = null;
			_interceptRate = 0;
			_defaultPrice = 0;
			_defaultShowRecordDays = 0;
			_channelStatus = null;
			_createBy = null;
			_createAt = null;
			_lastModifyBy = null;
			_lastModifyAt = null;
			_lastModifyComment = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SPSClientEntity( int id, string name, string description, int userID, bool? isDefaultClient, bool syncData, int? sycnNotInterceptCount, SPSDataSycnSettingEntity syncDataSetting, string alias, bool? isEnable, decimal interceptRate, decimal defaultPrice, int defaultShowRecordDays, string channelStatus, int? createBy, DateTime? createAt, int? lastModifyBy, DateTime? lastModifyAt, string lastModifyComment)
		{
			_id = id;
			_name = name;
			_description = description;
			_userID = userID;
			_isDefaultClient = isDefaultClient;
			_syncData = syncData;
			_sycnNotInterceptCount = sycnNotInterceptCount;
			_syncDataSetting = syncDataSetting;
			_alias = alias;
			_isEnable = isEnable;
			_interceptRate = interceptRate;
			_defaultPrice = defaultPrice;
			_defaultShowRecordDays = defaultShowRecordDays;
			_channelStatus = channelStatus;
			_createBy = createBy;
			_createAt = createAt;
			_lastModifyBy = lastModifyBy;
			_lastModifyAt = lastModifyAt;
			_lastModifyComment = lastModifyComment;
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
		public virtual int UserID
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
		public virtual bool SyncData
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
		public virtual int? SycnNotInterceptCount
		{
			get { return _sycnNotInterceptCount; }

			set	
			{
				_isChanged |= (_sycnNotInterceptCount != value); _sycnNotInterceptCount = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual SPSDataSycnSettingEntity SyncDataSetting
		{
			get { return _syncDataSetting; }

			set	
			{
				_isChanged |= (_syncDataSetting != value); _syncDataSetting = value;
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
		/// 
		/// </summary>
		[DataMember]
		public virtual bool? IsEnable
		{
			get { return _isEnable; }

			set	
			{
				_isChanged |= (_isEnable != value); _isEnable = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual decimal InterceptRate
		{
			get { return _interceptRate; }

			set	
			{
				_isChanged |= (_interceptRate != value); _interceptRate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual decimal DefaultPrice
		{
			get { return _defaultPrice; }

			set	
			{
				_isChanged |= (_defaultPrice != value); _defaultPrice = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int DefaultShowRecordDays
		{
			get { return _defaultShowRecordDays; }

			set	
			{
				_isChanged |= (_defaultShowRecordDays != value); _defaultShowRecordDays = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string ChannelStatus
		{
			get { return _channelStatus; }

			set	
			{

				if( value != null && value.Length > 40)
					throw new ArgumentOutOfRangeException("Invalid value for ChannelStatus", value, value.ToString());
				_isChanged |= (_channelStatus != value); _channelStatus = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? CreateBy
		{
			get { return _createBy; }

			set	
			{
				_isChanged |= (_createBy != value); _createBy = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual DateTime? CreateAt
		{
			get { return _createAt; }

			set	
			{
				_isChanged |= (_createAt != value); _createAt = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? LastModifyBy
		{
			get { return _lastModifyBy; }

			set	
			{
				_isChanged |= (_lastModifyBy != value); _lastModifyBy = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual DateTime? LastModifyAt
		{
			get { return _lastModifyAt; }

			set	
			{
				_isChanged |= (_lastModifyAt != value); _lastModifyAt = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string LastModifyComment
		{
			get { return _lastModifyComment; }

			set	
			{

				if( value != null && value.Length > 600)
					throw new ArgumentOutOfRangeException("Invalid value for LastModifyComment", value, value.ToString());
				_isChanged |= (_lastModifyComment != value); _lastModifyComment = value;
			}
		}
	

		#endregion 

        

		#region Equals 和 HashCode 方法覆盖
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			 return this.CheckEquals(obj as SPSClientEntity);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			return GetEntityHashCode();
		}
		#endregion
		
		public override int GetDataEntityKey()
	    {
	        return this._id;
	    }
		
		
	
		#region ICloneable methods
		
		public virtual object Clone()
		{
			return this.MemberwiseClone();
		}
		
		#endregion
	
	}
}
