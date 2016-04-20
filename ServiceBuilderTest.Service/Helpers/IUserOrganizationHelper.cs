	  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public interface IUserOrganizationHelper
    {
        /// <summary>
        /// Creates a/an UserOrganization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserOrganization that was created in the database.</returns>
        UserOrganization CreateUserOrganization(UserOrganization entity);
		

		/// <summary>
        /// Gets a list of all UserOrganizations.
        /// </summary>
        /// <returns>Returns all the UserOrganizations in the database.</returns>
        IEnumerable<UserOrganization> GetUserOrganizations();
		
        /// <summary>
        /// Gets a/an UserOrganization by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserOrganization that was found with matching Id.</returns>
        UserOrganization GetUserOrganizationById(int id);


        /// <summary>
        /// Gets a/an UserOrganization by UserId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserOrganization that was found with matching UserId.</returns>
        UserOrganization GetUserOrganizationByUserId(System.Guid userId);


        /// <summary>
        /// Gets a/an UserOrganization by OrganizationId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserOrganization that was found with matching OrganizationId.</returns>
        UserOrganization GetUserOrganizationByOrganizationId(int organizationId);

		/// <summary>
        /// Updates a/an UserOrganization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserOrganization that was updated in the database.</returns>
        UserOrganization UpdateUserOrganization(UserOrganization entity);
		
		/// <summary>
        /// Deletes a/an UserOrganization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        int DeleteUserOrganizationById(int id);
	}
}

