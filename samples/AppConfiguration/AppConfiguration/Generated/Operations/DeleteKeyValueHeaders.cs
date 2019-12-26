// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure;
using Azure.Core;

namespace AppConfiguration
{
    internal class DeleteKeyValueHeaders
    {
        private readonly Response _response;
        public DeleteKeyValueHeaders(Response response)
        {
            _response = response;
        }
        public string? SyncToken => _response.Headers.TryGetValue("Sync-Token", out string? value) ? value : null;
        public string? ETag => _response.Headers.TryGetValue("ETag", out string? value) ? value : null;
    }
}