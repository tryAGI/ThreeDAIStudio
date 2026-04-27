
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum TripoMultiviewTo3DRequestVariant2TextureAlignment
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
    public static class TripoMultiviewTo3DRequestVariant2TextureAlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TripoMultiviewTo3DRequestVariant2TextureAlignment value)
        {
            return value switch
            {
                TripoMultiviewTo3DRequestVariant2TextureAlignment.Geometry => "geometry",
                TripoMultiviewTo3DRequestVariant2TextureAlignment.OriginalImage => "original_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TripoMultiviewTo3DRequestVariant2TextureAlignment? ToEnum(string value)
        {
            return value switch
            {
                "geometry" => TripoMultiviewTo3DRequestVariant2TextureAlignment.Geometry,
                "original_image" => TripoMultiviewTo3DRequestVariant2TextureAlignment.OriginalImage,
                _ => null,
            };
        }
    }
}