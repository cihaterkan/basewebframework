// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using LD.SPPipeManage.Data.AdoNet;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using LD.SPPipeManage.Data.Tables;
using LD.SPPipeManage.Entity.Tables;
using LD.SPPipeManage.Data.Tables.Container;


namespace LD.SPPipeManage.Bussiness.ServiceProxys.Tables
{
    internal partial class SPSendClientParamsServiceProxy : BaseSpringNHibernateEntityServiceProxy<SPSendClientParamsEntity>
    {
		public DataObjectContainers DataObjectsContainerIocID { set; get; }
	
        public SPSendClientParamsDataObject SelfDataObj
        {
            set
            {
                selfDataObject = value;
            }
			get
            {
                return (SPSendClientParamsDataObject)selfDataObject;
            }
        }
		
        public AdoNetDataObject AdoNetDb { set; get; }		

		
    }
}
