﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Coolite.Ext.Web;
using LD.SPPipeManage.Bussiness.Wrappers;

namespace Legendigital.Common.Web.Moudles.SPS.Reports
{
    public partial class DetailRecordView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Ext.IsAjaxRequest)
                return;

            //SetTitle();

            storeData.Reader.Add(GetJsonReaderByDataTable(SPChannelWrapper.FindById(this.ChannleID)));

            this.GridPanel1.StoreID = "storeData";

            this.PagingToolBar1.StoreID = "storeData";
        }



        private DataReader GetJsonReaderByDataTable(SPChannelWrapper channelWrapper)
        {
            JsonReader reader = new JsonReader();

            reader.ReaderID = "RecordID";

            reader.Fields.Add("RecordID", RecordFieldType.Int);
            reader.Fields[reader.Fields.Count - 1].Mapping = "RecordID";

            reader.Fields.Add("CreateDate", RecordFieldType.Date);
            reader.Fields[reader.Fields.Count - 1].Mapping = "CreateDate";
            this.GridPanel1.ColumnModel.Columns.Add(NewColumn("colCreateDate", "日期", false, "CreateDate", "Ext.util.Format.dateRenderer('n/d/Y H:i:s A')", RendererFormat.None));

            reader.Fields.Add("Province", RecordFieldType.String);
            reader.Fields[reader.Fields.Count - 1].Mapping = "Province";
            this.GridPanel1.ColumnModel.Columns.Add(NewColumn("colProvince", "省份", false, "Province", "", RendererFormat.None));

            List<SPChannelParamsWrapper> channelParams = channelWrapper.GetAllShowParams();

            foreach (SPChannelParamsWrapper channelParam in channelParams)
            {
                string pName = channelParam.Name.ToString();
                reader.Fields.Add(channelParam.ParamsMappingName, RecordFieldType.String);
                reader.Fields[reader.Fields.Count - 1].Mapping = channelParam.ParamsMappingName.ToString();
                this.GridPanel1.ColumnModel.Columns.Add(NewColumn("col" + pName, pName, false, channelParam.ParamsMappingName.ToString(), "", RendererFormat.None));
            }

            return reader;




        }

        private Column NewColumn(string id, string header, bool cansort, string dataIndex, string render, RendererFormat rendererFormat)
        {
            Column col1 = new Column();
            col1.ColumnID = id;
            col1.Header = header;
            col1.Sortable = cansort;
            col1.DataIndex = dataIndex;
            if (!string.IsNullOrEmpty(render))
            {
                if (col1.Renderer == null)
                    col1.Renderer = new Renderer();
                col1.Renderer.Fn = render;
            }

            if (rendererFormat != RendererFormat.None)
            {
                if (col1.Renderer == null)
                    col1.Renderer = new Renderer();
                col1.Renderer.Format = rendererFormat;
            }

            return col1;
        }

        public int ChannleID
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Request.QueryString["ChannleID"]))
                {
                    return Convert.ToInt32(this.Request.QueryString["ChannleID"]);
                }
                return 0;
            }
        }

        public int ClientID
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Request.QueryString["ClientID"]))
                {
                    return Convert.ToInt32(this.Request.QueryString["ClientID"]);
                }
                return 0;
            }
        }


        public DateTime StartDate
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Request.QueryString["StartDate"]))
                {
                    return Convert.ToDateTime(this.Request.QueryString["StartDate"].Replace("\"", ""));
                }
                return DateTime.MinValue;
            }
        }


        public DateTime EndDate
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Request.QueryString["EndDate"]))
                {
                    return Convert.ToDateTime(this.Request.QueryString["EndDate"].Replace("\"", ""));
                }
                return DateTime.MinValue;
            }
        }


        public DataType DType
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Request.QueryString["DataType"]))
                {
                    string dataType = this.Request.QueryString["DataType"];

                    switch (dataType.ToLower())
                    {
                        case "totalcountdetail":
                            return DataType.All;
                        case "interceptcountdetail":
                            return DataType.Intercept;
                        case "downcountdetail":
                            return DataType.Down;
                        case "downsycncountdetail":
                            return DataType.DownSycn;
                    }

                }
                return DataType.DownSycn;
            }
        }

        protected void storeData_Refresh(object sender, StoreRefreshDataEventArgs e)
        {
            int recordCount = 0;
            string sortFieldName = "";
            if (e.Sort != null)
                sortFieldName = e.Sort;

            int startIndex = 0;

            if (e.Start > -1)
            {
                startIndex = e.Start;
            }

            int limit = this.PagingToolBar1.PageSize;

            int pageIndex = 1;

            if ((startIndex % limit) == 0)
                pageIndex = startIndex / limit + 1;
            else
                pageIndex = startIndex / limit;

            DataTable dt = SPPaymentInfoWrapper.FindAllDataTableByOrderByAndCleintIDAndChanneLIDAndDate(ChannleID, this.ClientID, Convert.ToDateTime(this.StartDate), Convert.ToDateTime(this.EndDate), DType, "CreateDate", true, pageIndex, limit, out recordCount);

            if (storeData.Reader.Count == 0)
                storeData.Reader.Add(GetJsonReaderByDataTable(SPChannelWrapper.FindById(this.ChannleID)));

            storeData.DataSource = dt;
            e.TotalCount = recordCount;

            storeData.DataBind();


        }
    }
}
