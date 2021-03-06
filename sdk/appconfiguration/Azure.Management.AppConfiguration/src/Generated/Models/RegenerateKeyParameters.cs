// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.AppConfiguration.Models
{
    /// <summary> The parameters used to regenerate an API key. </summary>
    public partial class RegenerateKeyParameters
    {
        /// <summary> Initializes a new instance of RegenerateKeyParameters. </summary>
        public RegenerateKeyParameters()
        {
        }

        /// <summary> Initializes a new instance of RegenerateKeyParameters. </summary>
        /// <param name="id"> The id of the key to regenerate. </param>
        internal RegenerateKeyParameters(string id)
        {
            Id = id;
        }

        /// <summary> The id of the key to regenerate. </summary>
        public string Id { get; set; }
    }
}
