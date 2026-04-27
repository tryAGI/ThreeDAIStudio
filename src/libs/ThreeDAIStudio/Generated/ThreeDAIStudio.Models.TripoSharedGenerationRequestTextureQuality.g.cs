
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum TripoSharedGenerationRequestTextureQuality
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
    public static class TripoSharedGenerationRequestTextureQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TripoSharedGenerationRequestTextureQuality value)
        {
            return value switch
            {
                TripoSharedGenerationRequestTextureQuality.Detailed => "detailed",
                TripoSharedGenerationRequestTextureQuality.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TripoSharedGenerationRequestTextureQuality? ToEnum(string value)
        {
            return value switch
            {
                "detailed" => TripoSharedGenerationRequestTextureQuality.Detailed,
                "standard" => TripoSharedGenerationRequestTextureQuality.Standard,
                _ => null,
            };
        }
    }
}