
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum TripoSharedGenerationRequestGeometryQuality
    {
        /// <summary>
        /// 
        /// </summary>
        Detailed,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TripoSharedGenerationRequestGeometryQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TripoSharedGenerationRequestGeometryQuality value)
        {
            return value switch
            {
                TripoSharedGenerationRequestGeometryQuality.Detailed => "detailed",
                TripoSharedGenerationRequestGeometryQuality.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TripoSharedGenerationRequestGeometryQuality? ToEnum(string value)
        {
            return value switch
            {
                "detailed" => TripoSharedGenerationRequestGeometryQuality.Detailed,
                "standard" => TripoSharedGenerationRequestGeometryQuality.Standard,
                _ => null,
            };
        }
    }
}