using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public class OrganizationHelper : IOrganizationHelper
    {
        internal IServiceBuilderTestRepository repo;

        public OrganizationHelper(IServiceBuilderTestRepository repo)
        {
            this.repo = repo;
        }
        
        #region CREATE

        /// <summary>
        /// Creates a/an Organization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Organization that was created in the database.</returns>
        public Organization CreateOrganization(Organization entity)
        {
            try
            {
                return repo.Create<Organization>(entity);
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
        /// Gets a list of all Organizations.
        /// </summary>
        /// <returns>Returns all the Organizations in the database.</returns>
        public IEnumerable<Organization> GetOrganizations()
        {
            try
            {
                return repo.All<Organization>().AsEnumerable();
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Organization by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Organization that was found with matching Id.</returns>
        public Organization GetOrganizationById(int id)
        {
            try
            {
                return repo.Single<Organization>(e => e.Id == id);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Organization by Name.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Organization that was found with matching Name.</returns>
        public Organization GetOrganizationByName(string name)
        {
            try
            {
                return repo.Single<Organization>(e => e.Name == name);
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
        /// Updates a/an Organization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Organization that was updated in the database.</returns>
        public Organization UpdateOrganization(Organization entity)
        {
            try
            {
                return repo.Update<Organization>(entity);
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
        /// Deletes a/an Organization.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        public int DeleteOrganizationById(int id)
        {
            try
            {
			    var entity = GetOrganizationById(id);
                return repo.Delete<Organization>(entity);
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
