	  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public interface IApplicationHelper
    {
        /// <summary>
        /// Creates a/an Application.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Application that was created in the database.</returns>
        Application CreateApplication(Application entity);
		

		/// <summary>
        /// Gets a list of all Applications.
        /// </summary>
        /// <returns>Returns all the Applications in the database.</returns>
        IEnumerable<Application> GetApplications();
		
        /// <summary>
        /// Gets a/an Application by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Application that was found with matching Id.</returns>
        Application GetApplicationById(int id);


        /// <summary>
        /// Gets a/an Application by Name.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Application that was found with matching Name.</returns>
        Application GetApplicationByName(string name);

		/// <summary>
        /// Updates a/an Application.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Application that was updated in the database.</returns>
        Application UpdateApplication(Application entity);
		
		/// <summary>
        /// Deletes a/an Application.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        int DeleteApplicationById(int id);
	}
}

