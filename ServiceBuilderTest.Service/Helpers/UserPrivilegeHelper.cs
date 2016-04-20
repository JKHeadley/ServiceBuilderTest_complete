using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public class UserPrivilegeHelper : IUserPrivilegeHelper
    {
        internal IServiceBuilderTestRepository repo;

        public UserPrivilegeHelper(IServiceBuilderTestRepository repo)
        {
            this.repo = repo;
        }
        
        #region CREATE

        /// <summary>
        /// Creates a/an UserPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserPrivilege that was created in the database.</returns>
        public UserPrivilege CreateUserPrivilege(UserPrivilege entity)
        {
            try
            {
                return repo.Create<UserPrivilege>(entity);
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
        /// Gets a list of all UserPrivileges.
        /// </summary>
        /// <returns>Returns all the UserPrivileges in the database.</returns>
        public IEnumerable<UserPrivilege> GetUserPrivileges()
        {
            try
            {
                return repo.All<UserPrivilege>().AsEnumerable();
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an UserPrivilege by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserPrivilege that was found with matching Id.</returns>
        public UserPrivilege GetUserPrivilegeById(int id)
        {
            try
            {
                return repo.Single<UserPrivilege>(e => e.Id == id);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an UserPrivilege by UserId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserPrivilege that was found with matching UserId.</returns>
        public UserPrivilege GetUserPrivilegeByUserId(System.Guid userId)
        {
            try
            {
                return repo.Single<UserPrivilege>(e => e.UserId == userId);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an UserPrivilege by PrivilegeId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserPrivilege that was found with matching PrivilegeId.</returns>
        public UserPrivilege GetUserPrivilegeByPrivilegeId(int privilegeId)
        {
            try
            {
                return repo.Single<UserPrivilege>(e => e.PrivilegeId == privilegeId);
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
        /// Updates a/an UserPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserPrivilege that was updated in the database.</returns>
        public UserPrivilege UpdateUserPrivilege(UserPrivilege entity)
        {
            try
            {
                return repo.Update<UserPrivilege>(entity);
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
        /// Deletes a/an UserPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        public int DeleteUserPrivilegeById(int id)
        {
            try
            {
			    var entity = GetUserPrivilegeById(id);
                return repo.Delete<UserPrivilege>(entity);
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
