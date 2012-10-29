// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SPAdReportServiceProxy.cs">
//   Copyright (c) Foreveross Enterprises. All rights reserved.
// </copyright>
// <summary>
//   Generated by MyGeneration Version # (1.3.0.9)
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using SPS.Bussiness.Wrappers;
using SPS.Data.Tables;
using SPS.Entity.Tables;
using Spring.Transaction;
using Spring.Transaction.Interceptor;


namespace SPS.Bussiness.ServiceProxys.Tables
{
	public interface ISPAdReportServiceProxy : IBaseSpringNHibernateEntityServiceProxy<SPAdReportEntity,int> ,ISPAdReportServiceProxyDesigner
    {
	    List<SPAdReportEntity> QueryReport(DateTime startDate, DateTime endDate);
	    void SaveNewReport(SPAdReportEntity spAdReportWrapper);
	    List<SPAdReportEntity> QueryReport(DateTime startDate, DateTime endDate, SPSClientEntity spsClientEntity);
    }

    internal partial class SPAdReportServiceProxy : ISPAdReportServiceProxy
    {
        public List<SPAdReportEntity> QueryReport(DateTime startDate, DateTime endDate)
        {
            return this.SelfDataObj.QueryReport(startDate, endDate);
        }

        [Transaction(TransactionPropagation.Required, ReadOnly = false)]
        public void SaveNewReport(SPAdReportEntity spAdReportWrapper)
        {
            SPAdReportEntity spAdReport = this.SelfDataObj.FindByCilentIDAdPackIDAndReportDate(
                spAdReportWrapper.SPAdID, spAdReportWrapper.SPPackID, spAdReportWrapper.SPClientID,
                spAdReportWrapper.ReportDate);

            if(spAdReport!=null)
            {
                spAdReport.ClientCount = spAdReportWrapper.ClientCount;
                spAdReport.AdCount = spAdReportWrapper.AdCount;
                this.SelfDataObj.Update(spAdReport);
            }
            else
            {
                this.SelfDataObj.Save(spAdReportWrapper);
            }



        }

        public List<SPAdReportEntity> QueryReport(DateTime startDate, DateTime endDate, SPSClientEntity spsClientEntity)
        {
            return this.SelfDataObj.QueryReport(startDate, endDate, spsClientEntity);
        }
    }
}
