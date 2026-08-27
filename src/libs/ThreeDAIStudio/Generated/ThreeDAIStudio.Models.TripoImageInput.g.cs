
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TripoImageInput
    {
        /// <summary>
        ///
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
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        public string? View { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TripoImageInput" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="imageUrl"></param>
        /// <param name="view"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TripoImageInput(
            string? image,
            string? imageUrl,
            string? view)
        {
            this.Image = image;
            this.ImageUrl = imageUrl;
            this.View = view;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TripoImageInput" /> class.
        /// </summary>
        public TripoImageInput()
        {
        }

    }
}