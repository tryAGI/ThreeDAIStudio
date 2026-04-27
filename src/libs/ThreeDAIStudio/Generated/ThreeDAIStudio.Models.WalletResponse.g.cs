
#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WalletResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        public double? Balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_credits")]
        public double? TotalCredits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_credits")]
        public double? UsedCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletResponse" /> class.
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="balance"></param>
        /// <param name="totalCredits"></param>
        /// <param name="usedCredits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WalletResponse(
            double? credits,
            double? balance,
            double? totalCredits,
            double? usedCredits)
        {
            this.Credits = credits;
            this.Balance = balance;
            this.TotalCredits = totalCredits;
            this.UsedCredits = usedCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletResponse" /> class.
        /// </summary>
        public WalletResponse()
        {
        }
    }
}