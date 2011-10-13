// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using Legendigital.Framework.Common.BaseFramework.Data.Tables;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.BaseFramework.Data.Tables.Container;




namespace Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables
{

    public interface ISystemAttachmentContentServiceProxyDesigner
    {
		List<SystemAttachmentContentEntity> FindAllByOrderByAndFilterAndAttacmentID(string orderByColumnName, bool isDesc,   SystemAttachmentEntity _attacmentID, PageQueryParams pageQueryParams);
		List<SystemAttachmentContentEntity> FindAllByAttacmentID(SystemAttachmentEntity _attacmentID);
    }

    public partial class SystemAttachmentContentServiceProxy : BaseSpringNHibernateEntityServiceProxy<SystemAttachmentContentEntity>
    {
		public BaseFrameworkDataObjectContainers DataObjectsContainerIocID { set; get; }
	
        public SystemAttachmentContentDataObject SelfDataObj
        {
            set
            {
                selfDataObject = value;
            }
			get
            {
                return (SystemAttachmentContentDataObject)selfDataObject;
            }
        }
	
		public List<SystemAttachmentContentEntity> FindAllByOrderByAndFilterAndAttacmentID(string orderByColumnName, bool isDesc,  SystemAttachmentEntity _attacmentID, PageQueryParams pageQueryParams)
        {
			return this.SelfDataObj.GetPageList_By_AttacmentID_SystemAttachmentEntity(orderByColumnName, isDesc,_attacmentID, pageQueryParams);
        }
		
		public List<SystemAttachmentContentEntity> FindAllByAttacmentID(SystemAttachmentEntity _attacmentID)
        {
			return this.SelfDataObj.GetList_By_AttacmentID_SystemAttachmentEntity(_attacmentID);
        }





		
    }
}
