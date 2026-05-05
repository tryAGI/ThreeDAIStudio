#nullable enable

namespace ThreeDAIStudio
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Get generation task status
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ThreeDAIStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.GenerationStatusResponse> GetGenerationRequestStatusAsync(
            string taskId,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get generation task status
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ThreeDAIStudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ThreeDAIStudio.AutoSDKHttpResponse<global::ThreeDAIStudio.GenerationStatusResponse>> GetGenerationRequestStatusAsResponseAsync(
            string taskId,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}