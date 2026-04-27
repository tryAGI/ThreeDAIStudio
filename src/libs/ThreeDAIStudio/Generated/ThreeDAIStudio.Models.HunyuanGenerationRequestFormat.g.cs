
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum HunyuanGenerationRequestFormat
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
    public static class HunyuanGenerationRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HunyuanGenerationRequestFormat value)
        {
            return value switch
            {
                HunyuanGenerationRequestFormat.Fbx => "fbx",
                HunyuanGenerationRequestFormat.Glb => "glb",
                HunyuanGenerationRequestFormat.Obj => "obj",
                HunyuanGenerationRequestFormat.Stl => "stl",
                HunyuanGenerationRequestFormat.Usdz => "usdz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HunyuanGenerationRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "fbx" => HunyuanGenerationRequestFormat.Fbx,
                "glb" => HunyuanGenerationRequestFormat.Glb,
                "obj" => HunyuanGenerationRequestFormat.Obj,
                "stl" => HunyuanGenerationRequestFormat.Stl,
                "usdz" => HunyuanGenerationRequestFormat.Usdz,
                _ => null,
            };
        }
    }
}