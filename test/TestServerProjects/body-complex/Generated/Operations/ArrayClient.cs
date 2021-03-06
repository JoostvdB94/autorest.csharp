// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using body_complex.Models;

namespace body_complex
{
    public partial class ArrayClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal ArrayRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ArrayClient for mocking. </summary>
        protected ArrayClient()
        {
        }
        /// <summary> Initializes a new instance of ArrayClient. </summary>
        internal ArrayClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new ArrayRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <summary> Get complex types with array property. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ArrayWrapper>> GetValidAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetValidAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get complex types with array property. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ArrayWrapper> GetValid(CancellationToken cancellationToken = default)
        {
            return RestClient.GetValid(cancellationToken);
        }
        /// <summary> Put complex types with array property. </summary>
        /// <param name="complexBody"> Please put an array with 4 items: &quot;1, 2, 3, 4&quot;, &quot;&quot;, null, &quot;&amp;S#$(*Y&quot;, &quot;The quick brown fox jumps over the lazy dog&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutValidAsync(ArrayWrapper complexBody, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutValidAsync(complexBody, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Put complex types with array property. </summary>
        /// <param name="complexBody"> Please put an array with 4 items: &quot;1, 2, 3, 4&quot;, &quot;&quot;, null, &quot;&amp;S#$(*Y&quot;, &quot;The quick brown fox jumps over the lazy dog&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutValid(ArrayWrapper complexBody, CancellationToken cancellationToken = default)
        {
            return RestClient.PutValid(complexBody, cancellationToken);
        }
        /// <summary> Get complex types with array property which is empty. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ArrayWrapper>> GetEmptyAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetEmptyAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get complex types with array property which is empty. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ArrayWrapper> GetEmpty(CancellationToken cancellationToken = default)
        {
            return RestClient.GetEmpty(cancellationToken);
        }
        /// <summary> Put complex types with array property which is empty. </summary>
        /// <param name="complexBody"> Please put an array with 4 items: &quot;1, 2, 3, 4&quot;, &quot;&quot;, null, &quot;&amp;S#$(*Y&quot;, &quot;The quick brown fox jumps over the lazy dog&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutEmptyAsync(ArrayWrapper complexBody, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutEmptyAsync(complexBody, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Put complex types with array property which is empty. </summary>
        /// <param name="complexBody"> Please put an array with 4 items: &quot;1, 2, 3, 4&quot;, &quot;&quot;, null, &quot;&amp;S#$(*Y&quot;, &quot;The quick brown fox jumps over the lazy dog&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutEmpty(ArrayWrapper complexBody, CancellationToken cancellationToken = default)
        {
            return RestClient.PutEmpty(complexBody, cancellationToken);
        }
        /// <summary> Get complex types with array property while server doesn&apos;t provide a response payload. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ArrayWrapper>> GetNotProvidedAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetNotProvidedAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get complex types with array property while server doesn&apos;t provide a response payload. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ArrayWrapper> GetNotProvided(CancellationToken cancellationToken = default)
        {
            return RestClient.GetNotProvided(cancellationToken);
        }
    }
}
