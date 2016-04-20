using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public class UserOrganizationHelper : IUserOrganizationHelper
    {
        internal IServiceBuilderTestRepository repo;

        public UserOrganizationHelper(IServiceBuilderTestRepository repo)
        {
            this.repo = repo;
        }
        
        #region CREATE

        /// <summary>
        /// Creates a/an UserOrganization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserOrganization that was created in the database.</returns>
        public UserOrganization CreateUserOrganization(UserOrganization entity)
        {
            try
            {
                return repo.Create<UserOrganization>(entity);
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
        /// Gets a list of all UserOrganizations.
        /// </summary>
        /// <returns>Returns all the UserOrganizations in the database.</returns>
        public IEnumerable<UserOrganization> GetUserOrganizations()
        {
            try
            {
                return repo.All<UserOrganization>().AsEnumerable();
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an UserOrganization by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserOrganization that was found with matching Id.</returns>
        public UserOrganization GetUserOrganizationById(int id)
        {
            try
            {
                return repo.Single<UserOrganization>(e => e.Id == id);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an UserOrganization by UserId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserOrganization that was found with matching UserId.</returns>
        public UserOrganization GetUserOrganizationByUserId(System.Guid userId)
        {
            try
            {
                return repo.Single<UserOrganization>(e => e.UserId == userId);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an UserOrganization by OrganizationId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserOrganization that was found with matching OrganizationId.</returns>
        public UserOrganization GetUserOrganizationByOrganizationId(int organizationId)
        {
            try
            {
                return repo.Single<UserOrganization>(e => e.OrganizationId == organizationId);
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
        /// Updates a/an UserOrganization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserOrganization that was updated in the database.</returns>
        public UserOrganization UpdateUserOrganization(UserOrganization entity)
        {
            try
            {
                return repo.Update<UserOrganization>(entity);
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
        /// Deletes a/an UserOrganization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        public int DeleteUserOrganizationById(int id)
        {
            try
            {
			    var entity = GetUserOrganizationById(id);
                return repo.Delete<UserOrganization>(entity);
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
