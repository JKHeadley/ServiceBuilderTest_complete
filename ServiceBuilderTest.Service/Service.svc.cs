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
    public class Service : IService
    {
        private IDTOMapper _dtoMapper;
		private IUserGroupHelper _userGroupHelper;
		private IOrganizationPrivilegeHelper _organizationPrivilegeHelper;
		private IUserHelper _userHelper;
		private IOrganizationHelper _organizationHelper;
		private IUserOrganizationHelper _userOrganizationHelper;
		private IApplicationHelper _applicationHelper;
		private IGroupPrivilegeHelper _groupPrivilegeHelper;
		private IPrivilegeHelper _privilegeHelper;
		private IUserPrivilegeHelper _userPrivilegeHelper;
		private IGroupHelper _groupHelper;
		private ILogEventHelper _logEventHelper;

        public Service(IDTOMapper dtoMapper, IUserGroupHelper userGroupHelper, IOrganizationPrivilegeHelper organizationPrivilegeHelper, IUserHelper userHelper,  
					   IOrganizationHelper organizationHelper, IUserOrganizationHelper userOrganizationHelper, IApplicationHelper applicationHelper,  
					   IGroupPrivilegeHelper groupPrivilegeHelper, IPrivilegeHelper privilegeHelper, IUserPrivilegeHelper userPrivilegeHelper,  
					   IGroupHelper groupHelper, ILogEventHelper logEventHelper)
        {
			_dtoMapper = dtoMapper;
			_userGroupHelper = userGroupHelper;
			_organizationPrivilegeHelper = organizationPrivilegeHelper;
			_userHelper = userHelper;
			_organizationHelper = organizationHelper;
			_userOrganizationHelper = userOrganizationHelper;
			_applicationHelper = applicationHelper;
			_groupPrivilegeHelper = groupPrivilegeHelper;
			_privilegeHelper = privilegeHelper;
			_userPrivilegeHelper = userPrivilegeHelper;
			_groupHelper = groupHelper;
			_logEventHelper = logEventHelper;
        }


		public UserGroupDTO CreateUserGroup(UserGroupDTO entity)
		{
			var userGroup = _userGroupHelper.CreateUserGroup(_dtoMapper.MapDTOToUserGroup(entity));
			return _dtoMapper.MapUserGroupToDTO(userGroup);
		}
		public IEnumerable<UserGroupDTO> GetUserGroups( )
		{
			var userGroups = _userGroupHelper.GetUserGroups();
			return userGroups.Select(e => _dtoMapper.MapUserGroupToDTO(e));
		}
		public UserGroupDTO GetUserGroupById(int id)
		{
			var userGroup = _userGroupHelper.GetUserGroupById(id);
			return _dtoMapper.MapUserGroupToDTO(userGroup);
		}
		public UserGroupDTO GetUserGroupByUserId(System.Guid userId)
		{
			var userGroup = _userGroupHelper.GetUserGroupByUserId(userId);
			return _dtoMapper.MapUserGroupToDTO(userGroup);
		}
		public UserGroupDTO GetUserGroupByGroupId(int groupId)
		{
			var userGroup = _userGroupHelper.GetUserGroupByGroupId(groupId);
			return _dtoMapper.MapUserGroupToDTO(userGroup);
		}
		public UserGroupDTO UpdateUserGroup(UserGroupDTO entity)
		{
			var userGroup = _userGroupHelper.UpdateUserGroup(_dtoMapper.MapDTOToUserGroup(entity));
			return _dtoMapper.MapUserGroupToDTO(userGroup);
		}
		public int DeleteUserGroupById(int id)
		{
			return _userGroupHelper.DeleteUserGroupById(id);
		}
		public OrganizationPrivilegeDTO CreateOrganizationPrivilege(OrganizationPrivilegeDTO entity)
		{
			var organizationPrivilege = _organizationPrivilegeHelper.CreateOrganizationPrivilege(_dtoMapper.MapDTOToOrganizationPrivilege(entity));
			return _dtoMapper.MapOrganizationPrivilegeToDTO(organizationPrivilege);
		}
		public IEnumerable<OrganizationPrivilegeDTO> GetOrganizationPrivileges( )
		{
			var organizationPrivileges = _organizationPrivilegeHelper.GetOrganizationPrivileges();
			return organizationPrivileges.Select(e => _dtoMapper.MapOrganizationPrivilegeToDTO(e));
		}
		public OrganizationPrivilegeDTO GetOrganizationPrivilegeById(int id)
		{
			var organizationPrivilege = _organizationPrivilegeHelper.GetOrganizationPrivilegeById(id);
			return _dtoMapper.MapOrganizationPrivilegeToDTO(organizationPrivilege);
		}
		public OrganizationPrivilegeDTO GetOrganizationPrivilegeByOrganizationId(int organizationId)
		{
			var organizationPrivilege = _organizationPrivilegeHelper.GetOrganizationPrivilegeByOrganizationId(organizationId);
			return _dtoMapper.MapOrganizationPrivilegeToDTO(organizationPrivilege);
		}
		public OrganizationPrivilegeDTO GetOrganizationPrivilegeByPrivilegeId(int privilegeId)
		{
			var organizationPrivilege = _organizationPrivilegeHelper.GetOrganizationPrivilegeByPrivilegeId(privilegeId);
			return _dtoMapper.MapOrganizationPrivilegeToDTO(organizationPrivilege);
		}
		public OrganizationPrivilegeDTO UpdateOrganizationPrivilege(OrganizationPrivilegeDTO entity)
		{
			var organizationPrivilege = _organizationPrivilegeHelper.UpdateOrganizationPrivilege(_dtoMapper.MapDTOToOrganizationPrivilege(entity));
			return _dtoMapper.MapOrganizationPrivilegeToDTO(organizationPrivilege);
		}
		public int DeleteOrganizationPrivilegeById(int id)
		{
			return _organizationPrivilegeHelper.DeleteOrganizationPrivilegeById(id);
		}
		public UserDTO CreateUser(UserDTO entity)
		{
			var user = _userHelper.CreateUser(_dtoMapper.MapDTOToUser(entity));
			return _dtoMapper.MapUserToDTO(user);
		}
		public IEnumerable<UserDTO> GetUsers( )
		{
			var users = _userHelper.GetUsers();
			return users.Select(e => _dtoMapper.MapUserToDTO(e));
		}
		public UserDTO GetUserById(System.Guid id)
		{
			var user = _userHelper.GetUserById(id);
			return _dtoMapper.MapUserToDTO(user);
		}
		public UserDTO GetUserByUsername(string username)
		{
			var user = _userHelper.GetUserByUsername(username);
			return _dtoMapper.MapUserToDTO(user);
		}
		public UserDTO GetUserByPassword(string password)
		{
			var user = _userHelper.GetUserByPassword(password);
			return _dtoMapper.MapUserToDTO(user);
		}
		public UserDTO UpdateUser(UserDTO entity)
		{
			var user = _userHelper.UpdateUser(_dtoMapper.MapDTOToUser(entity));
			return _dtoMapper.MapUserToDTO(user);
		}
		public int DeleteUserById(System.Guid id)
		{
			return _userHelper.DeleteUserById(id);
		}
		public OrganizationDTO CreateOrganization(OrganizationDTO entity)
		{
			var organization = _organizationHelper.CreateOrganization(_dtoMapper.MapDTOToOrganization(entity));
			return _dtoMapper.MapOrganizationToDTO(organization);
		}
		public IEnumerable<OrganizationDTO> GetOrganizations( )
		{
			var organizations = _organizationHelper.GetOrganizations();
			return organizations.Select(e => _dtoMapper.MapOrganizationToDTO(e));
		}
		public OrganizationDTO GetOrganizationById(int id)
		{
			var organization = _organizationHelper.GetOrganizationById(id);
			return _dtoMapper.MapOrganizationToDTO(organization);
		}
		public OrganizationDTO GetOrganizationByName(string name)
		{
			var organization = _organizationHelper.GetOrganizationByName(name);
			return _dtoMapper.MapOrganizationToDTO(organization);
		}
		public OrganizationDTO UpdateOrganization(OrganizationDTO entity)
		{
			var organization = _organizationHelper.UpdateOrganization(_dtoMapper.MapDTOToOrganization(entity));
			return _dtoMapper.MapOrganizationToDTO(organization);
		}
		public int DeleteOrganizationById(int id)
		{
			return _organizationHelper.DeleteOrganizationById(id);
		}
		public UserOrganizationDTO CreateUserOrganization(UserOrganizationDTO entity)
		{
			var userOrganization = _userOrganizationHelper.CreateUserOrganization(_dtoMapper.MapDTOToUserOrganization(entity));
			return _dtoMapper.MapUserOrganizationToDTO(userOrganization);
		}
		public IEnumerable<UserOrganizationDTO> GetUserOrganizations( )
		{
			var userOrganizations = _userOrganizationHelper.GetUserOrganizations();
			return userOrganizations.Select(e => _dtoMapper.MapUserOrganizationToDTO(e));
		}
		public UserOrganizationDTO GetUserOrganizationById(int id)
		{
			var userOrganization = _userOrganizationHelper.GetUserOrganizationById(id);
			return _dtoMapper.MapUserOrganizationToDTO(userOrganization);
		}
		public UserOrganizationDTO GetUserOrganizationByUserId(System.Guid userId)
		{
			var userOrganization = _userOrganizationHelper.GetUserOrganizationByUserId(userId);
			return _dtoMapper.MapUserOrganizationToDTO(userOrganization);
		}
		public UserOrganizationDTO GetUserOrganizationByOrganizationId(int organizationId)
		{
			var userOrganization = _userOrganizationHelper.GetUserOrganizationByOrganizationId(organizationId);
			return _dtoMapper.MapUserOrganizationToDTO(userOrganization);
		}
		public UserOrganizationDTO UpdateUserOrganization(UserOrganizationDTO entity)
		{
			var userOrganization = _userOrganizationHelper.UpdateUserOrganization(_dtoMapper.MapDTOToUserOrganization(entity));
			return _dtoMapper.MapUserOrganizationToDTO(userOrganization);
		}
		public int DeleteUserOrganizationById(int id)
		{
			return _userOrganizationHelper.DeleteUserOrganizationById(id);
		}
		public ApplicationDTO CreateApplication(ApplicationDTO entity)
		{
			var application = _applicationHelper.CreateApplication(_dtoMapper.MapDTOToApplication(entity));
			return _dtoMapper.MapApplicationToDTO(application);
		}
		public IEnumerable<ApplicationDTO> GetApplications( )
		{
			var applications = _applicationHelper.GetApplications();
			return applications.Select(e => _dtoMapper.MapApplicationToDTO(e));
		}
		public ApplicationDTO GetApplicationById(int id)
		{
			var application = _applicationHelper.GetApplicationById(id);
			return _dtoMapper.MapApplicationToDTO(application);
		}
		public ApplicationDTO GetApplicationByName(string name)
		{
			var application = _applicationHelper.GetApplicationByName(name);
			return _dtoMapper.MapApplicationToDTO(application);
		}
		public ApplicationDTO UpdateApplication(ApplicationDTO entity)
		{
			var application = _applicationHelper.UpdateApplication(_dtoMapper.MapDTOToApplication(entity));
			return _dtoMapper.MapApplicationToDTO(application);
		}
		public int DeleteApplicationById(int id)
		{
			return _applicationHelper.DeleteApplicationById(id);
		}
		public GroupPrivilegeDTO CreateGroupPrivilege(GroupPrivilegeDTO entity)
		{
			var groupPrivilege = _groupPrivilegeHelper.CreateGroupPrivilege(_dtoMapper.MapDTOToGroupPrivilege(entity));
			return _dtoMapper.MapGroupPrivilegeToDTO(groupPrivilege);
		}
		public IEnumerable<GroupPrivilegeDTO> GetGroupPrivileges( )
		{
			var groupPrivileges = _groupPrivilegeHelper.GetGroupPrivileges();
			return groupPrivileges.Select(e => _dtoMapper.MapGroupPrivilegeToDTO(e));
		}
		public GroupPrivilegeDTO GetGroupPrivilegeById(int id)
		{
			var groupPrivilege = _groupPrivilegeHelper.GetGroupPrivilegeById(id);
			return _dtoMapper.MapGroupPrivilegeToDTO(groupPrivilege);
		}
		public GroupPrivilegeDTO GetGroupPrivilegeByGroupId(int groupId)
		{
			var groupPrivilege = _groupPrivilegeHelper.GetGroupPrivilegeByGroupId(groupId);
			return _dtoMapper.MapGroupPrivilegeToDTO(groupPrivilege);
		}
		public GroupPrivilegeDTO GetGroupPrivilegeByPrivilegeId(int privilegeId)
		{
			var groupPrivilege = _groupPrivilegeHelper.GetGroupPrivilegeByPrivilegeId(privilegeId);
			return _dtoMapper.MapGroupPrivilegeToDTO(groupPrivilege);
		}
		public GroupPrivilegeDTO UpdateGroupPrivilege(GroupPrivilegeDTO entity)
		{
			var groupPrivilege = _groupPrivilegeHelper.UpdateGroupPrivilege(_dtoMapper.MapDTOToGroupPrivilege(entity));
			return _dtoMapper.MapGroupPrivilegeToDTO(groupPrivilege);
		}
		public int DeleteGroupPrivilegeById(int id)
		{
			return _groupPrivilegeHelper.DeleteGroupPrivilegeById(id);
		}
		public PrivilegeDTO CreatePrivilege(PrivilegeDTO entity)
		{
			var privilege = _privilegeHelper.CreatePrivilege(_dtoMapper.MapDTOToPrivilege(entity));
			return _dtoMapper.MapPrivilegeToDTO(privilege);
		}
		public IEnumerable<PrivilegeDTO> GetPrivileges( )
		{
			var privileges = _privilegeHelper.GetPrivileges();
			return privileges.Select(e => _dtoMapper.MapPrivilegeToDTO(e));
		}
		public PrivilegeDTO GetPrivilegeById(int id)
		{
			var privilege = _privilegeHelper.GetPrivilegeById(id);
			return _dtoMapper.MapPrivilegeToDTO(privilege);
		}
		public PrivilegeDTO GetPrivilegeByName(string name)
		{
			var privilege = _privilegeHelper.GetPrivilegeByName(name);
			return _dtoMapper.MapPrivilegeToDTO(privilege);
		}
		public PrivilegeDTO GetPrivilegeByApplicationId(int applicationId)
		{
			var privilege = _privilegeHelper.GetPrivilegeByApplicationId(applicationId);
			return _dtoMapper.MapPrivilegeToDTO(privilege);
		}
		public PrivilegeDTO GetPrivilegeByApplication(ApplicationDTO application)
		{
			var privilege = _privilegeHelper.GetPrivilegeByApplication(_dtoMapper.MapDTOToApplication(application));
			return _dtoMapper.MapPrivilegeToDTO(privilege);
		}
		public PrivilegeDTO UpdatePrivilege(PrivilegeDTO entity)
		{
			var privilege = _privilegeHelper.UpdatePrivilege(_dtoMapper.MapDTOToPrivilege(entity));
			return _dtoMapper.MapPrivilegeToDTO(privilege);
		}
		public int DeletePrivilegeById(int id)
		{
			return _privilegeHelper.DeletePrivilegeById(id);
		}
		public UserPrivilegeDTO CreateUserPrivilege(UserPrivilegeDTO entity)
		{
			var userPrivilege = _userPrivilegeHelper.CreateUserPrivilege(_dtoMapper.MapDTOToUserPrivilege(entity));
			return _dtoMapper.MapUserPrivilegeToDTO(userPrivilege);
		}
		public IEnumerable<UserPrivilegeDTO> GetUserPrivileges( )
		{
			var userPrivileges = _userPrivilegeHelper.GetUserPrivileges();
			return userPrivileges.Select(e => _dtoMapper.MapUserPrivilegeToDTO(e));
		}
		public UserPrivilegeDTO GetUserPrivilegeById(int id)
		{
			var userPrivilege = _userPrivilegeHelper.GetUserPrivilegeById(id);
			return _dtoMapper.MapUserPrivilegeToDTO(userPrivilege);
		}
		public UserPrivilegeDTO GetUserPrivilegeByUserId(System.Guid userId)
		{
			var userPrivilege = _userPrivilegeHelper.GetUserPrivilegeByUserId(userId);
			return _dtoMapper.MapUserPrivilegeToDTO(userPrivilege);
		}
		public UserPrivilegeDTO GetUserPrivilegeByPrivilegeId(int privilegeId)
		{
			var userPrivilege = _userPrivilegeHelper.GetUserPrivilegeByPrivilegeId(privilegeId);
			return _dtoMapper.MapUserPrivilegeToDTO(userPrivilege);
		}
		public UserPrivilegeDTO UpdateUserPrivilege(UserPrivilegeDTO entity)
		{
			var userPrivilege = _userPrivilegeHelper.UpdateUserPrivilege(_dtoMapper.MapDTOToUserPrivilege(entity));
			return _dtoMapper.MapUserPrivilegeToDTO(userPrivilege);
		}
		public int DeleteUserPrivilegeById(int id)
		{
			return _userPrivilegeHelper.DeleteUserPrivilegeById(id);
		}
		public GroupDTO CreateGroup(GroupDTO entity)
		{
			var group = _groupHelper.CreateGroup(_dtoMapper.MapDTOToGroup(entity));
			return _dtoMapper.MapGroupToDTO(group);
		}
		public IEnumerable<GroupDTO> GetGroups( )
		{
			var groups = _groupHelper.GetGroups();
			return groups.Select(e => _dtoMapper.MapGroupToDTO(e));
		}
		public GroupDTO GetGroupById(int id)
		{
			var group = _groupHelper.GetGroupById(id);
			return _dtoMapper.MapGroupToDTO(group);
		}
		public GroupDTO GetGroupByName(string name)
		{
			var group = _groupHelper.GetGroupByName(name);
			return _dtoMapper.MapGroupToDTO(group);
		}
		public GroupDTO GetGroupByParentOrganizationId(int parentOrganizationId)
		{
			var group = _groupHelper.GetGroupByParentOrganizationId(parentOrganizationId);
			return _dtoMapper.MapGroupToDTO(group);
		}
		public GroupDTO GetGroupByParentOrganization(OrganizationDTO parentOrganization)
		{
			var group = _groupHelper.GetGroupByParentOrganization(_dtoMapper.MapDTOToOrganization(parentOrganization));
			return _dtoMapper.MapGroupToDTO(group);
		}
		public GroupDTO UpdateGroup(GroupDTO entity)
		{
			var group = _groupHelper.UpdateGroup(_dtoMapper.MapDTOToGroup(entity));
			return _dtoMapper.MapGroupToDTO(group);
		}
		public int DeleteGroupById(int id)
		{
			return _groupHelper.DeleteGroupById(id);
		}
		public LogEventDTO CreateLogEvent(LogEventDTO entity)
		{
			var logEvent = _logEventHelper.CreateLogEvent(_dtoMapper.MapDTOToLogEvent(entity));
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public IEnumerable<LogEventDTO> GetLogEvents( )
		{
			var logEvents = _logEventHelper.GetLogEvents();
			return logEvents.Select(e => _dtoMapper.MapLogEventToDTO(e));
		}
		public LogEventDTO GetLogEventById(int id)
		{
			var logEvent = _logEventHelper.GetLogEventById(id);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByLogEventType(string logEventType)
		{
			var logEvent = _logEventHelper.GetLogEventByLogEventType(logEventType);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByEntityType(string entityType)
		{
			var logEvent = _logEventHelper.GetLogEventByEntityType(entityType);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByEntityId(string entityId)
		{
			var logEvent = _logEventHelper.GetLogEventByEntityId(entityId);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByChangedByUserId(string changedByUserId)
		{
			var logEvent = _logEventHelper.GetLogEventByChangedByUserId(changedByUserId);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByChangedByUserName(string changedByUserName)
		{
			var logEvent = _logEventHelper.GetLogEventByChangedByUserName(changedByUserName);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByDate(System.DateTime date)
		{
			var logEvent = _logEventHelper.GetLogEventByDate(date);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByPropertyName(string propertyName)
		{
			var logEvent = _logEventHelper.GetLogEventByPropertyName(propertyName);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByPropertyType(string propertyType)
		{
			var logEvent = _logEventHelper.GetLogEventByPropertyType(propertyType);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByOldValue(string oldValue)
		{
			var logEvent = _logEventHelper.GetLogEventByOldValue(oldValue);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByNewValue(string newValue)
		{
			var logEvent = _logEventHelper.GetLogEventByNewValue(newValue);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByErrorMessage(string errorMessage)
		{
			var logEvent = _logEventHelper.GetLogEventByErrorMessage(errorMessage);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO GetLogEventByStackTrace(string stackTrace)
		{
			var logEvent = _logEventHelper.GetLogEventByStackTrace(stackTrace);
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public LogEventDTO UpdateLogEvent(LogEventDTO entity)
		{
			var logEvent = _logEventHelper.UpdateLogEvent(_dtoMapper.MapDTOToLogEvent(entity));
			return _dtoMapper.MapLogEventToDTO(logEvent);
		}
		public int DeleteLogEventById(int id)
		{
			return _logEventHelper.DeleteLogEventById(id);
		}

    }
}



