
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Trellis2GenerationRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ThreeDAIStudio.JsonConverters.Trellis2GenerationRequestResolutionJsonConverter))]
        public global::ThreeDAIStudio.Trellis2GenerationRequestResolution? Resolution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textures")]
        public bool? Textures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_size")]
        public int? TextureSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decimation_target")]
        public int? DecimationTarget { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_thumbnail")]
        public bool? GenerateThumbnail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Trellis2GenerationRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// Base64-encoded image input.
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="resolution"></param>
        /// <param name="steps"></param>
        /// <param name="textures"></param>
        /// <param name="textureSize"></param>
        /// <param name="decimationTarget"></param>
        /// <param name="seed"></param>
        /// <param name="generateThumbnail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Trellis2GenerationRequest(
            string? image,
            string? imageUrl,
            global::ThreeDAIStudio.Trellis2GenerationRequestResolution? resolution,
            int? steps,
            bool? textures,
            int? textureSize,
            int? decimationTarget,
            int? seed,
            bool? generateThumbnail)
        {
            this.Image = image;
            this.ImageUrl = imageUrl;
            this.Resolution = resolution;
            this.Steps = steps;
            this.Textures = textures;
            this.TextureSize = textureSize;
            this.DecimationTarget = decimationTarget;
            this.Seed = seed;
            this.GenerateThumbnail = generateThumbnail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trellis2GenerationRequest" /> class.
        /// </summary>
        public Trellis2GenerationRequest()
        {
        }

    }
}