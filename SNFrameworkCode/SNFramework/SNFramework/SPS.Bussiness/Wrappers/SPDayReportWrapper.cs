
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using SPS.Bussiness.Code;
using SPS.Data.AdoNet;
using SPS.Entity.Tables;
using SPS.Bussiness.ServiceProxys.Tables;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;


namespace SPS.Bussiness.Wrappers
{
	[Serializable]
    public partial class SPDayReportWrapper : BaseSpringNHibernateWrapper<SPDayReportEntity, ISPDayReportServiceProxy, SPDayReportWrapper, int>  
    {
        #region Static Common Data Operation

        public static void Save(SPDayReportWrapper obj)
        {
            Save(obj, businessProxy);
        }

        public static void Update(SPDayReportWrapper obj)
        {
            Update(obj, businessProxy);
        }

        public static void SaveOrUpdate(SPDayReportWrapper obj)
        {
            SaveOrUpdate(obj, businessProxy);
        }

        public static void DeleteAll()
        {
            DeleteAll(businessProxy);
        }

        public static void DeleteByID(int id)
        {
            DeleteByID(id, businessProxy);
        }

        public static void PatchDeleteByIDs(int[] ids)
        {

            PatchDeleteByIDs(ids, businessProxy);
        }

        public static void Delete(SPDayReportWrapper instance)
        {
            Delete(instance, businessProxy);
        }

        public static void Refresh(SPDayReportWrapper instance)
        {
            Refresh(instance, businessProxy);
        }

        public static SPDayReportWrapper FindById(int id)
        {
            return ConvertEntityToWrapper(FindById(id, businessProxy));
        }

        public static List<SPDayReportWrapper> FindAll()
        {
            return ConvertToWrapperList(businessProxy.FindAll());
        }

        public static List<SPDayReportWrapper> FindAllByPage(PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(FindAll(businessProxy));
        }

        public static List<SPDayReportWrapper> FindAllByOrderBy(string orderByColumnName, bool isDesc, PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(FindAllByPage(pageQueryParams, businessProxy));
        }


        public static List<SPDayReportWrapper> FindAllByOrderByAndFilter(List<QueryFilter> filters, string orderByColumnName, bool isDesc, PageQueryParams pageQueryParams)
        {
            orderByColumnName = ProcessColumnName(orderByColumnName);

            return FindAllByOrderByAndFilter(new List<QueryFilter>(), orderByColumnName, isDesc, pageQueryParams);
        }


        public static List<SPDayReportWrapper> FindAllByOrderByAndFilter(List<QueryFilter> filters, string orderByFieldName, bool isDesc)
        {
            List<SPDayReportWrapper> results = null;

            ProcessQueryFilters(filters);

            results = ConvertToWrapperList(
                    FindAllByOrderByAndFilter(filters, orderByFieldName, isDesc, businessProxy));

            return results;
        }

        #endregion


        public static List<SPDayReportWrapper> CaculateReport(DateTime reportDate)
        {
            return ConvertNoDbDataToWrapperList(businessProxy.CaculateReport(reportDate.Date));
        }

        public static List<SPDayReportWrapper> CaculateReport(DateTime reportDate,SPSClientWrapper clientWrapper)
        {
            return ConvertNoDbDataToWrapperList(businessProxy.CaculateReport(reportDate.Date, clientWrapper.Entity));
        }

	    public string CodeID_MoCode
	    {
	        get
	        {
                if (CodeID == null)
                    return "";
	            return CodeID.MoCode;
	        }
	    }

	    internal static List<SPDayReportWrapper> ConvertNoDbDataToWrapperList(List<SPDayReportEntity> entitys)
        {
            List<SPDayReportWrapper> list = new List<SPDayReportWrapper>();
            foreach (SPDayReportEntity reportEntity in entitys)
            {
                list.Add(new SPDayReportWrapper(reportEntity));
            }
            int i = 1;
            foreach (SPDayReportWrapper report  in list)
            {
                report.Id = i;
                i++;
            }
            return list;
        }

        public static void ReGenerateDayReport(DateTime date)
        {
            businessProxy.ReBulidReport(date);
        }

        public static List<SPDayReportWrapper> ConvertToDayReport(List<SPDayReportWrapper> convertToWrapperList)
        {
            //var dayReports = from p in convertToWrapperList
            //                 group p by new { p.ChannelID_Id, p.CodeID_Id, p.ClientID_Id, p.ReportDate } into g
            //                 select new
            //                 {
            //                     ChannelID = g.Key.ChannelID_Id.Value,
            //                     CodeID = g.Key.CodeID_Id.Value,
            //                     ClientID = g.Key.ClientID_Id.Value,
            //                     ReportDate = g.Key.ReportDate,
            //                     TotalCount = g.Sum(p => p.TotalCount),
            //                     TotalSuccessCount = g.Sum(p => p.TotalSuccessCount),
            //                     InterceptCount = g.Sum(p => p.InterceptCount),
            //                     DownTotalCount = g.Sum(p => p.DownTotalCount),
            //                     DownSycnSuccess = g.Sum(p => p.DownSycnSuccess),
            //                     DownSycnFailed = g.Sum(p => p.DownSycnFailed),
            //                     DownNotSycn = g.Sum(p => p.DownNotSycn)
            //                 };

            List<SPDayReportWrapper> spDays = new List<SPDayReportWrapper>();

            foreach (SPDayReportWrapper dayReport in convertToWrapperList)
            {
                SPDayReportWrapper finDayReportWrapper =
                    spDays.Find(
                        p =>
                        (
                         (p.ChannelID.Id == dayReport.ChannelID.Id) && 
                         (p.ClientID.Id == dayReport.ClientID.Id) &&
                         (p.CodeID.Id == dayReport.CodeID.Id) &&
                         (p.ReportDate == dayReport.ReportDate)
                        ));

                if (finDayReportWrapper!=null)
                {
                    finDayReportWrapper.TotalCount += dayReport.TotalCount;
                    finDayReportWrapper.TotalSuccessCount += dayReport.TotalSuccessCount;
                    finDayReportWrapper.InterceptCount += dayReport.InterceptCount;
                    finDayReportWrapper.DownTotalCount += dayReport.DownTotalCount;
                    finDayReportWrapper.DownSycnSuccess += dayReport.DownSycnSuccess;
                    finDayReportWrapper.DownSycnFailed += dayReport.DownSycnFailed;
                    finDayReportWrapper.DownNotSycn += dayReport.DownNotSycn;
                }
                else
                {
                    spDays.Add(dayReport);         
                }
 

            }

            return spDays;

        }

        public static List<SPDayReportWrapper> QueryReport(DateTime startDate, DateTime endDate)
        {
            return ConvertToDayReport(ConvertToWrapperList(businessProxy.QueryReport(startDate, endDate)));
        }

        public static List<SPDayReportWrapper> QueryReport(DateTime startDate, DateTime endDate, SPSClientWrapper client)
        {
            return ConvertToDayReport(ConvertToWrapperList(businessProxy.QueryReport(startDate, endDate, client.Entity)));
        }

	    public static void ReGenerateDayReport(DateTime startDate, DateTime endDate)
	    {
            for (DateTime i = startDate; i < endDate.AddDays(1); i = i.AddDays(1))
            {
                try
                {
                    ReGenerateDayReport(i);
                }
                catch (Exception ex)
                {
                    Logger.Error("���ɱ�������" + ex.Message);
                }
            }
	    }

        public static DataSet QueryRecordProvine(DateTime? startDate, DateTime? endDate, string dayReportType, int? channelId, int? codeID, int? clientID)
        {
            DayReportType reportType = (DayReportType)Enum.Parse(typeof(DayReportType), dayReportType);
            return businessProxy.QueryRecordProvine(startDate, endDate, reportType, channelId, codeID, clientID);
        }

        public static DataSet QueryChannelInvoiceReport(DateTime? startDate, DateTime? endDate,int? channelId, int? codeID)
        {
            DataSet ds = businessProxy.QueryChannelInvoiceReport(startDate, endDate, channelId, codeID);

            ds.Tables[0].Columns.Add(new DataColumn("ChannelName"));
            ds.Tables[0].Columns.Add(new DataColumn("MoName"));
            ds.Tables[0].Columns.Add(new DataColumn("Price",typeof(decimal)));
            
            ds.AcceptChanges();

            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                dataRow["ChannelName"] = SPChannelWrapper.FindById((int) dataRow["ChannelID"]).Name;
                dataRow["MoName"] = SPCodeWrapper.FindById((int)dataRow["CodeID"]).MoCode;
                dataRow["Price"] = SPCodeWrapper.FindById((int)dataRow["CodeID"]).Price;
            }

            ds.AcceptChanges();

            return ds;
        }

        public static DataSet QueryClientInvoiceReport(DateTime? startDate, DateTime? endDate, int? clientID, int? codeID)
        {
            DataSet ds = businessProxy.QueryClientInvoiceReport(startDate, endDate, clientID, codeID);

            ds.Tables[0].Columns.Add(new DataColumn("ClientName"));
            ds.Tables[0].Columns.Add(new DataColumn("MoName"));
            ds.Tables[0].Columns.Add(new DataColumn("Price", typeof(decimal)));

            ds.AcceptChanges();

            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                dataRow["ClientName"] = SPSClientWrapper.FindById((int)dataRow["ClientId"]).Name;
                dataRow["MoName"] = SPCodeWrapper.FindById((int)dataRow["CodeID"]).MoCode;
                dataRow["Price"] = SPCodeWrapper.FindById((int)dataRow["CodeID"]).Price;
            }

            ds.AcceptChanges();

            return ds;
        }

        public static DataSet QueryChannelOperatorReport(DateTime? startDate, DateTime? endDate, int? channelId, int? codeID)
        {
            return businessProxy.QueryChannelOperatorReport(startDate, endDate, channelId, codeID);
        }

        public static DataSet QueryClientOperatorReport(DateTime? startDate, DateTime? endDate, int? clientID, int? codeID)
        {
            return businessProxy.QueryClientOperatorReport(startDate, endDate, clientID, codeID);
        }

        public static DataSet QueryChannelProvinceReport(DateTime? startDate, DateTime? endDate, int? channelId, int? codeID)
        {
            return businessProxy.QueryChannelProvinceReport(startDate, endDate, channelId, codeID);
        }

        public static DataSet QueryClientProvinceReport(DateTime? startDate, DateTime? endDate, int? clientID, int? codeID)
        {
            return businessProxy.QueryClientProvinceReport(startDate, endDate, clientID, codeID);
        }
    }
}
