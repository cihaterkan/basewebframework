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
    public partial class SystemTaskWrapper
    {
        #region Member

		internal static readonly ISystemTaskServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemTaskServiceProxyInstance;
	 
	 
        internal SystemTaskEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SystemTaskWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SystemTaskWrapper() : this(new SystemTaskEntity())
        {
            
        }

        internal SystemTaskWrapper(SystemTaskEntity entityObj)
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

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemTaskEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_TITLE = "Title";
		public static readonly string PROPERTY_NAME_TASKCONTENT = "TaskContent";
		public static readonly string PROPERTY_NAME_ASSIGNEDUSERID = "AssignedUserID";
		public static readonly string PROPERTY_NAME_STATUS = "Status";
		public static readonly string PROPERTY_NAME_DATEDUE = "DateDue";
		public static readonly string PROPERTY_NAME_ISDATEDUE = "IsDateDue";
		public static readonly string PROPERTY_NAME_DATESTART = "DateStart";
		public static readonly string PROPERTY_NAME_ISDATESTART = "IsDateStart";
		public static readonly string PROPERTY_NAME_PRIORITY = "Priority";
		public static readonly string PROPERTY_NAME_PARENTDATAID = "ParentDataID";
		public static readonly string PROPERTY_NAME_PARENTDATATYPE = "ParentDataType";
		public static readonly string PROPERTY_NAME_ISFINISHED = "IsFinished";
		public static readonly string PROPERTY_NAME_CREATEBY = "CreateBy";
		public static readonly string PROPERTY_NAME_CREATEAT = "CreateAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYBY = "LastModifyBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYAT = "LastModifyAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYCOMMENT = "LastModifyComment";
		
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
		/// <summary>
		/// 
		/// </summary>		
		public string TaskContent
		{
			get
			{
				return entity.TaskContent;
			}
			set
			{
				entity.TaskContent = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? AssignedUserID
		{
			get
			{
				return entity.AssignedUserID;
			}
			set
			{
				entity.AssignedUserID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string Status
		{
			get
			{
				return entity.Status;
			}
			set
			{
				entity.Status = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? DateDue
		{
			get
			{
				return entity.DateDue;
			}
			set
			{
				entity.DateDue = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool? IsDateDue
		{
			get
			{
				return entity.IsDateDue;
			}
			set
			{
				entity.IsDateDue = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? DateStart
		{
			get
			{
				return entity.DateStart;
			}
			set
			{
				entity.DateStart = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool? IsDateStart
		{
			get
			{
				return entity.IsDateStart;
			}
			set
			{
				entity.IsDateStart = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string Priority
		{
			get
			{
				return entity.Priority;
			}
			set
			{
				entity.Priority = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? ParentDataID
		{
			get
			{
				return entity.ParentDataID;
			}
			set
			{
				entity.ParentDataID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ParentDataType
		{
			get
			{
				return entity.ParentDataType;
			}
			set
			{
				entity.ParentDataType = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool? IsFinished
		{
			get
			{
				return entity.IsFinished;
			}
			set
			{
				entity.IsFinished = value;
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



        #endregion








        #region Static Common Data Operation
		
		internal static List<SystemTaskWrapper> ConvertToWrapperList(List<SystemTaskEntity> entitylist)
        {
            List<SystemTaskWrapper> list = new List<SystemTaskWrapper>();
            foreach (SystemTaskEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemTaskWrapper> ConvertToWrapperList(IList<SystemTaskEntity> entitylist)
        {
            List<SystemTaskWrapper> list = new List<SystemTaskWrapper>();
            foreach (SystemTaskEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemTaskEntity> ConvertToEntityList(List<SystemTaskWrapper> wrapperlist)
        {
            List<SystemTaskEntity> list = new List<SystemTaskEntity>();
            foreach (SystemTaskWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemTaskWrapper ConvertEntityToWrapper(SystemTaskEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SystemTaskWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

