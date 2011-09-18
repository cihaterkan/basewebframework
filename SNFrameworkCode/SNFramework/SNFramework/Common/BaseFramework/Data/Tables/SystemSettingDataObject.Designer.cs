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
    public partial class SystemSettingDataObject : BaseNHibernateDataObject<SystemSettingEntity>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_ID = new IntProperty(Property.ForName(SystemSettingEntity.PROPERTY_NAME_ID));		
		public static readonly StringProperty PROPERTY_SYSTEMNAME = new StringProperty(Property.ForName(SystemSettingEntity.PROPERTY_NAME_SYSTEMNAME));		
		public static readonly StringProperty PROPERTY_SYSTEMDESCRIPTION = new StringProperty(Property.ForName(SystemSettingEntity.PROPERTY_NAME_SYSTEMDESCRIPTION));		
		public static readonly StringProperty PROPERTY_SYSTEMURL = new StringProperty(Property.ForName(SystemSettingEntity.PROPERTY_NAME_SYSTEMURL));		
		public static readonly StringProperty PROPERTY_SYSTEMVERSION = new StringProperty(Property.ForName(SystemSettingEntity.PROPERTY_NAME_SYSTEMVERSION));		
		public static readonly StringProperty PROPERTY_SYSTEMLISENCE = new StringProperty(Property.ForName(SystemSettingEntity.PROPERTY_NAME_SYSTEMLISENCE));		
		public static readonly IntProperty PROPERTY_CREATEBY = new IntProperty(Property.ForName(SystemSettingEntity.PROPERTY_NAME_CREATEBY));		
		public static readonly DateTimeProperty PROPERTY_CREATEAT = new DateTimeProperty(Property.ForName(SystemSettingEntity.PROPERTY_NAME_CREATEAT));		
		public static readonly IntProperty PROPERTY_LASTMODIFYBY = new IntProperty(Property.ForName(SystemSettingEntity.PROPERTY_NAME_LASTMODIFYBY));		
		public static readonly DateTimeProperty PROPERTY_LASTMODIFYAT = new DateTimeProperty(Property.ForName(SystemSettingEntity.PROPERTY_NAME_LASTMODIFYAT));		
		public static readonly StringProperty PROPERTY_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(SystemSettingEntity.PROPERTY_NAME_LASTMODIFYCOMMENT));		
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "Id" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "Id":
                    return typeof (int);
                case "SystemName":
                    return typeof (string);
                case "SystemDescription":
                    return typeof (string);
                case "SystemUrl":
                    return typeof (string);
                case "SystemVersion":
                    return typeof (string);
                case "SystemLisence":
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
		

		
		
    }
}
