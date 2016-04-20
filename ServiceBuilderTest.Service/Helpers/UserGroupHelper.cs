using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public class UserGroupHelper : IUserGroupHelper
    {
        internal IServiceBuilderTestRepository repo;

        public UserGroupHelper(IServiceBuilderTestRepository repo)
        {
            this.repo = repo;
        }
        
        #region CREATE

        /// <summary>
        /// Creates a/an UserGroup.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserGroup that was created in the database.</returns>
        public UserGroup CreateUserGroup(UserGroup entity)
        {
            try
            {
                return repo.Create<UserGroup>(entity);
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
        /// Gets a list of all UserGroups.
        /// </summary>
        /// <returns>Returns all the UserGroups in the database.</returns>
        public IEnumerable<UserGroup> GetUserGroups()
        {
            try
            {
                return repo.All<UserGroup>().AsEnumerable();
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an UserGroup by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserGroup that was found with matching Id.</returns>
        public UserGroup GetUserGroupById(int id)
        {
            try
            {
                return repo.Single<UserGroup>(e => e.Id == id);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an UserGroup by UserId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserGroup that was found with matching UserId.</returns>
        public UserGroup GetUserGroupByUserId(System.Guid userId)
        {
            try
            {
                return repo.Single<UserGroup>(e => e.UserId == userId);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an UserGroup by GroupId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserGroup that was found with matching GroupId.</returns>
        public UserGroup GetUserGroupByGroupId(int groupId)
        {
            try
            {
                return repo.Single<UserGroup>(e => e.GroupId == groupId);
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
        /// Updates a/an UserGroup.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the UserGroup that was updated in the database.</returns>
        public UserGroup UpdateUserGroup(UserGroup entity)
        {
            try
            {
                return repo.Update<UserGroup>(entity);
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
        /// Deletes a/an UserGroup.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        public int DeleteUserGroupById(int id)
        {
            try
            {
			    var entity = GetUserGroupById(id);
                return repo.Delete<UserGroup>(entity);
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
