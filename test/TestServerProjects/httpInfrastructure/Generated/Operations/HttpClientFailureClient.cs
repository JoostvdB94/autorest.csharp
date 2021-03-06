// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace httpInfrastructure
{
    public partial class HttpClientFailureClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal HttpClientFailureRestClient RestClient { get; }
        /// <summary> Initializes a new instance of HttpClientFailureClient for mocking. </summary>
        protected HttpClientFailureClient()
        {
        }
        /// <summary> Initializes a new instance of HttpClientFailureClient. </summary>
        internal HttpClientFailureClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new HttpClientFailureRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Head400Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Head400Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Head400(CancellationToken cancellationToken = default)
        {
            return RestClient.Head400(cancellationToken);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Get400Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Get400Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get400(CancellationToken cancellationToken = default)
        {
            return RestClient.Get400(cancellationToken);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Options400Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Options400Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Options400(CancellationToken cancellationToken = default)
        {
            return RestClient.Options400(cancellationToken);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Put400Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Put400Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Put400(CancellationToken cancellationToken = default)
        {
            return RestClient.Put400(cancellationToken);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Patch400Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Patch400Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Patch400(CancellationToken cancellationToken = default)
        {
            return RestClient.Patch400(cancellationToken);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Post400Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Post400Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Post400(CancellationToken cancellationToken = default)
        {
            return RestClient.Post400(cancellationToken);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Delete400Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Delete400Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 400 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete400(CancellationToken cancellationToken = default)
        {
            return RestClient.Delete400(cancellationToken);
        }
        /// <summary> Return 401 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Head401Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Head401Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 401 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Head401(CancellationToken cancellationToken = default)
        {
            return RestClient.Head401(cancellationToken);
        }
        /// <summary> Return 402 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Get402Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Get402Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 402 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get402(CancellationToken cancellationToken = default)
        {
            return RestClient.Get402(cancellationToken);
        }
        /// <summary> Return 403 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Options403Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Options403Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 403 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Options403(CancellationToken cancellationToken = default)
        {
            return RestClient.Options403(cancellationToken);
        }
        /// <summary> Return 403 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Get403Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Get403Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 403 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get403(CancellationToken cancellationToken = default)
        {
            return RestClient.Get403(cancellationToken);
        }
        /// <summary> Return 404 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Put404Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Put404Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 404 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Put404(CancellationToken cancellationToken = default)
        {
            return RestClient.Put404(cancellationToken);
        }
        /// <summary> Return 405 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Patch405Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Patch405Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 405 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Patch405(CancellationToken cancellationToken = default)
        {
            return RestClient.Patch405(cancellationToken);
        }
        /// <summary> Return 406 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Post406Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Post406Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 406 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Post406(CancellationToken cancellationToken = default)
        {
            return RestClient.Post406(cancellationToken);
        }
        /// <summary> Return 407 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Delete407Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Delete407Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 407 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete407(CancellationToken cancellationToken = default)
        {
            return RestClient.Delete407(cancellationToken);
        }
        /// <summary> Return 409 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Put409Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Put409Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 409 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Put409(CancellationToken cancellationToken = default)
        {
            return RestClient.Put409(cancellationToken);
        }
        /// <summary> Return 410 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Head410Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Head410Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 410 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Head410(CancellationToken cancellationToken = default)
        {
            return RestClient.Head410(cancellationToken);
        }
        /// <summary> Return 411 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Get411Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Get411Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 411 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get411(CancellationToken cancellationToken = default)
        {
            return RestClient.Get411(cancellationToken);
        }
        /// <summary> Return 412 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Options412Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Options412Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 412 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Options412(CancellationToken cancellationToken = default)
        {
            return RestClient.Options412(cancellationToken);
        }
        /// <summary> Return 412 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Get412Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Get412Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 412 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get412(CancellationToken cancellationToken = default)
        {
            return RestClient.Get412(cancellationToken);
        }
        /// <summary> Return 413 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Put413Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Put413Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 413 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Put413(CancellationToken cancellationToken = default)
        {
            return RestClient.Put413(cancellationToken);
        }
        /// <summary> Return 414 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Patch414Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Patch414Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 414 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Patch414(CancellationToken cancellationToken = default)
        {
            return RestClient.Patch414(cancellationToken);
        }
        /// <summary> Return 415 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Post415Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Post415Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 415 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Post415(CancellationToken cancellationToken = default)
        {
            return RestClient.Post415(cancellationToken);
        }
        /// <summary> Return 416 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Get416Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Get416Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 416 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get416(CancellationToken cancellationToken = default)
        {
            return RestClient.Get416(cancellationToken);
        }
        /// <summary> Return 417 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Delete417Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Delete417Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 417 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete417(CancellationToken cancellationToken = default)
        {
            return RestClient.Delete417(cancellationToken);
        }
        /// <summary> Return 429 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Head429Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.Head429Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Return 429 status code - should be represented in the client as an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Head429(CancellationToken cancellationToken = default)
        {
            return RestClient.Head429(cancellationToken);
        }
    }
}
