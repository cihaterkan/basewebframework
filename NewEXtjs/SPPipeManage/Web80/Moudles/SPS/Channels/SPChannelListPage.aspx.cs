﻿using System;
using System.Collections.Generic;
using System.Linq;
using Coolite.Ext.Web;
using LD.SPPipeManage.Bussiness.Wrappers;
using Legendigital.Framework.Common.BaseFramework.Web;

namespace Legendigital.Common.Web.Moudles.SPS.Channels
{
    public partial class SPChannelListPage : BaseSecurityPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Ext.IsAjaxRequest)
                return;

            this.gridPanelSPChannel.Reload();
        }


        [AjaxMethod]
        public void DeleteRecord(int id)
        {
            try
            {
                SPChannelWrapper.DeleteByID(id);

                ScriptManager.AjaxSuccess = true;
            }
            catch (Exception ex)
            {
                ScriptManager.AjaxSuccess = false;
                ScriptManager.AjaxErrorMessage = string.Format(ex.Message);
                return;
            }
        }

        protected void storeSPChannel_Refresh(object sender, StoreRefreshDataEventArgs e)
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

            storeSPChannel.DataSource = SPChannelWrapper.FindAllByOrderBy(sortFieldName, (e.Dir == SortDirection.DESC), pageIndex, limit, out recordCount);
            e.TotalCount = recordCount;

            storeSPChannel.DataBind();

        }
    }

}