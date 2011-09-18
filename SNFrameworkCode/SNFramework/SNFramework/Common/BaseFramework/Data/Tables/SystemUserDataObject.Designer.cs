// Generated by MyGeneration Version # (1.3.0.9)
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
    public partial class SystemUserDataObject : BaseNHibernateDataObject<SystemUserEntity>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_USERID = new IntProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_USERID));		
		public static readonly StringProperty PROPERTY_USERLOGINID = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_USERLOGINID));		
		public static readonly StringProperty PROPERTY_USERNAME = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_USERNAME));		
		public static readonly StringProperty PROPERTY_USEREMAIL = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_USEREMAIL));		
		public static readonly StringProperty PROPERTY_USERPASSWORD = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_USERPASSWORD));		
		public static readonly StringProperty PROPERTY_USERSTATUS = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_USERSTATUS));		
		public static readonly DateTimeProperty PROPERTY_USERCREATEDATE = new DateTimeProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_USERCREATEDATE));		
		public static readonly StringProperty PROPERTY_USERTYPE = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_USERTYPE));		
		public static readonly EntityProperty<SystemDepartmentEntity> PROPERTY_DEPARTMENTID = new EntityProperty<SystemDepartmentEntity>(Property.ForName(SystemUserEntity.PROPERTY_NAME_DEPARTMENTID));
		#region departmentID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemUserEntity> InClude_DepartmentID_Query(NHibernateDynamicQueryGenerator<SystemUserEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemUserEntity.PROPERTY_NAME_DEPARTMENTID, PROPERTY_DEPARTMENTID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_DEPARTMENTID_ALIAS_NAME = "DepartmentID_SystemUserEntity_Alias";
		public static readonly IntProperty PROPERTY_DEPARTMENTID_DEPARTMENTID = new IntProperty(Property.ForName(PROPERTY_DEPARTMENTID_ALIAS_NAME + ".DepartmentID"));
		public static readonly EntityProperty<SystemDepartmentEntity> PROPERTY_DEPARTMENTID_PARENTDEPARTMENTID = new EntityProperty<SystemDepartmentEntity>(Property.ForName(PROPERTY_DEPARTMENTID_ALIAS_NAME + ".ParentDepartmentID"));
		public static readonly StringProperty PROPERTY_DEPARTMENTID_DEPARTMENTNAMECN = new StringProperty(Property.ForName(PROPERTY_DEPARTMENTID_ALIAS_NAME + ".DepartmentNameCn"));
		public static readonly StringProperty PROPERTY_DEPARTMENTID_DEPARTMENTNAMEEN = new StringProperty(Property.ForName(PROPERTY_DEPARTMENTID_ALIAS_NAME + ".DepartmentNameEn"));
		public static readonly StringProperty PROPERTY_DEPARTMENTID_DEPARTMENTDECRIPTION = new StringProperty(Property.ForName(PROPERTY_DEPARTMENTID_ALIAS_NAME + ".DepartmentDecription"));
		public static readonly IntProperty PROPERTY_DEPARTMENTID_DEPARTMENTSORTINDEX = new IntProperty(Property.ForName(PROPERTY_DEPARTMENTID_ALIAS_NAME + ".DepartmentSortIndex"));
		public static readonly IntProperty PROPERTY_DEPARTMENTID_CREATEBY = new IntProperty(Property.ForName(PROPERTY_DEPARTMENTID_ALIAS_NAME + ".CreateBy"));
		public static readonly DateTimeProperty PROPERTY_DEPARTMENTID_CREATEAT = new DateTimeProperty(Property.ForName(PROPERTY_DEPARTMENTID_ALIAS_NAME + ".CreateAt"));
		public static readonly IntProperty PROPERTY_DEPARTMENTID_LASTMODIFYBY = new IntProperty(Property.ForName(PROPERTY_DEPARTMENTID_ALIAS_NAME + ".LastModifyBy"));
		public static readonly DateTimeProperty PROPERTY_DEPARTMENTID_LASTMODIFYAT = new DateTimeProperty(Property.ForName(PROPERTY_DEPARTMENTID_ALIAS_NAME + ".LastModifyAt"));
		public static readonly StringProperty PROPERTY_DEPARTMENTID_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(PROPERTY_DEPARTMENTID_ALIAS_NAME + ".LastModifyComment"));
		#endregion
		public static readonly StringProperty PROPERTY_MOBILEPIN = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_MOBILEPIN));		
		public static readonly IntProperty PROPERTY_PASSWORDFORMAT = new IntProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_PASSWORDFORMAT));		
		public static readonly StringProperty PROPERTY_PASSWORDQUESTION = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_PASSWORDQUESTION));		
		public static readonly StringProperty PROPERTY_PASSWORDANSWER = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_PASSWORDANSWER));		
		public static readonly StringProperty PROPERTY_COMMENTS = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_COMMENTS));		
		public static readonly BoolProperty PROPERTY_ISAPPROVED = new BoolProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_ISAPPROVED));		
		public static readonly BoolProperty PROPERTY_ISLOCKEDOUT = new BoolProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_ISLOCKEDOUT));		
		public static readonly DateTimeProperty PROPERTY_LASTACTIVITYDATE = new DateTimeProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_LASTACTIVITYDATE));		
		public static readonly DateTimeProperty PROPERTY_LASTLOGINDATE = new DateTimeProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_LASTLOGINDATE));		
		public static readonly DateTimeProperty PROPERTY_LASTLOCKEDOUTDATE = new DateTimeProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_LASTLOCKEDOUTDATE));		
		public static readonly DateTimeProperty PROPERTY_LASTPASSWORDCHANGEDATE = new DateTimeProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_LASTPASSWORDCHANGEDATE));		
		public static readonly IntProperty PROPERTY_FAILEDPWDATTEMPTCNT = new IntProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_FAILEDPWDATTEMPTCNT));		
		public static readonly DateTimeProperty PROPERTY_FAILEDPWDATTEMPTWNDSTART = new DateTimeProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_FAILEDPWDATTEMPTWNDSTART));		
		public static readonly IntProperty PROPERTY_FAILEDPWDANSATTEMPTCNT = new IntProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_FAILEDPWDANSATTEMPTCNT));		
		public static readonly DateTimeProperty PROPERTY_FAILEDPWDANSATTEMPTWNDSTART = new DateTimeProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_FAILEDPWDANSATTEMPTWNDSTART));		
		public static readonly BoolProperty PROPERTY_ISNEEDCHGPWD = new BoolProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_ISNEEDCHGPWD));		
		public static readonly StringProperty PROPERTY_PASSWORDSALT = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_PASSWORDSALT));		
		public static readonly StringProperty PROPERTY_LOWEREDEMAIL = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_LOWEREDEMAIL));		
		public static readonly IntProperty PROPERTY_CREATEBY = new IntProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_CREATEBY));		
		public static readonly DateTimeProperty PROPERTY_CREATEAT = new DateTimeProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_CREATEAT));		
		public static readonly IntProperty PROPERTY_LASTMODIFYBY = new IntProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_LASTMODIFYBY));		
		public static readonly DateTimeProperty PROPERTY_LASTMODIFYAT = new DateTimeProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_LASTMODIFYAT));		
		public static readonly StringProperty PROPERTY_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(SystemUserEntity.PROPERTY_NAME_LASTMODIFYCOMMENT));		
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "UserID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "UserID":
                    return typeof (int);
                case "UserLoginID":
                    return typeof (string);
                case "UserName":
                    return typeof (string);
                case "UserEmail":
                    return typeof (string);
                case "UserPassword":
                    return typeof (string);
                case "UserStatus":
                    return typeof (string);
                case "UserCreateDate":
                    return typeof (DateTime);
                case "UserType":
                    return typeof (string);
                case "DepartmentID":
                    return typeof (int);
                case "MobilePIN":
                    return typeof (string);
                case "PasswordFormat":
                    return typeof (int);
                case "PasswordQuestion":
                    return typeof (string);
                case "PasswordAnswer":
                    return typeof (string);
                case "Comments":
                    return typeof (string);
                case "IsApproved":
                    return typeof (bool);
                case "IsLockedOut":
                    return typeof (bool);
                case "LastActivityDate":
                    return typeof (DateTime);
                case "LastLoginDate":
                    return typeof (DateTime);
                case "LastLockedOutDate":
                    return typeof (DateTime);
                case "LastPasswordChangeDate":
                    return typeof (DateTime);
                case "FailedPwdAttemptCnt":
                    return typeof (int);
                case "FailedPwdAttemptWndStart":
                    return typeof (DateTime);
                case "FailedPwdAnsAttemptCnt":
                    return typeof (int);
                case "FailedPwdAnsAttemptWndStart":
                    return typeof (DateTime);
                case "IsNeedChgPwd":
                    return typeof (bool);
                case "PasswordSalt":
                    return typeof (string);
                case "LoweredEmail":
                    return typeof (string);
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
		
		public List<SystemUserEntity> GetList_By_DepartmentID_SystemDepartmentEntity(SystemDepartmentEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemUserEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_DEPARTMENTID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemUserEntity> GetPageList_By_DepartmentID_SystemDepartmentEntity(string orderByColumnName, bool isDesc, SystemDepartmentEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemUserEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_DEPARTMENTID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		

		
		
    }
}
