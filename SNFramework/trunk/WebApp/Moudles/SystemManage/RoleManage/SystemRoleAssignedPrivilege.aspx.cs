﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers;

namespace Legendigital.Common.WebApp.Moudles.SystemManage.RoleManage
{
    public partial class SystemRoleAssignedPrivilege : System.Web.UI.Page
    {
        public int RoleID
        {
            get
            {
                if (this.Request.QueryString["RoleID"] == null)
                {
                    return 0;
                }
                return Convert.ToInt32(this.Request.QueryString["RoleID"]);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (X.IsAjaxRequest)
                return;

            GridPanel1.Reload();
            GridPanel2.Reload();
        }

        protected void Store1_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
        {
            SystemRoleWrapper systemRoleWrapper = SystemRoleWrapper.FindById(RoleID);
            List<SystemPrivilegeWrapper> list1 = SystemPrivilegeWrapper.FindAll();
            List<string> list2 = SystemRoleWrapper.GetRoleAssignedPermissions(systemRoleWrapper);
            List<SystemPrivilegeWrapper> list3 = list1.FindAll(p => !list2.Contains(p.PrivilegeID.ToString()));
            Store1.DataSource = list3;
            Store1.DataBind();
        }

        protected void Store2_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
        {
            SystemRoleWrapper systemRoleWrapper = SystemRoleWrapper.FindById(RoleID);
            List<string> list2 = SystemRoleWrapper.GetRoleAssignedPermissions(systemRoleWrapper);
            List<SystemPrivilegeWrapper> list3 = new List<SystemPrivilegeWrapper>();
            foreach (string s in list2)
            {
                list3.Add(SystemPrivilegeWrapper.FindById(Int32.Parse(s)));
            }
            Store2.DataSource = list3;
            Store2.DataBind();
        }

  

        [DirectMethod]
        public void Save_RolePermission(string json)
        {
            try
            {
                KeyValuePair<string, string>[] selectIDs = JSON.Deserialize<KeyValuePair<string, string>[]>(json);
                List<String> list = new List<string>();
                foreach (KeyValuePair<string, string> row in selectIDs)
                {
                    list.Add(row.Key);
                }
                SystemRoleWrapper.PatchAssignRolePermissions(SystemRoleWrapper.FindById(RoleID), list);
            }
            catch (Exception ex)
            {
                ResourceManager.AjaxSuccess = false;
                ResourceManager.AjaxErrorMessage = "Error Message:" + ex.Message;
            }
        }

 

    
    }
}
