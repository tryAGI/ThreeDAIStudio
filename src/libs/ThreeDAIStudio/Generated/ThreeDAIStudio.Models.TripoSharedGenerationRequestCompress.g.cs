
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum TripoSharedGenerationRequestCompress
    {
        /// <summary>
        /// 
        /// </summary>
        Geometry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TripoSharedGenerationRequestCompressExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TripoSharedGenerationRequestCompress value)
        {
            return value switch
            {
                TripoSharedGenerationRequestCompress.Geometry => "geometry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TripoSharedGenerationRequestCompress? ToEnum(string value)
        {
            return value switch
            {
                "geometry" => TripoSharedGenerationRequestCompress.Geometry,
                _ => null,
            };
        }
    }
}