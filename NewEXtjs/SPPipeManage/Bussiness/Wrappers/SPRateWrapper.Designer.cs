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
    public partial class SPRateWrapper
    {
        #region Member

		internal static readonly ISPRateServiceProxy businessProxy = ((LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID", typeof(LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)))).SPRateServiceProxyInstance;
		//internal static readonly ISPRateServiceProxy businessProxy = ((ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID"))).SPRateServiceProxyInstance;

        internal SPRateEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SPRateWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SPRateWrapper() : this(new SPRateEntity())
        {
            
        }

        internal SPRateWrapper(SPRateEntity entityObj)
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

		public static readonly string CLASS_FULL_NAME = "LD.SPPipeManage.Entity.Tables.SPRateEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_CHANNELID = "ChannelID";
		public static readonly string PROPERTY_NAME_CLINETID = "ClinetID";
		public static readonly string PROPERTY_NAME_INTERCEPTRATE = "InterceptRate";
		public static readonly string PROPERTY_NAME_UPRATE = "UpRate";
		public static readonly string PROPERTY_NAME_DOWNRATE = "DownRate";
		
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
		public int? ChannelID
		{
			get
			{
				return entity.ChannelID;
			}
			set
			{
				entity.ChannelID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? ClinetID
		{
			get
			{
				return entity.ClinetID;
			}
			set
			{
				entity.ClinetID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? InterceptRate
		{
			get
			{
				return entity.InterceptRate;
			}
			set
			{
				entity.InterceptRate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? UpRate
		{
			get
			{
				return entity.UpRate;
			}
			set
			{
				entity.UpRate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? DownRate
		{
			get
			{
				return entity.DownRate;
			}
			set
			{
				entity.DownRate = value;
			}
		}
		#endregion 







        #region Static Common Data Operation
		
		internal static List<SPRateWrapper> ConvertToWrapperList(List<SPRateEntity> entitylist)
        {
            List<SPRateWrapper> list = new List<SPRateWrapper>();
            foreach (SPRateEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SPRateWrapper> ConvertToWrapperList(IList<SPRateEntity> entitylist)
        {
            List<SPRateWrapper> list = new List<SPRateWrapper>();
            foreach (SPRateEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SPRateEntity> ConvertToEntityList(List<SPRateWrapper> wrapperlist)
        {
            List<SPRateEntity> list = new List<SPRateEntity>();
            foreach (SPRateWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SPRateWrapper ConvertEntityToWrapper(SPRateEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SPRateWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

