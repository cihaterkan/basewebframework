﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Powerasp.Enterprise.Core.BaseManager.Domain;
using Powerasp.Enterprise.Core.BaseManager.Service;
using Powerasp.Enterprise.Core.Web.BasePage;
using Powerasp.Enterprise.Core.Attribute;

namespace Powerasp.Enterprise.Core.BaseManager.BaseDataUIPage.EditFunction
{
	[WebDataModule("系统用户部门")]
    public class SystemDepartmentEditUIPage : BaseDataEditPage<SystemDepartment>
    {
        protected SystemDepartmentService systemDepartmentServiceInstance;

        public SystemDepartmentService SystemDepartmentServiceInstance
        {
            set { systemDepartmentServiceInstance = value; }
        }
		 protected override SystemDepartment LoadDataByID(int id)
        {
            return systemDepartmentServiceInstance.FindById(id);
        }

        protected override void DeleteDataByID(int id)
        {
            systemDepartmentServiceInstance.DeleteByID(id);
        }

        protected override void UpdateData(SystemDepartment obj)
        {
            systemDepartmentServiceInstance.Update(obj);
        }
    }
}



