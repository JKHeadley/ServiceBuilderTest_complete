	  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public interface IOrganizationPrivilegeHelper
    {
        /// <summary>
        /// Creates a/an OrganizationPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the OrganizationPrivilege that was created in the database.</returns>
        OrganizationPrivilege CreateOrganizationPrivilege(OrganizationPrivilege entity);
		

		/// <summary>
        /// Gets a list of all OrganizationPrivileges.
        /// </summary>
        /// <returns>Returns all the OrganizationPrivileges in the database.</returns>
        IEnumerable<OrganizationPrivilege> GetOrganizationPrivileges();
		
        /// <summary>
        /// Gets a/an OrganizationPrivilege by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the OrganizationPrivilege that was found with matching Id.</returns>
        OrganizationPrivilege GetOrganizationPrivilegeById(int id);


        /// <summary>
        /// Gets a/an OrganizationPrivilege by OrganizationId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the OrganizationPrivilege that was found with matching OrganizationId.</returns>
        OrganizationPrivilege GetOrganizationPrivilegeByOrganizationId(int organizationId);


        /// <summary>
        /// Gets a/an OrganizationPrivilege by PrivilegeId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the OrganizationPrivilege that was found with matching PrivilegeId.</returns>
        OrganizationPrivilege GetOrganizationPrivilegeByPrivilegeId(int privilegeId);

		/// <summary>
        /// Updates a/an OrganizationPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the OrganizationPrivilege that was updated in the database.</returns>
        OrganizationPrivilege UpdateOrganizationPrivilege(OrganizationPrivilege entity);
		
		/// <summary>
        /// Deletes a/an OrganizationPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        int DeleteOrganizationPrivilegeById(int id);
	}
}

