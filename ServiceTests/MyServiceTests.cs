using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceTests.ServiceReference1;

namespace ServiceTests
{
    [TestClass]
    public class MyServiceTests
    {
        [TestMethod]
        public void TestSomeServiceCalls()
        {
            using (var svc = new ServiceClient())
            {
                //NOTE: Running this test twice will result in a duplicate error since two users can't have the same Id. This error
                //will be logged and can viewed in the LogEvent table as an error example.
                UserDTO rootUser = new UserDTO { Username = "rootUser", Id = Guid.Parse("86f0f79c-3ae9-4393-a437-f691f408135f") };
                svc.CreateUser(rootUser);
                OrganizationDTO org = new OrganizationDTO { Name = "MyOrg" };
                var createdOrg = svc.CreateOrganization(org);
                createdOrg.Name = "BobsOrg";
                var updatedOrg = svc.UpdateOrganization(createdOrg);
                int deleted = svc.DeleteOrganizationById(updatedOrg.Id);

                OrganizationDTO newOrg = new OrganizationDTO { Name = "NewOrg" };
                var createdNewOrg = svc.CreateOrganization(newOrg);
            }
        }
    }
}
