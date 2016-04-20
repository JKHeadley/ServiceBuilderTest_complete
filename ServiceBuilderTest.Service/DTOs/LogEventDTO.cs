using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceBuilderTest.Model;

namespace ServiceBuilderTest.Service.DTOs
{
	[DataContract]
    public class LogEventDTO
    {        
		[DataMember]
        public int Id { get; set; }

		[DataMember]
        public string LogEventType { get; set; }

		[DataMember]
        public string EntityType { get; set; }

		[DataMember]
        public string EntityId { get; set; }

		[DataMember]
        public string ChangedByUserId { get; set; }

		[DataMember]
        public string ChangedByUserName { get; set; }

		[DataMember]
        public System.DateTime Date { get; set; }

		[DataMember]
        public string PropertyName { get; set; }

		[DataMember]
        public string PropertyType { get; set; }

		[DataMember]
        public string OldValue { get; set; }

		[DataMember]
        public string NewValue { get; set; }

		[DataMember]
        public string ErrorMessage { get; set; }

		[DataMember]
        public string StackTrace { get; set; }

	}
}
