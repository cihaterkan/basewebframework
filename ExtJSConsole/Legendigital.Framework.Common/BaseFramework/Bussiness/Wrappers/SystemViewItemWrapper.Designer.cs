// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context.Support;
using Common.Logging;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables;

namespace Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers
{
    public partial class SystemViewItemWrapper
    {
        #region Member

		internal static readonly ISystemViewItemServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemViewItemServiceProxyInstance;
		//internal static readonly ISystemViewItemServiceProxy businessProxy = ((ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID"))).SystemViewItemServiceProxyInstance;

        internal SystemViewItemEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SystemViewItemWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SystemViewItemWrapper() : this(new SystemViewItemEntity())
        {
            
        }

        internal SystemViewItemWrapper(SystemViewItemEntity entityObj)
        {
            entity = entityObj;
        }
		#endregion
		
		#region Equals 和 HashCode 方法覆盖
		public override bool Equals(object obj)
        {
            if (obj == null && entity!=null)
            {
                if (entity.SystemViewItemID == 0)
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

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemViewItemEntity";
		public static readonly string PROPERTY_NAME_SYSTEMVIEWITEMID = "SystemViewItemID";
		public static readonly string PROPERTY_NAME_SYSTEMVIEWITEMNAMEEN = "SystemViewItemNameEn";
		public static readonly string PROPERTY_NAME_SYSTEMVIEWITEMNAMECN = "SystemViewItemNameCn";
		public static readonly string PROPERTY_NAME_SYSTEMVIEWITEMDESCRIPTION = "SystemViewItemDescription";
		public static readonly string PROPERTY_NAME_SYSTEMVIEWID = "SystemViewID";
		public static readonly string PROPERTY_NAME_SYSTEMMOUDLEFIELDID = "SystemMoudleFieldID";
		
        #endregion


		#region Public Property
		/// <summary>
		/// 
		/// </summary>		
		public int SystemViewItemID
		{
			get
			{
				return entity.SystemViewItemID;
			}
			set
			{
				entity.SystemViewItemID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string SystemViewItemNameEn
		{
			get
			{
				return entity.SystemViewItemNameEn;
			}
			set
			{
				entity.SystemViewItemNameEn = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string SystemViewItemNameCn
		{
			get
			{
				return entity.SystemViewItemNameCn;
			}
			set
			{
				entity.SystemViewItemNameCn = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string SystemViewItemDescription
		{
			get
			{
				return entity.SystemViewItemDescription;
			}
			set
			{
				entity.SystemViewItemDescription = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public SystemViewWrapper SystemViewID
		{
			get
			{
				return SystemViewWrapper.ConvertEntityToWrapper(entity.SystemViewID) ;
			}
			set
			{
				entity.SystemViewID = ((value == null) ? null : value.entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public SystemMoudleFieldWrapper SystemMoudleFieldID
		{
			get
			{
				return SystemMoudleFieldWrapper.ConvertEntityToWrapper(entity.SystemMoudleFieldID) ;
			}
			set
			{
				entity.SystemMoudleFieldID = ((value == null) ? null : value.entity);
			}
		}
		#endregion 







        #region Static Common Data Operation
		
		internal static List<SystemViewItemWrapper> ConvertToWrapperList(List<SystemViewItemEntity> entitylist)
        {
            List<SystemViewItemWrapper> list = new List<SystemViewItemWrapper>();
            foreach (SystemViewItemEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemViewItemWrapper> ConvertToWrapperList(IList<SystemViewItemEntity> entitylist)
        {
            List<SystemViewItemWrapper> list = new List<SystemViewItemWrapper>();
            foreach (SystemViewItemEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemViewItemEntity> ConvertToEntityList(List<SystemViewItemWrapper> wrapperlist)
        {
            List<SystemViewItemEntity> list = new List<SystemViewItemEntity>();
            foreach (SystemViewItemWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemViewItemWrapper ConvertEntityToWrapper(SystemViewItemEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.SystemViewItemID == 0)
                return null;

            return new SystemViewItemWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

