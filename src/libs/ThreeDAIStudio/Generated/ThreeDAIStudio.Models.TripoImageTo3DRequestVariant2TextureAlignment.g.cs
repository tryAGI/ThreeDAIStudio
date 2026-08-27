
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    ///
    /// </summary>
    public enum TripoImageTo3DRequestVariant2TextureAlignment
    {
        /// <summary>
        ///
        /// </summary>
        Geometry,
        /// <summary>
        ///
        /// </summary>
        OriginalImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TripoImageTo3DRequestVariant2TextureAlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TripoImageTo3DRequestVariant2TextureAlignment value)
        {
            return value switch
            {
                TripoImageTo3DRequestVariant2TextureAlignment.Geometry => "geometry",
                TripoImageTo3DRequestVariant2TextureAlignment.OriginalImage => "original_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TripoImageTo3DRequestVariant2TextureAlignment? ToEnum(string value)
        {
            return value switch
            {
                "geometry" => TripoImageTo3DRequestVariant2TextureAlignment.Geometry,
                "original_image" => TripoImageTo3DRequestVariant2TextureAlignment.OriginalImage,
                _ => null,
            };
        }
    }
}