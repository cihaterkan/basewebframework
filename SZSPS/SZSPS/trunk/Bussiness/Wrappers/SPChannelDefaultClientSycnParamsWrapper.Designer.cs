// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context.Support;
using Common.Logging;
using LD.SPPipeManage.Entity.Tables;
using LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container;
using LD.SPPipeManage.Bussiness.ServiceProxys.Tables;

namespace LD.SPPipeManage.Bussiness.Wrappers
{
    public partial class SPChannelDefaultClientSycnParamsWrapper
    {
        #region Member

		internal static readonly ISPChannelDefaultClientSycnParamsServiceProxy businessProxy = ((LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID", typeof(LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)))).SPChannelDefaultClientSycnParamsServiceProxyInstance;
		//internal static readonly ISPChannelDefaultClientSycnParamsServiceProxy businessProxy = ((ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID"))).SPChannelDefaultClientSycnParamsServiceProxyInstance;

        internal SPChannelDefaultClientSycnParamsEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SPChannelDefaultClientSycnParamsWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SPChannelDefaultClientSycnParamsWrapper() : this(new SPChannelDefaultClientSycnParamsEntity())
        {
            
        }

        internal SPChannelDefaultClientSycnParamsWrapper(SPChannelDefaultClientSycnParamsEntity entityObj)
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

		public static readonly string CLASS_FULL_NAME = "LD.SPPipeManage.Entity.Tables.SPChannelDefaultClientSycnParamsEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		public static readonly string PROPERTY_NAME_ISENABLE = "IsEnable";
		public static readonly string PROPERTY_NAME_ISREQUIRED = "IsRequired";
		public static readonly string PROPERTY_NAME_CHANNELID = "ChannelID";
		public static readonly string PROPERTY_NAME_MAPPINGPARAMS = "MappingParams";
		public static readonly string PROPERTY_NAME_TITLE = "Title";
		
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
		public string Description
		{
			get
			{
				return entity.Description;
			}
			set
			{
				entity.Description = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool? IsEnable
		{
			get
			{
				return entity.IsEnable;
			}
			set
			{
				entity.IsEnable = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool? IsRequired
		{
			get
			{
				return entity.IsRequired;
			}
			set
			{
				entity.IsRequired = value;
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
		public string MappingParams
		{
			get
			{
				return entity.MappingParams;
			}
			set
			{
				entity.MappingParams = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string Title
		{
			get
			{
				return entity.Title;
			}
			set
			{
				entity.Title = value;
			}
		}
		#endregion 





        #region "FKQuery"
		
        public static List<SPChannelDefaultClientSycnParamsWrapper> FindAllByOrderByAndFilterAndChannelID(string orderByColumnName, bool isDesc,int pageIndex, int pageSize,    SPChannelWrapper channelID,  out int recordCount)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndChannelID(orderByColumnName, isDesc,pageIndex, pageSize,   channelID.entity,out recordCount));
        }

        public static List<SPChannelDefaultClientSycnParamsWrapper> FindAllByChannelID(SPChannelWrapper channelID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByChannelID(channelID.entity));
        }
		



        #endregion

        #region Static Common Data Operation
		
		internal static List<SPChannelDefaultClientSycnParamsWrapper> ConvertToWrapperList(List<SPChannelDefaultClientSycnParamsEntity> entitylist)
        {
            List<SPChannelDefaultClientSycnParamsWrapper> list = new List<SPChannelDefaultClientSycnParamsWrapper>();
            foreach (SPChannelDefaultClientSycnParamsEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SPChannelDefaultClientSycnParamsWrapper> ConvertToWrapperList(IList<SPChannelDefaultClientSycnParamsEntity> entitylist)
        {
            List<SPChannelDefaultClientSycnParamsWrapper> list = new List<SPChannelDefaultClientSycnParamsWrapper>();
            foreach (SPChannelDefaultClientSycnParamsEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SPChannelDefaultClientSycnParamsEntity> ConvertToEntityList(List<SPChannelDefaultClientSycnParamsWrapper> wrapperlist)
        {
            List<SPChannelDefaultClientSycnParamsEntity> list = new List<SPChannelDefaultClientSycnParamsEntity>();
            foreach (SPChannelDefaultClientSycnParamsWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SPChannelDefaultClientSycnParamsWrapper ConvertEntityToWrapper(SPChannelDefaultClientSycnParamsEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SPChannelDefaultClientSycnParamsWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

