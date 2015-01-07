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
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Contains the response to a Get Database request.
    /// </summary>
    public partial class DatabaseGetResponse : AzureOperationResponse
    {
        private Database _database;
        
        /// <summary>
        /// Optional. Gets or sets the database that was returned from the
        /// service in response to the get operation.
        /// </summary>
        public Database Database
        {
            get { return this._database; }
            set { this._database = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DatabaseGetResponse class.
        /// </summary>
        public DatabaseGetResponse()
        {
        }
    }
}
