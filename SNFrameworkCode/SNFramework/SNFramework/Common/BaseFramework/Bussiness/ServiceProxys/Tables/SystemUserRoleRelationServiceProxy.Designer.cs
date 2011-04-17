// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using Legendigital.Framework.Common.BaseFramework.Data.Tables;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.BaseFramework.Data.Tables.Container;




namespace Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables
{

    public interface ISystemUserRoleRelationServiceProxyDesigner
    {
		List<SystemUserRoleRelationEntity> FindAllByOrderByAndFilterAndUserID(string orderByColumnName, bool isDesc,   SystemUserEntity _userID, PageQueryParams pageQueryParams);
		List<SystemUserRoleRelationEntity> FindAllByUserID(SystemUserEntity _userID);
		List<SystemUserRoleRelationEntity> FindAllByOrderByAndFilterAndRoleID(string orderByColumnName, bool isDesc,   SystemRoleEntity _roleID, PageQueryParams pageQueryParams);
		List<SystemUserRoleRelationEntity> FindAllByRoleID(SystemRoleEntity _roleID);
    }

    public partial class SystemUserRoleRelationServiceProxy : BaseSpringNHibernateEntityServiceProxy<SystemUserRoleRelationEntity>
    {
		public BaseFrameworkDataObjectContainers DataObjectsContainerIocID { set; get; }
	
        public SystemUserRoleRelationDataObject SelfDataObj
        {
            set
            {
                selfDataObject = value;
            }
			get
            {
                return (SystemUserRoleRelationDataObject)selfDataObject;
            }
        }
	
		public List<SystemUserRoleRelationEntity> FindAllByOrderByAndFilterAndUserID(string orderByColumnName, bool isDesc,  SystemUserEntity _userID, PageQueryParams pageQueryParams)
        {
			return this.SelfDataObj.GetPageList_By_UserID_SystemUserEntity(orderByColumnName, isDesc,_userID, pageQueryParams);
        }
		
		public List<SystemUserRoleRelationEntity> FindAllByUserID(SystemUserEntity _userID)
        {
			return this.SelfDataObj.GetList_By_UserID_SystemUserEntity(_userID);
        }
	
		public List<SystemUserRoleRelationEntity> FindAllByOrderByAndFilterAndRoleID(string orderByColumnName, bool isDesc,  SystemRoleEntity _roleID, PageQueryParams pageQueryParams)
        {
			return this.SelfDataObj.GetPageList_By_RoleID_SystemRoleEntity(orderByColumnName, isDesc,_roleID, pageQueryParams);
        }
		
		public List<SystemUserRoleRelationEntity> FindAllByRoleID(SystemRoleEntity _roleID)
        {
			return this.SelfDataObj.GetList_By_RoleID_SystemRoleEntity(_roleID);
        }





		
    }
}