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
	public class SPChannelDefaultClientSycnParamsDataContract
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "LD.SPPipeManage.Bussiness.DataContracts.Tables.SPChannelDefaultClientSycnParamsDataContract";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		public static readonly string PROPERTY_NAME_ISENABLE = "IsEnable";
		public static readonly string PROPERTY_NAME_ISREQUIRED = "IsRequired";
		public static readonly string PROPERTY_NAME_CHANNELID = "ChannelID";
		public static readonly string PROPERTY_NAME_MAPPINGPARAMS = "MappingParams";
		public static readonly string PROPERTY_NAME_TITLE = "Title";
		
        #endregion
	
        #region 私有成员变量
		
		private int _id;
		private string _name;
		private string _description;
		private bool? _isEnable;
		private bool? _isRequired;
		private int? _channelID;
		private string _mappingParams;
		private string _title;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SPChannelDefaultClientSycnParamsDataContract()
		{
			_id = 0;
			_name = null;
			_description = null;
			_isEnable = null;
			_isRequired = null;
			_channelID = null;
			_mappingParams = null;
			_title = null;
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
		public bool? IsEnable
		{
			get { return _isEnable; }

			set	
			{
				_isEnable = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public bool? IsRequired
		{
			get { return _isRequired; }

			set	
			{
				_isRequired = value;
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
		public string MappingParams
		{
			get { return _mappingParams; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for MappingParams", value, value.ToString());
				_mappingParams = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string Title
		{
			get { return _title; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for Title", value, value.ToString());
				_title = value;
			}
		}

		
		#endregion 


        public void FromWrapper(SPChannelDefaultClientSycnParamsWrapper wrapper)
		{
			this.Id = wrapper.Id;
			this.Name = wrapper.Name;
			this.Description = wrapper.Description;
			this.IsEnable = wrapper.IsEnable;
			this.IsRequired = wrapper.IsRequired;
			this.ChannelID = (wrapper.ChannelID!=null) ? wrapper.ChannelID.Id : 0 ; 
			this.MappingParams = wrapper.MappingParams;
			this.Title = wrapper.Title;
		}
		
		
		public SPChannelDefaultClientSycnParamsWrapper ToWrapper()
        {
			SPChannelDefaultClientSycnParamsWrapper wrapper = new SPChannelDefaultClientSycnParamsWrapper();
			wrapper.Id = this.Id;
			wrapper.Name = this.Name;
			wrapper.Description = this.Description;
			wrapper.IsEnable = this.IsEnable;
			wrapper.IsRequired = this.IsRequired;
			wrapper.ChannelID =  (this.ChannelID==null) ? null : SPChannelWrapper.FindById(this.ChannelID);
			wrapper.MappingParams = this.MappingParams;
			wrapper.Title = this.Title;
		
		return wrapper;
        }



   }
}
