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
    public partial class SystemDictionaryWrapper
    {
        #region Member

		internal static readonly ISystemDictionaryServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemDictionaryServiceProxyInstance;
	 
	 
        internal SystemDictionaryEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SystemDictionaryWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SystemDictionaryWrapper() : this(new SystemDictionaryEntity())
        {
            
        }

        internal SystemDictionaryWrapper(SystemDictionaryEntity entityObj)
        {
            entity = entityObj;
        }
		#endregion
		
		#region Equals 和 HashCode 方法覆盖
		public override bool Equals(object obj)
        {
            if (obj == null && entity!=null)
            {
                if (entity.SystemDictionaryID == 0)
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

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemDictionaryEntity";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYID = "SystemDictionaryID";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYGROUPID = "SystemDictionaryGroupID";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYKEY = "SystemDictionaryKey";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYVALUE = "SystemDictionaryValue";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYDESCIPTION = "SystemDictionaryDesciption";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYORDER = "SystemDictionaryOrder";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYISENABLE = "SystemDictionaryIsEnable";
		public static readonly string PROPERTY_NAME_SYSTEMDICTIONARYISSYSTEM = "SystemDictionaryIsSystem";
		
        #endregion


		#region Public Property
		/// <summary>
		/// 
		/// </summary>		
		public int SystemDictionaryID
		{
			get
			{
				return entity.SystemDictionaryID;
			}
			set
			{
				entity.SystemDictionaryID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public SystemDictionaryGroupWrapper SystemDictionaryGroupID
		{
			get
			{
				return SystemDictionaryGroupWrapper.ConvertEntityToWrapper(entity.SystemDictionaryGroupID) ;
			}
			set
			{
				entity.SystemDictionaryGroupID = ((value == null) ? null : value.entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string SystemDictionaryKey
		{
			get
			{
				return entity.SystemDictionaryKey;
			}
			set
			{
				entity.SystemDictionaryKey = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string SystemDictionaryValue
		{
			get
			{
				return entity.SystemDictionaryValue;
			}
			set
			{
				entity.SystemDictionaryValue = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string SystemDictionaryDesciption
		{
			get
			{
				return entity.SystemDictionaryDesciption;
			}
			set
			{
				entity.SystemDictionaryDesciption = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? SystemDictionaryOrder
		{
			get
			{
				return entity.SystemDictionaryOrder;
			}
			set
			{
				entity.SystemDictionaryOrder = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool? SystemDictionaryIsEnable
		{
			get
			{
				return entity.SystemDictionaryIsEnable;
			}
			set
			{
				entity.SystemDictionaryIsEnable = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool? SystemDictionaryIsSystem
		{
			get
			{
				return entity.SystemDictionaryIsSystem;
			}
			set
			{
				entity.SystemDictionaryIsSystem = value;
			}
		}
		#endregion 





        #region "FKQuery"
		
        public static List<SystemDictionaryWrapper> FindAllByOrderByAndFilterAndSystemDictionaryGroupID(string orderByColumnName, bool isDesc,   SystemDictionaryGroupWrapper systemDictionaryGroupID,  PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndSystemDictionaryGroupID(orderByColumnName, isDesc,   systemDictionaryGroupID.entity, pageQueryParams));
        }

        public static List<SystemDictionaryWrapper> FindAllBySystemDictionaryGroupID(SystemDictionaryGroupWrapper systemDictionaryGroupID)
        {
            return ConvertToWrapperList(businessProxy.FindAllBySystemDictionaryGroupID(systemDictionaryGroupID.entity));
        }
		



        #endregion








        #region Static Common Data Operation
		
		internal static List<SystemDictionaryWrapper> ConvertToWrapperList(List<SystemDictionaryEntity> entitylist)
        {
            List<SystemDictionaryWrapper> list = new List<SystemDictionaryWrapper>();
            foreach (SystemDictionaryEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemDictionaryWrapper> ConvertToWrapperList(IList<SystemDictionaryEntity> entitylist)
        {
            List<SystemDictionaryWrapper> list = new List<SystemDictionaryWrapper>();
            foreach (SystemDictionaryEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemDictionaryEntity> ConvertToEntityList(List<SystemDictionaryWrapper> wrapperlist)
        {
            List<SystemDictionaryEntity> list = new List<SystemDictionaryEntity>();
            foreach (SystemDictionaryWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemDictionaryWrapper ConvertEntityToWrapper(SystemDictionaryEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.SystemDictionaryID == 0)
                return null;

            return new SystemDictionaryWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

