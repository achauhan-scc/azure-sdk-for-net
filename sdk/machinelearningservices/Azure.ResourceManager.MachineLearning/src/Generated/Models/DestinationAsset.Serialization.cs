// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class DestinationAsset : IUtf8JsonSerializable, IJsonModel<DestinationAsset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DestinationAsset>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DestinationAsset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DestinationAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DestinationAsset)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
<<<<<<< HEAD
            if (Optional.IsDefined(RegistryName))
            {
                if (RegistryName != null)
                {
                    writer.WritePropertyName("registryName"u8);
                    writer.WriteStringValue(RegistryName);
                }
                else
                {
                    writer.WriteNull("registryName");
                }
            }
            if (Optional.IsDefined(DestinationName))
            {
                if (DestinationName != null)
                {
                    writer.WritePropertyName("destinationName"u8);
                    writer.WriteStringValue(DestinationName);
                }
                else
                {
                    writer.WriteNull("destinationName");
                }
            }
            if (Optional.IsDefined(DestinationVersion))
            {
                if (DestinationVersion != null)
                {
                    writer.WritePropertyName("destinationVersion"u8);
                    writer.WriteStringValue(DestinationVersion);
                }
                else
                {
                    writer.WriteNull("destinationVersion");
=======
            if (Optional.IsDefined(DestinationName))
            {
                if (DestinationName != null)
                {
                    writer.WritePropertyName("destinationName"u8);
                    writer.WriteStringValue(DestinationName);
                }
                else
                {
                    writer.WriteNull("destinationName");
                }
            }
            if (Optional.IsDefined(DestinationVersion))
            {
                if (DestinationVersion != null)
                {
                    writer.WritePropertyName("destinationVersion"u8);
                    writer.WriteStringValue(DestinationVersion);
                }
                else
                {
                    writer.WriteNull("destinationVersion");
                }
            }
            if (Optional.IsDefined(RegistryName))
            {
                if (RegistryName != null)
                {
                    writer.WritePropertyName("registryName"u8);
                    writer.WriteStringValue(RegistryName);
                }
                else
                {
                    writer.WriteNull("registryName");
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                }
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DestinationAsset IJsonModel<DestinationAsset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DestinationAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DestinationAsset)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDestinationAsset(document.RootElement, options);
        }

        internal static DestinationAsset DeserializeDestinationAsset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
<<<<<<< HEAD
            string registryName = default;
            string destinationName = default;
            string destinationVersion = default;
=======
            string destinationName = default;
            string destinationVersion = default;
            string registryName = default;
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
<<<<<<< HEAD
                if (property.NameEquals("registryName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        registryName = null;
                        continue;
                    }
                    registryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        destinationName = null;
                        continue;
                    }
                    destinationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        destinationVersion = null;
                        continue;
                    }
                    destinationVersion = property.Value.GetString();
=======
                if (property.NameEquals("destinationName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        destinationName = null;
                        continue;
                    }
                    destinationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        destinationVersion = null;
                        continue;
                    }
                    destinationVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registryName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        registryName = null;
                        continue;
                    }
                    registryName = property.Value.GetString();
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
<<<<<<< HEAD
            return new DestinationAsset(registryName, destinationName, destinationVersion, serializedAdditionalRawData);
=======
            return new DestinationAsset(destinationName, destinationVersion, registryName, serializedAdditionalRawData);
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        }

        BinaryData IPersistableModel<DestinationAsset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DestinationAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DestinationAsset)} does not support writing '{options.Format}' format.");
            }
        }

        DestinationAsset IPersistableModel<DestinationAsset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DestinationAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDestinationAsset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DestinationAsset)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DestinationAsset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
