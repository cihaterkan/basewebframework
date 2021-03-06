
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Threading;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;


namespace Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers
{
	[Serializable]
    public partial class SystemApplicationWrapper : BaseSpringNHibernateWrapper<SystemApplicationEntity, ISystemApplicationServiceProxy, SystemApplicationWrapper, int>
    {
        #region Static Common Data Operation
		
		public static void Save(SystemApplicationWrapper obj)
        {
            Save(obj, businessProxy);
        }

        public static void Update(SystemApplicationWrapper obj)
        {
            Update(obj, businessProxy);
        }

        public static void SaveOrUpdate(SystemApplicationWrapper obj)
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

        public static void Delete(SystemApplicationWrapper instance)
        {
            Delete(instance, businessProxy);
        }

        public static void Refresh(SystemApplicationWrapper instance)
        {
            Refresh(instance, businessProxy);
        }

        public static SystemApplicationWrapper FindById(int id)
        {
            return ConvertEntityToWrapper(FindById(id, businessProxy));
        }

        public static List<SystemApplicationWrapper> FindAll()
        {
            return ConvertToWrapperList(FindAll(businessProxy));
        }

        public static List<SystemApplicationWrapper> FindAllByPage(PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(FindAllByPage(pageQueryParams, businessProxy));
        }

        public static List<SystemApplicationWrapper> FindAllByOrderBy(string orderByColumnName, bool isDesc, PageQueryParams pageQueryParams)
        {
            orderByColumnName = ProcessColumnName(orderByColumnName);

            return ConvertToWrapperList(FindAllByOrderByAndFilter(new List<QueryFilter>(), orderByColumnName, isDesc, pageQueryParams, businessProxy));
        }



        public static List<SystemApplicationWrapper> FindAllByOrderByAndFilter(List<QueryFilter> filters, string orderByFieldName, bool isDesc, PageQueryParams pageQueryParams)
        {
            orderByFieldName = ProcessColumnName(orderByFieldName);

            ProcessQueryFilters(filters);

            return ConvertToWrapperList(FindAllByOrderByAndFilter(filters, orderByFieldName, isDesc, businessProxy)); ;
        }



	    #endregion

        public const string BaseSystemApplicationName = "Base System Module";
 
	    /// <summary>
        /// 通过配置文件加载系统应用（如果不存在，则创建。MemberShip使用）
        /// </summary>
        /// <param name="configValue"></param>
        /// <returns></returns>
        public static SystemApplicationWrapper CreateOrLoadApplication(string configValue)
        {
            return businessProxy.CreateOrLoadApplication(configValue);
        }

        /// <summary>
        /// 获取用户分配的所有系统应用
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static List<SystemApplicationWrapper> GetUserAvaiableApplications(SystemUserWrapper user)
        {
            //如果是系统管理员，获取所有的系统应用
            if (SystemUserWrapper.CheckUserIfDeveloperAdminOrSystemAdmin(user.UserLoginID))
                return FindAll();

            return ConvertToWrapperList(businessProxy.GetUserAvaiableApplications(user));
        }

        public static List<SystemApplicationWrapper> GetUserAvaiableApplicationsNotAssigned(SystemUserWrapper currentLoginUser, int roleID)
        {
            List<SystemApplicationWrapper> allAplications = GetUserAvaiableApplications(currentLoginUser);

            SystemRoleWrapper systemRoleWrapper = SystemRoleWrapper.FindById(roleID);

            List<SystemApplicationWrapper> assignedApplications = SystemRoleWrapper.GetRoleAssignedApplications(systemRoleWrapper);

            foreach (SystemApplicationWrapper assignedApplication in assignedApplications)
            {
                int appID = assignedApplication.SystemApplicationID;

                allAplications.RemoveAll(p => (p.SystemApplicationID == appID));
            }

            return allAplications;
        }


	    public string LocaLocalizationName
	    {
	        get
	        {
                return SystemTerminologyWrapper.GetLocalizationName(this.SystemApplicationName, Thread.CurrentThread.CurrentUICulture.ToString().ToLower());
	        }
	    }

	    public static SystemApplicationWrapper FindByCode(string applicationCode)
	    {
            return new SystemApplicationWrapper(businessProxy.FindByCode(applicationCode));
	    }
    }
}
