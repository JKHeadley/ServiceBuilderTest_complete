using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceBuilderTest.Model;

namespace ServiceBuilderTest.Service.DTOs
{
	[DataContract]
    public class UserGroupDTO
    {        
		[DataMember]
        public int Id { get; set; }

		[DataMember]
        public System.Guid UserId { get; set; }

		[DataMember]
        public int GroupId { get; set; }

	}
}
