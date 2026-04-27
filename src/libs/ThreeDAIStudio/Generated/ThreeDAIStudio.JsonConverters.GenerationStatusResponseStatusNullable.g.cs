#nullable enable

namespace ThreeDAIStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationStatusResponseStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ThreeDAIStudio.GenerationStatusResponseStatus?>
    {
        /// <inheritdoc />
        public override global::ThreeDAIStudio.GenerationStatusResponseStatus? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::ThreeDAIStudio.GenerationStatusResponseStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ThreeDAIStudio.GenerationStatusResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ThreeDAIStudio.GenerationStatusResponseStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ThreeDAIStudio.GenerationStatusResponseStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ThreeDAIStudio.GenerationStatusResponseStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
