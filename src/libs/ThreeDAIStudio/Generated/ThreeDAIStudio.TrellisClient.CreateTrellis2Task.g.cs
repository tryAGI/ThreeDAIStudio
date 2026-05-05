
#nullable enable

namespace ThreeDAIStudio
{
    public partial class TrellisClient
    {


        private static readonly global::ThreeDAIStudio.EndPointSecurityRequirement s_CreateTrellis2TaskSecurityRequirement0 =
            new global::ThreeDAIStudio.EndPointSecurityRequirement
            {
                Authorizations = new global::ThreeDAIStudio.EndPointAuthorizationRequirement[]
                {                    new global::ThreeDAIStudio.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::ThreeDAIStudio.EndPointSecurityRequirement[] s_CreateTrellis2TaskSecurityRequirements =
            new global::ThreeDAIStudio.EndPointSecurityRequirement[]
            {                s_CreateTrellis2TaskSecurityRequirement0,
            };
        partial void PrepareCreateTrellis2TaskArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ThreeDAIStudio.Trellis2GenerationRequest request);
        partial void PrepareCreateTrellis2TaskRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ThreeDAIStudio.Trellis2GenerationRequest request);
        partial void ProcessCreateTrellis2TaskResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTrellis2TaskResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate a TRELLIS.2 model from an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ThreeDAIStudio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ThreeDAIStudio.GenerationTaskResponse> CreateTrellis2TaskAsync(

            global::ThreeDAIStudio.Trellis2GenerationRequest request,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateTrellis2TaskAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Generate a TRELLIS.2 model from an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ThreeDAIStudio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ThreeDAIStudio.AutoSDKHttpResponse<global::ThreeDAIStudio.GenerationTaskResponse>> CreateTrellis2TaskAsResponseAsync(

            global::ThreeDAIStudio.Trellis2GenerationRequest request,
            global::ThreeDAIStudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTrellis2TaskArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::ThreeDAIStudio.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTrellis2TaskSecurityRequirements,
                operationName: "CreateTrellis2TaskAsync");

            using var __timeoutCancellationTokenSource = global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::ThreeDAIStudio.PathBuilder(
                                path: "/v1/3d-models/trellis2/generate/",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateTrellis2TaskRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTrellis2Task",
                                methodName: "CreateTrellis2TaskAsync",
                                pathTemplate: "\"/v1/3d-models/trellis2/generate/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTrellis2Task",
                                methodName: "CreateTrellis2TaskAsync",
                                pathTemplate: "\"/v1/3d-models/trellis2/generate/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTrellis2Task",
                                methodName: "CreateTrellis2TaskAsync",
                                pathTemplate: "\"/v1/3d-models/trellis2/generate/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateTrellis2TaskResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTrellis2Task",
                                methodName: "CreateTrellis2TaskAsync",
                                pathTemplate: "\"/v1/3d-models/trellis2/generate/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ThreeDAIStudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTrellis2Task",
                                methodName: "CreateTrellis2TaskAsync",
                                pathTemplate: "\"/v1/3d-models/trellis2/generate/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateTrellis2TaskResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ThreeDAIStudio.GenerationTaskResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ThreeDAIStudio.AutoSDKHttpResponse<global::ThreeDAIStudio.GenerationTaskResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ThreeDAIStudio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::ThreeDAIStudio.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::ThreeDAIStudio.GenerationTaskResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ThreeDAIStudio.AutoSDKHttpResponse<global::ThreeDAIStudio.GenerationTaskResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ThreeDAIStudio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::ThreeDAIStudio.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::ThreeDAIStudio.GenerationTaskResponse> CreateTrellis2TaskAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ThreeDAIStudio.Trellis2GenerationRequest
            {
                Image = image,
                ImageUrl = imageUrl,
                Resolution = resolution,
                Steps = steps,
                Textures = textures,
                TextureSize = textureSize,
                DecimationTarget = decimationTarget,
                Seed = seed,
                GenerateThumbnail = generateThumbnail,
            };

            return await CreateTrellis2TaskAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}