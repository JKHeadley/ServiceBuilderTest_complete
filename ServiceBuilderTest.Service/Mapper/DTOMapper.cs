using ServiceBuilderTest.Service.DTOs;
using ServiceBuilderTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceBuilderTest.Service
{
    public class DTOMapper : IDTOMapper
    {
        public DTOMapper()
        {
			AutoMapper.Mapper.CreateMap<LogEvent, LogEventDTO>();
			AutoMapper.Mapper.CreateMap<LogEventDTO, LogEvent>();
			AutoMapper.Mapper.CreateMap<Group, GroupDTO>();
			AutoMapper.Mapper.CreateMap<GroupDTO, Group>();
			AutoMapper.Mapper.CreateMap<UserPrivilege, UserPrivilegeDTO>();
			AutoMapper.Mapper.CreateMap<UserPrivilegeDTO, UserPrivilege>();
			AutoMapper.Mapper.CreateMap<Privilege, PrivilegeDTO>();
			AutoMapper.Mapper.CreateMap<PrivilegeDTO, Privilege>();
			AutoMapper.Mapper.CreateMap<GroupPrivilege, GroupPrivilegeDTO>();
			AutoMapper.Mapper.CreateMap<GroupPrivilegeDTO, GroupPrivilege>();
			AutoMapper.Mapper.CreateMap<Application, ApplicationDTO>();
			AutoMapper.Mapper.CreateMap<ApplicationDTO, Application>();
			AutoMapper.Mapper.CreateMap<UserOrganization, UserOrganizationDTO>();
			AutoMapper.Mapper.CreateMap<UserOrganizationDTO, UserOrganization>();
			AutoMapper.Mapper.CreateMap<Organization, OrganizationDTO>();
			AutoMapper.Mapper.CreateMap<OrganizationDTO, Organization>();
			AutoMapper.Mapper.CreateMap<User, UserDTO>();
			AutoMapper.Mapper.CreateMap<UserDTO, User>();
			AutoMapper.Mapper.CreateMap<OrganizationPrivilege, OrganizationPrivilegeDTO>();
			AutoMapper.Mapper.CreateMap<OrganizationPrivilegeDTO, OrganizationPrivilege>();
			AutoMapper.Mapper.CreateMap<UserGroup, UserGroupDTO>();
			AutoMapper.Mapper.CreateMap<UserGroupDTO, UserGroup>();
        }


		public LogEventDTO MapLogEventToDTO(LogEvent logEvent)
		{
			var mappedDTO = AutoMapper.Mapper.Map<LogEventDTO>(logEvent);
			return mappedDTO;
		}

		public LogEvent MapDTOToLogEvent(LogEventDTO logEventDTO)
		{
			var mappedLogEvent = AutoMapper.Mapper.Map<LogEvent>(logEventDTO);
			return mappedLogEvent;
		}

		public GroupDTO MapGroupToDTO(Group group)
		{
			var mappedDTO = AutoMapper.Mapper.Map<GroupDTO>(group);
			return mappedDTO;
		}

		public Group MapDTOToGroup(GroupDTO groupDTO)
		{
			var mappedGroup = AutoMapper.Mapper.Map<Group>(groupDTO);
			return mappedGroup;
		}

		public UserPrivilegeDTO MapUserPrivilegeToDTO(UserPrivilege userPrivilege)
		{
			var mappedDTO = AutoMapper.Mapper.Map<UserPrivilegeDTO>(userPrivilege);
			return mappedDTO;
		}

		public UserPrivilege MapDTOToUserPrivilege(UserPrivilegeDTO userPrivilegeDTO)
		{
			var mappedUserPrivilege = AutoMapper.Mapper.Map<UserPrivilege>(userPrivilegeDTO);
			return mappedUserPrivilege;
		}

		public PrivilegeDTO MapPrivilegeToDTO(Privilege privilege)
		{
			var mappedDTO = AutoMapper.Mapper.Map<PrivilegeDTO>(privilege);
			return mappedDTO;
		}

		public Privilege MapDTOToPrivilege(PrivilegeDTO privilegeDTO)
		{
			var mappedPrivilege = AutoMapper.Mapper.Map<Privilege>(privilegeDTO);
			return mappedPrivilege;
		}

		public GroupPrivilegeDTO MapGroupPrivilegeToDTO(GroupPrivilege groupPrivilege)
		{
			var mappedDTO = AutoMapper.Mapper.Map<GroupPrivilegeDTO>(groupPrivilege);
			return mappedDTO;
		}

		public GroupPrivilege MapDTOToGroupPrivilege(GroupPrivilegeDTO groupPrivilegeDTO)
		{
			var mappedGroupPrivilege = AutoMapper.Mapper.Map<GroupPrivilege>(groupPrivilegeDTO);
			return mappedGroupPrivilege;
		}

		public ApplicationDTO MapApplicationToDTO(Application application)
		{
			var mappedDTO = AutoMapper.Mapper.Map<ApplicationDTO>(application);
			return mappedDTO;
		}

		public Application MapDTOToApplication(ApplicationDTO applicationDTO)
		{
			var mappedApplication = AutoMapper.Mapper.Map<Application>(applicationDTO);
			return mappedApplication;
		}

		public UserOrganizationDTO MapUserOrganizationToDTO(UserOrganization userOrganization)
		{
			var mappedDTO = AutoMapper.Mapper.Map<UserOrganizationDTO>(userOrganization);
			return mappedDTO;
		}

		public UserOrganization MapDTOToUserOrganization(UserOrganizationDTO userOrganizationDTO)
		{
			var mappedUserOrganization = AutoMapper.Mapper.Map<UserOrganization>(userOrganizationDTO);
			return mappedUserOrganization;
		}

		public OrganizationDTO MapOrganizationToDTO(Organization organization)
		{
			var mappedDTO = AutoMapper.Mapper.Map<OrganizationDTO>(organization);
			return mappedDTO;
		}

		public Organization MapDTOToOrganization(OrganizationDTO organizationDTO)
		{
			var mappedOrganization = AutoMapper.Mapper.Map<Organization>(organizationDTO);
			return mappedOrganization;
		}

		public UserDTO MapUserToDTO(User user)
		{
			var mappedDTO = AutoMapper.Mapper.Map<UserDTO>(user);
			return mappedDTO;
		}

		public User MapDTOToUser(UserDTO userDTO)
		{
			var mappedUser = AutoMapper.Mapper.Map<User>(userDTO);
			return mappedUser;
		}

		public OrganizationPrivilegeDTO MapOrganizationPrivilegeToDTO(OrganizationPrivilege organizationPrivilege)
		{
			var mappedDTO = AutoMapper.Mapper.Map<OrganizationPrivilegeDTO>(organizationPrivilege);
			return mappedDTO;
		}

		public OrganizationPrivilege MapDTOToOrganizationPrivilege(OrganizationPrivilegeDTO organizationPrivilegeDTO)
		{
			var mappedOrganizationPrivilege = AutoMapper.Mapper.Map<OrganizationPrivilege>(organizationPrivilegeDTO);
			return mappedOrganizationPrivilege;
		}

		public UserGroupDTO MapUserGroupToDTO(UserGroup userGroup)
		{
			var mappedDTO = AutoMapper.Mapper.Map<UserGroupDTO>(userGroup);
			return mappedDTO;
		}

		public UserGroup MapDTOToUserGroup(UserGroupDTO userGroupDTO)
		{
			var mappedUserGroup = AutoMapper.Mapper.Map<UserGroup>(userGroupDTO);
			return mappedUserGroup;
		}


    }
}

