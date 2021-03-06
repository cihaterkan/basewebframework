// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using Legendigital.Framework.Common.BaseFramework.Data.Tables;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Spring.Transaction;
using Spring.Transaction.Interceptor;


namespace Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables
{
    [ServiceContract(Namespace = "http://Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables")]
    public interface ISystemSettingServiceProxy : IBaseSpringNHibernateEntityServiceProxy<SystemSettingEntity>, ISystemSettingServiceProxyDesigner
    {
        [OperationContract]
        SystemSettingEntity GetCurrentSystemSetting();

        void InstallSystem(SortedList<string, string> installParams);
    }

    public partial class SystemSettingServiceProxy : ISystemSettingServiceProxy
    {
        /// <summary>
        /// 获取系统基本设置信息
        /// </summary>
        /// <returns></returns>
        [Transaction(TransactionPropagation.Required)]
        public virtual SystemSettingEntity GetCurrentSystemSetting()
        {
            List<SystemSettingEntity> listSystemSetting = this.SelfDataObj.FindAll();
            if (listSystemSetting.Count <= 0)
            {
                SystemSettingEntity systemSetting = new SystemSettingEntity();
                systemSetting.SystemName = "基础管理平台";
                systemSetting.SystemUrl = "#";
                systemSetting.SystemDescription = "";
                systemSetting.SystemVersion = "1.0.0";
                systemSetting.SystemLisence =
                    "Powered By <a href='#' target='_blank'><font color='#ffffff'>Supesoft.com</font></a> Information Technology Logistics Inc.";
                this.SelfDataObj.Save(systemSetting);
                return systemSetting;
            }
            else if (listSystemSetting.Count == 1)
            {
                return listSystemSetting[0];
            }
            else if (listSystemSetting.Count > 1)
            {
                for (int i = 0; i < listSystemSetting.Count - 1; i++)
                {
                    this.Delete(listSystemSetting[i + 1]);
                }
                return listSystemSetting[0];
            }
            else
            {
                SystemSettingEntity systemSetting = new SystemSettingEntity();
                systemSetting.SystemName = "基础管理平台";
                systemSetting.SystemUrl = "#";
                systemSetting.SystemDescription = "";
                systemSetting.SystemVersion = "1.0.0";
                systemSetting.SystemLisence =
                    "Powered By <a href='#' target='_blank'><font color='#ffffff'>Supesoft.com</font></a> Information Technology Logistics Inc.";
                this.SelfDataObj.Save(systemSetting);
                return systemSetting;
            }
        }
        [Transaction(TransactionPropagation.Required)]
        public void InstallSystem(SortedList<string, string> installParams)
        {
            SystemSettingEntity systemSetting = GetCurrentSystemSetting();

            systemSetting.SystemName = installParams["sysName"].ToString();
            systemSetting.SystemDescription = installParams["sysDescription"].ToString();
            systemSetting.SystemVersion = installParams["sysVersion"].ToString();
            systemSetting.SystemLisence = installParams["sysCopyRight"].ToString();

            this.DataObjectsContainerIocID.SystemSettingDataObjectInstance.Update(systemSetting);

            List<SystemApplicationEntity> applicationEntitys =
                this.DataObjectsContainerIocID.SystemApplicationDataObjectInstance.FindedApplicationsByName(
                    "Base System Module");

            SystemApplicationEntity app = null;

            if(applicationEntitys!=null && applicationEntitys.Count>0)
            {
                app = applicationEntitys[0];
            }
            else
            {
                app = new SystemApplicationEntity();
                app.SystemApplicationName = "Base System Module";
                app.SystemApplicationIsSystemApplication = true;
                app.SystemApplicationDescription = "Base System Module";
                app.SystemApplicationUrl = "#";
                this.DataObjectsContainerIocID.SystemApplicationDataObjectInstance.Save(app);
            }

            //Delete all system menu

            SystemMenuEntity mainMenu = AddSystemMainMenu(app, "系统高级设置",1);

 
            AddSubMenu(app, "系统菜单管理", "~/Moudles/SystemManage/MenuManage/SystemMenuListPage.aspx", "", mainMenu, 1);
            AddSubMenu(app, "系统应用管理", "~/Moudles/SystemManage/ApplicationManage/SystemApplicationListPage.aspx", "", mainMenu, 2);
            AddSubMenu(app, "系统角色管理", "~/Moudles/SystemManage/RoleManage/SystemRoleListPage.aspx", "", mainMenu, 3);
            AddSubMenu(app, "系统用户管理", "~/Moudles/SystemManage/UserManage/SystemUserListPage.aspx", "", mainMenu, 4);
            AddSubMenu(app, "系统用户组管理", "~/Moudles/SystemManage/UserGroupManage/SystemUserGroupListPage.aspx", "", mainMenu, 5);
            AddSubMenu(app, "系统配置管理", "~/Moudles/SystemManage/ConfigManage/SystemConfigListPage.aspx", "", mainMenu, 6);
            AddSubMenu(app, "系统字典管理", "~/Moudles/SystemManage/DictionaryManage/SystemDictionaryListPage.aspx", "", mainMenu,7);
            AddSubMenu(app, "系统部门管理", "~/Moudles/SystemManage/DepartmentManage/SystemDepartmentListPage.aspx", "", mainMenu,8);
            AddSubMenu(app, "系统日志管理", "~/Moudles/SystemManage/LogManage/SystemLogListPage.aspx", "", mainMenu, 9);
            AddSubMenu(app, "系统模块管理", "~/Moudles/SystemManage/MoudleManage/SystemMoudleListPage.aspx", "", mainMenu, 10);
            AddSubMenu(app, "系统权限管理", "~/Moudles/SystemManage/PermissionManage/SystemPrivilegeListPage.aspx", "", mainMenu, 11);
            AddSubMenu(app, "系统名称设置", "~/Moudles/SystemManage/SettingManage/SystemSettingEditor.aspx", "", mainMenu, 12);
            AddSubMenu(app, "邮件服务器设置", "~/Moudles/SystemManage/EmailSettingManage/SystemEmailSettingsListPage.aspx", "", mainMenu, 13);
        }

        private void AddSubMenu(SystemApplicationEntity app, string menuName, string menuurl, string iconurl, SystemMenuEntity mainMenu, int menuorder)
        {
            SystemMenuEntity subMenu = new SystemMenuEntity();

            subMenu.ApplicationID = app;
            subMenu.MenuName = menuName;
            subMenu.MenuDescription = menuName;
            subMenu.MenuUrl = menuurl;
            subMenu.MenuUrlTarget = "1";
            subMenu.MenuIconUrl = iconurl;
            subMenu.MenuType = "1";
            subMenu.MenuIsSystemMenu = true;
            subMenu.MenuIsEnable = true;
            subMenu.ParentMenuID = mainMenu;
            subMenu.MenuOrder = menuorder;
            mainMenu.MenuIsCategory = false;

            this.DataObjectsContainerIocID.SystemMenuDataObjectInstance.Save(subMenu);
        }

        private SystemMenuEntity AddSystemMainMenu(SystemApplicationEntity app, string menuName, int menuorder)
        {
            SystemMenuEntity mainMenu = new SystemMenuEntity();

            mainMenu.ApplicationID = app;
            mainMenu.MenuName = menuName;
            mainMenu.MenuDescription = menuName;
            mainMenu.MenuUrl = "";
            mainMenu.MenuUrlTarget = "";
            mainMenu.MenuIconUrl = "";
            mainMenu.MenuType = "1";
            mainMenu.MenuIsSystemMenu = true;
            mainMenu.MenuIsEnable = true;
            mainMenu.ParentMenuID = null;
            mainMenu.MenuOrder = menuorder;
            mainMenu.MenuIsCategory = true;

            this.DataObjectsContainerIocID.SystemMenuDataObjectInstance.Save(mainMenu);

            return mainMenu;
        }
    }
}
