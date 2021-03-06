// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.



namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// The enum FreeBusyStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum FreeBusyStatus
    {
        
        /// <summary>
        /// free
        /// </summary>
        Free,
        
        /// <summary>
        /// tentative
        /// </summary>
        Tentative,
        
        /// <summary>
        /// busy
        /// </summary>
        Busy,
        
        /// <summary>
        /// oof
        /// </summary>
        Oof,
        
        /// <summary>
        /// working Elsewhere
        /// </summary>
        WorkingElsewhere,
        
        /// <summary>
        /// unknown
        /// </summary>
        Unknown,
        
    }
}
