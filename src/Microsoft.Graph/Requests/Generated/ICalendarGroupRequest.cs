// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface ICalendarGroupRequest.
    /// </summary>
    public partial interface ICalendarGroupRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CalendarGroup using PUT.
        /// </summary>
        /// <param name="calendarGroupToCreate">The CalendarGroup to create.</param>
        /// <returns>The created CalendarGroup.</returns>
        Task<CalendarGroup> CreateAsync(CalendarGroup calendarGroupToCreate);        /// <summary>
        /// Creates the specified CalendarGroup using PUT.
        /// </summary>
        /// <param name="calendarGroupToCreate">The CalendarGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CalendarGroup.</returns>
        Task<CalendarGroup> CreateAsync(CalendarGroup calendarGroupToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CalendarGroup.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CalendarGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CalendarGroup.
        /// </summary>
        /// <returns>The CalendarGroup.</returns>
        Task<CalendarGroup> GetAsync();

        /// <summary>
        /// Gets the specified CalendarGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CalendarGroup.</returns>
        Task<CalendarGroup> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CalendarGroup using PATCH.
        /// </summary>
        /// <param name="calendarGroupToUpdate">The CalendarGroup to update.</param>
        /// <returns>The updated CalendarGroup.</returns>
        Task<CalendarGroup> UpdateAsync(CalendarGroup calendarGroupToUpdate);

        /// <summary>
        /// Updates the specified CalendarGroup using PATCH.
        /// </summary>
        /// <param name="calendarGroupToUpdate">The CalendarGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated CalendarGroup.</returns>
        Task<CalendarGroup> UpdateAsync(CalendarGroup calendarGroupToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICalendarGroupRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICalendarGroupRequest Select(string value);

    }
}
