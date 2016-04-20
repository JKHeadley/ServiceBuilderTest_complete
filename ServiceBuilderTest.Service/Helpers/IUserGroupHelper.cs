	  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public interface IUserGroupHelper
    {
        /// <summary>
        /// Creates a/an UserGroup.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserGroup that was created in the database.</returns>
        UserGroup CreateUserGroup(UserGroup entity);
		

		/// <summary>
        /// Gets a list of all UserGroups.
        /// </summary>
        /// <returns>Returns all the UserGroups in the database.</returns>
        IEnumerable<UserGroup> GetUserGroups();
		
        /// <summary>
        /// Gets a/an UserGroup by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserGroup that was found with matching Id.</returns>
        UserGroup GetUserGroupById(int id);


        /// <summary>
        /// Gets a/an UserGroup by UserId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserGroup that was found with matching UserId.</returns>
        UserGroup GetUserGroupByUserId(System.Guid userId);


        /// <summary>
        /// Gets a/an UserGroup by GroupId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserGroup that was found with matching GroupId.</returns>
        UserGroup GetUserGroupByGroupId(int groupId);

		/// <summary>
        /// Updates a/an UserGroup.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserGroup that was updated in the database.</returns>
        UserGroup UpdateUserGroup(UserGroup entity);
		
		/// <summary>
        /// Deletes a/an UserGroup.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        int DeleteUserGroupById(int id);
	}
}

