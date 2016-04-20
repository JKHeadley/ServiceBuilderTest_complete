using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public class UserHelper : IUserHelper
    {
        internal IServiceBuilderTestRepository repo;

        public UserHelper(IServiceBuilderTestRepository repo)
        {
            this.repo = repo;
        }
        
        #region CREATE

        /// <summary>
        /// Creates a/an User.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the User that was created in the database.</returns>
        public User CreateUser(User entity)
        {
            try
            {
                return repo.Create<User>(entity);
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
        /// Gets a list of all Users.
        /// </summary>
        /// <returns>Returns all the Users in the database.</returns>
        public IEnumerable<User> GetUsers()
        {
            try
            {
                return repo.All<User>().AsEnumerable();
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an User by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the User that was found with matching Id.</returns>
        public User GetUserById(System.Guid id)
        {
            try
            {
                return repo.Single<User>(e => e.Id == id);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an User by Username.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the User that was found with matching Username.</returns>
        public User GetUserByUsername(string username)
        {
            try
            {
                return repo.Single<User>(e => e.Username == username);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an User by Password.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the User that was found with matching Password.</returns>
        public User GetUserByPassword(string password)
        {
            try
            {
                return repo.Single<User>(e => e.Password == password);
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
        /// Updates a/an User.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the User that was updated in the database.</returns>
        public User UpdateUser(User entity)
        {
            try
            {
                return repo.Update<User>(entity);
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
        /// Deletes a/an User.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        public int DeleteUserById(System.Guid id)
        {
            try
            {
			    var entity = GetUserById(id);
                return repo.Delete<User>(entity);
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
