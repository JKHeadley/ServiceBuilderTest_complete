using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public class OrganizationPrivilegeHelper : IOrganizationPrivilegeHelper
    {
        internal IServiceBuilderTestRepository repo;

        public OrganizationPrivilegeHelper(IServiceBuilderTestRepository repo)
        {
            this.repo = repo;
        }
        
        #region CREATE

        /// <summary>
        /// Creates a/an OrganizationPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the OrganizationPrivilege that was created in the database.</returns>
        public OrganizationPrivilege CreateOrganizationPrivilege(OrganizationPrivilege entity)
        {
            try
            {
                return repo.Create<OrganizationPrivilege>(entity);
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
        /// Gets a list of all OrganizationPrivileges.
        /// </summary>
        /// <returns>Returns all the OrganizationPrivileges in the database.</returns>
        public IEnumerable<OrganizationPrivilege> GetOrganizationPrivileges()
        {
            try
            {
                return repo.All<OrganizationPrivilege>().AsEnumerable();
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an OrganizationPrivilege by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the OrganizationPrivilege that was found with matching Id.</returns>
        public OrganizationPrivilege GetOrganizationPrivilegeById(int id)
        {
            try
            {
                return repo.Single<OrganizationPrivilege>(e => e.Id == id);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an OrganizationPrivilege by OrganizationId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the OrganizationPrivilege that was found with matching OrganizationId.</returns>
        public OrganizationPrivilege GetOrganizationPrivilegeByOrganizationId(int organizationId)
        {
            try
            {
                return repo.Single<OrganizationPrivilege>(e => e.OrganizationId == organizationId);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an OrganizationPrivilege by PrivilegeId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the OrganizationPrivilege that was found with matching PrivilegeId.</returns>
        public OrganizationPrivilege GetOrganizationPrivilegeByPrivilegeId(int privilegeId)
        {
            try
            {
                return repo.Single<OrganizationPrivilege>(e => e.PrivilegeId == privilegeId);
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
        /// Updates a/an OrganizationPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the OrganizationPrivilege that was updated in the database.</returns>
        public OrganizationPrivilege UpdateOrganizationPrivilege(OrganizationPrivilege entity)
        {
            try
            {
                return repo.Update<OrganizationPrivilege>(entity);
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
        /// Deletes a/an OrganizationPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        public int DeleteOrganizationPrivilegeById(int id)
        {
            try
            {
			    var entity = GetOrganizationPrivilegeById(id);
                return repo.Delete<OrganizationPrivilege>(entity);
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
