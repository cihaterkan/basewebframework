// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SystemUserGroupUserRelationDataObject.Designer.cs">
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
    public partial class SystemUserGroupUserRelationDataObject : BaseNHibernateDataObject<SystemUserGroupUserRelationEntity,int>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_USERGROUPUSERID = new IntProperty(Property.ForName(SystemUserGroupUserRelationEntity.PROPERTY_NAME_USERGROUPUSERID));		
		public static readonly EntityProperty<SystemUserEntity> PROPERTY_USERID = new EntityProperty<SystemUserEntity>(Property.ForName(SystemUserGroupUserRelationEntity.PROPERTY_NAME_USERID));
		#region userID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemUserGroupUserRelationEntity> InClude_UserID_Query(NHibernateDynamicQueryGenerator<SystemUserGroupUserRelationEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemUserGroupUserRelationEntity.PROPERTY_NAME_USERID, PROPERTY_USERID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_USERID_ALIAS_NAME = "UserID_SystemUserGroupUserRelationEntity_Alias";
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
		public static readonly EntityProperty<SystemUserGroupEntity> PROPERTY_USERGROUPID = new EntityProperty<SystemUserGroupEntity>(Property.ForName(SystemUserGroupUserRelationEntity.PROPERTY_NAME_USERGROUPID));
		#region userGroupID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemUserGroupUserRelationEntity> InClude_UserGroupID_Query(NHibernateDynamicQueryGenerator<SystemUserGroupUserRelationEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemUserGroupUserRelationEntity.PROPERTY_NAME_USERGROUPID, PROPERTY_USERGROUPID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_USERGROUPID_ALIAS_NAME = "UserGroupID_SystemUserGroupUserRelationEntity_Alias";
		public static readonly IntProperty PROPERTY_USERGROUPID_GROUPID = new IntProperty(Property.ForName(PROPERTY_USERGROUPID_ALIAS_NAME + ".GroupID"));
		public static readonly StringProperty PROPERTY_USERGROUPID_GROUPNAMECN = new StringProperty(Property.ForName(PROPERTY_USERGROUPID_ALIAS_NAME + ".GroupNameCn"));
		public static readonly StringProperty PROPERTY_USERGROUPID_GROUPNAMEEN = new StringProperty(Property.ForName(PROPERTY_USERGROUPID_ALIAS_NAME + ".GroupNameEn"));
		public static readonly StringProperty PROPERTY_USERGROUPID_GROUPDESCRIPTION = new StringProperty(Property.ForName(PROPERTY_USERGROUPID_ALIAS_NAME + ".GroupDescription"));
		public static readonly IntProperty PROPERTY_USERGROUPID_CREATEBY = new IntProperty(Property.ForName(PROPERTY_USERGROUPID_ALIAS_NAME + ".CreateBy"));
		public static readonly DateTimeProperty PROPERTY_USERGROUPID_CREATEAT = new DateTimeProperty(Property.ForName(PROPERTY_USERGROUPID_ALIAS_NAME + ".CreateAt"));
		public static readonly IntProperty PROPERTY_USERGROUPID_LASTMODIFYBY = new IntProperty(Property.ForName(PROPERTY_USERGROUPID_ALIAS_NAME + ".LastModifyBy"));
		public static readonly DateTimeProperty PROPERTY_USERGROUPID_LASTMODIFYAT = new DateTimeProperty(Property.ForName(PROPERTY_USERGROUPID_ALIAS_NAME + ".LastModifyAt"));
		public static readonly StringProperty PROPERTY_USERGROUPID_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(PROPERTY_USERGROUPID_ALIAS_NAME + ".LastModifyComment"));
		#endregion
      












		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "UserGroupUserID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "UserGroupUserID":
                    return typeof (int);
                case "UserID":
                    return typeof (int);
                case "UserGroupID":
                    return typeof (int);
          }
			return typeof(string);
        }

		#region 获取外键字段类型
		
		public override Type GetFieldTypeByFieldName(string fieldName, string parent_alias)
        {
            switch (parent_alias)
            {
	            case "UserID_SystemUserGroupUserRelationEntity_Alias":
					switch (fieldName)
					{
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.UserID":
							return typeof (int);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.UserLoginID":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.UserName":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.UserEmail":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.UserPassword":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.UserStatus":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.UserCreateDate":
							return typeof (DateTime);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.UserType":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.MobilePIN":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.PasswordFormat":
							return typeof (int);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.PasswordQuestion":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.PasswordAnswer":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.Comments":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.IsApproved":
							return typeof (bool);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.IsLockedOut":
							return typeof (bool);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.LastActivityDate":
							return typeof (DateTime);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.LastLoginDate":
							return typeof (DateTime);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.LastLockedOutDate":
							return typeof (DateTime);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.LastPasswordChangeDate":
							return typeof (DateTime);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.FailedPwdAttemptCnt":
							return typeof (int);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.FailedPwdAttemptWndStart":
							return typeof (DateTime);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.FailedPwdAnsAttemptCnt":
							return typeof (int);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.FailedPwdAnsAttemptWndStart":
							return typeof (DateTime);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.IsNeedChgPwd":
							return typeof (bool);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.PasswordSalt":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.LoweredEmail":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.ValidateType":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.ADDomain":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.BindUKey":
							return typeof (bool);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.USBKeySerial":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.USBKeyCode":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.SSOKey":
							return typeof (string);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.CreateBy":
							return typeof (int);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.CreateAt":
							return typeof (DateTime);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.LastModifyBy":
							return typeof (int);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.LastModifyAt":
							return typeof (DateTime);
                		case "UserID_SystemUserGroupUserRelationEntity_Alias.LastModifyComment":
							return typeof (string);
          			}
                    break;
	            case "UserGroupID_SystemUserGroupUserRelationEntity_Alias":
					switch (fieldName)
					{
                		case "UserGroupID_SystemUserGroupUserRelationEntity_Alias.GroupID":
							return typeof (int);
                		case "UserGroupID_SystemUserGroupUserRelationEntity_Alias.GroupNameCn":
							return typeof (string);
                		case "UserGroupID_SystemUserGroupUserRelationEntity_Alias.GroupNameEn":
							return typeof (string);
                		case "UserGroupID_SystemUserGroupUserRelationEntity_Alias.GroupDescription":
							return typeof (string);
                		case "UserGroupID_SystemUserGroupUserRelationEntity_Alias.CreateBy":
							return typeof (int);
                		case "UserGroupID_SystemUserGroupUserRelationEntity_Alias.CreateAt":
							return typeof (DateTime);
                		case "UserGroupID_SystemUserGroupUserRelationEntity_Alias.LastModifyBy":
							return typeof (int);
                		case "UserGroupID_SystemUserGroupUserRelationEntity_Alias.LastModifyAt":
							return typeof (DateTime);
                		case "UserGroupID_SystemUserGroupUserRelationEntity_Alias.LastModifyComment":
							return typeof (string);
          			}
                    break;
 
                default:
                    break;
            }

            return typeof(string);
        }
		
		#endregion

        public override void InClude_Parent_Table(string parent_alias, NHibernateDynamicQueryGenerator<SystemUserGroupUserRelationEntity> queryGenerator)
        {
            switch (parent_alias)
            {
	            case "UserID_SystemUserGroupUserRelationEntity_Alias":
                    queryGenerator.AddAlians(SystemUserGroupUserRelationEntity.PROPERTY_NAME_USERID, PROPERTY_USERID_ALIAS_NAME);
                    break;
	            case "UserGroupID_SystemUserGroupUserRelationEntity_Alias":
                    queryGenerator.AddAlians(SystemUserGroupUserRelationEntity.PROPERTY_NAME_USERGROUPID, PROPERTY_USERGROUPID_ALIAS_NAME);
                    break;
                default:
                    break;
 
            }
        }
		
		
		
		public List<SystemUserGroupUserRelationEntity> GetList_By_UserID_SystemUserEntity(SystemUserEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemUserGroupUserRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_USERID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemUserGroupUserRelationEntity> GetPageList_By_UserID_SystemUserEntity(string orderByColumnName, bool isDesc, SystemUserEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemUserGroupUserRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_USERID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		
		public List<SystemUserGroupUserRelationEntity> GetList_By_UserGroupID_SystemUserGroupEntity(SystemUserGroupEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemUserGroupUserRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_USERGROUPID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemUserGroupUserRelationEntity> GetPageList_By_UserGroupID_SystemUserGroupEntity(string orderByColumnName, bool isDesc, SystemUserGroupEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemUserGroupUserRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_USERGROUPID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		

		
		
    }
}
