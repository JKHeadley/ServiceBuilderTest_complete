	  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public interface IGroupHelper
    {
        /// <summary>
        /// Creates a/an Group.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was created in the database.</returns>
        Group CreateGroup(Group entity);
		

		/// <summary>
        /// Gets a list of all Groups.
        /// </summary>
        /// <returns>Returns all the Groups in the database.</returns>
        IEnumerable<Group> GetGroups();
		
        /// <summary>
        /// Gets a/an Group by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was found with matching Id.</returns>
        Group GetGroupById(int id);


        /// <summary>
        /// Gets a/an Group by Name.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was found with matching Name.</returns>
        Group GetGroupByName(string name);


        /// <summary>
        /// Gets a/an Group by ParentOrganizationId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was found with matching ParentOrganizationId.</returns>
        Group GetGroupByParentOrganizationId(int parentOrganizationId);


        /// <summary>
        /// Gets a/an Group by ParentOrganization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was found with matching ParentOrganization.</returns>
        Group GetGroupByParentOrganization(ServiceBuilderTest.Model.Organization parentOrganization);

		/// <summary>
        /// Updates a/an Group.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was updated in the database.</returns>
        Group UpdateGroup(Group entity);
		
		/// <summary>
        /// Deletes a/an Group.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        int DeleteGroupById(int id);
	}
}

