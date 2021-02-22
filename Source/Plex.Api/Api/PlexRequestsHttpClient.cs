namespace Plex.Api.Api
{
    using System.Net.Http;
    using System.Threading.Tasks;


    /// <inheritdoc />
    public class PlexRequestsHttpClient : IPlexRequestsHttpClient
    {
        private readonly HttpClient _client;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlexRequestsHttpClient"/> class.
        /// </summary>
        public PlexRequestsHttpClient() => this._client = new HttpClient();

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) =>
            await this._client.SendAsync(request);
    }
}