#nullable enable

namespace ThreeDAIStudio
{
    public partial interface IHunyuanClient
    {
        /// <summary>
        /// Generate a Hunyuan 3D model with the pro endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ThreeDAIStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.GenerationTaskResponse> CreateTencentHunyuanProTaskAsync(

            global::ThreeDAIStudio.HunyuanGenerationRequest request,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a Hunyuan 3D model with the pro endpoint
        /// </summary>
        /// <param name="image">
        /// Base64-encoded image input.
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="prompt"></param>
        /// <param name="seed"></param>
        /// <param name="texture"></param>
        /// <param name="pbr"></param>
        /// <param name="faceLimit"></param>
        /// <param name="format"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.GenerationTaskResponse> CreateTencentHunyuanProTaskAsync(
            string? image = default,
            string? imageUrl = default,
            string? prompt = default,
            int? seed = default,
            bool? texture = default,
            bool? pbr = default,
            int? faceLimit = default,
            global::ThreeDAIStudio.HunyuanGenerationRequestFormat? format = default,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}