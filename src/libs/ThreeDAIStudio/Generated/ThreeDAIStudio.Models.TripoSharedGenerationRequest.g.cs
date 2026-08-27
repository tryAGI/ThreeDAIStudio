
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TripoSharedGenerationRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture")]
        public bool? Texture { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pbr")]
        public bool? Pbr { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ThreeDAIStudio.JsonConverters.TripoSharedGenerationRequestTextureQualityJsonConverter))]
        public global::ThreeDAIStudio.TripoSharedGenerationRequestTextureQuality? TextureQuality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_seed")]
        public int? TextureSeed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geometry_quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ThreeDAIStudio.JsonConverters.TripoSharedGenerationRequestGeometryQualityJsonConverter))]
        public global::ThreeDAIStudio.TripoSharedGenerationRequestGeometryQuality? GeometryQuality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_limit")]
        public int? FaceLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quad")]
        public bool? Quad { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smart_low_poly")]
        public bool? SmartLowPoly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_parts")]
        public bool? GenerateParts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_uv")]
        public bool? ExportUv { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_size")]
        public bool? AutoSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compress")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ThreeDAIStudio.JsonConverters.TripoSharedGenerationRequestCompressJsonConverter))]
        public global::ThreeDAIStudio.TripoSharedGenerationRequestCompress? Compress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TripoSharedGenerationRequest" /> class.
        /// </summary>
        /// <param name="negativePrompt"></param>
        /// <param name="texture"></param>
        /// <param name="pbr"></param>
        /// <param name="textureQuality"></param>
        /// <param name="textureSeed"></param>
        /// <param name="geometryQuality"></param>
        /// <param name="faceLimit"></param>
        /// <param name="quad"></param>
        /// <param name="smartLowPoly"></param>
        /// <param name="generateParts"></param>
        /// <param name="exportUv"></param>
        /// <param name="autoSize"></param>
        /// <param name="compress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TripoSharedGenerationRequest(
            string? negativePrompt,
            bool? texture,
            bool? pbr,
            global::ThreeDAIStudio.TripoSharedGenerationRequestTextureQuality? textureQuality,
            int? textureSeed,
            global::ThreeDAIStudio.TripoSharedGenerationRequestGeometryQuality? geometryQuality,
            int? faceLimit,
            bool? quad,
            bool? smartLowPoly,
            bool? generateParts,
            bool? exportUv,
            bool? autoSize,
            global::ThreeDAIStudio.TripoSharedGenerationRequestCompress? compress)
        {
            this.NegativePrompt = negativePrompt;
            this.Texture = texture;
            this.Pbr = pbr;
            this.TextureQuality = textureQuality;
            this.TextureSeed = textureSeed;
            this.GeometryQuality = geometryQuality;
            this.FaceLimit = faceLimit;
            this.Quad = quad;
            this.SmartLowPoly = smartLowPoly;
            this.GenerateParts = generateParts;
            this.ExportUv = exportUv;
            this.AutoSize = autoSize;
            this.Compress = compress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TripoSharedGenerationRequest" /> class.
        /// </summary>
        public TripoSharedGenerationRequest()
        {
        }

    }
}