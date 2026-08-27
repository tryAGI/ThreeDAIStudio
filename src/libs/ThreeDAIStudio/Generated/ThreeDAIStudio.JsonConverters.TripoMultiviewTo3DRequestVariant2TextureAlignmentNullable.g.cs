#nullable enable

namespace ThreeDAIStudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class TripoMultiviewTo3DRequestVariant2TextureAlignmentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2TextureAlignment?>
    {
        /// <inheritdoc />
        public override global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2TextureAlignment? Read(
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
                        return global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2TextureAlignmentExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2TextureAlignment)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2TextureAlignment?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2TextureAlignment? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2TextureAlignmentExtensions.ToValueString(value.Value));
            }
        }
    }
}
