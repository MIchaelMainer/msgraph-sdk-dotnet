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
    /// The interface IConversationRequest.
    /// </summary>
    public partial interface IConversationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Conversation using PUT.
        /// </summary>
        /// <param name="conversationToCreate">The Conversation to create.</param>
        /// <returns>The created Conversation.</returns>
        Task<Conversation> CreateAsync(Conversation conversationToCreate);        /// <summary>
        /// Creates the specified Conversation using PUT.
        /// </summary>
        /// <param name="conversationToCreate">The Conversation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Conversation.</returns>
        Task<Conversation> CreateAsync(Conversation conversationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Conversation.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Conversation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Conversation.
        /// </summary>
        /// <returns>The Conversation.</returns>
        Task<Conversation> GetAsync();

        /// <summary>
        /// Gets the specified Conversation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Conversation.</returns>
        Task<Conversation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Conversation using PATCH.
        /// </summary>
        /// <param name="conversationToUpdate">The Conversation to update.</param>
        /// <returns>The updated Conversation.</returns>
        Task<Conversation> UpdateAsync(Conversation conversationToUpdate);

        /// <summary>
        /// Updates the specified Conversation using PATCH.
        /// </summary>
        /// <param name="conversationToUpdate">The Conversation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Conversation.</returns>
        Task<Conversation> UpdateAsync(Conversation conversationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IConversationRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IConversationRequest Select(string value);

    }
}
