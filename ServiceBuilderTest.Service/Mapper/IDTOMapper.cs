using ServiceBuilderTest.Service.DTOs;
using ServiceBuilderTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceBuilderTest.Service
{
    public interface IDTOMapper
    {


		LogEventDTO MapLogEventToDTO(LogEvent logEvent);

		LogEvent MapDTOToLogEvent(LogEventDTO logEventDTO);

		GroupDTO MapGroupToDTO(Group group);

		Group MapDTOToGroup(GroupDTO groupDTO);

		UserPrivilegeDTO MapUserPrivilegeToDTO(UserPrivilege userPrivilege);

		UserPrivilege MapDTOToUserPrivilege(UserPrivilegeDTO userPrivilegeDTO);

		PrivilegeDTO MapPrivilegeToDTO(Privilege privilege);

		Privilege MapDTOToPrivilege(PrivilegeDTO privilegeDTO);

		GroupPrivilegeDTO MapGroupPrivilegeToDTO(GroupPrivilege groupPrivilege);

		GroupPrivilege MapDTOToGroupPrivilege(GroupPrivilegeDTO groupPrivilegeDTO);

		ApplicationDTO MapApplicationToDTO(Application application);

		Application MapDTOToApplication(ApplicationDTO applicationDTO);

		UserOrganizationDTO MapUserOrganizationToDTO(UserOrganization userOrganization);

		UserOrganization MapDTOToUserOrganization(UserOrganizationDTO userOrganizationDTO);

		OrganizationDTO MapOrganizationToDTO(Organization organization);

		Organization MapDTOToOrganization(OrganizationDTO organizationDTO);

		UserDTO MapUserToDTO(User user);

		User MapDTOToUser(UserDTO userDTO);

		OrganizationPrivilegeDTO MapOrganizationPrivilegeToDTO(OrganizationPrivilege organizationPrivilege);

		OrganizationPrivilege MapDTOToOrganizationPrivilege(OrganizationPrivilegeDTO organizationPrivilegeDTO);

		UserGroupDTO MapUserGroupToDTO(UserGroup userGroup);

		UserGroup MapDTOToUserGroup(UserGroupDTO userGroupDTO);


    }
}

