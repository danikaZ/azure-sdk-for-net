// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedInstanceAdministratorsOperations.
    /// </summary>
    public static partial class ManagedInstanceAdministratorsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of managed instance administrators.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            public static IPage<ManagedInstanceAdministrator> ListByInstance(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName)
            {
                return operations.ListByInstanceAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of managed instance administrators.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedInstanceAdministrator>> ListByInstanceAsync(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInstanceWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a managed instance administrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            public static ManagedInstanceAdministrator Get(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName)
            {
                return operations.GetAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a managed instance administrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstanceAdministrator> GetAsync(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a managed instance administrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested administrator parameters.
            /// </param>
            public static ManagedInstanceAdministrator CreateOrUpdate(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceAdministrator parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, managedInstanceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a managed instance administrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested administrator parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstanceAdministrator> CreateOrUpdateAsync(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceAdministrator parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a managed instance administrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            public static void Delete(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName)
            {
                operations.DeleteAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a managed instance administrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a managed instance administrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested administrator parameters.
            /// </param>
            public static ManagedInstanceAdministrator BeginCreateOrUpdate(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceAdministrator parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, managedInstanceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a managed instance administrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested administrator parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstanceAdministrator> BeginCreateOrUpdateAsync(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceAdministrator parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a managed instance administrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            public static void BeginDelete(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a managed instance administrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IManagedInstanceAdministratorsOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of managed instance administrators.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedInstanceAdministrator> ListByInstanceNext(this IManagedInstanceAdministratorsOperations operations, string nextPageLink)
            {
                return operations.ListByInstanceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of managed instance administrators.
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
            public static async Task<IPage<ManagedInstanceAdministrator>> ListByInstanceNextAsync(this IManagedInstanceAdministratorsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInstanceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
