
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using LD.SPPipeManage.Bussiness.Commons;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using LD.SPPipeManage.Entity.Tables;
using LD.SPPipeManage.Bussiness.ServiceProxys.Tables;
using Legendigital.Framework.Common.Utility;


namespace LD.SPPipeManage.Bussiness.Wrappers
{
	[Serializable]
    public partial class SPChannelWrapper
    {
        #region Static Common Data Operation
		
		public static void Save(SPChannelWrapper obj)
        {
            businessProxy.Save(obj.entity);
        }

        public static void Update(SPChannelWrapper obj)
        {
            businessProxy.Update(obj.entity);
        }

        public static void SaveOrUpdate(SPChannelWrapper obj)
        {
            businessProxy.SaveOrUpdate(obj.entity);
        }

        public static void DeleteAll()
        {
            businessProxy.DeleteAll();
        }

        public static void DeleteByID(object id)
        {
            businessProxy.DeleteByID(id);
        }

        public static void PatchDeleteByIDs(object[] ids)
        {

            businessProxy.PatchDeleteByIDs(ids);
        }

        public static void Delete(SPChannelWrapper instance)
        {
            businessProxy.Delete(instance.entity);
        }

        public static void Refresh(SPChannelWrapper instance)
        {
            businessProxy.Refresh(instance.entity);
        }

        public static SPChannelWrapper FindById(object id)
        {
            return ConvertEntityToWrapper(businessProxy.FindById(id));
        }

        public static List<SPChannelWrapper> FindAll()
        {
            return ConvertToWrapperList(businessProxy.FindAll());
        }

        public static List<SPChannelWrapper> FindAll(int firstRow, int maxRows, out int recordCount)
        {
            List<SPChannelEntity> list = businessProxy.FindAll(firstRow, maxRows, out recordCount);
            return ConvertToWrapperList(list);
        }
		
		public static List<SPChannelWrapper> FindAllByOrderBy(string orderByColumnName, bool isDesc, int pageIndex, int pageSize, out int recordCount)
        {
            return FindAllByOrderByAndFilter(new List<QueryFilter>(), orderByColumnName, isDesc, pageIndex, pageSize,
                                             out recordCount);
        }


        public static List<SPChannelWrapper> FindAllByOrderByAndFilter(List<QueryFilter> filters, string orderByColumnName, bool isDesc, int pageIndex, int pageSize, out int recordCount)
        {
            List<SPChannelWrapper> results = null;

            results = ConvertToWrapperList(
                    businessProxy.FindAllByOrderByAndFilter(filters, orderByColumnName, isDesc,
                                                   (pageIndex - 1) * pageSize, pageSize, out recordCount));

            return results;
        }
		

        public static List<SPChannelWrapper> FindAllByOrderByAndFilter(List<QueryFilter> filters, string orderByFieldName, bool isDesc)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilter(filters, orderByFieldName, isDesc));
        }
			
		#endregion


        public static string[] fields = new string[] { "cpid", "mid", "mobile", "port", "ywid", "msg", "linkid", "dest", "price", "extendfield1", "extendfield2", "extendfield3", "extendfield4", "extendfield5", "extendfield6", "extendfield7", "extendfield8", "extendfield9" };

        public static SPChannelWrapper GetChannelByPath(string fileName)
        {
            int id = 0;

            int.TryParse(fileName, out id);

            SPChannelWrapper channel = null;

            if (id != 0)
            {
                channel = SPChannelWrapper.FindById(id);
            }

            if (channel != null)
            {
                return channel;
            }

            return ConvertEntityToWrapper(businessProxy.FindByAlias(fileName)); 
        }

        public bool ProcessRequest(Hashtable hashtable, string ip, string query)
        {
            Hashtable fieldMappings = this.GetFieldMappings();

            string cpid = GetParamsValue(hashtable, "cpid", fieldMappings);
            string mid = GetParamsValue(hashtable, "mid", fieldMappings);
            string mobile = GetParamsValue(hashtable, "mobile", fieldMappings);
            string port = GetParamsValue(hashtable, "port", fieldMappings);
            string ywid = GetParamsValue(hashtable, "ywid", fieldMappings);
            string msg = GetParamsValue(hashtable, "msg", fieldMappings);
            string linkid = GetParamsValue(hashtable, "linkid", fieldMappings);
            string dest = GetParamsValue(hashtable, "dest", fieldMappings);
            string price = GetParamsValue(hashtable, "price", fieldMappings);
            string extendfield1 = GetParamsValue(hashtable, "extendfield1", fieldMappings);
            string extendfield2 = GetParamsValue(hashtable, "extendfield2", fieldMappings);
            string extendfield3 = GetParamsValue(hashtable, "extendfield3", fieldMappings);
            string extendfield4 = GetParamsValue(hashtable, "extendfield4", fieldMappings);
            string extendfield5 = GetParamsValue(hashtable, "extendfield5", fieldMappings);
            string extendfield6 = GetParamsValue(hashtable, "extendfield6", fieldMappings);
            string extendfield7 = GetParamsValue(hashtable, "extendfield7", fieldMappings);
            string extendfield8 = GetParamsValue(hashtable, "extendfield8", fieldMappings);
            string extendfield9 = GetParamsValue(hashtable, "extendfield9", fieldMappings);


            string content = query;


            Hashtable exparams = GetEXParamsValue(hashtable);

            SPClientChannelSettingWrapper channelSetting = GetClientChannelSettingFromYWID(ywid);



            if (channelSetting != null)
            {

                SPPaymentInfoWrapper paymentInfo = new SPPaymentInfoWrapper();

                paymentInfo.ChannelID = this;
                paymentInfo.ClientID = channelSetting.ClinetID;
                paymentInfo.Cpid = cpid;
                paymentInfo.Mid = mid;
                paymentInfo.MobileNumber = mobile;
                paymentInfo.Port = port;
                paymentInfo.Ywid = ywid;
                paymentInfo.Message = msg;
                paymentInfo.Linkid = linkid;
                paymentInfo.Dest = dest;
                paymentInfo.Price = price;
                paymentInfo.ExtendField1 = extendfield1;
                paymentInfo.ExtendField2 = extendfield2;
                paymentInfo.ExtendField3 = extendfield3;
                paymentInfo.ExtendField4 = extendfield4;
                paymentInfo.ExtendField5 = extendfield5;
                paymentInfo.ExtendField6 = extendfield6;
                paymentInfo.ExtendField7 = extendfield7;
                paymentInfo.ExtendField8 = extendfield8;
                paymentInfo.ExtendField9 = extendfield9;
                paymentInfo.Ip = ip;
                paymentInfo.IsIntercept = channelSetting.CaculteIsIntercept();
                paymentInfo.CreateDate = System.DateTime.Now;
                paymentInfo.RequestContent = content;

                if (!paymentInfo.IsIntercept.Value)
                {
                    if (!string.IsNullOrEmpty(channelSetting.ClinetID.RecieveDataUrl))
                        paymentInfo.SucesssToSend = channelSetting.ClinetID.SendMsg(paymentInfo);
                        //paymentInfo.SucesssToSend = channelSetting.ClinetID.SendMsg(cpid, mid, mobile, port, ywid, msg, linkid, dest, price, exparams);
                    else
                        paymentInfo.SucesssToSend = false;
                }
                else
                {
                    paymentInfo.SucesssToSend = false;
                }

                SPPaymentInfoWrapper.Save(paymentInfo);

                return true;
            }
            else
            {
                logger.Error("Process Request Error:Can't find channle  "+this.Name+" client setting.");

                return false;
            }

            
        }

	    public Hashtable GetFieldMappings()
	    {
            Hashtable mappingFields = new Hashtable();

            List<SPChannelParamsWrapper> spChannelParamsWrappers = SPChannelParamsWrapper.ConvertToWrapperList(businessProxy.GetAllEnableParams(this.entity));

	        foreach (string field in fields)
	        {
                string findFeild = field.ToLower();

	            SPChannelParamsWrapper channelParamsWrapper =
                    spChannelParamsWrappers.Find(p => (p.ParamsMappingName.Equals(findFeild.ToLower())));

                if(channelParamsWrapper==null)
                {
                    mappingFields.Add(findFeild.ToLower(), findFeild.ToLower());
                }
                else
                {
                    mappingFields.Add(findFeild.ToLower(), channelParamsWrapper.Name.ToLower());                  
                }
	        }

	        return mappingFields;
	    }

	    private Hashtable GetEXParamsValue(Hashtable hashtable)
	    {
	        return new Hashtable();
	    }

        private SPClientChannelSettingWrapper GetClientChannelSettingFromYWID(string ywid)
	    {
	        List<SPClientChannelSettingWrapper> clientChannelSettings = SPClientChannelSettingWrapper.GetSettingByChannel(this);

	        foreach (SPClientChannelSettingWrapper channelSetting in clientChannelSettings)
	        {
	            if(channelSetting.MatchByYWID(ywid))
	            {
	                return channelSetting;
	            }
	        }

	        return null;
	    }

	    private string GetParamsValue(Hashtable hashtable, string key, Hashtable fieldMappings)
        {
            string queryKey = key.ToLower();

            if (fieldMappings.ContainsKey(key))
            {
                queryKey = (string)fieldMappings[key];
            }

            if (!hashtable.ContainsKey(queryKey))
                return "";

            return hashtable[queryKey].ToString();
        }

        public ChannelStatus CStatus
        {
            get
            {
                switch (this.Status)
                {
                    case 0:
                        return ChannelStatus.Run;
                        break;
                    case 1:
                        return ChannelStatus.Stop;
                        break;
                    case 2:
                        return ChannelStatus.Disable;
                        break;
                    default:
                        return ChannelStatus.Disable;
                        break;
                }
            }
        }

        public string CStatusString
        {
            get
            {
                switch (this.CStatus)
                {
                    case ChannelStatus.Run:
                        return "����";
                        break;
                    case ChannelStatus.Stop:
                        return "��ͣ";
                        break;
                    case ChannelStatus.Disable:
                        return "����";
                        break;
                    default:
                        return "����";
                        break;
                }
            }
        }

	    public string GetOkCode()
	    {
	        return "ok";
	    }

        public DataTable BuildChannelRecordTable()
        {
            DataTable record = new DataTable();

            record.Columns.Add("RecordID", typeof(int));
            record.Columns.Add("CreateDate",typeof(DateTime));

            foreach (string field in fields)
            {
                record.Columns.Add(field);
            }

            record.AcceptChanges();

            return record;
        }
    }
}
