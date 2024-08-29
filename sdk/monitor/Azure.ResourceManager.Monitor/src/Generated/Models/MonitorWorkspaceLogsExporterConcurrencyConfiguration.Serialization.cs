// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorWorkspaceLogsExporterConcurrencyConfiguration : IUtf8JsonSerializable, IJsonModel<MonitorWorkspaceLogsExporterConcurrencyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorWorkspaceLogsExporterConcurrencyConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MonitorWorkspaceLogsExporterConcurrencyConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsExporterConcurrencyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWorkspaceLogsExporterConcurrencyConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(WorkerCount))
            {
                writer.WritePropertyName("workerCount"u8);
                writer.WriteNumberValue(WorkerCount.Value);
            }
            if (Optional.IsDefined(BatchQueueSize))
            {
                writer.WritePropertyName("batchQueueSize"u8);
                writer.WriteNumberValue(BatchQueueSize.Value);
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

        MonitorWorkspaceLogsExporterConcurrencyConfiguration IJsonModel<MonitorWorkspaceLogsExporterConcurrencyConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsExporterConcurrencyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWorkspaceLogsExporterConcurrencyConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorWorkspaceLogsExporterConcurrencyConfiguration(document.RootElement, options);
        }

        internal static MonitorWorkspaceLogsExporterConcurrencyConfiguration DeserializeMonitorWorkspaceLogsExporterConcurrencyConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? workerCount = default;
            int? batchQueueSize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workerCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workerCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("batchQueueSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    batchQueueSize = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MonitorWorkspaceLogsExporterConcurrencyConfiguration(workerCount, batchQueueSize, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorWorkspaceLogsExporterConcurrencyConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsExporterConcurrencyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorWorkspaceLogsExporterConcurrencyConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        MonitorWorkspaceLogsExporterConcurrencyConfiguration IPersistableModel<MonitorWorkspaceLogsExporterConcurrencyConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWorkspaceLogsExporterConcurrencyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorWorkspaceLogsExporterConcurrencyConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorWorkspaceLogsExporterConcurrencyConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorWorkspaceLogsExporterConcurrencyConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
