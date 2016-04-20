	  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public interface IGroupPrivilegeHelper
    {
        /// <summary>
        /// Creates a/an GroupPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the GroupPrivilege that was created in the database.</returns>
        GroupPrivilege CreateGroupPrivilege(GroupPrivilege entity);
		

		/// <summary>
        /// Gets a list of all GroupPrivileges.
        /// </summary>
        /// <returns>Returns all the GroupPrivileges in the database.</returns>
        IEnumerable<GroupPrivilege> GetGroupPrivileges();
		
        /// <summary>
        /// Gets a/an GroupPrivilege by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the GroupPrivilege that was found with matching Id.</returns>
        GroupPrivilege GetGroupPrivilegeById(int id);


        /// <summary>
        /// Gets a/an GroupPrivilege by GroupId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the GroupPrivilege that was found with matching GroupId.</returns>
        GroupPrivilege GetGroupPrivilegeByGroupId(int groupId);


        /// <summary>
        /// Gets a/an GroupPrivilege by PrivilegeId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the GroupPrivilege that was found with matching PrivilegeId.</returns>
        GroupPrivilege GetGroupPrivilegeByPrivilegeId(int privilegeId);

		/// <summary>
        /// Updates a/an GroupPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the GroupPrivilege that was updated in the database.</returns>
        GroupPrivilege UpdateGroupPrivilege(GroupPrivilege entity);
		
		/// <summary>
        /// Deletes a/an GroupPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        int DeleteGroupPrivilegeById(int id);
	}
}

