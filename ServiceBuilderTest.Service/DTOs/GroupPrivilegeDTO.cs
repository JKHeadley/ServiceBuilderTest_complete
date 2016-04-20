using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceBuilderTest.Model;

namespace ServiceBuilderTest.Service.DTOs
{
	[DataContract]
    public class GroupPrivilegeDTO
    {        
		[DataMember]
        public int Id { get; set; }

		[DataMember]
        public int GroupId { get; set; }

		[DataMember]
        public int PrivilegeId { get; set; }

	}
}
