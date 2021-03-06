// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using Legendigital.Framework.Common.BaseFramework.Data.Tables;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Spring.Transaction.Interceptor;


namespace Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables
{
    [ServiceContract(Namespace = "http://Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables")]
    public interface ISystemPrivilegeInRolesServiceProxy : IBaseSpringNHibernateEntityServiceProxy<SystemPrivilegeInRolesEntity, int>, ISystemPrivilegeInRolesServiceProxyDesigner
    {
        [OperationContract]
	    void PatchUpdatePermissionsParam(List<SystemPrivilegeInRolesEntity> privilegeInRolesEntities);
        [OperationContract]
        IList<SystemPrivilegeInRolesEntity> GetAllPrivilegeByCategoryByUserID(SystemUserEntity entity);
        [OperationContract]
        SystemPrivilegeInRolesEntity GetRelationByRoleAndPrivilege(SystemRoleEntity roleEntity, SystemPrivilegeEntity privilegeEntity);
    }

    public partial class SystemPrivilegeInRolesServiceProxy : BaseSpringNHibernateEntityServiceProxy<SystemPrivilegeInRolesEntity,int>, ISystemPrivilegeInRolesServiceProxy
    {
        [Transaction(ReadOnly = false)]
        public void PatchUpdatePermissionsParam(List<SystemPrivilegeInRolesEntity> privilegeInRolesEntities)
        {
            foreach (SystemPrivilegeInRolesEntity list in privilegeInRolesEntities)
            {
                this.SelfDataObj.Update(list);
            }
        }

        public IList<SystemPrivilegeInRolesEntity> GetAllPrivilegeByCategoryByUserID(SystemUserEntity entity)
        {
            return this.SelfDataObj.GetAllPrivilegeByCategoryByUserID(entity);
        }

        public SystemPrivilegeInRolesEntity GetRelationByRoleAndPrivilege(SystemRoleEntity roleEntity, SystemPrivilegeEntity privilegeEntity)
        {
            return this.SelfDataObj.GetRelationByRoleAndPrivilege(roleEntity, privilegeEntity);
        }
    }
}
