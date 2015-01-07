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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// Contains methods to allow various operations on Azure SQL Database
    /// Servers.
    /// </summary>
    public partial interface IServerOperations
    {
        /// <summary>
        /// Changes the administrative password of an existing Azure SQL
        /// Database Server for a given subscription.
        /// </summary>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server that will have the
        /// administrator password changed.
        /// </param>
        /// <param name='parameters'>
        /// The necessary parameters for modifying the adminstrator password
        /// for a server.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> ChangeAdministratorPasswordAsync(string serverName, ServerChangeAdministratorPasswordParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Provisions a new SQL Database server in a subscription.
        /// </summary>
        /// <param name='parameters'>
        /// The parameters needed to provision a server.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response returned from the Create Server operation.  This
        /// contains all the information returned from the service when a
        /// server is created.
        /// </returns>
        Task<ServerCreateResponse> CreateAsync(ServerCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the specified Azure SQL Database Server from a subscription.
        /// </summary>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server to be deleted.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string serverName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns all SQL Database Servers that are provisioned for a
        /// subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response structure for the Server List operation.  Contains a
        /// list of all the servers in a subscription.
        /// </returns>
        Task<ServerListResponse> ListAsync(CancellationToken cancellationToken);
    }
}
