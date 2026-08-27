
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    ///
    /// </summary>
    public enum ConvertRequestOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Fbx,
        /// <summary>
        ///
        /// </summary>
        Glb,
        /// <summary>
        ///
        /// </summary>
        Obj,
        /// <summary>
        ///
        /// </summary>
        Stl,
        /// <summary>
        ///
        /// </summary>
        Usdz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConvertRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvertRequestOutputFormat value)
        {
            return value switch
            {
                ConvertRequestOutputFormat.Fbx => "fbx",
                ConvertRequestOutputFormat.Glb => "glb",
                ConvertRequestOutputFormat.Obj => "obj",
                ConvertRequestOutputFormat.Stl => "stl",
                ConvertRequestOutputFormat.Usdz => "usdz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvertRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "fbx" => ConvertRequestOutputFormat.Fbx,
                "glb" => ConvertRequestOutputFormat.Glb,
                "obj" => ConvertRequestOutputFormat.Obj,
                "stl" => ConvertRequestOutputFormat.Stl,
                "usdz" => ConvertRequestOutputFormat.Usdz,
                _ => null,
            };
        }
    }
}