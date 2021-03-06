
using System;
using System.Collections.Generic;
using System.Configuration;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;


namespace Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers
{
	[Serializable]
    public partial class SystemUserGroupWrapper
    {
        #region Static Common Data Operation
		
		public static void Save(SystemUserGroupWrapper obj)
        {
            businessProxy.Save(obj.entity);
        }

        public static void Update(SystemUserGroupWrapper obj)
        {
            businessProxy.Update(obj.entity);
        }

        public static void SaveOrUpdate(SystemUserGroupWrapper obj)
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

        public static void Delete(SystemUserGroupWrapper instance)
        {
            businessProxy.Delete(instance.entity);
        }

        public static void Refresh(SystemUserGroupWrapper instance)
        {
            businessProxy.Refresh(instance.entity);
        }

        public static SystemUserGroupWrapper FindById(object id)
        {
            return ConvertEntityToWrapper(businessProxy.FindById(id));
        }

        public static List<SystemUserGroupWrapper> FindAll()
        {
            return ConvertToWrapperList(businessProxy.FindAll());
        }

        public static List<SystemUserGroupWrapper> FindAllByPage(PageQueryParams pageQueryParams)
        {
            List<SystemUserGroupEntity> list = businessProxy.FindAllByPage(pageQueryParams);
            return ConvertToWrapperList(list);
        }

        public static List<SystemUserGroupWrapper> FindAllByOrderBy(string orderByColumnName, bool isDesc, PageQueryParams pageQueryParams)
        {
            return FindAllByOrderByAndFilter(new List<QueryFilter>(), orderByColumnName, isDesc, pageQueryParams);
        }


        public static List<SystemUserGroupWrapper> FindAllByOrderByAndFilter(List<QueryFilter> filters, string orderByColumnName, bool isDesc, PageQueryParams pageQueryParams)
        {
            List<SystemUserGroupWrapper> results = null;

            results = ConvertToWrapperList(
                    businessProxy.FindAllByOrderByAndFilter(filters, orderByColumnName, isDesc,
                                                  pageQueryParams));

            return results;
        }
		

		
		#endregion


        public static List<string> GetUserGroupAssignedRoleIDs(SystemUserGroupWrapper userGroupWrapper)
        {
            if (userGroupWrapper == null)
                throw new ArgumentNullException("systemUserGroupWrapper");

            List<SystemRoleEntity> assignedRoles = businessProxy.GetAssignedRoleByUserGroup(userGroupWrapper.entity);

            List<string> roleIDs = new List<string>();

            foreach (SystemRoleEntity role in assignedRoles)
            {
                roleIDs.Add(role.RoleID.ToString());
            }

            return roleIDs;
        }

        public static void PatchAssignUserGroupRoles(SystemUserGroupWrapper userGroupWrapper, List<string> roleids)
        {
            if (userGroupWrapper == null)
                throw new ArgumentNullException("userGroupWrapper");
            if (roleids == null)
                throw new ArgumentNullException("roleids");

            businessProxy.PatchAssignUserGroupRoles(userGroupWrapper.entity, roleids);
        }
    }
}
