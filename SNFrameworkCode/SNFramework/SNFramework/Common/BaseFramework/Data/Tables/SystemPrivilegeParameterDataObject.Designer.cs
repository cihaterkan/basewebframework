// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SystemPrivilegeParameterDataObject.Designer.cs">
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
    public partial class SystemPrivilegeParameterDataObject : BaseNHibernateDataObject<SystemPrivilegeParameterEntity,int>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_PRIVILEGEPARAMETERID = new IntProperty(Property.ForName(SystemPrivilegeParameterEntity.PROPERTY_NAME_PRIVILEGEPARAMETERID));		
		public static readonly EntityProperty<SystemRoleEntity> PROPERTY_ROLEID = new EntityProperty<SystemRoleEntity>(Property.ForName(SystemPrivilegeParameterEntity.PROPERTY_NAME_ROLEID));
		#region roleID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemPrivilegeParameterEntity> InClude_RoleID_Query(NHibernateDynamicQueryGenerator<SystemPrivilegeParameterEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemPrivilegeParameterEntity.PROPERTY_NAME_ROLEID, PROPERTY_ROLEID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_ROLEID_ALIAS_NAME = "RoleID_SystemPrivilegeParameterEntity_Alias";
		public static readonly IntProperty PROPERTY_ROLEID_ROLEID = new IntProperty(Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleID"));
		public static readonly StringProperty PROPERTY_ROLEID_ROLENAME = new StringProperty(Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleName"));
		public static readonly StringProperty PROPERTY_ROLEID_ROLECODE = new StringProperty(Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleCode"));
		public static readonly StringProperty PROPERTY_ROLEID_ROLEDESCRIPTION = new StringProperty(Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleDescription"));
		public static readonly BoolProperty PROPERTY_ROLEID_ROLEISSYSTEMROLE = new BoolProperty(Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleIsSystemRole"));
		public static readonly StringProperty PROPERTY_ROLEID_ROLETYPE = new StringProperty(Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleType"));
		public static readonly IntProperty PROPERTY_ROLEID_CREATEBY = new IntProperty(Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".CreateBy"));
		public static readonly DateTimeProperty PROPERTY_ROLEID_CREATEAT = new DateTimeProperty(Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".CreateAt"));
		public static readonly IntProperty PROPERTY_ROLEID_LASTMODIFYBY = new IntProperty(Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".LastModifyBy"));
		public static readonly DateTimeProperty PROPERTY_ROLEID_LASTMODIFYAT = new DateTimeProperty(Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".LastModifyAt"));
		public static readonly StringProperty PROPERTY_ROLEID_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".LastModifyComment"));
		#endregion
		public static readonly EntityProperty<SystemPrivilegeEntity> PROPERTY_PRIVILEGEID = new EntityProperty<SystemPrivilegeEntity>(Property.ForName(SystemPrivilegeParameterEntity.PROPERTY_NAME_PRIVILEGEID));
		#region privilegeID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemPrivilegeParameterEntity> InClude_PrivilegeID_Query(NHibernateDynamicQueryGenerator<SystemPrivilegeParameterEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemPrivilegeParameterEntity.PROPERTY_NAME_PRIVILEGEID, PROPERTY_PRIVILEGEID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_PRIVILEGEID_ALIAS_NAME = "PrivilegeID_SystemPrivilegeParameterEntity_Alias";
		public static readonly IntProperty PROPERTY_PRIVILEGEID_PRIVILEGEID = new IntProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".PrivilegeID"));
		public static readonly EntityProperty<SystemOperationEntity> PROPERTY_PRIVILEGEID_OPERATIONID = new EntityProperty<SystemOperationEntity>(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".OperationID"));
		public static readonly EntityProperty<SystemResourcesEntity> PROPERTY_PRIVILEGEID_RESOURCESID = new EntityProperty<SystemResourcesEntity>(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".ResourcesID"));
		public static readonly StringProperty PROPERTY_PRIVILEGEID_PRIVILEGECNNAME = new StringProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".PrivilegeCnName"));
		public static readonly StringProperty PROPERTY_PRIVILEGEID_PRIVILEGEENNAME = new StringProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".PrivilegeEnName"));
		public static readonly StringProperty PROPERTY_PRIVILEGEID_DEFAULTVALUE = new StringProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".DefaultValue"));
		public static readonly StringProperty PROPERTY_PRIVILEGEID_DESCRIPTION = new StringProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".Description"));
		public static readonly IntProperty PROPERTY_PRIVILEGEID_PRIVILEGEORDER = new IntProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".PrivilegeOrder"));
		public static readonly StringProperty PROPERTY_PRIVILEGEID_PRIVILEGETYPE = new StringProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".PrivilegeType"));
		public static readonly IntProperty PROPERTY_PRIVILEGEID_CREATEBY = new IntProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".CreateBy"));
		public static readonly DateTimeProperty PROPERTY_PRIVILEGEID_CREATEAT = new DateTimeProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".CreateAt"));
		public static readonly IntProperty PROPERTY_PRIVILEGEID_LASTMODIFYBY = new IntProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".LastModifyBy"));
		public static readonly DateTimeProperty PROPERTY_PRIVILEGEID_LASTMODIFYAT = new DateTimeProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".LastModifyAt"));
		public static readonly StringProperty PROPERTY_PRIVILEGEID_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(PROPERTY_PRIVILEGEID_ALIAS_NAME + ".LastModifyComment"));
		#endregion
		public static readonly StringProperty PROPERTY_BIZPARAMETER = new StringProperty(Property.ForName(SystemPrivilegeParameterEntity.PROPERTY_NAME_BIZPARAMETER));		
		public static readonly IntProperty PROPERTY_CREATEBY = new IntProperty(Property.ForName(SystemPrivilegeParameterEntity.PROPERTY_NAME_CREATEBY));		
		public static readonly DateTimeProperty PROPERTY_CREATEAT = new DateTimeProperty(Property.ForName(SystemPrivilegeParameterEntity.PROPERTY_NAME_CREATEAT));		
		public static readonly IntProperty PROPERTY_LASTMODIFYBY = new IntProperty(Property.ForName(SystemPrivilegeParameterEntity.PROPERTY_NAME_LASTMODIFYBY));		
		public static readonly DateTimeProperty PROPERTY_LASTMODIFYAT = new DateTimeProperty(Property.ForName(SystemPrivilegeParameterEntity.PROPERTY_NAME_LASTMODIFYAT));		
		public static readonly StringProperty PROPERTY_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(SystemPrivilegeParameterEntity.PROPERTY_NAME_LASTMODIFYCOMMENT));		
      












		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "PrivilegeParameterID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "PrivilegeParameterID":
                    return typeof (int);
                case "RoleID":
                    return typeof (int);
                case "PrivilegeID":
                    return typeof (int);
                case "BizParameter":
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

		#region 获取外键字段类型
		
		public override Type GetFieldTypeByFieldName(string fieldName, string parent_alias)
        {
            switch (parent_alias)
            {
	            case "RoleID_SystemPrivilegeParameterEntity_Alias":
					switch (fieldName)
					{
                		case "RoleID_SystemPrivilegeParameterEntity_Alias.RoleID":
							return typeof (int);
                		case "RoleID_SystemPrivilegeParameterEntity_Alias.RoleName":
							return typeof (string);
                		case "RoleID_SystemPrivilegeParameterEntity_Alias.RoleCode":
							return typeof (string);
                		case "RoleID_SystemPrivilegeParameterEntity_Alias.RoleDescription":
							return typeof (string);
                		case "RoleID_SystemPrivilegeParameterEntity_Alias.RoleIsSystemRole":
							return typeof (bool);
                		case "RoleID_SystemPrivilegeParameterEntity_Alias.RoleType":
							return typeof (string);
                		case "RoleID_SystemPrivilegeParameterEntity_Alias.CreateBy":
							return typeof (int);
                		case "RoleID_SystemPrivilegeParameterEntity_Alias.CreateAt":
							return typeof (DateTime);
                		case "RoleID_SystemPrivilegeParameterEntity_Alias.LastModifyBy":
							return typeof (int);
                		case "RoleID_SystemPrivilegeParameterEntity_Alias.LastModifyAt":
							return typeof (DateTime);
                		case "RoleID_SystemPrivilegeParameterEntity_Alias.LastModifyComment":
							return typeof (string);
          			}
                    break;
	            case "PrivilegeID_SystemPrivilegeParameterEntity_Alias":
					switch (fieldName)
					{
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.PrivilegeID":
							return typeof (int);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.OperationID":
							return typeof (int);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.ResourcesID":
							return typeof (int);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.PrivilegeCnName":
							return typeof (string);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.PrivilegeEnName":
							return typeof (string);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.DefaultValue":
							return typeof (string);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.Description":
							return typeof (string);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.PrivilegeOrder":
							return typeof (int);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.PrivilegeType":
							return typeof (string);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.CreateBy":
							return typeof (int);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.CreateAt":
							return typeof (DateTime);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.LastModifyBy":
							return typeof (int);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.LastModifyAt":
							return typeof (DateTime);
                		case "PrivilegeID_SystemPrivilegeParameterEntity_Alias.LastModifyComment":
							return typeof (string);
          			}
                    break;
 
                default:
                    break;
            }

            return typeof(string);
        }
		
		#endregion

        public override void InClude_Parent_Table(string parent_alias, NHibernateDynamicQueryGenerator<SystemPrivilegeParameterEntity> queryGenerator)
        {
            switch (parent_alias)
            {
	            case "RoleID_SystemPrivilegeParameterEntity_Alias":
                    queryGenerator.AddAlians(SystemPrivilegeParameterEntity.PROPERTY_NAME_ROLEID, PROPERTY_ROLEID_ALIAS_NAME);
                    break;
	            case "PrivilegeID_SystemPrivilegeParameterEntity_Alias":
                    queryGenerator.AddAlians(SystemPrivilegeParameterEntity.PROPERTY_NAME_PRIVILEGEID, PROPERTY_PRIVILEGEID_ALIAS_NAME);
                    break;
                default:
                    break;
 
            }
        }
		
		
		
		public List<SystemPrivilegeParameterEntity> GetList_By_RoleID_SystemRoleEntity(SystemRoleEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemPrivilegeParameterEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_ROLEID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemPrivilegeParameterEntity> GetPageList_By_RoleID_SystemRoleEntity(string orderByColumnName, bool isDesc, SystemRoleEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemPrivilegeParameterEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_ROLEID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		
		public List<SystemPrivilegeParameterEntity> GetList_By_PrivilegeID_SystemPrivilegeEntity(SystemPrivilegeEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemPrivilegeParameterEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_PRIVILEGEID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemPrivilegeParameterEntity> GetPageList_By_PrivilegeID_SystemPrivilegeEntity(string orderByColumnName, bool isDesc, SystemPrivilegeEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemPrivilegeParameterEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_PRIVILEGEID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		

		
		
    }
}
