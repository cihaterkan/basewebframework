using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using LD.SPPipeManage.Bussiness.Wrappers;

namespace LD.SPPipeManage.Bussiness.DataContracts.Tables
{
	/// <summary>
	///	
	/// </summary>
	[DataContract]
	public class SPClientChannelSettingDataContract
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "LD.SPPipeManage.Bussiness.DataContracts.Tables.SPClientChannelSettingDataContract";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		public static readonly string PROPERTY_NAME_CHANNELID = "ChannelID";
		public static readonly string PROPERTY_NAME_CLINETID = "ClinetID";
		public static readonly string PROPERTY_NAME_INTERCEPTRATE = "InterceptRate";
		public static readonly string PROPERTY_NAME_UPRATE = "UpRate";
		public static readonly string PROPERTY_NAME_DOWNRATE = "DownRate";
		public static readonly string PROPERTY_NAME_COMMANDTYPE = "CommandType";
		public static readonly string PROPERTY_NAME_COMMANDCODE = "CommandCode";
		public static readonly string PROPERTY_NAME_DISABLE = "Disable";
		public static readonly string PROPERTY_NAME_COMMANDCOLUMN = "CommandColumn";
		public static readonly string PROPERTY_NAME_INTERCEPTRATETYPE = "InterceptRateType";
		public static readonly string PROPERTY_NAME_SYNCDATA = "SyncData";
		public static readonly string PROPERTY_NAME_SYNCDATAURL = "SyncDataUrl";
		public static readonly string PROPERTY_NAME_OKMESSAGE = "OkMessage";
		public static readonly string PROPERTY_NAME_FAILEDMESSAGE = "FailedMessage";
		public static readonly string PROPERTY_NAME_SYNCTYPE = "SyncType";
		public static readonly string PROPERTY_NAME_ORDERINDEX = "OrderIndex";
		public static readonly string PROPERTY_NAME_CHANNELCODE = "ChannelCode";
		
        #endregion
	
        #region 私有成员变量
		
		private int _id;
		private string _name;
		private string _description;
		private int? _channelID;
		private int? _clinetID;
		private int? _interceptRate;
		private int? _upRate;
		private int? _downRate;
		private string _commandType;
		private string _commandCode;
		private bool? _disable;
		private string _commandColumn;
		private string _interceptRateType;
		private bool? _syncData;
		private string _syncDataUrl;
		private string _okMessage;
		private string _failedMessage;
		private string _syncType;
		private int? _orderIndex;
		private string _channelCode;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SPClientChannelSettingDataContract()
		{
			_id = 0;
			_name = null;
			_description = null;
			_channelID = null;
			_clinetID = null;
			_interceptRate = null;
			_upRate = null;
			_downRate = null;
			_commandType = null;
			_commandCode = null;
			_disable = null;
			_commandColumn = null;
			_interceptRateType = null;
			_syncData = null;
			_syncDataUrl = null;
			_okMessage = null;
			_failedMessage = null;
			_syncType = null;
			_orderIndex = 1;
			_channelCode = null;
		}
		#endregion

	    #region 公共属性

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int Id
		{
			get { return _id; }

			set	
			{
				_id = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string Name
		{
			get { return _name; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for Name", value, value.ToString());
				_name = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string Description
		{
			get { return _description; }

			set	
			{

				if( value != null && value.Length > 4000)
					throw new ArgumentOutOfRangeException("Invalid value for Description", value, value.ToString());
				_description = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? ChannelID
		{
			get { return _channelID; }

			set	
			{
				_channelID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? ClinetID
		{
			get { return _clinetID; }

			set	
			{
				_clinetID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? InterceptRate
		{
			get { return _interceptRate; }

			set	
			{
				_interceptRate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? UpRate
		{
			get { return _upRate; }

			set	
			{
				_upRate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? DownRate
		{
			get { return _downRate; }

			set	
			{
				_downRate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string CommandType
		{
			get { return _commandType; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for CommandType", value, value.ToString());
				_commandType = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string CommandCode
		{
			get { return _commandCode; }

			set	
			{

				if( value != null && value.Length > 1600)
					throw new ArgumentOutOfRangeException("Invalid value for CommandCode", value, value.ToString());
				_commandCode = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public bool? Disable
		{
			get { return _disable; }

			set	
			{
				_disable = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string CommandColumn
		{
			get { return _commandColumn; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for CommandColumn", value, value.ToString());
				_commandColumn = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string InterceptRateType
		{
			get { return _interceptRateType; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for InterceptRateType", value, value.ToString());
				_interceptRateType = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public bool? SyncData
		{
			get { return _syncData; }

			set	
			{
				_syncData = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string SyncDataUrl
		{
			get { return _syncDataUrl; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for SyncDataUrl", value, value.ToString());
				_syncDataUrl = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string OkMessage
		{
			get { return _okMessage; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for OkMessage", value, value.ToString());
				_okMessage = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string FailedMessage
		{
			get { return _failedMessage; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for FailedMessage", value, value.ToString());
				_failedMessage = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string SyncType
		{
			get { return _syncType; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for SyncType", value, value.ToString());
				_syncType = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? OrderIndex
		{
			get { return _orderIndex; }

			set	
			{
				_orderIndex = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string ChannelCode
		{
			get { return _channelCode; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for ChannelCode", value, value.ToString());
				_channelCode = value;
			}
		}

		
		#endregion 


        public void FromWrapper(SPClientChannelSettingWrapper wrapper)
		{
			this.Id = wrapper.Id;
			this.Name = wrapper.Name;
			this.Description = wrapper.Description;
			this.ChannelID = (wrapper.ChannelID!=null) ? wrapper.ChannelID.Id : 0 ; 
			this.ClinetID = (wrapper.ClinetID!=null) ? wrapper.ClinetID.Id : 0 ; 
			this.InterceptRate = wrapper.InterceptRate;
			this.UpRate = wrapper.UpRate;
			this.DownRate = wrapper.DownRate;
			this.CommandType = wrapper.CommandType;
			this.CommandCode = wrapper.CommandCode;
			this.Disable = wrapper.Disable;
			this.CommandColumn = wrapper.CommandColumn;
			this.InterceptRateType = wrapper.InterceptRateType;
			this.SyncData = wrapper.SyncData;
			this.SyncDataUrl = wrapper.SyncDataUrl;
			this.OkMessage = wrapper.OkMessage;
			this.FailedMessage = wrapper.FailedMessage;
			this.SyncType = wrapper.SyncType;
			this.OrderIndex = wrapper.OrderIndex;
			this.ChannelCode = wrapper.ChannelCode;
		}
		
		
		public SPClientChannelSettingWrapper ToWrapper()
        {
			SPClientChannelSettingWrapper wrapper = new SPClientChannelSettingWrapper();
			wrapper.Id = this.Id;
			wrapper.Name = this.Name;
			wrapper.Description = this.Description;
			wrapper.ChannelID =  (this.ChannelID==null) ? null : SPChannelWrapper.FindById(this.ChannelID);
			wrapper.ClinetID =  (this.ClinetID==null) ? null : SPClientWrapper.FindById(this.ClinetID);
			wrapper.InterceptRate = this.InterceptRate;
			wrapper.UpRate = this.UpRate;
			wrapper.DownRate = this.DownRate;
			wrapper.CommandType = this.CommandType;
			wrapper.CommandCode = this.CommandCode;
			wrapper.Disable = this.Disable;
			wrapper.CommandColumn = this.CommandColumn;
			wrapper.InterceptRateType = this.InterceptRateType;
			wrapper.SyncData = this.SyncData;
			wrapper.SyncDataUrl = this.SyncDataUrl;
			wrapper.OkMessage = this.OkMessage;
			wrapper.FailedMessage = this.FailedMessage;
			wrapper.SyncType = this.SyncType;
			wrapper.OrderIndex = this.OrderIndex;
			wrapper.ChannelCode = this.ChannelCode;
		
		return wrapper;
        }



   }
}
