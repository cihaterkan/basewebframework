// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Web.Security;
using Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using Legendigital.Framework.Common.BaseFramework.Data.Tables;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.Exceptions;
using Spring.Transaction.Interceptor;
using Legendigital.Framework.Common.BaseFramework.Providers;


namespace Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables
{
    [ServiceContract(Namespace = "http://Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables")]
    public interface ISystemUserServiceProxy : IBaseSpringNHibernateEntityServiceProxy<SystemUserEntity>
    {
        [OperationContract]
        List<SystemRoleWrapper> GetUserAssignedRoleByUserLoginId(string loginId);
        [OperationContract]
        SystemUserWrapper GetUserByLoginIdAndPassword(string loginId, string password);
        [OperationContract]
        SystemUserWrapper GetUserByLoginId(string loginId);
        [OperationContract]
        SystemUserWrapper GetUserByEmail(string email);
        [OperationContract]
        bool CheckUserRoleRelationIsExist(SystemUserWrapper user, SystemRoleWrapper role);
        [OperationContract]
        List<SystemUserWrapper> FindUsersByEmail(string emailMatch, int index, int size, out int records);
        [OperationContract]
        List<SystemUserWrapper> FindAllUsers(int pageIndex, int pageSize, out int totalRecords);
        [OperationContract]
        int FindOnlineUsersCount(DateTime time);
        [OperationContract]
        List<SystemUserWrapper> FindUsersByLoginId(string loginIdMatch, int index, int size, out int records);
        [OperationContract]
        void DeleteUser(string loginId, bool deleteAllRelatedData);
        [OperationContract]
        bool IsUserInRole(string loginID, string roleName);
        [OperationContract]
        string[] GetRolesForUser(string username);
        [OperationContract]
        SystemUserWrapper GetInitalUserByLoginID(string loginID);
        [OperationContract]
        List<SystemRoleEntity> GetUserAssignedRoleByUser(SystemUserEntity user);
        [OperationContract]
        void PatchAssignUserRoles(SystemUserEntity userEntity, List<string> roleids);
        [OperationContract]
        bool UserHasPermission(SystemUserEntity userWrapper, SystemPrivilegeEntity permission);
        [OperationContract]
        List<SystemUserEntity> FindAuthenticatedUserAll(int pageIndex, int pageSize, out int totalRecords);
        [OperationContract]
        bool CheckUserIfDeveloperAdminOrSystemAdmin(SystemUserWrapper userWrapper);
        [OperationContract]
        SystemRoleEntity GetUserMaxRoleTypeRole(SystemUserEntity systemUserEntity);
        [OperationContract]
        SystemRoleEntity GetUserMinRoleTypeRole(SystemUserEntity systemUserEntity);
        [OperationContract]
        bool LockUser(string userName, bool isLock);
        [OperationContract]
        void LockByIDS(List<int> ids, bool isLock);
        [OperationContract]
        void SaveFirstChangePassword(string loginID, string newPassword);
        [OperationContract]
        SystemRoleEntity GetUserDefaultRoleByUserID(int userId);
        [OperationContract]
        void SetUserDefaultRole(int userID, int roleID);
        [OperationContract]
        void PatchAssignUserUserGroups(SystemUserEntity userentity, List<string> usergroupids);
        [OperationContract]
        List<SystemUserGroupEntity> GetUserAssignedGroupsByUser(SystemUserEntity systemUserEntity);
    }

    public partial class SystemUserServiceProxy : ISystemUserServiceProxy
    {
        protected const string DEV_USER_ID = "DeveloperAdministrator";
        protected const string SYS_USER_ID = "SystemAdministrator";

        /// <summary>
        /// 获取用户分配的所有角色
        /// </summary>
        /// <param name="loginID">登陆ID</param>
        /// <returns></returns>
        public List<SystemRoleWrapper> GetUserAssignedRoleByUserLoginId(string loginID)
        {
            if (loginID == SystemUserWrapper.DEV_USER_ID)
                return SystemRoleWrapper.ConvertToWrapperList(this.DataObjectsContainerIocID.SystemRoleDataObjectInstance.FindAll());


            SystemUserEntity user = SelfDataObj.GetUserByLoginID(loginID);
            List<SystemRoleEntity> list = this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.GetUserAssignedRoles(user);
            foreach (SystemRoleEntity role in list)
            {
                this.DataObjectsContainerIocID.SystemRoleDataObjectInstance.InitializeLazyProperty(role, SystemRoleEntity.PROPERTY_NAME_ROLEID);
                this.DataObjectsContainerIocID.SystemRoleDataObjectInstance.InitializeLazyProperty(role, SystemRoleEntity.PROPERTY_NAME_ROLENAME);
                this.DataObjectsContainerIocID.SystemRoleDataObjectInstance.InitializeLazyProperty(role, SystemRoleEntity.PROPERTY_NAME_ROLEDESCRIPTION);
                this.DataObjectsContainerIocID.SystemRoleDataObjectInstance.InitializeLazyProperty(role, SystemRoleEntity.PROPERTY_NAME_ROLEISSYSTEMROLE);
            }
            return SystemRoleWrapper.ConvertToWrapperList(list);
        }



        /// <summary>
        /// 通过登录ID和密码获取用户
        /// </summary>
        /// <param name="loginID">登录ID</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public SystemUserWrapper GetUserByLoginIdAndPassword(string loginID, string password)
        {
            SystemUserEntity findUser = this.SelfDataObj.GetUserByLoginIDAndPassword(loginID, password);
            if ((findUser != null) && findUser.UserPassword.Equals(password))
            {
                return SystemUserWrapper.ConvertEntityToWrapper(findUser);
            }
            return null;
        }

        /// <summary>
        /// 通过登录ID获取用户
        /// </summary>
        /// <param name="loginID"></param>
        /// <returns></returns>
        public SystemUserWrapper GetUserByLoginId(string loginID)
        {
            return SystemUserWrapper.ConvertEntityToWrapper(this.DataObjectsContainerIocID.SystemUserDataObjectInstance.GetUserByLoginID(loginID));
        }

        /// <summary>
        /// 通过Email获取用户
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public SystemUserWrapper GetUserByEmail(string email)
        {
            return SystemUserWrapper.ConvertEntityToWrapper(this.DataObjectsContainerIocID.SystemUserDataObjectInstance.GetUserByEmail(email));
        }

        /// <summary>
        /// 检查用户角色之间是否存在对应关系
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="role">角色</param>
        /// <returns></returns>
        public bool CheckUserRoleRelationIsExist(SystemUserWrapper user, SystemRoleWrapper role)
        {
            return CheckUserRoleRelationIsExist(user.entity, role.entity);
        }

        /// <summary>
        /// 通过Email分页查找用户
        /// </summary>
        /// <param name="emailMatch">Email</param>
        /// <param name="index">当前页码</param>
        /// <param name="size">页码大小</param>
        /// <param name="records">总记录数</param>
        /// <returns></returns>
        public List<SystemUserWrapper> FindUsersByEmail(string emailMatch, int index, int size, out int records)
        {
            return SystemUserWrapper.ConvertToWrapperList(this.SelfDataObj.FindUsersByEmail(emailMatch, index, size, out records));
        }
        /// <summary>
        /// 分页读取所有的用户
        /// </summary>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">页码大小</param>
        /// <param name="totalRecords">总记录数</param>
        /// <returns></returns>
        public List<SystemUserWrapper> FindAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            return SystemUserWrapper.ConvertToWrapperList(this.SelfDataObj.FindAllUsers(pageIndex, pageSize, out totalRecords));
        }
        /// <summary>
        /// 在线用户总数
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public int FindOnlineUsersCount(DateTime time)
        {
            return this.SelfDataObj.FindOnlineUsersCount(time);
        }

        /// <summary>
        /// 通过登陆ID分页查找用户
        /// </summary>
        /// <param name="loginIDMatch"></param>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <param name="records"></param>
        /// <returns></returns>
        public List<SystemUserWrapper> FindUsersByLoginId(string loginIDMatch, int index, int size, out int records)
        {

            return SystemUserWrapper.ConvertToWrapperList(this.SelfDataObj.FindUsersByName(loginIDMatch, index, size, out records));
        }

        public bool IsUserInRole(string loginId, string roleName)
        {
            SystemUserEntity user = this.SelfDataObj.GetUserByLoginID(loginId);
            SystemRoleEntity role = this.DataObjectsContainerIocID.SystemRoleDataObjectInstance.GetRoleByName(roleName);
            if ((user != null) && (role != null))
            {
                return CheckUserRoleRelationIsExist(user, role);
            }
            return false;
        }

        public string[] GetRolesForUser(string username)
        {
            var list = new List<string>();
            List<SystemRoleWrapper> allRoles = GetUserAssignedRoleByUserLoginId(username);
            foreach (var role in allRoles)
            {
                list.Add(role.RoleName);
            }
            return list.ToArray();
        }

        /// <summary>
        /// 通过用户LoginID获取用户
        /// </summary>
        /// <param name="loginID"></param>
        /// <returns></returns>
        public SystemUserWrapper GetInitalUserByLoginID(string loginID)
        {
            SystemUserEntity user = this.DataObjectsContainerIocID.SystemUserDataObjectInstance.GetUserByLoginID(loginID);
            this.DataObjectsContainerIocID.SystemUserDataObjectInstance.InitializeLazyProperties(user);
            return SystemUserWrapper.ConvertEntityToWrapper(user);
        }

        /// <summary>
        /// 获取用户分配的角色
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<SystemRoleEntity> GetUserAssignedRoleByUser(SystemUserEntity user)
        {
            List<SystemRoleEntity> list = this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.GetUserAssignedRoles(user);

            return list;
        }
        /// <summary>
        /// 获取用户分配的用户组
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<SystemUserGroupEntity> GetUserAssignedGroupsByUser(SystemUserEntity systemUserEntity)
        {
            List<SystemUserGroupEntity> list = new List<SystemUserGroupEntity>();

            List<SystemUserGroupUserRelationEntity> userGroupRoleRelations = this.DataObjectsContainerIocID.SystemUserGroupUserRelationDataObjectInstance.GetAllRelationByUser(systemUserEntity);

            foreach (SystemUserGroupUserRelationEntity relation in userGroupRoleRelations)
            {
                list.Add(relation.UserGroupID);
            }

            return list;
        }

        /// <summary>
        /// 检查用户角色对应关系是否存在
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        private bool CheckUserRoleRelationIsExist(SystemUserEntity user, SystemRoleEntity role)
        {
            SystemUserRoleRelationEntity systemUserRoleRelation = this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.GetUserRoleRelation(user, role);
            return (systemUserRoleRelation != null);
        }

        /// <summary>
        /// 批量设置用户用户分配的角色
        /// </summary>
        /// <param name="userEntity"></param>
        /// <param name="roleids"></param>
        [Transaction(ReadOnly = false)]
        public void PatchAssignUserRoles(SystemUserEntity userEntity, List<string> roleids)
        {
            //获取所有的角色
            List<SystemRoleEntity> allroles =
                this.DataObjectsContainerIocID.SystemRoleDataObjectInstance.FindAll();

            //遍历所有的role
            foreach (SystemRoleEntity roleEntity in allroles)
            {
                //查找是否存在对应关系
                SystemUserRoleRelationEntity systemUserRoleRelationEntity = this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.GetUserRoleRelation(userEntity, roleEntity);
                //检查是否需要保存
                if (roleids.Contains(roleEntity.RoleID.ToString()))
                {
                    //添加或修改对应关系
                    if (systemUserRoleRelationEntity == null)
                    {
                        systemUserRoleRelationEntity = new SystemUserRoleRelationEntity();
                    }
                    systemUserRoleRelationEntity.RoleID = roleEntity;
                    systemUserRoleRelationEntity.UserID = userEntity;
                    this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.SaveOrUpdate(systemUserRoleRelationEntity);
                }
                else
                {
                    //如果不需要保存则删除已存在的对应关系
                    if (systemUserRoleRelationEntity != null)
                    {
                        this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.Delete(systemUserRoleRelationEntity);
                    }
                }
            }
        }
        public void PatchAssignUserUserGroups(SystemUserEntity userentity, List<string> usergroupids)
        {
            //获取所有的角色
            List<SystemUserGroupEntity> allUserGroups =
                this.DataObjectsContainerIocID.SystemUserGroupDataObjectInstance.FindAll();

            //遍历所有的role
            foreach (SystemUserGroupEntity groupEntity in allUserGroups)
            {
                //查找是否存在对应关系
                SystemUserGroupUserRelationEntity systemUserGroupUserRelationEntity = this.DataObjectsContainerIocID.SystemUserGroupUserRelationDataObjectInstance.GetUserUserGroupRelation(userentity, groupEntity);
                //检查是否需要保存
                if (usergroupids.Contains(groupEntity.GroupID.ToString()))
                {
                    //添加或修改对应关系
                    if (systemUserGroupUserRelationEntity == null)
                    {
                        systemUserGroupUserRelationEntity = new SystemUserGroupUserRelationEntity();
                    }
                    systemUserGroupUserRelationEntity.UserGroupID = groupEntity;
                    systemUserGroupUserRelationEntity.UserID = userentity;
                    this.DataObjectsContainerIocID.SystemUserGroupUserRelationDataObjectInstance.SaveOrUpdate(systemUserGroupUserRelationEntity);
                }
                else
                {
                    //如果不需要保存则删除已存在的对应关系
                    if (systemUserGroupUserRelationEntity != null)
                    {
                        this.DataObjectsContainerIocID.SystemUserGroupUserRelationDataObjectInstance.Delete(systemUserGroupUserRelationEntity);
                    }
                }
            }
        }

        public bool UserHasPermission(SystemUserEntity userWrapper, SystemPrivilegeEntity permission)
        {
            //获取用户分配的所有的角色
            List<SystemRoleEntity> assignedroles =
                this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.GetUserAssignedRoles(userWrapper);

            return
                this.DataObjectsContainerIocID.SystemPrivilegeInRolesDataObjectInstance.RolesHasPermission(
                    assignedroles, permission);
        }

        public List<SystemUserEntity> FindAuthenticatedUserAll(int pageIndex, int pageSize, out int totalRecords)
        {
            return this.SelfDataObj.FindAuthenticatedUserAll(pageIndex, pageSize, out totalRecords);
        }

        public bool CheckUserIfDeveloperAdminOrSystemAdmin(SystemUserWrapper userWrapper)
        {
            return
                (bool)
                (userWrapper.UserLoginID.ToUpper().Equals(DEV_USER_ID.ToUpper()) ||
                 userWrapper.UserLoginID.ToUpper().Equals(SYS_USER_ID.ToUpper()));
        }

        public SystemRoleEntity GetUserMaxRoleTypeRole(SystemUserEntity systemUserEntity)
        {
            return this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.GetUserMaxRoleTypeRole(systemUserEntity);
        }

        public SystemRoleEntity GetUserMinRoleTypeRole(SystemUserEntity systemUserEntity)
        {
            return this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.GetUserMinRoleTypeRole(systemUserEntity);
        }

        [Transaction(ReadOnly = false)]
        public bool LockUser(string userName, bool isLock)
        {
            SystemUserEntity user = this.DataObjectsContainerIocID.SystemUserDataObjectInstance.GetUserByLoginID(userName);
            if (user != null)
            {
                user.IsLockedOut = isLock;
                user.LastLockedOutDate = DateTime.Now;
                user.LastActivityDate = DateTime.Now;
                this.DataObjectsContainerIocID.SystemUserDataObjectInstance.SaveOrUpdate(user);
                return true;
            }
            return false;
        }


        [Transaction(ReadOnly = false)]
        public bool LockUserByID(int id, bool isLock)
        {
            SystemUserEntity user = this.FindById(id);
            if (user != null)
            {
                user.IsLockedOut = isLock;
                user.LastLockedOutDate = DateTime.Now;
                user.LastActivityDate = DateTime.Now;
                this.DataObjectsContainerIocID.SystemUserDataObjectInstance.SaveOrUpdate(user);
                return true;
            }
            return false;
        }

        [Transaction(ReadOnly = false)]
        public void LockByIDS(List<int> ids, bool isLock)
        {

            foreach (int id in ids)
            {
                LockUserByID(id, isLock);
            }


        }

        /// <summary>
        /// 第一次修改密码
        /// </summary>
        /// <param name="systemUserEntity"></param>
        /// <param name="newPassword"></param>
        [Transaction(ReadOnly = false)]
        public void SaveFirstChangePassword(string loginID, string newPassword)
        {

            SystemUserEntity user = this.DataObjectsContainerIocID.SystemUserDataObjectInstance.GetUserByLoginID(loginID);
 
            user.UserPassword =
                ((NHibernateMembershipProvider)Membership.Provider).EncodePassword(newPassword,
                                                                                    user.PasswordSalt);
            user.LastPasswordChangeDate = DateTime.Now;
            user.LastActivityDate = DateTime.Now;
            user.IsNeedChgPwd = false;
            Update(user);


        }

        public SystemRoleEntity GetUserDefaultRoleByUserID(int userId)
        {
            SystemUserEntity user = this.SelfDataObj.Load(userId);

            List<SystemRoleEntity> userRoles =
                this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.GetUserAssignedRoles(user);

            if(userRoles!=null && userRoles.Count>0)
            {
                return userRoles[0];
            }
            else
            {
                return null;        
            }
        }

        [Transaction(ReadOnly = false)]
        public void SetUserDefaultRole(int userID, int roleID)
        {
            SystemUserEntity user = this.SelfDataObj.Load(userID);

            List<SystemRoleEntity> userRoles = this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.GetUserAssignedRoles(user);

            bool hasRelation = false;

            foreach (SystemRoleEntity role in userRoles)
            {
                if(role.RoleID!=roleID)
                {
                    SystemUserRoleRelationEntity relation =
                        this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.GetUserRoleRelation(
                            user, role);

                    this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.Delete(relation);
                }
                else
                {
                    hasRelation = true;
                }
            }

            if(!hasRelation)
            {
                SystemUserRoleRelationEntity relation = new SystemUserRoleRelationEntity();
                relation.UserID = user;
                relation.RoleID = this.DataObjectsContainerIocID.SystemRoleDataObjectInstance.Load(roleID);

                this.DataObjectsContainerIocID.SystemUserRoleRelationDataObjectInstance.Save(relation);
            }


        }


        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="loginId"></param>
        /// <param name="deleteAllRelatedData"></param>
        [Transaction(ReadOnly = false)]
        public void DeleteUser(string loginId, bool deleteAllRelatedData)
        {
            SystemUserEntity user = this.SelfDataObj.GetUserByLoginID(loginId);
            if (user != null)
            {
                //级联删除用户相关数据。
                Delete(user);
            }
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="obj"></param>
        [Transaction(ReadOnly = false)]
        public override void Save(SystemUserEntity obj)
        {
            SystemUserEntity finduser = SelfDataObj.GetUserByLoginID(obj.UserLoginID);

            if (finduser != null)
            {
                throw new DataValidationException(" Login ID ”" + obj.UserLoginID + "“ has exist。");
            }

            base.Save(obj);
        }


    }
}
