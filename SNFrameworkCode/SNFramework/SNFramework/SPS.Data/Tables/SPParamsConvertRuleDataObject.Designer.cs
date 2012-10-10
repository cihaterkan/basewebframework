// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SPParamsConvertRuleDataObject.Designer.cs">
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
using SPS.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;


namespace SPS.Data.Tables
{
    public partial class SPParamsConvertRuleDataObject : BaseNHibernateDataObject<SPParamsConvertRuleEntity,int>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_ID = new IntProperty(Property.ForName(SPParamsConvertRuleEntity.PROPERTY_NAME_ID));		
		public static readonly IntProperty PROPERTY_PARENTDATAID = new IntProperty(Property.ForName(SPParamsConvertRuleEntity.PROPERTY_NAME_PARENTDATAID));		
		public static readonly StringProperty PROPERTY_PARENTDATATYPE = new StringProperty(Property.ForName(SPParamsConvertRuleEntity.PROPERTY_NAME_PARENTDATATYPE));		
		public static readonly StringProperty PROPERTY_CONVERTCODE = new StringProperty(Property.ForName(SPParamsConvertRuleEntity.PROPERTY_NAME_CONVERTCODE));		
		public static readonly StringProperty PROPERTY_CONVERTTYPE = new StringProperty(Property.ForName(SPParamsConvertRuleEntity.PROPERTY_NAME_CONVERTTYPE));		
      












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
                case "ParentDataID":
                    return typeof (int);
                case "ParentDataType":
                    return typeof (string);
                case "ConvertCode":
                    return typeof (string);
                case "ConvertType":
                    return typeof (string);
          }
			return typeof(string);
        }

		#region 获取外键字段类型
		
		public override Type GetFieldTypeByFieldName(string fieldName, string parent_alias)
        {
            switch (parent_alias)
            {
 
                default:
                    break;
            }

            return typeof(string);
        }
		
		#endregion

        public override void InClude_Parent_Table(string parent_alias, NHibernateDynamicQueryGenerator<SPParamsConvertRuleEntity> queryGenerator)
        {
            switch (parent_alias)
            {
                default:
                    break;
 
            }
        }
		
		
		

		
		
    }
}
