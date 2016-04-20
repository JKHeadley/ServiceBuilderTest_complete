using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ServiceBuilderTest.Repository
{
    class LoggingConfiguration_User : ConfigurationSection
    {
        private static LoggingConfiguration_User instance = null;
        private static object syncObject = new object();

        public static LoggingConfiguration_User Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (instance == null)
                    {
                        instance = (LoggingConfiguration_User)ConfigurationManager.GetSection("LoggingConfiguration_User");
                    }
                }
                return instance;
            }
        }

		[ConfigurationProperty("Id", IsRequired = true)]
        public string Id
        {
            get { return this["Id"].ToString(); }
        }

        [ConfigurationProperty("UserTypeFullName", IsRequired = true)]
        public string UserTypeFullName
        {
            get { return this["UserTypeFullName"].ToString(); }
        }

        [ConfigurationProperty("UserTypeAssemblyName", IsRequired = true)]
        public string UserTypeAssemblyName
        {
            get { return this["UserTypeAssemblyName"].ToString(); }
        }

        [ConfigurationProperty("UserName", IsRequired = true)]
        public string UserName
        {
            get { return this["UserName"].ToString(); }
        }
    }
}


