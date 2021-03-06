// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppConfiguration.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> The PrivateLinkResources service client. </summary>
    public partial class PrivateLinkResourcesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PrivateLinkResourcesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of PrivateLinkResourcesOperations for mocking. </summary>
        protected PrivateLinkResourcesOperations()
        {
        }
        /// <summary> Initializes a new instance of PrivateLinkResourcesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal PrivateLinkResourcesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2019-11-01-preview")
        {
            RestClient = new PrivateLinkResourcesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a private link resource that need to be created for a configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateLinkResource>> GetAsync(string resourceGroupName, string configStoreName, string groupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, configStoreName, groupName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a private link resource that need to be created for a configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateLinkResource> Get(string resourceGroupName, string configStoreName, string groupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, configStoreName, groupName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PrivateLinkResource> ListByConfigurationStoreAsync(string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            async Task<Page<PrivateLinkResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesOperations.ListByConfigurationStore");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByConfigurationStoreAsync(resourceGroupName, configStoreName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateLinkResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesOperations.ListByConfigurationStore");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByConfigurationStoreNextPageAsync(nextLink, resourceGroupName, configStoreName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PrivateLinkResource> ListByConfigurationStore(string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            Page<PrivateLinkResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesOperations.ListByConfigurationStore");
                scope.Start();
                try
                {
                    var response = RestClient.ListByConfigurationStore(resourceGroupName, configStoreName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateLinkResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesOperations.ListByConfigurationStore");
                scope.Start();
                try
                {
                    var response = RestClient.ListByConfigurationStoreNextPage(nextLink, resourceGroupName, configStoreName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
