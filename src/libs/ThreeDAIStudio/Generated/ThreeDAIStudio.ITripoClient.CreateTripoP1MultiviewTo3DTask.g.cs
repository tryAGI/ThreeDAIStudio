#nullable enable

namespace ThreeDAIStudio
{
    public partial interface ITripoClient
    {
        /// <summary>
        /// Generate a Tripo P1 model from multiple views
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ThreeDAIStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.GenerationTaskResponse> CreateTripoP1MultiviewTo3DTaskAsync(

            global::ThreeDAIStudio.TripoMultiviewTo3DRequest request,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a Tripo P1 model from multiple views
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ThreeDAIStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.AutoSDKHttpResponse<global::ThreeDAIStudio.GenerationTaskResponse>> CreateTripoP1MultiviewTo3DTaskAsResponseAsync(

            global::ThreeDAIStudio.TripoMultiviewTo3DRequest request,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a Tripo P1 model from multiple views
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.GenerationTaskResponse> CreateTripoP1MultiviewTo3DTaskAsync(
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}