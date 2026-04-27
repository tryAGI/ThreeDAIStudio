
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTripoTextTo3DVersionTaskVersion
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
    public static class CreateTripoTextTo3DVersionTaskVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTripoTextTo3DVersionTaskVersion value)
        {
            return value switch
            {
                CreateTripoTextTo3DVersionTaskVersion.x30 => "3.0",
                CreateTripoTextTo3DVersionTaskVersion.x31 => "3.1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTripoTextTo3DVersionTaskVersion? ToEnum(string value)
        {
            return value switch
            {
                "3.0" => CreateTripoTextTo3DVersionTaskVersion.x30,
                "3.1" => CreateTripoTextTo3DVersionTaskVersion.x31,
                _ => null,
            };
        }
    }
}