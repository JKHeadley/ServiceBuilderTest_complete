using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public class GroupPrivilegeHelper : IGroupPrivilegeHelper
    {
        internal IServiceBuilderTestRepository repo;

        public GroupPrivilegeHelper(IServiceBuilderTestRepository repo)
        {
            this.repo = repo;
        }
        
        #region CREATE

        /// <summary>
        /// Creates a/an GroupPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the GroupPrivilege that was created in the database.</returns>
        public GroupPrivilege CreateGroupPrivilege(GroupPrivilege entity)
        {
            try
            {
                return repo.Create<GroupPrivilege>(entity);
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
        /// Gets a list of all GroupPrivileges.
        /// </summary>
        /// <returns>Returns all the GroupPrivileges in the database.</returns>
        public IEnumerable<GroupPrivilege> GetGroupPrivileges()
        {
            try
            {
                return repo.All<GroupPrivilege>().AsEnumerable();
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an GroupPrivilege by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the GroupPrivilege that was found with matching Id.</returns>
        public GroupPrivilege GetGroupPrivilegeById(int id)
        {
            try
            {
                return repo.Single<GroupPrivilege>(e => e.Id == id);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an GroupPrivilege by GroupId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the GroupPrivilege that was found with matching GroupId.</returns>
        public GroupPrivilege GetGroupPrivilegeByGroupId(int groupId)
        {
            try
            {
                return repo.Single<GroupPrivilege>(e => e.GroupId == groupId);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an GroupPrivilege by PrivilegeId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the GroupPrivilege that was found with matching PrivilegeId.</returns>
        public GroupPrivilege GetGroupPrivilegeByPrivilegeId(int privilegeId)
        {
            try
            {
                return repo.Single<GroupPrivilege>(e => e.PrivilegeId == privilegeId);
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
        /// Updates a/an GroupPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the GroupPrivilege that was updated in the database.</returns>
        public GroupPrivilege UpdateGroupPrivilege(GroupPrivilege entity)
        {
            try
            {
                return repo.Update<GroupPrivilege>(entity);
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
        /// Deletes a/an GroupPrivilege.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        public int DeleteGroupPrivilegeById(int id)
        {
            try
            {
			    var entity = GetGroupPrivilegeById(id);
                return repo.Delete<GroupPrivilege>(entity);
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
