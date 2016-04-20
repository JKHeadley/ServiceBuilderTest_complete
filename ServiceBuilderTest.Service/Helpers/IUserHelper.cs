	  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public interface IUserHelper
    {
        /// <summary>
        /// Creates a/an User.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the User that was created in the database.</returns>
        User CreateUser(User entity);
		

		/// <summary>
        /// Gets a list of all Users.
        /// </summary>
        /// <returns>Returns all the Users in the database.</returns>
        IEnumerable<User> GetUsers();
		
        /// <summary>
        /// Gets a/an User by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the User that was found with matching Id.</returns>
        User GetUserById(System.Guid id);


        /// <summary>
        /// Gets a/an User by Username.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the User that was found with matching Username.</returns>
        User GetUserByUsername(string username);


        /// <summary>
        /// Gets a/an User by Password.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the User that was found with matching Password.</returns>
        User GetUserByPassword(string password);

		/// <summary>
        /// Updates a/an User.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the User that was updated in the database.</returns>
        User UpdateUser(User entity);
		
		/// <summary>
        /// Deletes a/an User.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        int DeleteUserById(System.Guid id);
	}
}

