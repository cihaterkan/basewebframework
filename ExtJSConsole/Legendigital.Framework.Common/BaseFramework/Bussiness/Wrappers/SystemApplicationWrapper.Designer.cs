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
    public partial class SystemApplicationWrapper
    {
        #region Member

		internal static readonly ISystemApplicationServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemApplicationServiceProxyInstance;
		//internal static readonly ISystemApplicationServiceProxy businessProxy = ((ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID"))).SystemApplicationServiceProxyInstance;

        internal SystemApplicationEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SystemApplicationWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SystemApplicationWrapper() : this(new SystemApplicationEntity())
        {
            
        }

        internal SystemApplicationWrapper(SystemApplicationEntity entityObj)
        {
            entity = entityObj;
        }
		#endregion
		
		#region Equals 和 HashCode 方法覆盖
		public override bool Equals(object obj)
        {
            if (obj == null && entity!=null)
            {
                if (entity.SystemApplicationID == 0)
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

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemApplicationEntity";
		public static readonly string PROPERTY_NAME_SYSTEMAPPLICATIONID = "SystemApplicationID";
		public static readonly string PROPERTY_NAME_SYSTEMAPPLICATIONNAME = "SystemApplicationName";
		public static readonly string PROPERTY_NAME_SYSTEMAPPLICATIONDESCRIPTION = "SystemApplicationDescription";
		public static readonly string PROPERTY_NAME_SYSTEMAPPLICATIONURL = "SystemApplicationUrl";
		public static readonly string PROPERTY_NAME_SYSTEMAPPLICATIONISSYSTEMAPPLICATION = "SystemApplicationIsSystemApplication";
		
        #endregion


		#region Public Property
		/// <summary>
		/// 
		/// </summary>		
		public int SystemApplicationID
		{
			get
			{
				return entity.SystemApplicationID;
			}
			set
			{
				entity.SystemApplicationID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string SystemApplicationName
		{
			get
			{
				return entity.SystemApplicationName;
			}
			set
			{
				entity.SystemApplicationName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string SystemApplicationDescription
		{
			get
			{
				return entity.SystemApplicationDescription;
			}
			set
			{
				entity.SystemApplicationDescription = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string SystemApplicationUrl
		{
			get
			{
				return entity.SystemApplicationUrl;
			}
			set
			{
				entity.SystemApplicationUrl = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool? SystemApplicationIsSystemApplication
		{
			get
			{
				return entity.SystemApplicationIsSystemApplication;
			}
			set
			{
				entity.SystemApplicationIsSystemApplication = value;
			}
		}
		#endregion 







        #region Static Common Data Operation
		
		internal static List<SystemApplicationWrapper> ConvertToWrapperList(List<SystemApplicationEntity> entitylist)
        {
            List<SystemApplicationWrapper> list = new List<SystemApplicationWrapper>();
            foreach (SystemApplicationEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemApplicationWrapper> ConvertToWrapperList(IList<SystemApplicationEntity> entitylist)
        {
            List<SystemApplicationWrapper> list = new List<SystemApplicationWrapper>();
            foreach (SystemApplicationEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemApplicationEntity> ConvertToEntityList(List<SystemApplicationWrapper> wrapperlist)
        {
            List<SystemApplicationEntity> list = new List<SystemApplicationEntity>();
            foreach (SystemApplicationWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemApplicationWrapper ConvertEntityToWrapper(SystemApplicationEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.SystemApplicationID == 0)
                return null;

            return new SystemApplicationWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

