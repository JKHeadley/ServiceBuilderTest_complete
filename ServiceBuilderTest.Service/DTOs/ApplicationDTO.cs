using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceBuilderTest.Model;

namespace ServiceBuilderTest.Service.DTOs
{
	[DataContract]
    public class ApplicationDTO
    {        
		[DataMember]
        public int Id { get; set; }

		[DataMember]
        public string Name { get; set; }

		[DataMember]
        public IEnumerable<PrivilegeDTO> Privileges { get; set; }

	}
}
