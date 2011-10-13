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
    public partial class SystemShortMessageWrapper
    {
        #region Member

		internal static readonly ISystemShortMessageServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemShortMessageServiceProxyInstance;
	 
	 
        internal SystemShortMessageEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SystemShortMessageWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SystemShortMessageWrapper() : this(new SystemShortMessageEntity())
        {
            
        }

        internal SystemShortMessageWrapper(SystemShortMessageEntity entityObj)
        {
            entity = entityObj;
        }
		#endregion
		
		#region Equals 和 HashCode 方法覆盖
		public override bool Equals(object obj)
        {
            if (obj == null && entity!=null)
            {
                if (entity.ShortMessageID == 0)
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

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemShortMessageEntity";
		public static readonly string PROPERTY_NAME_SHORTMESSAGEID = "ShortMessageID";
		public static readonly string PROPERTY_NAME_SHORTMESSAGETITLE = "ShortMessageTitle";
		public static readonly string PROPERTY_NAME_SHORTMESSAGECATEGORY = "ShortMessageCategory";
		public static readonly string PROPERTY_NAME_SHORTMESSAGECONTENT = "ShortMessageContent";
		public static readonly string PROPERTY_NAME_SHORTMESSAGESENDERNAME = "ShortMessageSenderName";
		public static readonly string PROPERTY_NAME_SHORTMESSAGETONAME = "ShortMessageToName";
		public static readonly string PROPERTY_NAME_SHORTMESSAGESENDDATE = "ShortMessageSendDate";
		public static readonly string PROPERTY_NAME_SHORTMESSAGESENDUSERID = "ShortMessageSendUserID";
		public static readonly string PROPERTY_NAME_SHORTMESSAGERECEIVERUSERID = "ShortMessageReceiverUserID";
		public static readonly string PROPERTY_NAME_SHORTMESSAGEISREAD = "ShortMessageIsRead";
		public static readonly string PROPERTY_NAME_SHORTMESSAGETYPE = "ShortMessageType";
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
		public int ShortMessageID
		{
			get
			{
				return entity.ShortMessageID;
			}
			set
			{
				entity.ShortMessageID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ShortMessageTitle
		{
			get
			{
				return entity.ShortMessageTitle;
			}
			set
			{
				entity.ShortMessageTitle = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ShortMessageCategory
		{
			get
			{
				return entity.ShortMessageCategory;
			}
			set
			{
				entity.ShortMessageCategory = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ShortMessageContent
		{
			get
			{
				return entity.ShortMessageContent;
			}
			set
			{
				entity.ShortMessageContent = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ShortMessageSenderName
		{
			get
			{
				return entity.ShortMessageSenderName;
			}
			set
			{
				entity.ShortMessageSenderName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ShortMessageToName
		{
			get
			{
				return entity.ShortMessageToName;
			}
			set
			{
				entity.ShortMessageToName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public DateTime ShortMessageSendDate
		{
			get
			{
				return entity.ShortMessageSendDate;
			}
			set
			{
				entity.ShortMessageSendDate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? ShortMessageSendUserID
		{
			get
			{
				return entity.ShortMessageSendUserID;
			}
			set
			{
				entity.ShortMessageSendUserID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int ShortMessageReceiverUserID
		{
			get
			{
				return entity.ShortMessageReceiverUserID;
			}
			set
			{
				entity.ShortMessageReceiverUserID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool ShortMessageIsRead
		{
			get
			{
				return entity.ShortMessageIsRead;
			}
			set
			{
				entity.ShortMessageIsRead = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ShortMessageType
		{
			get
			{
				return entity.ShortMessageType;
			}
			set
			{
				entity.ShortMessageType = value;
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


		#region Query Property
		
		
      	
   
		#endregion


        #region "FKQuery"



        #endregion








        #region Static Common Data Operation
		
		internal static List<SystemShortMessageWrapper> ConvertToWrapperList(List<SystemShortMessageEntity> entitylist)
        {
            List<SystemShortMessageWrapper> list = new List<SystemShortMessageWrapper>();
            foreach (SystemShortMessageEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemShortMessageWrapper> ConvertToWrapperList(IList<SystemShortMessageEntity> entitylist)
        {
            List<SystemShortMessageWrapper> list = new List<SystemShortMessageWrapper>();
            foreach (SystemShortMessageEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemShortMessageEntity> ConvertToEntityList(List<SystemShortMessageWrapper> wrapperlist)
        {
            List<SystemShortMessageEntity> list = new List<SystemShortMessageEntity>();
            foreach (SystemShortMessageWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemShortMessageWrapper ConvertEntityToWrapper(SystemShortMessageEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.ShortMessageID == 0)
                return null;

            return new SystemShortMessageWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

