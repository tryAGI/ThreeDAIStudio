
#nullable enable

namespace ThreeDAIStudio
{
    public partial interface IThreeDAIStudioClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}