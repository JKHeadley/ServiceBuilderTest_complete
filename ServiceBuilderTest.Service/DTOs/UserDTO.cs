using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceBuilderTest.Model;

namespace ServiceBuilderTest.Service.DTOs
{
	[DataContract]
    public class UserDTO
    {        
		[DataMember]
        public System.Guid Id { get; set; }

		[DataMember]
        public string Username { get; set; }

		[DataMember]
        public string Password { get; set; }

		[DataMember]
        public IEnumerable<UserOrganizationDTO> UserOrganizations { get; set; }

		[DataMember]
        public IEnumerable<UserGroupDTO> UserGroups { get; set; }

		[DataMember]
        public IEnumerable<UserPrivilegeDTO> UserPrivileges { get; set; }

	}
}
