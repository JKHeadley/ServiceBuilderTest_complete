	  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public interface IOrganizationHelper
    {
        /// <summary>
        /// Creates a/an Organization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Organization that was created in the database.</returns>
        Organization CreateOrganization(Organization entity);
		

		/// <summary>
        /// Gets a list of all Organizations.
        /// </summary>
        /// <returns>Returns all the Organizations in the database.</returns>
        IEnumerable<Organization> GetOrganizations();
		
        /// <summary>
        /// Gets a/an Organization by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Organization that was found with matching Id.</returns>
        Organization GetOrganizationById(int id);


        /// <summary>
        /// Gets a/an Organization by Name.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Organization that was found with matching Name.</returns>
        Organization GetOrganizationByName(string name);

		/// <summary>
        /// Updates a/an Organization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Organization that was updated in the database.</returns>
        Organization UpdateOrganization(Organization entity);
		
		/// <summary>
        /// Deletes a/an Organization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        int DeleteOrganizationById(int id);
	}
}

