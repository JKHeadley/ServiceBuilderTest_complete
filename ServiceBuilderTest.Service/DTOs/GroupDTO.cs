using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceBuilderTest.Model;

namespace ServiceBuilderTest.Service.DTOs
{
	[DataContract]
    public class GroupDTO
    {        
		[DataMember]
        public int Id { get; set; }

		[DataMember]
        public string Name { get; set; }

		[DataMember]
        public int ParentOrganizationId { get; set; }

		[DataMember]
        public OrganizationDTO ParentOrganization { get; set; }

		[DataMember]
        public IEnumerable<UserGroupDTO> UserGroups { get; set; }

		[DataMember]
        public IEnumerable<GroupPrivilegeDTO> GroupPrivileges { get; set; }

	}
}
