// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SystemPersonalizationSettingsDataObject.Designer.cs">
//   Copyright (c) Foreveross Enterprises. All rights reserved.
// </copyright>
// <summary>
//   Generated by MyGeneration Version # (1.3.0.9)
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery.Propertys;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;


namespace Legendigital.Framework.Common.BaseFramework.Data.Tables
{
    public partial class SystemPersonalizationSettingsDataObject : BaseNHibernateDataObject<SystemPersonalizationSettingsEntity,int>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_PERSONALIZATIONID = new IntProperty(Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_PERSONALIZATIONID));		
		public static readonly EntityProperty<SystemApplicationEntity> PROPERTY_APPLICATIONID = new EntityProperty<SystemApplicationEntity>(Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_APPLICATIONID));
		#region applicationID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> InClude_ApplicationID_Query(NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemPersonalizationSettingsEntity.PROPERTY_NAME_APPLICATIONID, PROPERTY_APPLICATIONID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_APPLICATIONID_ALIAS_NAME = "ApplicationID_SystemPersonalizationSettingsEntity_Alias";
		public static readonly IntProperty PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONID = new IntProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationID"));
		public static readonly StringProperty PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONNAME = new StringProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationName"));
		public static readonly StringProperty PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONCODE = new StringProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationCode"));
		public static readonly StringProperty PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONDESCRIPTION = new StringProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationDescription"));
		public static readonly StringProperty PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONURL = new StringProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationUrl"));
		public static readonly BoolProperty PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONISSYSTEMAPPLICATION = new BoolProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationIsSystemApplication"));
		public static readonly StringProperty PROPERTY_APPLICATIONID_STATUS = new StringProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".Status"));
		public static readonly IntProperty PROPERTY_APPLICATIONID_ORDERINDEX = new IntProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".OrderIndex"));
		public static readonly IntProperty PROPERTY_APPLICATIONID_CREATEBY = new IntProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".CreateBy"));
		public static readonly DateTimeProperty PROPERTY_APPLICATIONID_CREATEAT = new DateTimeProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".CreateAt"));
		public static readonly IntProperty PROPERTY_APPLICATIONID_LASTMODIFYBY = new IntProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".LastModifyBy"));
		public static readonly DateTimeProperty PROPERTY_APPLICATIONID_LASTMODIFYAT = new DateTimeProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".LastModifyAt"));
		public static readonly StringProperty PROPERTY_APPLICATIONID_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".LastModifyComment"));
		#endregion
		public static readonly EntityProperty<SystemUserEntity> PROPERTY_USERID = new EntityProperty<SystemUserEntity>(Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_USERID));
		#region userId字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> InClude_UserId_Query(NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemPersonalizationSettingsEntity.PROPERTY_NAME_USERID, PROPERTY_USERID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_USERID_ALIAS_NAME = "UserId_SystemPersonalizationSettingsEntity_Alias";
		public static readonly IntProperty PROPERTY_USERID_USERID = new IntProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserID"));
		public static readonly StringProperty PROPERTY_USERID_USERLOGINID = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserLoginID"));
		public static readonly StringProperty PROPERTY_USERID_USERNAME = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserName"));
		public static readonly StringProperty PROPERTY_USERID_USEREMAIL = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserEmail"));
		public static readonly StringProperty PROPERTY_USERID_USERPASSWORD = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserPassword"));
		public static readonly StringProperty PROPERTY_USERID_USERSTATUS = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserStatus"));
		public static readonly DateTimeProperty PROPERTY_USERID_USERCREATEDATE = new DateTimeProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserCreateDate"));
		public static readonly StringProperty PROPERTY_USERID_USERTYPE = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserType"));
		public static readonly StringProperty PROPERTY_USERID_MOBILEPIN = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".MobilePIN"));
		public static readonly IntProperty PROPERTY_USERID_PASSWORDFORMAT = new IntProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordFormat"));
		public static readonly StringProperty PROPERTY_USERID_PASSWORDQUESTION = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordQuestion"));
		public static readonly StringProperty PROPERTY_USERID_PASSWORDANSWER = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordAnswer"));
		public static readonly StringProperty PROPERTY_USERID_COMMENTS = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".Comments"));
		public static readonly BoolProperty PROPERTY_USERID_ISAPPROVED = new BoolProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".IsApproved"));
		public static readonly BoolProperty PROPERTY_USERID_ISLOCKEDOUT = new BoolProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".IsLockedOut"));
		public static readonly DateTimeProperty PROPERTY_USERID_LASTACTIVITYDATE = new DateTimeProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastActivityDate"));
		public static readonly DateTimeProperty PROPERTY_USERID_LASTLOGINDATE = new DateTimeProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastLoginDate"));
		public static readonly DateTimeProperty PROPERTY_USERID_LASTLOCKEDOUTDATE = new DateTimeProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastLockedOutDate"));
		public static readonly DateTimeProperty PROPERTY_USERID_LASTPASSWORDCHANGEDATE = new DateTimeProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastPasswordChangeDate"));
		public static readonly IntProperty PROPERTY_USERID_FAILEDPWDATTEMPTCNT = new IntProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAttemptCnt"));
		public static readonly DateTimeProperty PROPERTY_USERID_FAILEDPWDATTEMPTWNDSTART = new DateTimeProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAttemptWndStart"));
		public static readonly IntProperty PROPERTY_USERID_FAILEDPWDANSATTEMPTCNT = new IntProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAnsAttemptCnt"));
		public static readonly DateTimeProperty PROPERTY_USERID_FAILEDPWDANSATTEMPTWNDSTART = new DateTimeProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAnsAttemptWndStart"));
		public static readonly BoolProperty PROPERTY_USERID_ISNEEDCHGPWD = new BoolProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".IsNeedChgPwd"));
		public static readonly StringProperty PROPERTY_USERID_PASSWORDSALT = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordSalt"));
		public static readonly StringProperty PROPERTY_USERID_LOWEREDEMAIL = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LoweredEmail"));
		public static readonly StringProperty PROPERTY_USERID_VALIDATETYPE = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".ValidateType"));
		public static readonly StringProperty PROPERTY_USERID_ADDOMAIN = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".ADDomain"));
		public static readonly BoolProperty PROPERTY_USERID_BINDUKEY = new BoolProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".BindUKey"));
		public static readonly StringProperty PROPERTY_USERID_USBKEYSERIAL = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".USBKeySerial"));
		public static readonly StringProperty PROPERTY_USERID_USBKEYCODE = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".USBKeyCode"));
		public static readonly StringProperty PROPERTY_USERID_SSOKEY = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".SSOKey"));
		public static readonly IntProperty PROPERTY_USERID_CREATEBY = new IntProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".CreateBy"));
		public static readonly DateTimeProperty PROPERTY_USERID_CREATEAT = new DateTimeProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".CreateAt"));
		public static readonly IntProperty PROPERTY_USERID_LASTMODIFYBY = new IntProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastModifyBy"));
		public static readonly DateTimeProperty PROPERTY_USERID_LASTMODIFYAT = new DateTimeProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastModifyAt"));
		public static readonly StringProperty PROPERTY_USERID_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastModifyComment"));
		#endregion
		public static readonly StringProperty PROPERTY_PATH = new StringProperty(Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_PATH));		
		public static readonly ByteArrayProperty PROPERTY_PAGESETTINGS = new ByteArrayProperty(Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_PAGESETTINGS));		
		public static readonly DateTimeProperty PROPERTY_LASTUPDATEDDATE = new DateTimeProperty(Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_LASTUPDATEDDATE));		
		public static readonly IntProperty PROPERTY_CREATEBY = new IntProperty(Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_CREATEBY));		
		public static readonly DateTimeProperty PROPERTY_CREATEAT = new DateTimeProperty(Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_CREATEAT));		
		public static readonly IntProperty PROPERTY_LASTMODIFYBY = new IntProperty(Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_LASTMODIFYBY));		
		public static readonly DateTimeProperty PROPERTY_LASTMODIFYAT = new DateTimeProperty(Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_LASTMODIFYAT));		
		public static readonly StringProperty PROPERTY_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_LASTMODIFYCOMMENT));		
      












		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "PersonalizationID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "PersonalizationID":
                    return typeof (int);
                case "ApplicationID":
                    return typeof (int);
                case "UserId":
                    return typeof (int);
                case "Path":
                    return typeof (string);
                case "PageSettings":
                    return typeof (byte[]);
                case "LastUpdatedDate":
                    return typeof (DateTime);
                case "CreateBy":
                    return typeof (int);
                case "CreateAt":
                    return typeof (DateTime);
                case "LastModifyBy":
                    return typeof (int);
                case "LastModifyAt":
                    return typeof (DateTime);
                case "LastModifyComment":
                    return typeof (string);
          }
			return typeof(string);
        }

		#region 获取外键字段类型
		
		public override Type GetFieldTypeByFieldName(string fieldName, string parent_alias)
        {
            switch (parent_alias)
            {
	            case "ApplicationID_SystemPersonalizationSettingsEntity_Alias":
					switch (fieldName)
					{
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.SystemApplicationID":
							return typeof (int);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.SystemApplicationName":
							return typeof (string);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.SystemApplicationCode":
							return typeof (string);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.SystemApplicationDescription":
							return typeof (string);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.SystemApplicationUrl":
							return typeof (string);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.SystemApplicationIsSystemApplication":
							return typeof (bool);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.Status":
							return typeof (string);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.OrderIndex":
							return typeof (int);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.CreateBy":
							return typeof (int);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.CreateAt":
							return typeof (DateTime);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.LastModifyBy":
							return typeof (int);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.LastModifyAt":
							return typeof (DateTime);
                		case "ApplicationID_SystemPersonalizationSettingsEntity_Alias.LastModifyComment":
							return typeof (string);
          			}
                    break;
	            case "UserId_SystemPersonalizationSettingsEntity_Alias":
					switch (fieldName)
					{
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.UserID":
							return typeof (int);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.UserLoginID":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.UserName":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.UserEmail":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.UserPassword":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.UserStatus":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.UserCreateDate":
							return typeof (DateTime);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.UserType":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.MobilePIN":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.PasswordFormat":
							return typeof (int);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.PasswordQuestion":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.PasswordAnswer":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.Comments":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.IsApproved":
							return typeof (bool);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.IsLockedOut":
							return typeof (bool);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.LastActivityDate":
							return typeof (DateTime);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.LastLoginDate":
							return typeof (DateTime);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.LastLockedOutDate":
							return typeof (DateTime);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.LastPasswordChangeDate":
							return typeof (DateTime);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.FailedPwdAttemptCnt":
							return typeof (int);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.FailedPwdAttemptWndStart":
							return typeof (DateTime);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.FailedPwdAnsAttemptCnt":
							return typeof (int);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.FailedPwdAnsAttemptWndStart":
							return typeof (DateTime);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.IsNeedChgPwd":
							return typeof (bool);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.PasswordSalt":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.LoweredEmail":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.ValidateType":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.ADDomain":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.BindUKey":
							return typeof (bool);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.USBKeySerial":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.USBKeyCode":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.SSOKey":
							return typeof (string);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.CreateBy":
							return typeof (int);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.CreateAt":
							return typeof (DateTime);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.LastModifyBy":
							return typeof (int);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.LastModifyAt":
							return typeof (DateTime);
                		case "UserId_SystemPersonalizationSettingsEntity_Alias.LastModifyComment":
							return typeof (string);
          			}
                    break;
 
                default:
                    break;
            }

            return typeof(string);
        }
		
		#endregion

        public override void InClude_Parent_Table(string parent_alias, NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> queryGenerator)
        {
            switch (parent_alias)
            {
	            case "ApplicationID_SystemPersonalizationSettingsEntity_Alias":
                    queryGenerator.AddAlians(SystemPersonalizationSettingsEntity.PROPERTY_NAME_APPLICATIONID, PROPERTY_APPLICATIONID_ALIAS_NAME);
                    break;
	            case "UserId_SystemPersonalizationSettingsEntity_Alias":
                    queryGenerator.AddAlians(SystemPersonalizationSettingsEntity.PROPERTY_NAME_USERID, PROPERTY_USERID_ALIAS_NAME);
                    break;
                default:
                    break;
 
            }
        }
		
		
		
		public List<SystemPersonalizationSettingsEntity> GetList_By_ApplicationID_SystemApplicationEntity(SystemApplicationEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_APPLICATIONID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemPersonalizationSettingsEntity> GetPageList_By_ApplicationID_SystemApplicationEntity(string orderByColumnName, bool isDesc, SystemApplicationEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_APPLICATIONID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		
		public List<SystemPersonalizationSettingsEntity> GetList_By_UserId_SystemUserEntity(SystemUserEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_USERID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemPersonalizationSettingsEntity> GetPageList_By_UserId_SystemUserEntity(string orderByColumnName, bool isDesc, SystemUserEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_USERID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		

		
		
    }
}
