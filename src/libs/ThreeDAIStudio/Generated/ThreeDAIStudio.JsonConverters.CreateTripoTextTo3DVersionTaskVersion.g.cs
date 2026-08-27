#nullable enable

namespace ThreeDAIStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTripoTextTo3DVersionTaskVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ThreeDAIStudio.CreateTripoTextTo3DVersionTaskVersion>
    {
        /// <inheritdoc />
        public override global::ThreeDAIStudio.CreateTripoTextTo3DVersionTaskVersion Read(
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
                        return global::ThreeDAIStudio.CreateTripoTextTo3DVersionTaskVersionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ThreeDAIStudio.CreateTripoTextTo3DVersionTaskVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ThreeDAIStudio.CreateTripoTextTo3DVersionTaskVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ThreeDAIStudio.CreateTripoTextTo3DVersionTaskVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ThreeDAIStudio.CreateTripoTextTo3DVersionTaskVersionExtensions.ToValueString(value));
        }
    }
}
