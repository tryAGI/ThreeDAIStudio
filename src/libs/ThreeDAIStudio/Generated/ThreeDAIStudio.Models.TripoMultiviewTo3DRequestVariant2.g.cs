
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TripoMultiviewTo3DRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ThreeDAIStudio.TripoImageInput> Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_alignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ThreeDAIStudio.JsonConverters.TripoMultiviewTo3DRequestVariant2TextureAlignmentJsonConverter))]
        public global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2TextureAlignment? TextureAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TripoMultiviewTo3DRequestVariant2" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="textureAlignment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TripoMultiviewTo3DRequestVariant2(
            global::System.Collections.Generic.IList<global::ThreeDAIStudio.TripoImageInput> images,
            global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2TextureAlignment? textureAlignment)
        {
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.TextureAlignment = textureAlignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TripoMultiviewTo3DRequestVariant2" /> class.
        /// </summary>
        public TripoMultiviewTo3DRequestVariant2()
        {
        }

    }
}