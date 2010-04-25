// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;


namespace Legendigital.Framework.Common.BaseFramework.Data.Tables
{
    public partial class SystemPersonalizationSettingsDataObject : BaseNHibernateDataObject<SystemPersonalizationSettingsEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_PERSONALIZATIONID = Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_PERSONALIZATIONID);
		public static readonly Property PROPERTY_APPLICATIONID = Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_APPLICATIONID);
		#region applicationID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> InClude_ApplicationID_Query(NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemPersonalizationSettingsEntity.PROPERTY_NAME_APPLICATIONID, PROPERTY_APPLICATIONID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_APPLICATIONID_ALIAS_NAME = "ApplicationID_SystemPersonalizationSettingsEntity_Alias";
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONID = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationID");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONNAME = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationName");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONDESCRIPTION = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationDescription");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONURL = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationUrl");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONISSYSTEMAPPLICATION = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationIsSystemApplication");
		#endregion
		public static readonly Property PROPERTY_USERID = Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_USERID);
		#region userId字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> InClude_UserId_Query(NHibernateDynamicQueryGenerator<SystemPersonalizationSettingsEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemPersonalizationSettingsEntity.PROPERTY_NAME_USERID, PROPERTY_USERID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_USERID_ALIAS_NAME = "UserId_SystemPersonalizationSettingsEntity_Alias";
		public static readonly Property PROPERTY_USERID_USERID = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserID");
		public static readonly Property PROPERTY_USERID_USERLOGINID = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserLoginID");
		public static readonly Property PROPERTY_USERID_USERNAME = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserName");
		public static readonly Property PROPERTY_USERID_USEREMAIL = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserEmail");
		public static readonly Property PROPERTY_USERID_USERPASSWORD = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserPassword");
		public static readonly Property PROPERTY_USERID_USERSTATUS = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserStatus");
		public static readonly Property PROPERTY_USERID_USERCREATEDATE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserCreateDate");
		public static readonly Property PROPERTY_USERID_USERTYPE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserType");
		public static readonly Property PROPERTY_USERID_DEPARTMENTID = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".DepartmentID");
		public static readonly Property PROPERTY_USERID_MOBILEPIN = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".MobilePIN");
		public static readonly Property PROPERTY_USERID_PASSWORDFORMAT = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordFormat");
		public static readonly Property PROPERTY_USERID_PASSWORDSALT = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordSalt");
		public static readonly Property PROPERTY_USERID_LOWEREDEMAIL = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LoweredEmail");
		public static readonly Property PROPERTY_USERID_PASSWORDQUESTION = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordQuestion");
		public static readonly Property PROPERTY_USERID_PASSWORDANSWER = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordAnswer");
		public static readonly Property PROPERTY_USERID_COMMENTS = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".Comments");
		public static readonly Property PROPERTY_USERID_ISAPPROVED = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".IsApproved");
		public static readonly Property PROPERTY_USERID_ISLOCKEDOUT = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".IsLockedOut");
		public static readonly Property PROPERTY_USERID_LASTACTIVITYDATE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastActivityDate");
		public static readonly Property PROPERTY_USERID_LASTLOGINDATE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastLoginDate");
		public static readonly Property PROPERTY_USERID_LASTLOCKEDOUTDATE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastLockedOutDate");
		public static readonly Property PROPERTY_USERID_LASTPASSWORDCHANGEDATE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastPasswordChangeDate");
		public static readonly Property PROPERTY_USERID_FAILEDPWDATTEMPTCNT = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAttemptCnt");
		public static readonly Property PROPERTY_USERID_FAILEDPWDATTEMPTWNDSTART = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAttemptWndStart");
		public static readonly Property PROPERTY_USERID_FAILEDPWDANSATTEMPTCNT = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAnsAttemptCnt");
		public static readonly Property PROPERTY_USERID_FAILEDPWDANSATTEMPTWNDSTART = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAnsAttemptWndStart");
		public static readonly Property PROPERTY_USERID_ISNEEDCHGPWD = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".IsNeedChgPwd");
		#endregion
		public static readonly Property PROPERTY_PATH = Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_PATH);
		public static readonly Property PROPERTY_PAGESETTINGS = Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_PAGESETTINGS);
		public static readonly Property PROPERTY_LASTUPDATEDDATE = Property.ForName(SystemPersonalizationSettingsEntity.PROPERTY_NAME_LASTUPDATEDDATE);
      
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
                    break;
                case "ApplicationID":
                    return typeof (int);
                    break;
                case "UserId":
                    return typeof (int);
                    break;
                case "Path":
                    return typeof (string);
                    break;
                case "PageSettings":
                    return typeof (byte[]);
                    break;
                case "LastUpdatedDate":
                    return typeof (DateTime);
                    break;
          }
			return typeof(string);
        }
    }
}
