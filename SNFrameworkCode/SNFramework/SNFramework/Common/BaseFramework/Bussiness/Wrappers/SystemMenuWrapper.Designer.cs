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
    public partial class SystemMenuWrapper
    {
        #region Member

		internal static readonly ISystemMenuServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemMenuServiceProxyInstance;
	 
	 
        internal SystemMenuEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SystemMenuWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SystemMenuWrapper() : this(new SystemMenuEntity())
        {
            
        }

        internal SystemMenuWrapper(SystemMenuEntity entityObj)
        {
            entity = entityObj;
        }
		#endregion
		
		#region Equals 和 HashCode 方法覆盖
		public override bool Equals(object obj)
        {
            if (obj == null && entity!=null)
            {
                if (entity.MenuID == 0)
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

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemMenuEntity";
		public static readonly string PROPERTY_NAME_MENUID = "MenuID";
		public static readonly string PROPERTY_NAME_MENUNAME = "MenuName";
		public static readonly string PROPERTY_NAME_MENUCODE = "MenuCode";
		public static readonly string PROPERTY_NAME_MENUDESCRIPTION = "MenuDescription";
		public static readonly string PROPERTY_NAME_MENUURL = "MenuUrl";
		public static readonly string PROPERTY_NAME_MENUURLTARGET = "MenuUrlTarget";
		public static readonly string PROPERTY_NAME_MENUICONURL = "MenuIconUrl";
		public static readonly string PROPERTY_NAME_MENUISCATEGORY = "MenuIsCategory";
		public static readonly string PROPERTY_NAME_PARENTMENUID = "ParentMenuID";
		public static readonly string PROPERTY_NAME_MENUORDER = "MenuOrder";
		public static readonly string PROPERTY_NAME_MENUTYPE = "MenuType";
		public static readonly string PROPERTY_NAME_MENUISSYSTEMMENU = "MenuIsSystemMenu";
		public static readonly string PROPERTY_NAME_MENUISENABLE = "MenuIsEnable";
		public static readonly string PROPERTY_NAME_APPLICATIONID = "ApplicationID";
		public static readonly string PROPERTY_NAME_CREATEBY = "CreateBy";
		public static readonly string PROPERTY_NAME_CREATEAT = "CreateAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYBY = "LastModifyBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYAT = "LastModifyAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYCOMMENT = "LastModifyComment";
		
        #endregion
	
 
		#region applicationID字段外键查询字段
        public static readonly string PROPERTY_APPLICATIONID_ALIAS_NAME = "ApplicationID_SystemMenuEntity_Alias";
		public static readonly string PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONID = "ApplicationID_SystemMenuEntity_Alias.SystemApplicationID";
		public static readonly string PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONNAME = "ApplicationID_SystemMenuEntity_Alias.SystemApplicationName";
		public static readonly string PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONCODE = "ApplicationID_SystemMenuEntity_Alias.SystemApplicationCode";
		public static readonly string PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONDESCRIPTION = "ApplicationID_SystemMenuEntity_Alias.SystemApplicationDescription";
		public static readonly string PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONURL = "ApplicationID_SystemMenuEntity_Alias.SystemApplicationUrl";
		public static readonly string PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONISSYSTEMAPPLICATION = "ApplicationID_SystemMenuEntity_Alias.SystemApplicationIsSystemApplication";
		public static readonly string PROPERTY_APPLICATIONID_ORDERINDEX = "ApplicationID_SystemMenuEntity_Alias.OrderIndex";
		public static readonly string PROPERTY_APPLICATIONID_CREATEBY = "ApplicationID_SystemMenuEntity_Alias.CreateBy";
		public static readonly string PROPERTY_APPLICATIONID_CREATEAT = "ApplicationID_SystemMenuEntity_Alias.CreateAt";
		public static readonly string PROPERTY_APPLICATIONID_LASTMODIFYBY = "ApplicationID_SystemMenuEntity_Alias.LastModifyBy";
		public static readonly string PROPERTY_APPLICATIONID_LASTMODIFYAT = "ApplicationID_SystemMenuEntity_Alias.LastModifyAt";
		public static readonly string PROPERTY_APPLICATIONID_LASTMODIFYCOMMENT = "ApplicationID_SystemMenuEntity_Alias.LastModifyComment";
		#endregion
      	
	
	
		 
		
		
		
		


		#region Public Property
		/// <summary>
		/// Primary Key
		/// </summary>		
		public int MenuID
		{
			get
			{
				return entity.MenuID;
			}
			set
			{
				entity.MenuID = value;
			}
		}
		/// <summary>
		/// Menu Name
		/// </summary>		
		public string MenuName
		{
			get
			{
				return entity.MenuName;
			}
			set
			{
				entity.MenuName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string MenuCode
		{
			get
			{
				return entity.MenuCode;
			}
			set
			{
				entity.MenuCode = value;
			}
		}
		/// <summary>
		/// Menu Description
		/// </summary>		
		public string MenuDescription
		{
			get
			{
				return entity.MenuDescription;
			}
			set
			{
				entity.MenuDescription = value;
			}
		}
		/// <summary>
		/// Menu Url
		/// </summary>		
		public string MenuUrl
		{
			get
			{
				return entity.MenuUrl;
			}
			set
			{
				entity.MenuUrl = value;
			}
		}
		/// <summary>
		/// Menu Url Target Name
		/// </summary>		
		public string MenuUrlTarget
		{
			get
			{
				return entity.MenuUrlTarget;
			}
			set
			{
				entity.MenuUrlTarget = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string MenuIconUrl
		{
			get
			{
				return entity.MenuIconUrl;
			}
			set
			{
				entity.MenuIconUrl = value;
			}
		}
		/// <summary>
		/// Menu Is Category
		/// </summary>		
		public bool MenuIsCategory
		{
			get
			{
				return entity.MenuIsCategory;
			}
			set
			{
				entity.MenuIsCategory = value;
			}
		}
		/// <summary>
		/// Parent Menu
		/// </summary>		
		public SystemMenuWrapper ParentMenuID
		{
			get
			{
				return SystemMenuWrapper.ConvertEntityToWrapper(entity.ParentMenuID) ;
			}
			set
			{
				entity.ParentMenuID = ((value == null) ? null : value.entity);
			}
		}
		/// <summary>
		/// Menu Order
		/// </summary>		
		public int? MenuOrder
		{
			get
			{
				return entity.MenuOrder;
			}
			set
			{
				entity.MenuOrder = value;
			}
		}
		/// <summary>
		/// Menu Type
		/// </summary>		
		public string MenuType
		{
			get
			{
				return entity.MenuType;
			}
			set
			{
				entity.MenuType = value;
			}
		}
		/// <summary>
		/// Is System Menu
		/// </summary>		
		public bool? MenuIsSystemMenu
		{
			get
			{
				return entity.MenuIsSystemMenu;
			}
			set
			{
				entity.MenuIsSystemMenu = value;
			}
		}
		/// <summary>
		/// Is Enable
		/// </summary>		
		public bool? MenuIsEnable
		{
			get
			{
				return entity.MenuIsEnable;
			}
			set
			{
				entity.MenuIsEnable = value;
			}
		}
		/// <summary>
		/// Application
		/// </summary>		
		public SystemApplicationWrapper ApplicationID
		{
			get
			{
				return SystemApplicationWrapper.ConvertEntityToWrapper(entity.ApplicationID) ;
			}
			set
			{
				entity.ApplicationID = ((value == null) ? null : value.entity);
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
		
        public static List<SystemMenuWrapper> FindAllByOrderByAndFilterAndApplicationID(string orderByColumnName, bool isDesc,   SystemApplicationWrapper applicationID,  PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndApplicationID(orderByColumnName, isDesc,   applicationID.entity, pageQueryParams));
        }

        public static List<SystemMenuWrapper> FindAllByApplicationID(SystemApplicationWrapper applicationID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByApplicationID(applicationID.entity));
        }
		



        #endregion








        #region Static Common Data Operation
		
		internal static List<SystemMenuWrapper> ConvertToWrapperList(List<SystemMenuEntity> entitylist)
        {
            List<SystemMenuWrapper> list = new List<SystemMenuWrapper>();
            foreach (SystemMenuEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemMenuWrapper> ConvertToWrapperList(IList<SystemMenuEntity> entitylist)
        {
            List<SystemMenuWrapper> list = new List<SystemMenuWrapper>();
            foreach (SystemMenuEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemMenuEntity> ConvertToEntityList(List<SystemMenuWrapper> wrapperlist)
        {
            List<SystemMenuEntity> list = new List<SystemMenuEntity>();
            foreach (SystemMenuWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemMenuWrapper ConvertEntityToWrapper(SystemMenuEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.MenuID == 0)
                return null;

            return new SystemMenuWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

