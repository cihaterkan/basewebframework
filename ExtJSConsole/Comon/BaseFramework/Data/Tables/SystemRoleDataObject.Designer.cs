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
    public partial class SystemRoleDataObject : BaseNHibernateDataObject<SystemRoleEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_ROLEID = Property.ForName(SystemRoleEntity.PROPERTY_NAME_ROLEID);
		public static readonly Property PROPERTY_ROLENAME = Property.ForName(SystemRoleEntity.PROPERTY_NAME_ROLENAME);
		public static readonly Property PROPERTY_ROLEDESCRIPTION = Property.ForName(SystemRoleEntity.PROPERTY_NAME_ROLEDESCRIPTION);
		public static readonly Property PROPERTY_ROLEISSYSTEMROLE = Property.ForName(SystemRoleEntity.PROPERTY_NAME_ROLEISSYSTEMROLE);
		public static readonly Property PROPERTY_ROLETYPE = Property.ForName(SystemRoleEntity.PROPERTY_NAME_ROLETYPE);
		public static readonly Property PROPERTY_CREATEBY = Property.ForName(SystemRoleEntity.PROPERTY_NAME_CREATEBY);
		public static readonly Property PROPERTY_CREATEDATE = Property.ForName(SystemRoleEntity.PROPERTY_NAME_CREATEDATE);
		public static readonly Property PROPERTY_LASTUPDATEBY = Property.ForName(SystemRoleEntity.PROPERTY_NAME_LASTUPDATEBY);
		public static readonly Property PROPERTY_LASTUPDATEDATE = Property.ForName(SystemRoleEntity.PROPERTY_NAME_LASTUPDATEDATE);
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "RoleID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "RoleID":
                    return typeof (int);
                    break;
                case "RoleName":
                    return typeof (string);
                    break;
                case "RoleDescription":
                    return typeof (string);
                    break;
                case "RoleIsSystemRole":
                    return typeof (bool);
                    break;
                case "RoleType":
                    return typeof (string);
                    break;
                case "CreateBy":
                    return typeof (int);
                    break;
                case "CreateDate":
                    return typeof (DateTime);
                    break;
                case "LastUpdateBy":
                    return typeof (int);
                    break;
                case "LastUpdateDate":
                    return typeof (DateTime);
                    break;
          }
			return typeof(string);
        }
    }
}
