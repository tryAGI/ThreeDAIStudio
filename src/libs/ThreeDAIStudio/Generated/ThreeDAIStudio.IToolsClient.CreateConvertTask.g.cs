#nullable enable

namespace ThreeDAIStudio
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Convert a model file
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ThreeDAIStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.GenerationTaskResponse> CreateConvertTaskAsync(

            global::ThreeDAIStudio.ConvertRequest request,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert a model file
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ThreeDAIStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.AutoSDKHttpResponse<global::ThreeDAIStudio.GenerationTaskResponse>> CreateConvertTaskAsResponseAsync(

            global::ThreeDAIStudio.ConvertRequest request,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert a model file
        /// </summary>
        /// <param name="modelUrl"></param>
        /// <param name="model"></param>
        /// <param name="outputFormat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.GenerationTaskResponse> CreateConvertTaskAsync(
            string? modelUrl = default,
            string? model = default,
            global::ThreeDAIStudio.ConvertRequestOutputFormat? outputFormat = default,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}