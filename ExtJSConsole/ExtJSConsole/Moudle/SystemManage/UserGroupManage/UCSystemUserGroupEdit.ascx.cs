﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Coolite.Ext.Web;
using Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers;

namespace ExtJSConsole.Moudle.SystemManage.UserGroupManage
{
    [AjaxMethodProxyID(IDMode = AjaxMethodProxyIDMode.Alias, Alias = "UCSystemUserGroupEdit")]
    public partial class UCSystemUserGroupEdit : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        [AjaxMethod]
        public void Show(int id)
        {
            try
            {
                SystemUserGroupWrapper obj = SystemUserGroupWrapper.FindById(id);

                if (obj != null)
                {
                    this.txtGroupNameCn.Text = obj.GroupNameCn.ToString();
                    this.txtGroupNameEn.Text = obj.GroupNameEn.ToString();
                    this.txtGroupDescription.Text = obj.GroupDescription.ToString();



                    hidSystemUserGroupID.Text = id.ToString();


                    winSystemUserGroupEdit.Show();

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

        protected void btnSaveSystemUserGroup_Click(object sender, AjaxEventArgs e)
        {
            try
            {
                SystemUserGroupWrapper obj = SystemUserGroupWrapper.FindById(int.Parse(hidSystemUserGroupID.Text.Trim()));
                obj.GroupNameCn = this.txtGroupNameCn.Text.Trim();
                obj.GroupNameEn = this.txtGroupNameEn.Text.Trim();
                obj.GroupDescription = this.txtGroupDescription.Text.Trim();

                SystemUserGroupWrapper.Update(obj);

                winSystemUserGroupEdit.Hide();
                Coolite.Ext.Web.ScriptManager.AjaxSuccess = true;
            }
            catch (Exception ex)
            {
                Coolite.Ext.Web.ScriptManager.AjaxSuccess = false;
                Coolite.Ext.Web.ScriptManager.AjaxErrorMessage = "错误信息：" + ex.Message;
                return;
            }

        }
    }

}