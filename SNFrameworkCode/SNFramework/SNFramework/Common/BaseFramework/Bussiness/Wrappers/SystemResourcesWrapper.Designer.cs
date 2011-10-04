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
    public partial class SystemResourcesWrapper
    {
        #region Member

		internal static readonly ISystemResourcesServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemResourcesServiceProxyInstance;
	 
	 
        internal SystemResourcesEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SystemResourcesWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SystemResourcesWrapper() : this(new SystemResourcesEntity())
        {
            
        }

        internal SystemResourcesWrapper(SystemResourcesEntity entityObj)
        {
            entity = entityObj;
        }
		#endregion
		
		#region Equals 和 HashCode 方法覆盖
		public override bool Equals(object obj)
        {
            if (obj == null && entity!=null)
            {
                if (entity.ResourcesID == 0)
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

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemResourcesEntity";
		public static readonly string PROPERTY_NAME_RESOURCESID = "ResourcesID";
		public static readonly string PROPERTY_NAME_RESOURCESNAMECN = "ResourcesNameCn";
		public static readonly string PROPERTY_NAME_RESOURCESNAMEEN = "ResourcesNameEn";
		public static readonly string PROPERTY_NAME_RESOURCESDESCRIPTION = "ResourcesDescription";
		public static readonly string PROPERTY_NAME_RESOURCESTYPE = "ResourcesType";
		public static readonly string PROPERTY_NAME_RESOURCESLIMITEXPRESSION = "ResourcesLimitExpression";
		public static readonly string PROPERTY_NAME_RESOURCESISRELATEUSER = "ResourcesIsRelateUser";
		public static readonly string PROPERTY_NAME_MOUDLEID = "MoudleID";
		public static readonly string PROPERTY_NAME_PARENTRESOURCESID = "ParentResourcesID";
		public static readonly string PROPERTY_NAME_ORDERINDEX = "OrderIndex";
		public static readonly string PROPERTY_NAME_CREATEBY = "CreateBy";
		public static readonly string PROPERTY_NAME_CREATEAT = "CreateAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYBY = "LastModifyBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYAT = "LastModifyAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYCOMMENT = "LastModifyComment";
		
        #endregion
	
 
		#region moudleID字段外键查询字段
        public static readonly string PROPERTY_MOUDLEID_ALIAS_NAME = "MoudleID_SystemResourcesEntity_Alias";
		public static readonly string PROPERTY_MOUDLEID_MOUDLEID = "MoudleID_SystemResourcesEntity_Alias.MoudleID";
		public static readonly string PROPERTY_MOUDLEID_MOUDLENAMECN = "MoudleID_SystemResourcesEntity_Alias.MoudleNameCn";
		public static readonly string PROPERTY_MOUDLEID_MOUDLENAMEEN = "MoudleID_SystemResourcesEntity_Alias.MoudleNameEn";
		public static readonly string PROPERTY_MOUDLEID_MOUDLENAMEDB = "MoudleID_SystemResourcesEntity_Alias.MoudleNameDb";
		public static readonly string PROPERTY_MOUDLEID_MOUDLEDESCRIPTION = "MoudleID_SystemResourcesEntity_Alias.MoudleDescription";
		public static readonly string PROPERTY_MOUDLEID_APPLICATIONID = "MoudleID_SystemResourcesEntity_Alias.ApplicationID";
		public static readonly string PROPERTY_MOUDLEID_MOUDLEISSYSTEMMOUDLE = "MoudleID_SystemResourcesEntity_Alias.MoudleIsSystemMoudle";
		public static readonly string PROPERTY_MOUDLEID_ORDERINDEX = "MoudleID_SystemResourcesEntity_Alias.OrderIndex";
		public static readonly string PROPERTY_MOUDLEID_CREATEBY = "MoudleID_SystemResourcesEntity_Alias.CreateBy";
		public static readonly string PROPERTY_MOUDLEID_CREATEAT = "MoudleID_SystemResourcesEntity_Alias.CreateAt";
		public static readonly string PROPERTY_MOUDLEID_LASTMODIFYBY = "MoudleID_SystemResourcesEntity_Alias.LastModifyBy";
		public static readonly string PROPERTY_MOUDLEID_LASTMODIFYAT = "MoudleID_SystemResourcesEntity_Alias.LastModifyAt";
		public static readonly string PROPERTY_MOUDLEID_LASTMODIFYCOMMENT = "MoudleID_SystemResourcesEntity_Alias.LastModifyComment";
		#endregion
      	
	
	
		 
		
		
		
		


		#region Public Property
		/// <summary>
		/// ??
		/// </summary>		
		public int ResourcesID
		{
			get
			{
				return entity.ResourcesID;
			}
			set
			{
				entity.ResourcesID = value;
			}
		}
		/// <summary>
		/// ?????
		/// </summary>		
		public string ResourcesNameCn
		{
			get
			{
				return entity.ResourcesNameCn;
			}
			set
			{
				entity.ResourcesNameCn = value;
			}
		}
		/// <summary>
		/// ?????
		/// </summary>		
		public string ResourcesNameEn
		{
			get
			{
				return entity.ResourcesNameEn;
			}
			set
			{
				entity.ResourcesNameEn = value;
			}
		}
		/// <summary>
		/// ????
		/// </summary>		
		public string ResourcesDescription
		{
			get
			{
				return entity.ResourcesDescription;
			}
			set
			{
				entity.ResourcesDescription = value;
			}
		}
		/// <summary>
		/// ????
		/// </summary>		
		public string ResourcesType
		{
			get
			{
				return entity.ResourcesType;
			}
			set
			{
				entity.ResourcesType = value;
			}
		}
		/// <summary>
		/// ??????
		/// </summary>		
		public string ResourcesLimitExpression
		{
			get
			{
				return entity.ResourcesLimitExpression;
			}
			set
			{
				entity.ResourcesLimitExpression = value;
			}
		}
		/// <summary>
		/// ?????????
		/// </summary>		
		public bool ResourcesIsRelateUser
		{
			get
			{
				return entity.ResourcesIsRelateUser;
			}
			set
			{
				entity.ResourcesIsRelateUser = value;
			}
		}
		/// <summary>
		/// ????
		/// </summary>		
		public SystemMoudleWrapper MoudleID
		{
			get
			{
				return SystemMoudleWrapper.ConvertEntityToWrapper(entity.MoudleID) ;
			}
			set
			{
				entity.MoudleID = ((value == null) ? null : value.entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public SystemResourcesWrapper ParentResourcesID
		{
			get
			{
				return SystemResourcesWrapper.ConvertEntityToWrapper(entity.ParentResourcesID) ;
			}
			set
			{
				entity.ParentResourcesID = ((value == null) ? null : value.entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? OrderIndex
		{
			get
			{
				return entity.OrderIndex;
			}
			set
			{
				entity.OrderIndex = value;
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
		/// <summary>
		/// 
		/// </summary>		
		public string LastModifyComment
		{
			get
			{
				return entity.LastModifyComment;
			}
			set
			{
				entity.LastModifyComment = value;
			}
		}
		#endregion 





        #region "FKQuery"
		
        public static List<SystemResourcesWrapper> FindAllByOrderByAndFilterAndMoudleID(string orderByColumnName, bool isDesc,   SystemMoudleWrapper moudleID,  PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndMoudleID(orderByColumnName, isDesc,   moudleID.entity, pageQueryParams));
        }

        public static List<SystemResourcesWrapper> FindAllByMoudleID(SystemMoudleWrapper moudleID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByMoudleID(moudleID.entity));
        }
		



        #endregion








        #region Static Common Data Operation
		
		internal static List<SystemResourcesWrapper> ConvertToWrapperList(List<SystemResourcesEntity> entitylist)
        {
            List<SystemResourcesWrapper> list = new List<SystemResourcesWrapper>();
            foreach (SystemResourcesEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemResourcesWrapper> ConvertToWrapperList(IList<SystemResourcesEntity> entitylist)
        {
            List<SystemResourcesWrapper> list = new List<SystemResourcesWrapper>();
            foreach (SystemResourcesEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemResourcesEntity> ConvertToEntityList(List<SystemResourcesWrapper> wrapperlist)
        {
            List<SystemResourcesEntity> list = new List<SystemResourcesEntity>();
            foreach (SystemResourcesWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemResourcesWrapper ConvertEntityToWrapper(SystemResourcesEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.ResourcesID == 0)
                return null;

            return new SystemResourcesWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

