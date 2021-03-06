﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.Core.Test.TestModels
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// A property bag class with no default constructor for unit testing purposes.
    /// </summary>
    [DataContract]
    public class ClassWithJson
    {
        public ClassWithJson()
        {
        }

        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false, IsRequired = false)]
        public JToken Data { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
