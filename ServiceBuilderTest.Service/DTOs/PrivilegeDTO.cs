using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceBuilderTest.Model;

namespace ServiceBuilderTest.Service.DTOs
{
	[DataContract]
    public class PrivilegeDTO
    {        
		[DataMember]
        public int Id { get; set; }

		[DataMember]
        public string Name { get; set; }

		[DataMember]
        public int ApplicationId { get; set; }

		[DataMember]
        public ApplicationDTO Application { get; set; }

		[DataMember]
        public IEnumerable<UserPrivilegeDTO> UserPrivileges { get; set; }

		[DataMember]
        public IEnumerable<OrganizationPrivilegeDTO> OrganizationPrivileges { get; set; }

		[DataMember]
        public IEnumerable<GroupPrivilegeDTO> GroupPrivileges { get; set; }

	}
}
