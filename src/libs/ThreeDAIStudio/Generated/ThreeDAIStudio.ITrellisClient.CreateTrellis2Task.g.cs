#nullable enable

namespace ThreeDAIStudio
{
    public partial interface ITrellisClient
    {
        /// <summary>
        /// Generate a TRELLIS.2 model from an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ThreeDAIStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.GenerationTaskResponse> CreateTrellis2TaskAsync(

            global::ThreeDAIStudio.Trellis2GenerationRequest request,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a TRELLIS.2 model from an image
        /// </summary>
        /// <param name="image">
        /// Base64-encoded image input.
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="resolution"></param>
        /// <param name="steps"></param>
        /// <param name="textures"></param>
        /// <param name="textureSize"></param>
        /// <param name="decimationTarget"></param>
        /// <param name="seed"></param>
        /// <param name="generateThumbnail"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.GenerationTaskResponse> CreateTrellis2TaskAsync(
            string? image = default,
            string? imageUrl = default,
            global::ThreeDAIStudio.Trellis2GenerationRequestResolution? resolution = default,
            int? steps = default,
            bool? textures = default,
            int? textureSize = default,
            int? decimationTarget = default,
            int? seed = default,
            bool? generateThumbnail = default,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}