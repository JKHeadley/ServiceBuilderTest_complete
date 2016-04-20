	  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;

namespace ServiceBuilderTest.Service.Helpers
{
    public interface ILogEventHelper
    {
        /// <summary>
        /// Creates a/an LogEvent.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was created in the database.</returns>
        LogEvent CreateLogEvent(LogEvent entity);
		

		/// <summary>
        /// Gets a list of all LogEvents.
        /// </summary>
        /// <returns>Returns all the LogEvents in the database.</returns>
        IEnumerable<LogEvent> GetLogEvents();
		
        /// <summary>
        /// Gets a/an LogEvent by Id.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching Id.</returns>
        LogEvent GetLogEventById(int id);


        /// <summary>
        /// Gets a/an LogEvent by LogEventType.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching LogEventType.</returns>
        LogEvent GetLogEventByLogEventType(string logEventType);


        /// <summary>
        /// Gets a/an LogEvent by EntityType.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching EntityType.</returns>
        LogEvent GetLogEventByEntityType(string entityType);


        /// <summary>
        /// Gets a/an LogEvent by EntityId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching EntityId.</returns>
        LogEvent GetLogEventByEntityId(string entityId);


        /// <summary>
        /// Gets a/an LogEvent by ChangedByUserId.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching ChangedByUserId.</returns>
        LogEvent GetLogEventByChangedByUserId(string changedByUserId);


        /// <summary>
        /// Gets a/an LogEvent by ChangedByUserName.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching ChangedByUserName.</returns>
        LogEvent GetLogEventByChangedByUserName(string changedByUserName);


        /// <summary>
        /// Gets a/an LogEvent by Date.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching Date.</returns>
        LogEvent GetLogEventByDate(System.DateTime date);


        /// <summary>
        /// Gets a/an LogEvent by PropertyName.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching PropertyName.</returns>
        LogEvent GetLogEventByPropertyName(string propertyName);


        /// <summary>
        /// Gets a/an LogEvent by PropertyType.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching PropertyType.</returns>
        LogEvent GetLogEventByPropertyType(string propertyType);


        /// <summary>
        /// Gets a/an LogEvent by OldValue.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching OldValue.</returns>
        LogEvent GetLogEventByOldValue(string oldValue);


        /// <summary>
        /// Gets a/an LogEvent by NewValue.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching NewValue.</returns>
        LogEvent GetLogEventByNewValue(string newValue);


        /// <summary>
        /// Gets a/an LogEvent by ErrorMessage.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching ErrorMessage.</returns>
        LogEvent GetLogEventByErrorMessage(string errorMessage);


        /// <summary>
        /// Gets a/an LogEvent by StackTrace.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was found with matching StackTrace.</returns>
        LogEvent GetLogEventByStackTrace(string stackTrace);

		/// <summary>
        /// Updates a/an LogEvent.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns the LogEvent that was updated in the database.</returns>
        LogEvent UpdateLogEvent(LogEvent entity);
		
		/// <summary>
        /// Deletes a/an LogEvent.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Returns an int for the result.</returns>
        int DeleteLogEventById(int id);
	}
}

