using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceBuilderTest.Model;

namespace ServiceBuilderTest.Service.DTOs
{
	[DataContract]
    public class OrganizationPrivilegeDTO
    {        
		[DataMember]
        public int Id { get; set; }

		[DataMember]
        public int OrganizationId { get; set; }

		[DataMember]
        public int PrivilegeId { get; set; }

	}
}
