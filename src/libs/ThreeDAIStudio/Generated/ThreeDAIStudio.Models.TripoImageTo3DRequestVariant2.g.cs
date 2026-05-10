
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TripoImageTo3DRequestVariant2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_alignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ThreeDAIStudio.JsonConverters.TripoImageTo3DRequestVariant2TextureAlignmentJsonConverter))]
        public global::ThreeDAIStudio.TripoImageTo3DRequestVariant2TextureAlignment? TextureAlignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_image_autofix")]
        public bool? EnableImageAutofix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TripoImageTo3DRequestVariant2" /> class.
        /// </summary>
        /// <param name="image">
        /// Base64-encoded image input.
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="textureAlignment"></param>
        /// <param name="enableImageAutofix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TripoImageTo3DRequestVariant2(
            string? image,
            string? imageUrl,
            global::ThreeDAIStudio.TripoImageTo3DRequestVariant2TextureAlignment? textureAlignment,
            bool? enableImageAutofix)
        {
            this.Image = image;
            this.ImageUrl = imageUrl;
            this.TextureAlignment = textureAlignment;
            this.EnableImageAutofix = enableImageAutofix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TripoImageTo3DRequestVariant2" /> class.
        /// </summary>
        public TripoImageTo3DRequestVariant2()
        {
        }

    }
}