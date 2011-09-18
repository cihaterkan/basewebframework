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
    public partial class SystemRoleMenuRelationDataObject : BaseNHibernateDataObject<SystemRoleMenuRelationEntity>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_MENUROLEID = new IntProperty(Property.ForName(SystemRoleMenuRelationEntity.PROPERTY_NAME_MENUROLEID));		
		public static readonly EntityProperty<SystemMenuEntity> PROPERTY_MENUID = new EntityProperty<SystemMenuEntity>(Property.ForName(SystemRoleMenuRelationEntity.PROPERTY_NAME_MENUID));
		#region menuID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> InClude_MenuID_Query(NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemRoleMenuRelationEntity.PROPERTY_NAME_MENUID, PROPERTY_MENUID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_MENUID_ALIAS_NAME = "MenuID_SystemRoleMenuRelationEntity_Alias";
		public static readonly IntProperty PROPERTY_MENUID_MENUID = new IntProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuID"));
		public static readonly StringProperty PROPERTY_MENUID_MENUNAME = new StringProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuName"));
		public static readonly StringProperty PROPERTY_MENUID_MENUCODE = new StringProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuCode"));
		public static readonly StringProperty PROPERTY_MENUID_MENUDESCRIPTION = new StringProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuDescription"));
		public static readonly StringProperty PROPERTY_MENUID_MENUURL = new StringProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuUrl"));
		public static readonly StringProperty PROPERTY_MENUID_MENUURLTARGET = new StringProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuUrlTarget"));
		public static readonly StringProperty PROPERTY_MENUID_MENUICONURL = new StringProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuIconUrl"));
		public static readonly BoolProperty PROPERTY_MENUID_MENUISCATEGORY = new BoolProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuIsCategory"));
		public static readonly EntityProperty<SystemMenuEntity> PROPERTY_MENUID_PARENTMENUID = new EntityProperty<SystemMenuEntity>(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".ParentMenuID"));
		public static readonly IntProperty PROPERTY_MENUID_MENUORDER = new IntProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuOrder"));
		public static readonly StringProperty PROPERTY_MENUID_MENUTYPE = new StringProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuType"));
		public static readonly BoolProperty PROPERTY_MENUID_MENUISSYSTEMMENU = new BoolProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuIsSystemMenu"));
		public static readonly BoolProperty PROPERTY_MENUID_MENUISENABLE = new BoolProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuIsEnable"));
		public static readonly EntityProperty<SystemApplicationEntity> PROPERTY_MENUID_APPLICATIONID = new EntityProperty<SystemApplicationEntity>(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".ApplicationID"));
		public static readonly IntProperty PROPERTY_MENUID_CREATEBY = new IntProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".CreateBy"));
		public static readonly DateTimeProperty PROPERTY_MENUID_CREATEAT = new DateTimeProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".CreateAt"));
		public static readonly IntProperty PROPERTY_MENUID_LASTMODIFYBY = new IntProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".LastModifyBy"));
		public static readonly DateTimeProperty PROPERTY_MENUID_LASTMODIFYAT = new DateTimeProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".LastModifyAt"));
		public static readonly StringProperty PROPERTY_MENUID_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".LastModifyComment"));
		#endregion
		public static readonly EntityProperty<SystemRoleEntity> PROPERTY_ROLEID = new EntityProperty<SystemRoleEntity>(Property.ForName(SystemRoleMenuRelationEntity.PROPERTY_NAME_ROLEID));
		#region roleID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> InClude_RoleID_Query(NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemRoleMenuRelationEntity.PROPERTY_NAME_ROLEID, PROPERTY_ROLEID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_ROLEID_ALIAS_NAME = "RoleID_SystemRoleMenuRelationEntity_Alias";
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
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "MenuRoleID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "MenuRoleID":
                    return typeof (int);
                case "MenuID":
                    return typeof (int);
                case "RoleID":
                    return typeof (int);
          }
			return typeof(string);
        }
		
		public List<SystemRoleMenuRelationEntity> GetList_By_MenuID_SystemMenuEntity(SystemMenuEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_MENUID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemRoleMenuRelationEntity> GetPageList_By_MenuID_SystemMenuEntity(string orderByColumnName, bool isDesc, SystemMenuEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_MENUID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		
		public List<SystemRoleMenuRelationEntity> GetList_By_RoleID_SystemRoleEntity(SystemRoleEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_ROLEID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemRoleMenuRelationEntity> GetPageList_By_RoleID_SystemRoleEntity(string orderByColumnName, bool isDesc, SystemRoleEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_ROLEID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		

		
		
    }
}
