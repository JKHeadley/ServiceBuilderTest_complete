using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceBuilderTest.Model;

namespace ServiceBuilderTest.Service.DTOs
{
	[DataContract]
    public class OrganizationDTO
    {        
		[DataMember]
        public int Id { get; set; }

		[DataMember]
        public string Name { get; set; }

		[DataMember]
        public IEnumerable<GroupDTO> Groups { get; set; }

		[DataMember]
        public IEnumerable<OrganizationPrivilegeDTO> OrganizationPrivileges { get; set; }

		[DataMember]
        public IEnumerable<UserOrganizationDTO> UserOrganizations { get; set; }

	}
}
