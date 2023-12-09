using System.Net.Http.Json;
using UntitledApp2.Models.DocumentsApi;

namespace UntitledApp2.DocumentsApi
{
    public class DocumentsApiService: IDocumentsApiService
    {
        private readonly HttpClient _http;

        public DocumentsApiService(HttpClient http)
        {
            _http = http;
        }

        public async Task<GetDocumentResponseDtoListServiceResponse> GetGetDocumentResponseDtoListServiceResponse()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://localhost:8200/api/v1/Documents", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<GetDocumentResponseDtoListServiceResponse>().ConfigureAwait(false);
            }

            return new GetDocumentResponseDtoListServiceResponse();
        }

        public async Task<GetDocumentResponseDtoServiceResponse> PostGetDocumentResponseDtoServiceResponse(object data)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, new Uri("https://localhost:8200/api/v1/Documents", UriKind.RelativeOrAbsolute));
            request.Content = new StringContent(@"{
  ""process"": ""string"",
  ""subProcess"": ""string"",
  ""requirement"": ""string"",
  ""detailedDocument"": ""string"",
  ""sequence"": 123,
  ""dateCreated"": ""string"",
  ""dateUpdated"": ""string""
}", System.Text.Encoding.UTF8, "application/json");
            request.Content = JsonContent.Create(data);
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<GetDocumentResponseDtoServiceResponse>().ConfigureAwait(false);
            }

            return new GetDocumentResponseDtoServiceResponse();
        }

        public async Task<GetDocumentResponseDtoServiceResponse> PutGetDocumentResponseDtoServiceResponse(object data)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, new Uri("https://localhost:8200/api/v1/Documents", UriKind.RelativeOrAbsolute));
            request.Content = new StringContent(@"{
  ""id"": ""string"",
  ""process"": ""string"",
  ""subProcess"": ""string"",
  ""requirement"": ""string"",
  ""detailedDocument"": ""string"",
  ""sequence"": 123,
  ""dateUpdated"": ""string""
}", System.Text.Encoding.UTF8, "application/json");
            request.Content = JsonContent.Create(data);
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<GetDocumentResponseDtoServiceResponse>().ConfigureAwait(false);
            }

            return new GetDocumentResponseDtoServiceResponse();
        }

        public async Task<GetDocumentResponseDtoServiceResponse> DeleteGetDocumentResponseDtoServiceResponse(string id)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, new Uri("https://localhost:8200/api/v1/Documents", UriKind.RelativeOrAbsolute));
            var query = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                ["id"] = id,
            }).ReadAsStringAsync().Result;
            request.RequestUri = new UriBuilder(request.RequestUri) { Query = query }.Uri;
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<GetDocumentResponseDtoServiceResponse>().ConfigureAwait(false);
            }

            return new GetDocumentResponseDtoServiceResponse();
        }
    }
}
