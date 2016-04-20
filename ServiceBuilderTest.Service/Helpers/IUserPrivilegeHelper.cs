	  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public interface IUserPrivilegeHelper
    {
        /// <summary>
        /// Creates a/an UserPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserPrivilege that was created in the database.</returns>
        UserPrivilege CreateUserPrivilege(UserPrivilege entity);
		

		/// <summary>
        /// Gets a list of all UserPrivileges.
        /// </summary>
        /// <returns>Returns all the UserPrivileges in the database.</returns>
        IEnumerable<UserPrivilege> GetUserPrivileges();
		
        /// <summary>
        /// Gets a/an UserPrivilege by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserPrivilege that was found with matching Id.</returns>
        UserPrivilege GetUserPrivilegeById(int id);


        /// <summary>
        /// Gets a/an UserPrivilege by UserId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserPrivilege that was found with matching UserId.</returns>
        UserPrivilege GetUserPrivilegeByUserId(System.Guid userId);


        /// <summary>
        /// Gets a/an UserPrivilege by PrivilegeId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserPrivilege that was found with matching PrivilegeId.</returns>
        UserPrivilege GetUserPrivilegeByPrivilegeId(int privilegeId);

		/// <summary>
        /// Updates a/an UserPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserPrivilege that was updated in the database.</returns>
        UserPrivilege UpdateUserPrivilege(UserPrivilege entity);
		
		/// <summary>
        /// Deletes a/an UserPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        int DeleteUserPrivilegeById(int id);
	}
}

