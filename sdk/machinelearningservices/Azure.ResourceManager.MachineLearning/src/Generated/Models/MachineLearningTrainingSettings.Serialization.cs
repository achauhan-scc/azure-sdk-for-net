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
    public partial class MachineLearningTrainingSettings : IUtf8JsonSerializable, IJsonModel<MachineLearningTrainingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningTrainingSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningTrainingSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningTrainingSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsOnnxCompatibleModelsEnabled))
            {
                writer.WritePropertyName("enableOnnxCompatibleModels"u8);
                writer.WriteBooleanValue(IsOnnxCompatibleModelsEnabled.Value);
            }
            if (Optional.IsDefined(StackEnsembleSettings))
            {
                if (StackEnsembleSettings != null)
                {
                    writer.WritePropertyName("stackEnsembleSettings"u8);
                    writer.WriteObjectValue(StackEnsembleSettings, options);
                }
                else
                {
                    writer.WriteNull("stackEnsembleSettings");
                }
            }
            if (Optional.IsDefined(IsStackEnsembleEnabled))
            {
                writer.WritePropertyName("enableStackEnsemble"u8);
                writer.WriteBooleanValue(IsStackEnsembleEnabled.Value);
            }
            if (Optional.IsDefined(IsVoteEnsembleEnabled))
            {
                writer.WritePropertyName("enableVoteEnsemble"u8);
                writer.WriteBooleanValue(IsVoteEnsembleEnabled.Value);
            }
            if (Optional.IsDefined(EnsembleModelDownloadTimeout))
            {
                writer.WritePropertyName("ensembleModelDownloadTimeout"u8);
                writer.WriteStringValue(EnsembleModelDownloadTimeout.Value, "P");
            }
            if (Optional.IsDefined(IsModelExplainabilityEnabled))
            {
                writer.WritePropertyName("enableModelExplainability"u8);
                writer.WriteBooleanValue(IsModelExplainabilityEnabled.Value);
            }
<<<<<<< HEAD
            if (Optional.IsDefined(IsDnnTrainingEnabled))
            {
                writer.WritePropertyName("enableDnnTraining"u8);
                writer.WriteBooleanValue(IsDnnTrainingEnabled.Value);
            }
=======
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
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

        MachineLearningTrainingSettings IJsonModel<MachineLearningTrainingSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningTrainingSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningTrainingSettings(document.RootElement, options);
        }

        internal static MachineLearningTrainingSettings DeserializeMachineLearningTrainingSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enableOnnxCompatibleModels = default;
            MachineLearningStackEnsembleSettings stackEnsembleSettings = default;
            bool? enableStackEnsemble = default;
            bool? enableVoteEnsemble = default;
            TimeSpan? ensembleModelDownloadTimeout = default;
<<<<<<< HEAD
            bool? enableModelExplainability = default;
            bool? enableDnnTraining = default;
=======
            MachineLearningStackEnsembleSettings stackEnsembleSettings = default;
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableOnnxCompatibleModels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableOnnxCompatibleModels = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("stackEnsembleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stackEnsembleSettings = null;
                        continue;
                    }
                    stackEnsembleSettings = MachineLearningStackEnsembleSettings.DeserializeMachineLearningStackEnsembleSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("enableStackEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableStackEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableVoteEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableVoteEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ensembleModelDownloadTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ensembleModelDownloadTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("enableModelExplainability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableModelExplainability = property.Value.GetBoolean();
                    continue;
                }
<<<<<<< HEAD
                if (property.NameEquals("enableDnnTraining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDnnTraining = property.Value.GetBoolean();
                    continue;
                }
=======
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningTrainingSettings(
                enableOnnxCompatibleModels,
                stackEnsembleSettings,
                enableStackEnsemble,
                enableVoteEnsemble,
                ensembleModelDownloadTimeout,
<<<<<<< HEAD
                enableModelExplainability,
                enableDnnTraining,
=======
                stackEnsembleSettings,
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningTrainingSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningTrainingSettings)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningTrainingSettings IPersistableModel<MachineLearningTrainingSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningTrainingSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningTrainingSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningTrainingSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
