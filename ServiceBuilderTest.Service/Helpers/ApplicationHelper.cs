using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public class ApplicationHelper : IApplicationHelper
    {
        internal IServiceBuilderTestRepository repo;

        public ApplicationHelper(IServiceBuilderTestRepository repo)
        {
            this.repo = repo;
        }
        
        #region CREATE

        /// <summary>
        /// Creates a/an Application.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Application that was created in the database.</returns>
        public Application CreateApplication(Application entity)
        {
            try
            {
                return repo.Create<Application>(entity);
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
        /// Gets a list of all Applications.
        /// </summary>
        /// <returns>Returns all the Applications in the database.</returns>
        public IEnumerable<Application> GetApplications()
        {
            try
            {
                return repo.All<Application>().AsEnumerable();
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Application by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Application that was found with matching Id.</returns>
        public Application GetApplicationById(int id)
        {
            try
            {
                return repo.Single<Application>(e => e.Id == id);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Application by Name.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Application that was found with matching Name.</returns>
        public Application GetApplicationByName(string name)
        {
            try
            {
                return repo.Single<Application>(e => e.Name == name);
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
        /// Updates a/an Application.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Application that was updated in the database.</returns>
        public Application UpdateApplication(Application entity)
        {
            try
            {
                return repo.Update<Application>(entity);
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
        /// Deletes a/an Application.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        public int DeleteApplicationById(int id)
        {
            try
            {
			    var entity = GetApplicationById(id);
                return repo.Delete<Application>(entity);
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
