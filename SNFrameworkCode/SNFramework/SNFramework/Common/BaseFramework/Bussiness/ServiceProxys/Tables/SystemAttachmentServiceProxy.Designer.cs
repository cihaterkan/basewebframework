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

    public interface ISystemAttachmentServiceProxyDesigner
    {
    }

    public partial class SystemAttachmentServiceProxy : BaseSpringNHibernateEntityServiceProxy<SystemAttachmentEntity>
    {
		public BaseFrameworkDataObjectContainers DataObjectsContainerIocID { set; get; }
	
        public SystemAttachmentDataObject SelfDataObj
        {
            set
            {
                selfDataObject = value;
            }
			get
            {
                return (SystemAttachmentDataObject)selfDataObject;
            }
        }





		
    }
}
