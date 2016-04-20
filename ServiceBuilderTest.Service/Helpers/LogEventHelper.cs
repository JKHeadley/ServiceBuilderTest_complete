
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public class LogEventHelper : ILogEventHelper
    {
        internal IServiceBuilderTestRepository repo;

        public LogEventHelper(IServiceBuilderTestRepository repo)
        {
            this.repo = repo;
        }
        
        #region CREATE

        /// <summary>
        /// Creates a/an LogEvent.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was created in the database.</returns>
        public LogEvent CreateLogEvent(LogEvent entity)
        {
            try
            {
                return repo.Create<LogEvent>(entity);
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
        /// Gets a list of all LogEvents.
        /// </summary>
        /// <returns>Returns all the LogEvents in the database.</returns>
        public IEnumerable<LogEvent> GetLogEvents()
        {
            try
            {
                return repo.All<LogEvent>().AsEnumerable();
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching Id.</returns>
        public LogEvent GetLogEventById(int id)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.Id == id);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by LogEventType.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching LogEventType.</returns>
        public LogEvent GetLogEventByLogEventType(string logEventType)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.LogEventType == logEventType);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by EntityType.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching EntityType.</returns>
        public LogEvent GetLogEventByEntityType(string entityType)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.EntityType == entityType);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by EntityId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching EntityId.</returns>
        public LogEvent GetLogEventByEntityId(string entityId)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.EntityId == entityId);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by ChangedByUserId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching ChangedByUserId.</returns>
        public LogEvent GetLogEventByChangedByUserId(string changedByUserId)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.ChangedByUserId == changedByUserId);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by ChangedByUserName.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching ChangedByUserName.</returns>
        public LogEvent GetLogEventByChangedByUserName(string changedByUserName)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.ChangedByUserName == changedByUserName);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by Date.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching Date.</returns>
        public LogEvent GetLogEventByDate(System.DateTime date)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.Date == date);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by PropertyName.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching PropertyName.</returns>
        public LogEvent GetLogEventByPropertyName(string propertyName)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.PropertyName == propertyName);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by PropertyType.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching PropertyType.</returns>
        public LogEvent GetLogEventByPropertyType(string propertyType)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.PropertyType == propertyType);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by OldValue.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching OldValue.</returns>
        public LogEvent GetLogEventByOldValue(string oldValue)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.OldValue == oldValue);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by NewValue.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching NewValue.</returns>
        public LogEvent GetLogEventByNewValue(string newValue)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.NewValue == newValue);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by ErrorMessage.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching ErrorMessage.</returns>
        public LogEvent GetLogEventByErrorMessage(string errorMessage)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.ErrorMessage == errorMessage);
            }
            catch (Exception ex)
            {
                repo.LogError(ex);
                throw ex;
            }
        }


        /// <summary>
        /// Gets a/an LogEvent by StackTrace.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching StackTrace.</returns>
        public LogEvent GetLogEventByStackTrace(string stackTrace)
        {
            try
            {
                return repo.Single<LogEvent>(e => e.StackTrace == stackTrace);
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
        /// Updates a/an LogEvent.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was updated in the database.</returns>
        public LogEvent UpdateLogEvent(LogEvent entity)
        {
            try
            {
                return repo.Update<LogEvent>(entity);
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
        /// Deletes a/an LogEvent.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        public int DeleteLogEventById(int id)
        {
            try
            {
			    var entity = GetLogEventById(id);
                return repo.Delete<LogEvent>(entity);
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
