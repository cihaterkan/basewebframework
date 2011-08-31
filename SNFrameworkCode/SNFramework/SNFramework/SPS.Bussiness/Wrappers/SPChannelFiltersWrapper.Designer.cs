// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context.Support;
using Common.Logging;
using SPS.Entity.Tables;
using SPS.Bussiness.ServiceProxys.Tables.Container;
using SPS.Bussiness.ServiceProxys.Tables;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;

namespace SPS.Bussiness.Wrappers
{
    public partial class SPChannelFiltersWrapper
    {
        #region Member

		internal static readonly ISPChannelFiltersServiceProxy businessProxy = ((SPS.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID", typeof(SPS.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)))).SPChannelFiltersServiceProxyInstance;
	 
	 
        internal SPChannelFiltersEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SPChannelFiltersWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SPChannelFiltersWrapper() : this(new SPChannelFiltersEntity())
        {
            
        }

        internal SPChannelFiltersWrapper(SPChannelFiltersEntity entityObj)
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

		public static readonly string CLASS_FULL_NAME = "SPS.Entity.Tables.SPChannelFiltersEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_CHANNELID = "ChannelID";
		public static readonly string PROPERTY_NAME_PARAMSNAME = "ParamsName";
		public static readonly string PROPERTY_NAME_FILTERTYPE = "FilterType";
		public static readonly string PROPERTY_NAME_FILTERVALUE = "FilterValue";
		public static readonly string PROPERTY_NAME_CREATEBY = "CreateBy";
		public static readonly string PROPERTY_NAME_CREATEAT = "CreateAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYBY = "LastModifyBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYAT = "LastModifyAt";
		
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
		public SPChannelWrapper ChannelID
		{
			get
			{
				return SPChannelWrapper.ConvertEntityToWrapper(entity.ChannelID) ;
			}
			set
			{
				entity.ChannelID = ((value == null) ? null : value.entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ParamsName
		{
			get
			{
				return entity.ParamsName;
			}
			set
			{
				entity.ParamsName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string FilterType
		{
			get
			{
				return entity.FilterType;
			}
			set
			{
				entity.FilterType = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string FilterValue
		{
			get
			{
				return entity.FilterValue;
			}
			set
			{
				entity.FilterValue = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? CreateBy
		{
			get
			{
				return entity.CreateBy;
			}
			set
			{
				entity.CreateBy = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? CreateAt
		{
			get
			{
				return entity.CreateAt;
			}
			set
			{
				entity.CreateAt = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? LastModifyBy
		{
			get
			{
				return entity.LastModifyBy;
			}
			set
			{
				entity.LastModifyBy = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? LastModifyAt
		{
			get
			{
				return entity.LastModifyAt;
			}
			set
			{
				entity.LastModifyAt = value;
			}
		}
		#endregion 





        #region "FKQuery"
		
        public static List<SPChannelFiltersWrapper> FindAllByOrderByAndFilterAndChannelID(string orderByColumnName, bool isDesc,   SPChannelWrapper channelID,  PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndChannelID(orderByColumnName, isDesc,   channelID.entity, pageQueryParams));
        }

        public static List<SPChannelFiltersWrapper> FindAllByChannelID(SPChannelWrapper channelID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByChannelID(channelID.entity));
        }
		



        #endregion








        #region Static Common Data Operation
		
		internal static List<SPChannelFiltersWrapper> ConvertToWrapperList(List<SPChannelFiltersEntity> entitylist)
        {
            List<SPChannelFiltersWrapper> list = new List<SPChannelFiltersWrapper>();
            foreach (SPChannelFiltersEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SPChannelFiltersWrapper> ConvertToWrapperList(IList<SPChannelFiltersEntity> entitylist)
        {
            List<SPChannelFiltersWrapper> list = new List<SPChannelFiltersWrapper>();
            foreach (SPChannelFiltersEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SPChannelFiltersEntity> ConvertToEntityList(List<SPChannelFiltersWrapper> wrapperlist)
        {
            List<SPChannelFiltersEntity> list = new List<SPChannelFiltersEntity>();
            foreach (SPChannelFiltersWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SPChannelFiltersWrapper ConvertEntityToWrapper(SPChannelFiltersEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SPChannelFiltersWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

