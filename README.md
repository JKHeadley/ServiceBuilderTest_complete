# ServiceBuilderTest
A test/example project for the Entity Framework ServiceBuilder tool: https://github.com/JKHeadley/ServiceBuilder

The ServiceBuilderTest model represents an application privileges framework in which users, groups, and organizations can be assigned privileges specific to individual applications. 

# Instructions:
- Build the 'ServiceBuilderTest.Model' project
- run `Enable-Migrations` in the Package Manage Console (PMC)
- run `Add-Migration init` in the PMC
- run `Update-Database` in the PMC
- Follow the instructions to install the ServiceBuilder: [https://github.com/JKHeadley/ServiceBuilder]
- Right click the "ServiceBuilderTest.Service" project and select "Debug->Start New Instance"
- Once the service is running, stop the debugger in VS
- In the "ServiceTests" project, right click "Service References" and select "Add Service Reference..."
- Click "Discover", select the service you just started, and click "OK"
- In VS, click "Test->Run->All Tests"
- If the test succeeds, then everything is working, congrats!

You should now be able to inspect your database to see the changes (I use Microsoft SQL Server Managment Studio 2012).  If you view the "Organization" table you should see one "NewOrg" entity, and if you view the "LogEvents" table you should see all the CRUD events that were logged during the test.
