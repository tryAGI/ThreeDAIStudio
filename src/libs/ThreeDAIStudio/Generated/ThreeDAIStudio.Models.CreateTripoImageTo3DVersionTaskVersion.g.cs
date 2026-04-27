
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTripoImageTo3DVersionTaskVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x30,
        /// <summary>
        /// 
        /// </summary>
        x31,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTripoImageTo3DVersionTaskVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTripoImageTo3DVersionTaskVersion value)
        {
            return value switch
            {
                CreateTripoImageTo3DVersionTaskVersion.x30 => "3.0",
                CreateTripoImageTo3DVersionTaskVersion.x31 => "3.1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTripoImageTo3DVersionTaskVersion? ToEnum(string value)
        {
            return value switch
            {
                "3.0" => CreateTripoImageTo3DVersionTaskVersion.x30,
                "3.1" => CreateTripoImageTo3DVersionTaskVersion.x31,
                _ => null,
            };
        }
    }
}