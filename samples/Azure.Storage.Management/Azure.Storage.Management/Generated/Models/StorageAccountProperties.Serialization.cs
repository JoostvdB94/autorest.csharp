// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class StorageAccountProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (PrimaryEndpoints != null)
            {
                writer.WritePropertyName("primaryEndpoints");
                writer.WriteObjectValue(PrimaryEndpoints);
            }
            if (PrimaryLocation != null)
            {
                writer.WritePropertyName("primaryLocation");
                writer.WriteStringValue(PrimaryLocation);
            }
            if (StatusOfPrimary != null)
            {
                writer.WritePropertyName("statusOfPrimary");
                writer.WriteStringValue(StatusOfPrimary.Value.ToSerialString());
            }
            if (LastGeoFailoverTime != null)
            {
                writer.WritePropertyName("lastGeoFailoverTime");
                writer.WriteStringValue(LastGeoFailoverTime.Value, "S");
            }
            if (SecondaryLocation != null)
            {
                writer.WritePropertyName("secondaryLocation");
                writer.WriteStringValue(SecondaryLocation);
            }
            if (StatusOfSecondary != null)
            {
                writer.WritePropertyName("statusOfSecondary");
                writer.WriteStringValue(StatusOfSecondary.Value.ToSerialString());
            }
            if (CreationTime != null)
            {
                writer.WritePropertyName("creationTime");
                writer.WriteStringValue(CreationTime.Value, "S");
            }
            if (CustomDomain != null)
            {
                writer.WritePropertyName("customDomain");
                writer.WriteObjectValue(CustomDomain);
            }
            if (SecondaryEndpoints != null)
            {
                writer.WritePropertyName("secondaryEndpoints");
                writer.WriteObjectValue(SecondaryEndpoints);
            }
            if (Encryption != null)
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            if (AccessTier != null)
            {
                writer.WritePropertyName("accessTier");
                writer.WriteStringValue(AccessTier.Value.ToSerialString());
            }
            if (AzureFilesIdentityBasedAuthentication != null)
            {
                writer.WritePropertyName("azureFilesIdentityBasedAuthentication");
                writer.WriteObjectValue(AzureFilesIdentityBasedAuthentication);
            }
            if (EnableHttpsTrafficOnly != null)
            {
                writer.WritePropertyName("supportsHttpsTrafficOnly");
                writer.WriteBooleanValue(EnableHttpsTrafficOnly.Value);
            }
            if (NetworkRuleSet != null)
            {
                writer.WritePropertyName("networkAcls");
                writer.WriteObjectValue(NetworkRuleSet);
            }
            if (IsHnsEnabled != null)
            {
                writer.WritePropertyName("isHnsEnabled");
                writer.WriteBooleanValue(IsHnsEnabled.Value);
            }
            if (GeoReplicationStats != null)
            {
                writer.WritePropertyName("geoReplicationStats");
                writer.WriteObjectValue(GeoReplicationStats);
            }
            if (FailoverInProgress != null)
            {
                writer.WritePropertyName("failoverInProgress");
                writer.WriteBooleanValue(FailoverInProgress.Value);
            }
            if (LargeFileSharesState != null)
            {
                writer.WritePropertyName("largeFileSharesState");
                writer.WriteStringValue(LargeFileSharesState.Value.ToString());
            }
            if (PrivateEndpointConnections != null)
            {
                writer.WritePropertyName("privateEndpointConnections");
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RoutingPreference != null)
            {
                writer.WritePropertyName("routingPreference");
                writer.WriteObjectValue(RoutingPreference);
            }
            if (BlobRestoreStatus != null)
            {
                writer.WritePropertyName("blobRestoreStatus");
                writer.WriteObjectValue(BlobRestoreStatus);
            }
            writer.WriteEndObject();
        }
        internal static StorageAccountProperties DeserializeStorageAccountProperties(JsonElement element)
        {
            StorageAccountProperties result = new StorageAccountProperties();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ProvisioningState = property.Value.GetString().ToProvisioningState();
                    continue;
                }
                if (property.NameEquals("primaryEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PrimaryEndpoints = Endpoints.DeserializeEndpoints(property.Value);
                    continue;
                }
                if (property.NameEquals("primaryLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PrimaryLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusOfPrimary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.StatusOfPrimary = property.Value.GetString().ToAccountStatus();
                    continue;
                }
                if (property.NameEquals("lastGeoFailoverTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.LastGeoFailoverTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("secondaryLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SecondaryLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusOfSecondary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.StatusOfSecondary = property.Value.GetString().ToAccountStatus();
                    continue;
                }
                if (property.NameEquals("creationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.CreationTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("customDomain"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.CustomDomain = CustomDomain.DeserializeCustomDomain(property.Value);
                    continue;
                }
                if (property.NameEquals("secondaryEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SecondaryEndpoints = Endpoints.DeserializeEndpoints(property.Value);
                    continue;
                }
                if (property.NameEquals("encryption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Encryption = Encryption.DeserializeEncryption(property.Value);
                    continue;
                }
                if (property.NameEquals("accessTier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.AccessTier = property.Value.GetString().ToAccessTier();
                    continue;
                }
                if (property.NameEquals("azureFilesIdentityBasedAuthentication"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.AzureFilesIdentityBasedAuthentication = AzureFilesIdentityBasedAuthentication.DeserializeAzureFilesIdentityBasedAuthentication(property.Value);
                    continue;
                }
                if (property.NameEquals("supportsHttpsTrafficOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.EnableHttpsTrafficOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("networkAcls"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.NetworkRuleSet = NetworkRuleSet.DeserializeNetworkRuleSet(property.Value);
                    continue;
                }
                if (property.NameEquals("isHnsEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IsHnsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("geoReplicationStats"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.GeoReplicationStats = GeoReplicationStats.DeserializeGeoReplicationStats(property.Value);
                    continue;
                }
                if (property.NameEquals("failoverInProgress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FailoverInProgress = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("largeFileSharesState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.LargeFileSharesState = new LargeFileSharesState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PrivateEndpointConnections = new List<PrivateEndpointConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.PrivateEndpointConnections.Add(PrivateEndpointConnection.DeserializePrivateEndpointConnection(item));
                    }
                    continue;
                }
                if (property.NameEquals("routingPreference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RoutingPreference = RoutingPreference.DeserializeRoutingPreference(property.Value);
                    continue;
                }
                if (property.NameEquals("blobRestoreStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.BlobRestoreStatus = BlobRestoreStatus.DeserializeBlobRestoreStatus(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}
