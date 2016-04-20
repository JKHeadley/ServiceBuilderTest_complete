using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public class PrivilegeHelper : IPrivilegeHelper
    {
        internal IServiceBuilderTestRepository repo;

        public PrivilegeHelper(IServiceBuilderTestRepository repo)
        {
            this.repo = repo;
        }
        
        #region CREATE

        /// <summary>
        /// Creates a/an Privilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was created in the database.</returns>
        public Privilege CreatePrivilege(Privilege entity)
        {
            try
            {
                return repo.Create<Privilege>(entity);
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
        /// Gets a list of all Privileges.
        /// </summary>
        /// <returns>Returns all the Privileges in the database.</returns>
        public IEnumerable<Privilege> GetPrivileges()
        {
            try
            {
                return repo.All<Privilege>().AsEnumerable();
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Privilege by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was found with matching Id.</returns>
        public Privilege GetPrivilegeById(int id)
        {
            try
            {
                return repo.Single<Privilege>(e => e.Id == id);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Privilege by Name.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was found with matching Name.</returns>
        public Privilege GetPrivilegeByName(string name)
        {
            try
            {
                return repo.Single<Privilege>(e => e.Name == name);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Privilege by ApplicationId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was found with matching ApplicationId.</returns>
        public Privilege GetPrivilegeByApplicationId(int applicationId)
        {
            try
            {
                return repo.Single<Privilege>(e => e.ApplicationId == applicationId);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an Privilege by Application.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was found with matching Application.</returns>
        public Privilege GetPrivilegeByApplication(ServiceBuilderTest.Model.Application application)
        {
            try
            {
                return repo.Single<Privilege>(e => e.Application == application);
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
        /// Updates a/an Privilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the Privilege that was updated in the database.</returns>
        public Privilege UpdatePrivilege(Privilege entity)
        {
            try
            {
                return repo.Update<Privilege>(entity);
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
        /// Deletes a/an Privilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        public int DeletePrivilegeById(int id)
        {
            try
            {
			    var entity = GetPrivilegeById(id);
                return repo.Delete<Privilege>(entity);
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
