// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resources
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class DeploymentOperationsOperationsExtensions
    {
            /// <summary>
            /// Get a list of deployments operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='operationId'>
            /// Operation Id.
            /// </param>
            public static DeploymentOperation Get(this IDeploymentOperationsOperations operations, string resourceGroupName, string deploymentName, string operationId)
            {
                return Task.Factory.StartNew(s => ((IDeploymentOperationsOperations)s).GetAsync(resourceGroupName, deploymentName, operationId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of deployments operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='operationId'>
            /// Operation Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentOperation> GetAsync( this IDeploymentOperationsOperations operations, string resourceGroupName, string deploymentName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<DeploymentOperation> result = await operations.GetWithHttpMessagesAsync(resourceGroupName, deploymentName, operationId, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of deployments operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='odataQuery'>
            /// Query parameters.
            /// </param>
            public static IPage<DeploymentOperation> List(this IDeploymentOperationsOperations operations, string resourceGroupName, string deploymentName, ODataQuery<int?> odataQuery = default(ODataQuery<int?>))
            {
                return Task.Factory.StartNew(s => ((IDeploymentOperationsOperations)s).ListAsync(resourceGroupName, deploymentName, odataQuery), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of deployments operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='odataQuery'>
            /// Query parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeploymentOperation>> ListAsync( this IDeploymentOperationsOperations operations, string resourceGroupName, string deploymentName, ODataQuery<int?> odataQuery = default(ODataQuery<int?>), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<DeploymentOperation>> result = await operations.ListWithHttpMessagesAsync(resourceGroupName, deploymentName, odataQuery, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of deployments operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DeploymentOperation> ListNext(this IDeploymentOperationsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IDeploymentOperationsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of deployments operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeploymentOperation>> ListNextAsync( this IDeploymentOperationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<DeploymentOperation>> result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
