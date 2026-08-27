
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    ///
    /// </summary>
    public enum Trellis2GenerationRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1024,
        /// <summary>
        ///
        /// </summary>
        x1536,
        /// <summary>
        ///
        /// </summary>
        x512,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Trellis2GenerationRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Trellis2GenerationRequestResolution value)
        {
            return value switch
            {
                Trellis2GenerationRequestResolution.x1024 => "1024",
                Trellis2GenerationRequestResolution.x1536 => "1536",
                Trellis2GenerationRequestResolution.x512 => "512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Trellis2GenerationRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1024" => Trellis2GenerationRequestResolution.x1024,
                "1536" => Trellis2GenerationRequestResolution.x1536,
                "512" => Trellis2GenerationRequestResolution.x512,
                _ => null,
            };
        }
    }
}