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
	public partial class SPDayReportEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "LD.SPPipeManage.Entity.Tables.SPDayReportEntity";
		public static readonly string PROPERTY_NAME_REPORTID = "ReportID";
		public static readonly string PROPERTY_NAME_REPORTDATE = "ReportDate";
		public static readonly string PROPERTY_NAME_UPTOTALCOUNT = "UpTotalCount";
		public static readonly string PROPERTY_NAME_UPSUCCESS = "UpSuccess";
		public static readonly string PROPERTY_NAME_INTERCEPTTOTALCOUNT = "InterceptTotalCount";
		public static readonly string PROPERTY_NAME_INTERCEPTSUCCESS = "InterceptSuccess";
		public static readonly string PROPERTY_NAME_DOWNTOTALCOUNT = "DownTotalCount";
		public static readonly string PROPERTY_NAME_DOWNSUCCESS = "DownSuccess";
		public static readonly string PROPERTY_NAME_DAYXMLFILENAME = "DayXmlFileName";
		public static readonly string PROPERTY_NAME_CLIENTID = "ClientID";
		public static readonly string PROPERTY_NAME_CHANNELID = "ChannelID";
		public static readonly string PROPERTY_NAME_CHANNELCLIENTID = "ChannelClientID";
		public static readonly string PROPERTY_NAME_UPERID = "UperID";
		public static readonly string PROPERTY_NAME_CLIENTGROUPID = "ClientGroupID";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _reportID;
		private DateTime? _reportDate;
		private int? _upTotalCount;
		private int? _upSuccess;
		private int? _interceptTotalCount;
		private int? _interceptSuccess;
		private int? _downTotalCount;
		private int? _downSuccess;
		private string _dayXmlFileName;
		private int? _clientID;
		private int? _channelID;
		private int? _channelClientID;
		private int? _uperID;
		private int? _clientGroupID;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SPDayReportEntity()
		{
			_reportID = 0;
			_reportDate = null;
			_upTotalCount = null;
			_upSuccess = null;
			_interceptTotalCount = null;
			_interceptSuccess = null;
			_downTotalCount = null;
			_downSuccess = null;
			_dayXmlFileName = null;
			_clientID = null;
			_channelID = null;
			_channelClientID = null;
			_uperID = null;
			_clientGroupID = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SPDayReportEntity( int reportID, DateTime? reportDate, int? upTotalCount, int? upSuccess, int? interceptTotalCount, int? interceptSuccess, int? downTotalCount, int? downSuccess, string dayXmlFileName, int? clientID, int? channelID, int? channelClientID, int? uperID, int? clientGroupID)
		{
			_reportID = reportID;
			_reportDate = reportDate;
			_upTotalCount = upTotalCount;
			_upSuccess = upSuccess;
			_interceptTotalCount = interceptTotalCount;
			_interceptSuccess = interceptSuccess;
			_downTotalCount = downTotalCount;
			_downSuccess = downSuccess;
			_dayXmlFileName = dayXmlFileName;
			_clientID = clientID;
			_channelID = channelID;
			_channelClientID = channelClientID;
			_uperID = uperID;
			_clientGroupID = clientGroupID;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int ReportID
		{
			get { return _reportID; }

			set	
			{
				_isChanged |= (_reportID != value); _reportID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual DateTime? ReportDate
		{
			get { return _reportDate; }

			set	
			{
				_isChanged |= (_reportDate != value); _reportDate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? UpTotalCount
		{
			get { return _upTotalCount; }

			set	
			{
				_isChanged |= (_upTotalCount != value); _upTotalCount = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? UpSuccess
		{
			get { return _upSuccess; }

			set	
			{
				_isChanged |= (_upSuccess != value); _upSuccess = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? InterceptTotalCount
		{
			get { return _interceptTotalCount; }

			set	
			{
				_isChanged |= (_interceptTotalCount != value); _interceptTotalCount = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? InterceptSuccess
		{
			get { return _interceptSuccess; }

			set	
			{
				_isChanged |= (_interceptSuccess != value); _interceptSuccess = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? DownTotalCount
		{
			get { return _downTotalCount; }

			set	
			{
				_isChanged |= (_downTotalCount != value); _downTotalCount = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? DownSuccess
		{
			get { return _downSuccess; }

			set	
			{
				_isChanged |= (_downSuccess != value); _downSuccess = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string DayXmlFileName
		{
			get { return _dayXmlFileName; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for DayXmlFileName", value, value.ToString());
				_isChanged |= (_dayXmlFileName != value); _dayXmlFileName = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? ClientID
		{
			get { return _clientID; }

			set	
			{
				_isChanged |= (_clientID != value); _clientID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? ChannelID
		{
			get { return _channelID; }

			set	
			{
				_isChanged |= (_channelID != value); _channelID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? ChannelClientID
		{
			get { return _channelClientID; }

			set	
			{
				_isChanged |= (_channelClientID != value); _channelClientID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? UperID
		{
			get { return _uperID; }

			set	
			{
				_isChanged |= (_uperID != value); _uperID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? ClientGroupID
		{
			get { return _clientGroupID; }

			set	
			{
				_isChanged |= (_clientGroupID != value); _clientGroupID = value;
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
			
			SPDayReportEntity castObj = (SPDayReportEntity)obj;
			
			return ( castObj != null ) && ( this._reportID == castObj.ReportID );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _reportID.GetHashCode();

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