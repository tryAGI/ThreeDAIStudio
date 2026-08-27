
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GenerationStatusResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Finished,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationStatusResponseStatus value)
        {
            return value switch
            {
                GenerationStatusResponseStatus.Cancelled => "CANCELLED",
                GenerationStatusResponseStatus.Failed => "FAILED",
                GenerationStatusResponseStatus.Finished => "FINISHED",
                GenerationStatusResponseStatus.Pending => "PENDING",
                GenerationStatusResponseStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => GenerationStatusResponseStatus.Cancelled,
                "FAILED" => GenerationStatusResponseStatus.Failed,
                "FINISHED" => GenerationStatusResponseStatus.Finished,
                "PENDING" => GenerationStatusResponseStatus.Pending,
                "RUNNING" => GenerationStatusResponseStatus.Running,
                _ => null,
            };
        }
    }
}