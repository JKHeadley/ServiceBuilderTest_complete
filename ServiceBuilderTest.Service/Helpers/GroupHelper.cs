using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public class GroupHelper : IGroupHelper
    {
        internal IServiceBuilderTestRepository repo;

        public GroupHelper(IServiceBuilderTestRepository repo)
        {
            this.repo = repo;
        }
        
        #region CREATE

        /// <summary>
        /// Creates a/an Group.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was created in the database.</returns>
        public Group CreateGroup(Group entity)
        {
            try
            {
                return repo.Create<Group>(entity);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }
		
		#endregion

		#region GET

		/// <summary>
        /// Gets a list of all Groups.
        /// </summary>
        /// <returns>Returns all the Groups in the database.</returns>
        public IEnumerable<Group> GetGroups()
        {
            try
            {
                return repo.All<Group>().AsEnumerable();
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Group by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was found with matching Id.</returns>
        public Group GetGroupById(int id)
        {
            try
            {
                return repo.Single<Group>(e => e.Id == id);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Group by Name.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was found with matching Name.</returns>
        public Group GetGroupByName(string name)
        {
            try
            {
                return repo.Single<Group>(e => e.Name == name);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Group by ParentOrganizationId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was found with matching ParentOrganizationId.</returns>
        public Group GetGroupByParentOrganizationId(int parentOrganizationId)
        {
            try
            {
                return repo.Single<Group>(e => e.ParentOrganizationId == parentOrganizationId);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Group by ParentOrganization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was found with matching ParentOrganization.</returns>
        public Group GetGroupByParentOrganization(ServiceBuilderTest.Model.Organization parentOrganization)
        {
            try
            {
                return repo.Single<Group>(e => e.ParentOrganization == parentOrganization);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


		#endregion
		
		#region UPDATE

        /// <summary>
        /// Updates a/an Group.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Group that was updated in the database.</returns>
        public Group UpdateGroup(Group entity)
        {
            try
            {
                return repo.Update<Group>(entity);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }

		#endregion
		
		#region DELETE

        /// <summary>
        /// Deletes a/an Group.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        public int DeleteGroupById(int id)
        {
            try
            {
			    var entity = GetGroupById(id);
                return repo.Delete<Group>(entity);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }

		#endregion
	}
}
