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
    /// The interface IEventRequest.
    /// </summary>
    public partial interface IEventRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Event using PUT.
        /// </summary>
        /// <param name="eventToCreate">The Event to create.</param>
        /// <returns>The created Event.</returns>
        Task<Event> CreateAsync(Event eventToCreate);        /// <summary>
        /// Creates the specified Event using PUT.
        /// </summary>
        /// <param name="eventToCreate">The Event to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Event.</returns>
        Task<Event> CreateAsync(Event eventToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Event.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Event.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Event.
        /// </summary>
        /// <returns>The Event.</returns>
        Task<Event> GetAsync();

        /// <summary>
        /// Gets the specified Event.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Event.</returns>
        Task<Event> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Event using PATCH.
        /// </summary>
        /// <param name="eventToUpdate">The Event to update.</param>
        /// <returns>The updated Event.</returns>
        Task<Event> UpdateAsync(Event eventToUpdate);

        /// <summary>
        /// Updates the specified Event using PATCH.
        /// </summary>
        /// <param name="eventToUpdate">The Event to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Event.</returns>
        Task<Event> UpdateAsync(Event eventToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEventRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEventRequest Select(string value);

    }
}
