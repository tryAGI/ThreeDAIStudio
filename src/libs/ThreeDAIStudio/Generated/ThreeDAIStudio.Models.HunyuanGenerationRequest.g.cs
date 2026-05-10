
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HunyuanGenerationRequest
    {
        /// <summary>
        /// Base64-encoded image input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("face_limit")]
        public int? FaceLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ThreeDAIStudio.JsonConverters.HunyuanGenerationRequestFormatJsonConverter))]
        public global::ThreeDAIStudio.HunyuanGenerationRequestFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HunyuanGenerationRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// Base64-encoded image input.
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="prompt"></param>
        /// <param name="seed"></param>
        /// <param name="texture"></param>
        /// <param name="pbr"></param>
        /// <param name="faceLimit"></param>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HunyuanGenerationRequest(
            string? image,
            string? imageUrl,
            string? prompt,
            int? seed,
            bool? texture,
            bool? pbr,
            int? faceLimit,
            global::ThreeDAIStudio.HunyuanGenerationRequestFormat? format)
        {
            this.Image = image;
            this.ImageUrl = imageUrl;
            this.Prompt = prompt;
            this.Seed = seed;
            this.Texture = texture;
            this.Pbr = pbr;
            this.FaceLimit = faceLimit;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HunyuanGenerationRequest" /> class.
        /// </summary>
        public HunyuanGenerationRequest()
        {
        }

    }
}