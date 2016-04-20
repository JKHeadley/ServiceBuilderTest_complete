using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ServiceBuilderTest.Repository
{
    class LoggingConfiguration_PrimaryKeys : ConfigurationSection
    {
        private static LoggingConfiguration_PrimaryKeys instance = null;
        private static object syncObject = new object();

        public static LoggingConfiguration_PrimaryKeys Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (instance == null)
                    {
                        instance = (LoggingConfiguration_PrimaryKeys)ConfigurationManager.GetSection("LoggingConfiguration_PrimaryKeys");
                    }
                }
                return instance;
            }
        }

		[ConfigurationProperty("Application", IsRequired = true)]
		public string Application
		{
			get { return this["Application"].ToString(); }
		}

		[ConfigurationProperty("Privilege", IsRequired = true)]
		public string Privilege
		{
			get { return this["Privilege"].ToString(); }
		}

		[ConfigurationProperty("GroupPrivilege", IsRequired = true)]
		public string GroupPrivilege
		{
			get { return this["GroupPrivilege"].ToString(); }
		}

		[ConfigurationProperty("OrganizationPrivilege", IsRequired = true)]
		public string OrganizationPrivilege
		{
			get { return this["OrganizationPrivilege"].ToString(); }
		}

		[ConfigurationProperty("UserPrivilege", IsRequired = true)]
		public string UserPrivilege
		{
			get { return this["UserPrivilege"].ToString(); }
		}

		[ConfigurationProperty("Group", IsRequired = true)]
		public string Group
		{
			get { return this["Group"].ToString(); }
		}

		[ConfigurationProperty("Organization", IsRequired = true)]
		public string Organization
		{
			get { return this["Organization"].ToString(); }
		}

		[ConfigurationProperty("UserOrganization", IsRequired = true)]
		public string UserOrganization
		{
			get { return this["UserOrganization"].ToString(); }
		}

		[ConfigurationProperty("UserGroup", IsRequired = true)]
		public string UserGroup
		{
			get { return this["UserGroup"].ToString(); }
		}

		[ConfigurationProperty("User", IsRequired = true)]
		public string User
		{
			get { return this["User"].ToString(); }
		}

		[ConfigurationProperty("__MigrationHistory", IsRequired = true)]
		public string __MigrationHistory
		{
			get { return this["__MigrationHistory"].ToString(); }
		}

		    }
}


