// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using LD.SPPipeManage.Data.Tables;
using LD.SPPipeManage.Entity.Tables;


namespace LD.SPPipeManage.Bussiness.ServiceProxys.Tables
{
    public interface ISPPaymentInfoServiceProxy : IBaseSpringNHibernateEntityServiceProxy<SPPaymentInfoEntity>, ISPPaymentInfoServiceProxyDesigner
    {
        List<SPPaymentInfoEntity> FindAllByOrderByAndCleintIDAndChanneLIDAndDateNoIntercept(int channelId, int clientId, DateTime startDateTime, DateTime enddateTime, string sortFieldName, bool isDesc, int pageIndex, int pageSize, out int recordCount);

        DataTable FindAllDataTableByOrderByAndCleintIDAndChanneLIDAndDateNoIntercept(int channelId, int clientId, DateTime startDateTime, DateTime enddateTime, string sortFieldName, bool isDesc, int pageIndex, int pageSize, out int recordCount);
    }

    internal partial class SPPaymentInfoServiceProxy : ISPPaymentInfoServiceProxy
    {
        public List<SPPaymentInfoEntity> FindAllByOrderByAndCleintIDAndChanneLIDAndDateNoIntercept(int channelId, int clientId, DateTime startDateTime, DateTime enddateTime, string sortFieldName, bool isDesc, int pageIndex, int pageSize, out int recordCount)
        {
            SPChannelEntity channelEntity = null;

            if (channelId > 0)
                channelEntity = this.DataObjectsContainerIocID.SPChannelDataObjectInstance.Load(channelId);


            SPClientEntity clientEntity = null;

            if (clientId > 0)
                clientEntity = this.DataObjectsContainerIocID.SPClientDataObjectInstance.Load(clientId);


            return this.SelfDataObj.FindAllByOrderByAndCleintIDAndChanneLIDAndDateNoIntercept(channelEntity, clientEntity,
                                                                                   startDateTime,
                                                                                   enddateTime,
                                                                                   sortFieldName, isDesc,
                                                                                   pageIndex, pageSize,
                                                                                   out recordCount);
        }

        public DataTable FindAllDataTableByOrderByAndCleintIDAndChanneLIDAndDateNoIntercept(int channelId, int clientId, DateTime startDateTime, DateTime enddateTime, string sortFieldName, bool isDesc, int pageIndex, int pageSize, out int recordCount)
        {
            throw new NotImplementedException();
        }
    }
}
