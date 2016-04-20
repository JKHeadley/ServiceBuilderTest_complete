	  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public interface IPrivilegeHelper
    {
        /// <summary>
        /// Creates a/an Privilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was created in the database.</returns>
        Privilege CreatePrivilege(Privilege entity);
		

		/// <summary>
        /// Gets a list of all Privileges.
        /// </summary>
        /// <returns>Returns all the Privileges in the database.</returns>
        IEnumerable<Privilege> GetPrivileges();
		
        /// <summary>
        /// Gets a/an Privilege by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was found with matching Id.</returns>
        Privilege GetPrivilegeById(int id);


        /// <summary>
        /// Gets a/an Privilege by Name.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was found with matching Name.</returns>
        Privilege GetPrivilegeByName(string name);


        /// <summary>
        /// Gets a/an Privilege by ApplicationId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was found with matching ApplicationId.</returns>
        Privilege GetPrivilegeByApplicationId(int applicationId);


        /// <summary>
        /// Gets a/an Privilege by Application.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was found with matching Application.</returns>
        Privilege GetPrivilegeByApplication(ServiceBuilderTest.Model.Application application);

		/// <summary>
        /// Updates a/an Privilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was updated in the database.</returns>
        Privilege UpdatePrivilege(Privilege entity);
		
		/// <summary>
        /// Deletes a/an Privilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        int DeletePrivilegeById(int id);
	}
}

