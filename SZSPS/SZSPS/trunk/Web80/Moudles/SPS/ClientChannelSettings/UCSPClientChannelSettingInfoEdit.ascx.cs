﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
using System.Web.UI.WebControls;
using Coolite.Ext.Web;
using LD.SPPipeManage.Bussiness.Wrappers;
using Legendigital.Framework.Common.Utility;
using Newtonsoft.Json;

namespace Legendigital.Common.Web.Moudles.SPS.ClientChannelSettings
{
    [AjaxMethodProxyID(IDMode = AjaxMethodProxyIDMode.Alias, Alias = "UCSPClientChannelSettingInfoEdit")]
    public partial class UCSPClientChannelSettingInfoEdit : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        [AjaxMethod]
        public void Show(int id)
        {
            try
            {
                SPClientChannelSettingWrapper obj = SPClientChannelSettingWrapper.FindById(id);

                if (obj != null)
                {

                    this.lblChannelName.Text = obj.ChannelName;

                    this.lblClientName.Text = obj.ClientName;

                    this.lblClientName.Text = obj.ClientGroupName;

                    this.lblName.Text = obj.Name;

                    this.lblChannelClientCode.Text = obj.ChannelClientCode;

                    chkHasDayMonthLimit.Checked = obj.HasDayMonthLimit.HasValue && obj.HasDayMonthLimit.Value;
                    chkHasDayTotalLimit.Checked = obj.HasDayTotalLimit.HasValue && obj.HasDayTotalLimit.Value;

                    if(chkHasDayMonthLimit.Checked)
                    {
                        if (obj.DayLimitCount.HasValue)
                            this.txtDayLimit.Text = obj.DayLimitCount.Value.ToString();
                        else
                            this.txtDayLimit.Text = "0";
                        if (obj.MonthLimitCount.HasValue)
                            this.txtMonthLimit.Text = obj.MonthLimitCount.Value.ToString();
                        else
                            this.txtMonthLimit.Text = "0";
                    }
                    else
                    {
                        this.txtDayLimit.Text = "0";
                        this.txtMonthLimit.Text = "0";
                    }

                    this.txtDayLimit.Hidden = !chkHasDayMonthLimit.Checked;
                    this.txtMonthLimit.Hidden = !chkHasDayMonthLimit.Checked;
                    this.chkDayTotalLimitInProvince.Hidden = !chkHasDayTotalLimit.Checked;
 
                    if(this.chkHasDayTotalLimit.Checked)
                    {
                        if (obj.DayTotalLimit.HasValue)
                            this.txtDayTotalLimit.Text = obj.DayTotalLimit.Value.ToString();
                        else
                            this.txtDayTotalLimit.Text = "0";


                        if (obj.DayTotalLimitInProvince.HasValue && obj.DayTotalLimitInProvince.Value)
                            this.chkDayTotalLimitInProvince.Checked = true;
                        else
                            this.chkDayTotalLimitInProvince.Checked = false;
                    }
                    else
                    {
                        this.txtDayTotalLimit.Text = "0";
                    }


                    this.txtDayTotalLimit.Hidden = !chkHasDayTotalLimit.Checked;
 
 

                    hidId.Text = id.ToString();

                    this.storeAreaCountList.DataSource = obj.LimitAreaAssigneds;
                    this.storeAreaCountList.DataBind();

                    this.grdAreaCountList.Hidden = !this.chkDayTotalLimitInProvince.Checked;

                    winSPClientChannelSettingInfoEdit.Show();

                }
                else
                {
                    ScriptManager.AjaxSuccess = false;
                    ScriptManager.AjaxErrorMessage = "错误信息：数据不存在";
                    return;
                }
            }
            catch (Exception ex)
            {
                Coolite.Ext.Web.ScriptManager.AjaxSuccess = false;
                Coolite.Ext.Web.ScriptManager.AjaxErrorMessage = "错误信息：" + ex.Message;
                return;
            }
        }

        protected void btnSaveSPClientChannelSetting_Click(object sender, AjaxEventArgs e)
        {
            try
            {
                SPClientChannelSettingWrapper obj = SPClientChannelSettingWrapper.FindById(int.Parse(hidId.Text.Trim()));

                obj.HasDayMonthLimit = this.chkHasDayMonthLimit.Checked;
                obj.DayLimitCount = Convert.ToInt32(this.txtDayLimit.Value);
                obj.MonthLimitCount = Convert.ToInt32(this.txtMonthLimit.Value);

                obj.HasDayTotalLimit = this.chkHasDayTotalLimit.Checked;
                obj.DayTotalLimit = Convert.ToInt32(this.txtDayTotalLimit.Value);

                obj.DayTotalLimitInProvince = chkDayTotalLimitInProvince.Checked;

                List<PhoneLimitAreaAssigned> phoneLimitAreaAssigneds = JsonConvert.DeserializeObject< List < PhoneLimitAreaAssigned >> (hidAreaCountList.Text);

                List<PhoneLimitAreaAssigned> phoneLimits = phoneLimitAreaAssigneds.FindAll(p => (p.LimitCount > 0 && !string.IsNullOrEmpty(p.AreaName)));

                obj.DayTotalLimitInProvinceAssignedCount = SerializeUtil.ToJson2(phoneLimits);

                SPClientChannelSettingWrapper.Update(obj);

                obj.ChannelID.RefreshChannelInfo();

                winSPClientChannelSettingInfoEdit.Hide();
            }
            catch (Exception ex)
            {
                Coolite.Ext.Web.ScriptManager.AjaxSuccess = false;
                Coolite.Ext.Web.ScriptManager.AjaxErrorMessage = "错误信息：" + ex.Message;
                return;
            }

        }


        protected void storeAreaCountList_Refresh(object sender, StoreRefreshDataEventArgs e)
        {
            SPClientChannelSettingWrapper obj = SPClientChannelSettingWrapper.FindById(int.Parse(hidId.Text.Trim()));

            this.storeAreaCountList.DataSource = obj.LimitAreaAssigneds;
            this.storeAreaCountList.DataBind();
        }
    }
}