// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure.Management.TrafficManager.Models;

namespace Microsoft.WindowsAzure.Management.TrafficManager.Models
{
    /// <summary>
    /// Describes the status and version of a definition.
    /// </summary>
    public partial class DefinitionStatusAndVersion
    {
        private ProfileDefinitionStatus _status;
        
        /// <summary>
        /// Optional. Indicates whether a definition of the specified profile
        /// is enabled or disabled in Windows Azure Traffic Manager.
        /// </summary>
        public ProfileDefinitionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private int _version;
        
        /// <summary>
        /// Optional. The version of the policy definition. This value is
        /// always 1.
        /// </summary>
        public int Version
        {
            get { return this._version; }
            set { this._version = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DefinitionStatusAndVersion class.
        /// </summary>
        public DefinitionStatusAndVersion()
        {
        }
    }
}
