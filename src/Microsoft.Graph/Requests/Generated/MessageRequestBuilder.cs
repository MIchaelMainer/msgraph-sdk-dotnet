// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type MessageRequestBuilder.
    /// </summary>
    public partial class MessageRequestBuilder : OutlookItemRequestBuilder, IMessageRequestBuilder
    {

        /// <summary>
        /// Constructs a new MessageRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MessageRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IMessageRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IMessageRequest Request(IEnumerable<Option> options)
        {
            return new MessageRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IMessageExtensionsCollectionRequestBuilder"/>.</returns>
        public IMessageExtensionsCollectionRequestBuilder Extensions
        {
            get
            {
                return new MessageExtensionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("extensions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Attachments.
        /// </summary>
        /// <returns>The <see cref="IMessageAttachmentsCollectionRequestBuilder"/>.</returns>
        public IMessageAttachmentsCollectionRequestBuilder Attachments
        {
            get
            {
                return new MessageAttachmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("attachments"), this.Client);
            }
        }
        
        /// <summary>
        /// Gets the request builder for MessageCopy.
        /// </summary>
        /// <returns>The <see cref="IMessageCopyRequestBuilder"/>.</returns>
        public IMessageCopyRequestBuilder Copy(
            string DestinationId = null)
        {
            return new MessageCopyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.copy"),
                this.Client,
                DestinationId);
        }

        /// <summary>
        /// Gets the request builder for MessageMove.
        /// </summary>
        /// <returns>The <see cref="IMessageMoveRequestBuilder"/>.</returns>
        public IMessageMoveRequestBuilder Move(
            string DestinationId = null)
        {
            return new MessageMoveRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.move"),
                this.Client,
                DestinationId);
        }

        /// <summary>
        /// Gets the request builder for MessageCreateReply.
        /// </summary>
        /// <returns>The <see cref="IMessageCreateReplyRequestBuilder"/>.</returns>
        public IMessageCreateReplyRequestBuilder CreateReply()
        {
            return new MessageCreateReplyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createReply"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for MessageCreateReplyAll.
        /// </summary>
        /// <returns>The <see cref="IMessageCreateReplyAllRequestBuilder"/>.</returns>
        public IMessageCreateReplyAllRequestBuilder CreateReplyAll()
        {
            return new MessageCreateReplyAllRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createReplyAll"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for MessageCreateForward.
        /// </summary>
        /// <returns>The <see cref="IMessageCreateForwardRequestBuilder"/>.</returns>
        public IMessageCreateForwardRequestBuilder CreateForward()
        {
            return new MessageCreateForwardRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createForward"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for MessageReply.
        /// </summary>
        /// <returns>The <see cref="IMessageReplyRequestBuilder"/>.</returns>
        public IMessageReplyRequestBuilder Reply(
            string Comment = null)
        {
            return new MessageReplyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.reply"),
                this.Client,
                Comment);
        }

        /// <summary>
        /// Gets the request builder for MessageReplyAll.
        /// </summary>
        /// <returns>The <see cref="IMessageReplyAllRequestBuilder"/>.</returns>
        public IMessageReplyAllRequestBuilder ReplyAll(
            string Comment = null)
        {
            return new MessageReplyAllRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.replyAll"),
                this.Client,
                Comment);
        }

        /// <summary>
        /// Gets the request builder for MessageForward.
        /// </summary>
        /// <returns>The <see cref="IMessageForwardRequestBuilder"/>.</returns>
        public IMessageForwardRequestBuilder Forward(
            string Comment = null,
            IEnumerable<Recipient> ToRecipients = null)
        {
            return new MessageForwardRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.forward"),
                this.Client,
                Comment,
                ToRecipients);
        }

        /// <summary>
        /// Gets the request builder for MessageSend.
        /// </summary>
        /// <returns>The <see cref="IMessageSendRequestBuilder"/>.</returns>
        public IMessageSendRequestBuilder Send()
        {
            return new MessageSendRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.send"),
                this.Client);
        }
    
    }
}
