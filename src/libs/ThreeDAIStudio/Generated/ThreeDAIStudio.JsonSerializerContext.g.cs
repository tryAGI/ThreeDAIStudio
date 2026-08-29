
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ThreeDAIStudio
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ThreeDAIStudio.JsonConverters.HunyuanGenerationRequestFormatJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.HunyuanGenerationRequestFormatNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.Trellis2GenerationRequestResolutionJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.Trellis2GenerationRequestResolutionNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoSharedGenerationRequestTextureQualityJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoSharedGenerationRequestTextureQualityNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoSharedGenerationRequestGeometryQualityJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoSharedGenerationRequestGeometryQualityNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoSharedGenerationRequestCompressJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoSharedGenerationRequestCompressNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoImageTo3DRequestVariant2TextureAlignmentJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoImageTo3DRequestVariant2TextureAlignmentNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoMultiviewTo3DRequestVariant2TextureAlignmentJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoMultiviewTo3DRequestVariant2TextureAlignmentNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.ConvertRequestOutputFormatJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.ConvertRequestOutputFormatNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.GenerationStatusResponseStatusJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.GenerationStatusResponseStatusNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.CreateTripoTextTo3DVersionTaskVersionJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.CreateTripoTextTo3DVersionTaskVersionNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.CreateTripoImageTo3DVersionTaskVersionJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.CreateTripoImageTo3DVersionTaskVersionNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.CreateTripoMultiviewTo3DVersionTaskVersionJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.CreateTripoMultiviewTo3DVersionTaskVersionNullableJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoTextTo3DRequestJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoImageTo3DRequestJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.TripoMultiviewTo3DRequestJsonConverter),

            typeof(global::ThreeDAIStudio.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.WalletResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.HunyuanGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.HunyuanGenerationRequestFormat), TypeInfoPropertyName = "HunyuanGenerationRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.Trellis2GenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.Trellis2GenerationRequestResolution), TypeInfoPropertyName = "Trellis2GenerationRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoSharedGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoSharedGenerationRequestTextureQuality), TypeInfoPropertyName = "TripoSharedGenerationRequestTextureQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoSharedGenerationRequestGeometryQuality), TypeInfoPropertyName = "TripoSharedGenerationRequestGeometryQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoSharedGenerationRequestCompress), TypeInfoPropertyName = "TripoSharedGenerationRequestCompress2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoTextTo3DRequest), TypeInfoPropertyName = "TripoTextTo3DRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoTextTo3DRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoImageTo3DRequest), TypeInfoPropertyName = "TripoImageTo3DRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoImageTo3DRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoImageTo3DRequestVariant2TextureAlignment), TypeInfoPropertyName = "TripoImageTo3DRequestVariant2TextureAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoMultiviewTo3DRequest), TypeInfoPropertyName = "TripoMultiviewTo3DRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ThreeDAIStudio.TripoImageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoImageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2TextureAlignment), TypeInfoPropertyName = "TripoMultiviewTo3DRequestVariant2TextureAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.ConvertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.ConvertRequestOutputFormat), TypeInfoPropertyName = "ConvertRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.GenerationTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.GenerationStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.GenerationStatusResponseStatus), TypeInfoPropertyName = "GenerationStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ThreeDAIStudio.GenerationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.GenerationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.CreateTripoTextTo3DVersionTaskVersion), TypeInfoPropertyName = "CreateTripoTextTo3DVersionTaskVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.CreateTripoImageTo3DVersionTaskVersion), TypeInfoPropertyName = "CreateTripoImageTo3DVersionTaskVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ThreeDAIStudio.CreateTripoMultiviewTo3DVersionTaskVersion), TypeInfoPropertyName = "CreateTripoMultiviewTo3DVersionTaskVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ThreeDAIStudio.TripoImageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ThreeDAIStudio.GenerationResult>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}