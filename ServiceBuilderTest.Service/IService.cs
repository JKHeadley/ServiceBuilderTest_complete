using ServiceBuilderTest.Service.Helpers;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;
using ServiceBuilderTest.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Transactions;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace ServiceBuilderTest.Service
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
		UserGroupDTO CreateUserGroup(UserGroupDTO entity);

        [OperationContract]
		IEnumerable<UserGroupDTO> GetUserGroups( );

        [OperationContract]
		UserGroupDTO GetUserGroupById(int id);

        [OperationContract]
		UserGroupDTO GetUserGroupByUserId(System.Guid userId);

        [OperationContract]
		UserGroupDTO GetUserGroupByGroupId(int groupId);

        [OperationContract]
		UserGroupDTO UpdateUserGroup(UserGroupDTO entity);

        [OperationContract]
		int DeleteUserGroupById(int id);

        [OperationContract]
		OrganizationPrivilegeDTO CreateOrganizationPrivilege(OrganizationPrivilegeDTO entity);

        [OperationContract]
		IEnumerable<OrganizationPrivilegeDTO> GetOrganizationPrivileges( );

        [OperationContract]
		OrganizationPrivilegeDTO GetOrganizationPrivilegeById(int id);

        [OperationContract]
		OrganizationPrivilegeDTO GetOrganizationPrivilegeByOrganizationId(int organizationId);

        [OperationContract]
		OrganizationPrivilegeDTO GetOrganizationPrivilegeByPrivilegeId(int privilegeId);

        [OperationContract]
		OrganizationPrivilegeDTO UpdateOrganizationPrivilege(OrganizationPrivilegeDTO entity);

        [OperationContract]
		int DeleteOrganizationPrivilegeById(int id);

        [OperationContract]
		UserDTO CreateUser(UserDTO entity);

        [OperationContract]
		IEnumerable<UserDTO> GetUsers( );

        [OperationContract]
		UserDTO GetUserById(System.Guid id);

        [OperationContract]
		UserDTO GetUserByUsername(string username);

        [OperationContract]
		UserDTO GetUserByPassword(string password);

        [OperationContract]
		UserDTO UpdateUser(UserDTO entity);

        [OperationContract]
		int DeleteUserById(System.Guid id);

        [OperationContract]
		OrganizationDTO CreateOrganization(OrganizationDTO entity);

        [OperationContract]
		IEnumerable<OrganizationDTO> GetOrganizations( );

        [OperationContract]
		OrganizationDTO GetOrganizationById(int id);

        [OperationContract]
		OrganizationDTO GetOrganizationByName(string name);

        [OperationContract]
		OrganizationDTO UpdateOrganization(OrganizationDTO entity);

        [OperationContract]
		int DeleteOrganizationById(int id);

        [OperationContract]
		UserOrganizationDTO CreateUserOrganization(UserOrganizationDTO entity);

        [OperationContract]
		IEnumerable<UserOrganizationDTO> GetUserOrganizations( );

        [OperationContract]
		UserOrganizationDTO GetUserOrganizationById(int id);

        [OperationContract]
		UserOrganizationDTO GetUserOrganizationByUserId(System.Guid userId);

        [OperationContract]
		UserOrganizationDTO GetUserOrganizationByOrganizationId(int organizationId);

        [OperationContract]
		UserOrganizationDTO UpdateUserOrganization(UserOrganizationDTO entity);

        [OperationContract]
		int DeleteUserOrganizationById(int id);

        [OperationContract]
		ApplicationDTO CreateApplication(ApplicationDTO entity);

        [OperationContract]
		IEnumerable<ApplicationDTO> GetApplications( );

        [OperationContract]
		ApplicationDTO GetApplicationById(int id);

        [OperationContract]
		ApplicationDTO GetApplicationByName(string name);

        [OperationContract]
		ApplicationDTO UpdateApplication(ApplicationDTO entity);

        [OperationContract]
		int DeleteApplicationById(int id);

        [OperationContract]
		GroupPrivilegeDTO CreateGroupPrivilege(GroupPrivilegeDTO entity);

        [OperationContract]
		IEnumerable<GroupPrivilegeDTO> GetGroupPrivileges( );

        [OperationContract]
		GroupPrivilegeDTO GetGroupPrivilegeById(int id);

        [OperationContract]
		GroupPrivilegeDTO GetGroupPrivilegeByGroupId(int groupId);

        [OperationContract]
		GroupPrivilegeDTO GetGroupPrivilegeByPrivilegeId(int privilegeId);

        [OperationContract]
		GroupPrivilegeDTO UpdateGroupPrivilege(GroupPrivilegeDTO entity);

        [OperationContract]
		int DeleteGroupPrivilegeById(int id);

        [OperationContract]
		PrivilegeDTO CreatePrivilege(PrivilegeDTO entity);

        [OperationContract]
		IEnumerable<PrivilegeDTO> GetPrivileges( );

        [OperationContract]
		PrivilegeDTO GetPrivilegeById(int id);

        [OperationContract]
		PrivilegeDTO GetPrivilegeByName(string name);

        [OperationContract]
		PrivilegeDTO GetPrivilegeByApplicationId(int applicationId);

        [OperationContract]
		PrivilegeDTO GetPrivilegeByApplication(ApplicationDTO application);

        [OperationContract]
		PrivilegeDTO UpdatePrivilege(PrivilegeDTO entity);

        [OperationContract]
		int DeletePrivilegeById(int id);

        [OperationContract]
		UserPrivilegeDTO CreateUserPrivilege(UserPrivilegeDTO entity);

        [OperationContract]
		IEnumerable<UserPrivilegeDTO> GetUserPrivileges( );

        [OperationContract]
		UserPrivilegeDTO GetUserPrivilegeById(int id);

        [OperationContract]
		UserPrivilegeDTO GetUserPrivilegeByUserId(System.Guid userId);

        [OperationContract]
		UserPrivilegeDTO GetUserPrivilegeByPrivilegeId(int privilegeId);

        [OperationContract]
		UserPrivilegeDTO UpdateUserPrivilege(UserPrivilegeDTO entity);

        [OperationContract]
		int DeleteUserPrivilegeById(int id);

        [OperationContract]
		GroupDTO CreateGroup(GroupDTO entity);

        [OperationContract]
		IEnumerable<GroupDTO> GetGroups( );

        [OperationContract]
		GroupDTO GetGroupById(int id);

        [OperationContract]
		GroupDTO GetGroupByName(string name);

        [OperationContract]
		GroupDTO GetGroupByParentOrganizationId(int parentOrganizationId);

        [OperationContract]
		GroupDTO GetGroupByParentOrganization(OrganizationDTO parentOrganization);

        [OperationContract]
		GroupDTO UpdateGroup(GroupDTO entity);

        [OperationContract]
		int DeleteGroupById(int id);

        [OperationContract]
		LogEventDTO CreateLogEvent(LogEventDTO entity);

        [OperationContract]
		IEnumerable<LogEventDTO> GetLogEvents( );

        [OperationContract]
		LogEventDTO GetLogEventById(int id);

        [OperationContract]
		LogEventDTO GetLogEventByLogEventType(string logEventType);

        [OperationContract]
		LogEventDTO GetLogEventByEntityType(string entityType);

        [OperationContract]
		LogEventDTO GetLogEventByEntityId(string entityId);

        [OperationContract]
		LogEventDTO GetLogEventByChangedByUserId(string changedByUserId);

        [OperationContract]
		LogEventDTO GetLogEventByChangedByUserName(string changedByUserName);

        [OperationContract]
		LogEventDTO GetLogEventByDate(System.DateTime date);

        [OperationContract]
		LogEventDTO GetLogEventByPropertyName(string propertyName);

        [OperationContract]
		LogEventDTO GetLogEventByPropertyType(string propertyType);

        [OperationContract]
		LogEventDTO GetLogEventByOldValue(string oldValue);

        [OperationContract]
		LogEventDTO GetLogEventByNewValue(string newValue);

        [OperationContract]
		LogEventDTO GetLogEventByErrorMessage(string errorMessage);

        [OperationContract]
		LogEventDTO GetLogEventByStackTrace(string stackTrace);

        [OperationContract]
		LogEventDTO UpdateLogEvent(LogEventDTO entity);

        [OperationContract]
		int DeleteLogEventById(int id);


    }
}



