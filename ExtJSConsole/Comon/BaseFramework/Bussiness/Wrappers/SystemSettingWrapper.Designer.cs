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
    public partial class SystemSettingWrapper
    {
        #region Member

		internal static readonly ISystemSettingServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemSettingServiceProxyInstance;
		//internal static readonly ISystemSettingServiceProxy businessProxy = ((ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID"))).SystemSettingServiceProxyInstance;

        internal SystemSettingEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SystemSettingWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SystemSettingWrapper() : this(new SystemSettingEntity())
        {
            
        }

        internal SystemSettingWrapper(SystemSettingEntity entityObj)
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

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemSettingEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_SYSTEMNAME = "SystemName";
		public static readonly string PROPERTY_NAME_SYSTEMDESCRIPTION = "SystemDescription";
		public static readonly string PROPERTY_NAME_SYSTEMURL = "SystemUrl";
		public static readonly string PROPERTY_NAME_SYSTEMVERSION = "SystemVersion";
		public static readonly string PROPERTY_NAME_SYSTEMLISENCE = "SystemLisence";
		
        #endregion


		#region Public Property
		/// <summary>
		/// 主键
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
		/// 系统名称
		/// </summary>		
		public string SystemName
		{
			get
			{
				return entity.SystemName;
			}
			set
			{
				entity.SystemName = value;
			}
		}
		/// <summary>
		/// 系统描述
		/// </summary>		
		public string SystemDescription
		{
			get
			{
				return entity.SystemDescription;
			}
			set
			{
				entity.SystemDescription = value;
			}
		}
		/// <summary>
		/// 系统URL
		/// </summary>		
		public string SystemUrl
		{
			get
			{
				return entity.SystemUrl;
			}
			set
			{
				entity.SystemUrl = value;
			}
		}
		/// <summary>
		/// 系统版本
		/// </summary>		
		public string SystemVersion
		{
			get
			{
				return entity.SystemVersion;
			}
			set
			{
				entity.SystemVersion = value;
			}
		}
		/// <summary>
		/// 系统版权声明
		/// </summary>		
		public string SystemLisence
		{
			get
			{
				return entity.SystemLisence;
			}
			set
			{
				entity.SystemLisence = value;
			}
		}
		#endregion 







        #region Static Common Data Operation
		
		internal static List<SystemSettingWrapper> ConvertToWrapperList(List<SystemSettingEntity> entitylist)
        {
            List<SystemSettingWrapper> list = new List<SystemSettingWrapper>();
            foreach (SystemSettingEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemSettingWrapper> ConvertToWrapperList(IList<SystemSettingEntity> entitylist)
        {
            List<SystemSettingWrapper> list = new List<SystemSettingWrapper>();
            foreach (SystemSettingEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemSettingEntity> ConvertToEntityList(List<SystemSettingWrapper> wrapperlist)
        {
            List<SystemSettingEntity> list = new List<SystemSettingEntity>();
            foreach (SystemSettingWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemSettingWrapper ConvertEntityToWrapper(SystemSettingEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SystemSettingWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

