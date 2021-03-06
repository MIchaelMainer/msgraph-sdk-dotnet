// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The type MessageRequest.
    /// </summary>
    public partial class MessageRequest : BaseRequest, IMessageRequest
    {
        /// <summary>
        /// Constructs a new MessageRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MessageRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Message using PUT.
        /// </summary>
        /// <param name="messageToCreate">The Message to create.</param>
        /// <returns>The created Message.</returns>
        public Task<Message> CreateAsync(Message messageToCreate)
        {
            return this.CreateAsync(messageToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Message using PUT.
        /// </summary>
        /// <param name="messageToCreate">The Message to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Message.</returns>
        public async Task<Message> CreateAsync(Message messageToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<Message>(messageToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Message.
        /// </summary>
        /// <returns>The task to await.</returns>
        public Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Message.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Message>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Message.
        /// </summary>
        /// <returns>The Message.</returns>
        public Task<Message> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Message.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Message.</returns>
        public async Task<Message> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Message>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Message using PATCH.
        /// </summary>
        /// <param name="messageToUpdate">The Message to update.</param>
        /// <returns>The updated Message.</returns>
        public Task<Message> UpdateAsync(Message messageToUpdate)
        {
            return this.UpdateAsync(messageToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Message using PATCH.
        /// </summary>
        /// <param name="messageToUpdate">The Message to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Message.</returns>
        public async Task<Message> UpdateAsync(Message messageToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Message>(messageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="messageToInitialize">The <see cref="Message"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Message messageToInitialize)
        {

            if (messageToInitialize != null && messageToInitialize.AdditionalData != null)
            {

                if (messageToInitialize.Extensions != null && messageToInitialize.Extensions.CurrentPage != null)
                {
                    messageToInitialize.Extensions.AdditionalData = messageToInitialize.AdditionalData;

                    object nextPageLink;
                    messageToInitialize.AdditionalData.TryGetValue("extensions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        messageToInitialize.Extensions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (messageToInitialize.Attachments != null && messageToInitialize.Attachments.CurrentPage != null)
                {
                    messageToInitialize.Attachments.AdditionalData = messageToInitialize.AdditionalData;

                    object nextPageLink;
                    messageToInitialize.AdditionalData.TryGetValue("attachments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        messageToInitialize.Attachments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
