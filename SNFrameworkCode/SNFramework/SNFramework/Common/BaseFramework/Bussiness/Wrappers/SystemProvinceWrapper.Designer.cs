// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context.Support;
using Common.Logging;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;

namespace Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers
{
    public partial class SystemProvinceWrapper
    {
        #region Member

		internal static readonly ISystemProvinceServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemProvinceServiceProxyInstance;
	 
	 
        internal SystemProvinceEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SystemProvinceWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SystemProvinceWrapper() : this(new SystemProvinceEntity())
        {
            
        }

        internal SystemProvinceWrapper(SystemProvinceEntity entityObj)
        {
            entity = entityObj;
        }
		#endregion
		
		#region Equals 和 HashCode 方法覆盖
		public override bool Equals(object obj)
        {
            if (obj == null && entity!=null)
            {
                if (entity.Id == 0)
                    return true;

                return false;
            }
            return entity.Equals(obj);
        }

        public override int GetHashCode()
        {
            return entity.GetHashCode();
        }
		#endregion
		
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemProvinceEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_ABBRNAME = "AbbrName";
		public static readonly string PROPERTY_NAME_SINGLEABBRNAME = "SingleAbbrName";
		public static readonly string PROPERTY_NAME_CODE = "Code";
		public static readonly string PROPERTY_NAME_COUNTRYID = "CountryID";
		
        #endregion


		#region Public Property
		/// <summary>
		/// 
		/// </summary>		
		public int Id
		{
			get
			{
				return entity.Id;
			}
			set
			{
				entity.Id = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string Name
		{
			get
			{
				return entity.Name;
			}
			set
			{
				entity.Name = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string AbbrName
		{
			get
			{
				return entity.AbbrName;
			}
			set
			{
				entity.AbbrName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string SingleAbbrName
		{
			get
			{
				return entity.SingleAbbrName;
			}
			set
			{
				entity.SingleAbbrName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string Code
		{
			get
			{
				return entity.Code;
			}
			set
			{
				entity.Code = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public SystemCountryWrapper CountryID
		{
			get
			{
				return SystemCountryWrapper.ConvertEntityToWrapper(entity.CountryID) ;
			}
			set
			{
				entity.CountryID = ((value == null) ? null : value.entity);
			}
		}
		#endregion 





        #region "FKQuery"
		
        public static List<SystemProvinceWrapper> FindAllByOrderByAndFilterAndCountryID(string orderByColumnName, bool isDesc,   SystemCountryWrapper countryID,  PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndCountryID(orderByColumnName, isDesc,   countryID.entity, pageQueryParams));
        }

        public static List<SystemProvinceWrapper> FindAllByCountryID(SystemCountryWrapper countryID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByCountryID(countryID.entity));
        }
		



        #endregion








        #region Static Common Data Operation
		
		internal static List<SystemProvinceWrapper> ConvertToWrapperList(List<SystemProvinceEntity> entitylist)
        {
            List<SystemProvinceWrapper> list = new List<SystemProvinceWrapper>();
            foreach (SystemProvinceEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemProvinceWrapper> ConvertToWrapperList(IList<SystemProvinceEntity> entitylist)
        {
            List<SystemProvinceWrapper> list = new List<SystemProvinceWrapper>();
            foreach (SystemProvinceEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemProvinceEntity> ConvertToEntityList(List<SystemProvinceWrapper> wrapperlist)
        {
            List<SystemProvinceEntity> list = new List<SystemProvinceEntity>();
            foreach (SystemProvinceWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemProvinceWrapper ConvertEntityToWrapper(SystemProvinceEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SystemProvinceWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace
