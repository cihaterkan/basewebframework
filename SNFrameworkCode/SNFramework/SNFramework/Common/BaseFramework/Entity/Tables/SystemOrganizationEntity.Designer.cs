// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Legendigital.Framework.Common.Entity;

namespace Legendigital.Framework.Common.BaseFramework.Entity.Tables
{
	/// <summary>
	///	
	/// </summary>
	[DataContract]
	public partial class SystemOrganizationEntity  : BaseTableEntity,ICloneable
	{
      #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemOrganizationEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_SHORTNAME = "ShortName";
		public static readonly string PROPERTY_NAME_CODE = "Code";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		public static readonly string PROPERTY_NAME_LOGOURL = "LogoUrl";
		public static readonly string PROPERTY_NAME_TYPE = "Type";
		public static readonly string PROPERTY_NAME_MASTERNAME = "MasterName";
		public static readonly string PROPERTY_NAME_ISMAINORGANIZATION = "IsMainOrganization";
		public static readonly string PROPERTY_NAME_PARENTID = "ParentID";
		public static readonly string PROPERTY_NAME_ADDRESSID = "AddressID";
		public static readonly string PROPERTY_NAME_TELPHONE = "TelPhone";
		public static readonly string PROPERTY_NAME_FAXNUMBER = "FaxNumber";
		public static readonly string PROPERTY_NAME_WEBSITE = "WebSite";
		public static readonly string PROPERTY_NAME_EMAIL = "Email";
		public static readonly string PROPERTY_NAME_CREATEBY = "CreateBy";
		public static readonly string PROPERTY_NAME_CREATEAT = "CreateAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYBY = "LastModifyBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYAT = "LastModifyAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYCOMMENT = "LastModifyComment";
		
        #endregion
	
 
      	
	
	
		 
		
		
		
		
	
        #region 私有成员变量

 
		
		private int _id;
		private string _name;
		private string _shortName;
		private string _code;
		private string _description;
		private string _logoUrl;
		private string _type;
		private string _masterName;
		private bool? _isMainOrganization;
		private int? _parentID;
		private int? _addressID;
		private string _telPhone;
		private string _faxNumber;
		private string _webSite;
		private string _email;
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
		public SystemOrganizationEntity()
		{
			_id = 0;
			_name = null;
			_shortName = null;
			_code = null;
			_description = null;
			_logoUrl = null;
			_type = null;
			_masterName = null;
			_isMainOrganization = null;
			_parentID = null;
			_addressID = null;
			_telPhone = null;
			_faxNumber = null;
			_webSite = null;
			_email = null;
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
		public SystemOrganizationEntity( int id, string name, string shortName, string code, string description, string logoUrl, string type, string masterName, bool? isMainOrganization, int? parentID, int? addressID, string telPhone, string faxNumber, string webSite, string email, int? createBy, DateTime? createAt, int? lastModifyBy, DateTime? lastModifyAt, string lastModifyComment)
		{
			_id = id;
			_name = name;
			_shortName = shortName;
			_code = code;
			_description = description;
			_logoUrl = logoUrl;
			_type = type;
			_masterName = masterName;
			_isMainOrganization = isMainOrganization;
			_parentID = parentID;
			_addressID = addressID;
			_telPhone = telPhone;
			_faxNumber = faxNumber;
			_webSite = webSite;
			_email = email;
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

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for Name", value, value.ToString());
				_isChanged |= (_name != value); _name = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string ShortName
		{
			get { return _shortName; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for ShortName", value, value.ToString());
				_isChanged |= (_shortName != value); _shortName = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string Code
		{
			get { return _code; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for Code", value, value.ToString());
				_isChanged |= (_code != value); _code = value;
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
		public virtual string LogoUrl
		{
			get { return _logoUrl; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for LogoUrl", value, value.ToString());
				_isChanged |= (_logoUrl != value); _logoUrl = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string Type
		{
			get { return _type; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for Type", value, value.ToString());
				_isChanged |= (_type != value); _type = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string MasterName
		{
			get { return _masterName; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for MasterName", value, value.ToString());
				_isChanged |= (_masterName != value); _masterName = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual bool? IsMainOrganization
		{
			get { return _isMainOrganization; }

			set	
			{
				_isChanged |= (_isMainOrganization != value); _isMainOrganization = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? ParentID
		{
			get { return _parentID; }

			set	
			{
				_isChanged |= (_parentID != value); _parentID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? AddressID
		{
			get { return _addressID; }

			set	
			{
				_isChanged |= (_addressID != value); _addressID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string TelPhone
		{
			get { return _telPhone; }

			set	
			{

				if( value != null && value.Length > 60)
					throw new ArgumentOutOfRangeException("Invalid value for TelPhone", value, value.ToString());
				_isChanged |= (_telPhone != value); _telPhone = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string FaxNumber
		{
			get { return _faxNumber; }

			set	
			{

				if( value != null && value.Length > 60)
					throw new ArgumentOutOfRangeException("Invalid value for FaxNumber", value, value.ToString());
				_isChanged |= (_faxNumber != value); _faxNumber = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string WebSite
		{
			get { return _webSite; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for WebSite", value, value.ToString());
				_isChanged |= (_webSite != value); _webSite = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string Email
		{
			get { return _email; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for Email", value, value.ToString());
				_isChanged |= (_email != value); _email = value;
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
			 return this.CheckEquals(obj as SystemOrganizationEntity);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			return GetEntityHashCode();
		}
		#endregion
		
		public override object GetDataEntityKey()
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
