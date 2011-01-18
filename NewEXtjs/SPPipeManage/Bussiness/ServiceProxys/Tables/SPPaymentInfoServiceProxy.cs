// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using LD.SPPipeManage.Bussiness.Wrappers;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using LD.SPPipeManage.Data.Tables;
using LD.SPPipeManage.Entity.Tables;
using Spring.Transaction.Interceptor;


namespace LD.SPPipeManage.Bussiness.ServiceProxys.Tables
{
    public enum PaymentInfoInsertErrorType {NoError,RepeatLinkID}


    public interface ISPPaymentInfoServiceProxy : IBaseSpringNHibernateEntityServiceProxy<SPPaymentInfoEntity>, ISPPaymentInfoServiceProxyDesigner
    {
        List<SPPaymentInfoEntity> FindAllByOrderByAndCleintIDAndChanneLIDAndDateNoIntercept(int channelId, int clientId, DateTime startDateTime, DateTime enddateTime, string sortFieldName, bool isDesc, int pageIndex, int pageSize, out int recordCount);

        //DataTable FindAllDataTableByOrderByAndCleintIDAndChanneLIDAndDateNoIntercept(int channelId, int clientId, DateTime startDateTime, DateTime enddateTime, string sortFieldName, bool isDesc, int pageIndex, int pageSize, out int recordCount);
        List<SPPaymentInfoEntity> FindAllDataTableByOrderByAndCleintIDAndChanneLIDAndDate(int channelId, int clientId, DateTime startDateTime, DateTime enddateTime, DataType dataType, string sortFieldName, bool isDesc, int pageIndex, int pageSize, out int recordCount);
        List<SPPaymentInfoEntity> FindAllNotSendData(int channelId, int clientId, DateTime startdate, DateTime endDate, int maxDataCount);
        DataTable FindAllNotSendChannelClient();
        bool InsertPayment(SPPaymentInfoEntity paymentInfo, List<string> uniqueKeyNames, out PaymentInfoInsertErrorType errorType);
        List<SPPaymentInfoEntity> FindAllByOrderByAndClientIDAndDateNoIntercept(int spClientID, DateTime startDate, DateTime endDate, string sortFieldName, bool isdesc, int pageIndex, int limit, out int recordCount);
        List<SPPaymentInfoEntity> FindAllByOrderByAndSPClientGroupIDAndDateNoIntercept(int spClientGroupID, DateTime startDate, DateTime endDate, string sortFieldName, bool isdesc, int pageIndex, int limit, out int recordCount);
        List<SPPaymentInfoEntity> FindAllByOrderByAndSPClientGroupIDAndDateAndProviceNoIntercept(int spClientGroupID, DateTime startDate, DateTime endDate, string province, string phone, string sortFieldName, bool isdesc, int pageIndex, int limit, out int recordCount);
        List<SPPaymentInfoEntity> FindAllByOrderByAndClientIDAndDate(int clientId, DateTime startDate, DateTime endDate, string sortFieldName, bool isDesc, int pageIndex, int limit, out int recordCount);
        List<SPPaymentInfoEntity> FindAllDefaultClientPaymentByOrderByDate(DateTime startDate, DateTime endDate, string sortFieldName, bool isDesc, int pageIndex, int limit, out int recordCount);
        List<SPPaymentInfoEntity> FindAllByOrderByAndCleintIDAndChanneLIDAndDateAndProviceNoIntercept(int spClientId, DateTime startDate, DateTime endDate, string province,string phone, string sortFieldName, bool isdesc, int pageIndex, int limit, out int recordCount);
        List<SPPaymentInfoEntity> FindAllNotSendData(int clientChannelId, DateTime starDate, DateTime endDate, int maxRetryCount);
        int[] GetGetAllClientChannelIDNeed(DateTime startDate, DateTime endDate);
        void UpdateRecordAndReport(DayliyReport dayReport, SPClientChannelSettingEntity spClientChannelSettingEntity, int newIntercept);
        void UpdateUrlSuccessSend(int id, string url);
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

        public List<SPPaymentInfoEntity> FindAllDataTableByOrderByAndCleintIDAndChanneLIDAndDate(int channelId, int clientId, DateTime startDateTime, DateTime enddateTime, DataType dataType, string sortFieldName, bool isDesc, int pageIndex, int pageSize, out int recordCount)
        {
            SPChannelEntity channelEntity = null;

            if (channelId > 0)
                channelEntity = this.DataObjectsContainerIocID.SPChannelDataObjectInstance.Load(channelId);


            SPClientEntity clientEntity = null;

            if (clientId > 0)
                clientEntity = this.DataObjectsContainerIocID.SPClientDataObjectInstance.Load(clientId);


            return this.SelfDataObj.FindAllDataTableByOrderByAndCleintIDAndChanneLIDAndDate(channelEntity, clientEntity,
                                                                                   startDateTime,
                                                                                   enddateTime, dataType.ToString(),
                                                                                   sortFieldName, isDesc,
                                                                                   pageIndex, pageSize,
                                                                                   out recordCount);
        }

        public List<SPPaymentInfoEntity> FindAllNotSendData(int channelId, int clientId, DateTime startdate, DateTime endDate, int maxDataCount)
        {
            SPChannelEntity channelEntity = null;

            if (channelId > 0)
                channelEntity = this.DataObjectsContainerIocID.SPChannelDataObjectInstance.Load(channelId);


            SPClientEntity clientEntity = null;

            if (clientId > 0)
                clientEntity = this.DataObjectsContainerIocID.SPClientDataObjectInstance.Load(clientId);


            return this.SelfDataObj.FindAllNotSendData(channelEntity, clientEntity, startdate, endDate, maxDataCount);
        }

        public DataTable FindAllNotSendChannelClient()
        {
            return this.AdoNetDb.GetAllNeedSendChannelClient().Tables[0];
        }


        [Transaction(ReadOnly = false)]
        public bool InsertPayment(SPPaymentInfoEntity paymentInfo, List<string> uniqueKeyNames, out PaymentInfoInsertErrorType errorType)
        {
            errorType = PaymentInfoInsertErrorType.NoError;

            SPPaymentInfoEntity spPaymentInfoEntity = this.DataObjectsContainerIocID.SPPaymentInfoDataObjectInstance.CheckChannleLinkIDIsExist(paymentInfo.ChannelID, paymentInfo, uniqueKeyNames);

            if(spPaymentInfoEntity!=null)
            {
                errorType = PaymentInfoInsertErrorType.RepeatLinkID;

                return false;
            }

            this.DataObjectsContainerIocID.SPPaymentInfoDataObjectInstance.Save(paymentInfo);

            return true;
        }

        public List<SPPaymentInfoEntity> FindAllByOrderByAndClientIDAndDateNoIntercept(int spClientID, DateTime startDate, DateTime endDate, string sortFieldName, bool isdesc, int pageIndex, int limit, out int recordCount)
        {

            SPClientEntity clientEntity = this.DataObjectsContainerIocID.SPClientDataObjectInstance.Load(spClientID);

            return this.SelfDataObj.FindAllByOrderByAndClientIDAndDateNoIntercept(clientEntity,
                                                                                   startDate,
                                                                                   endDate,
                                                                                   sortFieldName, isdesc,
                                                                                   pageIndex, limit,
                                                                                   out recordCount);
        }

        public List<SPPaymentInfoEntity> FindAllByOrderByAndSPClientGroupIDAndDateNoIntercept(int spClientGroupID, DateTime startDate, DateTime endDate, string sortFieldName, bool isdesc, int pageIndex, int limit, out int recordCount)
        {
            SPClientGroupEntity clientGroupEntity = this.DataObjectsContainerIocID.SPClientGroupDataObjectInstance.Load(spClientGroupID);

            List<SPClientEntity> spClientEntities =
                this.DataObjectsContainerIocID.SPClientDataObjectInstance.GetList_By_SPClientGroupEntity
                    (clientGroupEntity);

            return this.SelfDataObj.FindAllByOrderByAndSPClientIDsAndDateNoIntercept(spClientEntities,
                                                                                   startDate,
                                                                                   endDate,
                                                                                   sortFieldName, isdesc,
                                                                                   pageIndex, limit,
                                                                                   out recordCount);
        }

 

        public List<SPPaymentInfoEntity> FindAllByOrderByAndSPClientGroupIDAndDateAndProviceNoIntercept(int spClientGroupID, DateTime startDate, DateTime endDate, string province,string phone, string sortFieldName, bool isdesc, int pageIndex, int limit, out int recordCount)
        {
            SPClientGroupEntity clientGroupEntity = this.DataObjectsContainerIocID.SPClientGroupDataObjectInstance.Load(spClientGroupID);

            List<SPClientEntity> spClientEntities =
                this.DataObjectsContainerIocID.SPClientDataObjectInstance.GetList_By_SPClientGroupEntity
                    (clientGroupEntity);

            return this.SelfDataObj.FindAllByOrderByAndSPClientGroupIDAndDateAndProviceNoIntercept(spClientEntities,
                                                                                   startDate,
                                                                                   endDate, province, phone,
                                                                                   sortFieldName, isdesc,
                                                                                   pageIndex, limit,
                                                                                   out recordCount);
        }

        public List<SPPaymentInfoEntity> FindAllByOrderByAndClientIDAndDate(int clientId, DateTime startDate, DateTime endDate, string sortFieldName, bool isDesc, int pageIndex, int limit, out int recordCount)
        {
            SPClientEntity clientEntity = this.DataObjectsContainerIocID.SPClientDataObjectInstance.Load(clientId);



            return this.SelfDataObj.FindAllByOrderByAndClientIDAndDate(clientEntity,
                                                                                   startDate,
                                                                                   endDate,
                                                                                   sortFieldName, isDesc,
                                                                                   pageIndex, limit,
                                                                                   out recordCount);
        }

        public List<SPPaymentInfoEntity> FindAllDefaultClientPaymentByOrderByDate(DateTime startDate, DateTime endDate, string sortFieldName, bool isDesc, int pageIndex, int limit, out int recordCount)
        {
            List<SPClientEntity> spClientEntities =
                this.DataObjectsContainerIocID.SPClientDataObjectInstance.GetAllDefaultClient();



            return this.SelfDataObj.FindAllDefaultClientPaymentByOrderByDate(spClientEntities,
                                                                                   startDate,
                                                                                   endDate,
                                                                                   sortFieldName, isDesc,
                                                                                   pageIndex, limit,
                                                                                   out recordCount);
        }

        public List<SPPaymentInfoEntity> FindAllByOrderByAndCleintIDAndChanneLIDAndDateAndProviceNoIntercept(int spClientId, DateTime startDate, DateTime endDate, string province,string phone, string sortFieldName, bool isdesc, int pageIndex, int limit, out int recordCount)
        {
            SPClientEntity clientEntity = this.DataObjectsContainerIocID.SPClientDataObjectInstance.Load(spClientId);



            return this.SelfDataObj.FindAllByOrderByAndCleintIDAndChanneLIDAndDateAndProviceNoIntercept(clientEntity,
                                                                                   startDate,
                                                                                   endDate, province, phone,
                                                                                   sortFieldName, isdesc,
                                                                                   pageIndex, limit,
                                                                                   out recordCount);
        }

        public List<SPPaymentInfoEntity> FindAllNotSendData(int clientChannelId, DateTime starDate, DateTime endDate, int maxRetryCount)
        {
            return this.SelfDataObj.FindAllNotSendData(clientChannelId, starDate, endDate, maxRetryCount);
        }

        public int[] GetGetAllClientChannelIDNeed(DateTime startDate, DateTime endDate)
        {
            DataSet ds = this.AdoNetDb.GetGetAllClientChannelIDNeed(startDate, endDate);

            List<int> ids = new List<int>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ids.Add((int)(row["ChannleClientID"]));
            }

            return ids.ToArray();
        }


        [Transaction(ReadOnly = false)]
        public void UpdateRecordAndReport(DayliyReport dayReport, SPClientChannelSettingEntity spClientChannelSettingEntity, int newIntercept)
        {
            if (newIntercept < 0)
                return;
            if (newIntercept > dayReport.TotalCount)
                return;

            int newCount = dayReport.InterceptCount - newIntercept;

            if (newCount == 0)
                return;

            string sql = "";

            if(newCount<0)
            {
                sql = string.Format("Update SPPaymentInfo set IsIntercept = 1 where ID In (select Top {0} id from dbo.SPPaymentInfo where ChannleClientID = {1} and CreateDate > '{2}' and CreateDate < '{3}' and IsIntercept = 0)", newCount * -1, spClientChannelSettingEntity.Id, dayReport.ReportDate.Date, dayReport.ReportDate.Date.AddDays(1));
            }
            else
            {
                sql = string.Format("Update SPPaymentInfo set IsIntercept = 0 where ID In (select Top {0} id from dbo.SPPaymentInfo where ChannleClientID = {1} and CreateDate > '{2}' and CreateDate < '{3}' and IsIntercept = 1)", newCount, spClientChannelSettingEntity.Id, dayReport.ReportDate.Date, dayReport.ReportDate.Date.AddDays(1));             
            }

            this.AdoNetDb.ExecuteNoQuery(sql,CommandType.Text);

            if(dayReport.ReportDate.Date<System.DateTime.Now.Date)
            {
                SPDayReportEntity spDayReportEntity =
                    this.DataObjectsContainerIocID.SPDayReportDataObjectInstance.FindReportByChannelIDChannelIDAndDate(spClientChannelSettingEntity.ChannelID.Id, spClientChannelSettingEntity.ClinetID.Id, dayReport.ReportDate.Date);

                if (spDayReportEntity == null)
                    return;

                spDayReportEntity.InterceptTotalCount = newIntercept;
                spDayReportEntity.DownTotalCount = dayReport.TotalCount - newIntercept;
                this.DataObjectsContainerIocID.SPDayReportDataObjectInstance.Update(spDayReportEntity);
            }
        }

        public void UpdateUrlSuccessSend(int id, string url)
        {
            AdoNetDb.UpdateUrlSuccessSend(id, url);
        }


        //    //string tableName = "[SPPaymentInfo]";

        //    //string orderBy = " Order By [CreateDate] DESC ";

        //    //string where = " Where IsIntercept=1 ";

        //    //if(channelId<=0)
        //    //    throw new ArgumentException(" channelId must great than 0.", "channelId");

        //    //where += string.Format(" AND (ChannelID={0}) ", channelId);

        //    //if(clientId>0)
        //    //{
        //    //    where += string.Format(" AND (ClientID={0}) ", clientId);
        //    //}

        //    //if(startDateTime!=DateTime.MinValue)
        //    //{
        //    //    where += string.Format(" AND (CreateDate>='{0}') ", startDateTime.Date.ToShortDateString());
        //    //}

        //    //if (enddateTime != DateTime.MinValue)
        //    //{
        //    //    where += string.Format(" AND (CreateDate<'{0}') ", enddateTime.AddDays(1).Date.ToShortDateString());
        //    //}

        //    //string selectfield = " [CreateDate] ";

        //    //SPChannelEntity channelEntity = this.DataObjectsContainerIocID.SPChannelDataObjectInstance.Load(channelId);

        //    //List<SPChannelParamsEntity> cparam =
        //    //    this.DataObjectsContainerIocID.SPChannelParamsDataObjectInstance.GetList_By_SPChannelEntity(
        //    //        channelEntity);


        //    //foreach (SPChannelParamsEntity spChannelParamsEntity in cparam)
        //    //{
        //    //    selectfield += string.Format(" ,[{0}] ", spChannelParamsEntity.ParamsMappingName);
        //    //}


        //    //recordCount = this.AdoNetDb.ExcuteCount(tableName, where);

        //    //return this.AdoNetDb.ExcutePageResult(selectfield, tableName, where, orderBy, pageIndex, pageSize);

        //}
    }
}
