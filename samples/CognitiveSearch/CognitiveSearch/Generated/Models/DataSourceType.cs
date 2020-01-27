// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace CognitiveSearch.Models
{
    /// <summary> Defines the type of a datasource. </summary>
    public readonly partial struct DataSourceType : IEquatable<DataSourceType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DataSourceType"/> values are the same. </summary>
        public DataSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureSqlValue = "azuresql";
        private const string CosmosDbValue = "cosmosdb";
        private const string AzureBlobValue = "azureblob";
        private const string AzureTableValue = "azuretable";

        /// <summary> The value &apos;azuresql&apos;. </summary>
        public static DataSourceType AzureSql { get; } = new DataSourceType(AzureSqlValue);
        /// <summary> The value &apos;cosmosdb&apos;. </summary>
        public static DataSourceType CosmosDb { get; } = new DataSourceType(CosmosDbValue);
        /// <summary> The value &apos;azureblob&apos;. </summary>
        public static DataSourceType AzureBlob { get; } = new DataSourceType(AzureBlobValue);
        /// <summary> The value &apos;azuretable&apos;. </summary>
        public static DataSourceType AzureTable { get; } = new DataSourceType(AzureTableValue);
        /// <summary> Determines if two <see cref="DataSourceType"/> values are the same. </summary>
        public static bool operator ==(DataSourceType left, DataSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataSourceType"/> values are not the same. </summary>
        public static bool operator !=(DataSourceType left, DataSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataSourceType"/>. </summary>
        public static implicit operator DataSourceType(string value) => new DataSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataSourceType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}