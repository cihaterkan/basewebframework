// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using LD.SPPipeManage.Data.Tables;
using LD.SPPipeManage.Entity.Tables;


namespace LD.SPPipeManage.Bussiness.ServiceProxys.Tables
{
	public interface ISPCodeInfoServiceProxy : IBaseSpringNHibernateEntityServiceProxy<SPCodeInfoEntity>
    {
	    List<SPCodeInfoEntity> FindAllByOrderByAndFilterAndChannelID(int channelId, List<QueryFilter> filters, string orderByColumnName, bool isDesc, int pageIndex, int pageSize, out int recordCount);
	    List<SPCodeInfoEntity> FindAllByOrderByAndChannelID(int channelId, List<QueryFilter> queryFilters, string orderByColumnName, bool isDesc);
    }

    internal partial class SPCodeInfoServiceProxy : ISPCodeInfoServiceProxy
    {
        public List<SPCodeInfoEntity> FindAllByOrderByAndFilterAndChannelID(int channelId, List<QueryFilter> filters, string orderByColumnName, bool isDesc, int pageIndex, int pageSize, out int recordCount)
        {
            if (channelId <= 0)
                return this.selfDataObject.FindAllByOrderByAndFilter(filters, orderByColumnName, isDesc, pageIndex,
                                                                     pageSize, out recordCount);


            return this.SelfDataObj.FindAllByOrderByAndFilterAndChannelID(this.DataObjectsContainerIocID.SPChannelDataObjectInstance.Load(channelId), filters, orderByColumnName, isDesc,
                                                                             pageIndex,
                                                                             pageSize, out recordCount);
        }

        public List<SPCodeInfoEntity> FindAllByOrderByAndChannelID(int channelId, List<QueryFilter> queryFilters, string orderByColumnName, bool isDesc)
        {
            if (channelId <= 0)
                return this.selfDataObject.FindAllByOrderByAndFilter(queryFilters, orderByColumnName, isDesc);


            return this.SelfDataObj.FindAllByOrderByAndFilterAndChannelID(this.DataObjectsContainerIocID.SPChannelDataObjectInstance.Load(channelId), queryFilters, orderByColumnName, isDesc);
        }
    }
}
