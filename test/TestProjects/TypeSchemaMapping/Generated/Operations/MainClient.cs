// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using TypeSchemaMapping;

namespace CustomNamespace
{
    internal partial class MainClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal ServiceRestClient RestClient { get; }
        /// <summary> Initializes a new instance of MainClient for mocking. </summary>
        protected MainClient()
        {
        }
        /// <summary> Initializes a new instance of MainClient. </summary>
        internal MainClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new ServiceRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <param name="body"> The Model to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CustomizedModel>> OperationAsync(CustomizedModel body, CancellationToken cancellationToken = default)
        {
            return await RestClient.OperationAsync(body, cancellationToken).ConfigureAwait(false);
        }
        /// <param name="body"> The Model to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CustomizedModel> Operation(CustomizedModel body, CancellationToken cancellationToken = default)
        {
            return RestClient.Operation(body, cancellationToken);
        }
    }
}
