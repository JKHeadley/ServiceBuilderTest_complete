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
