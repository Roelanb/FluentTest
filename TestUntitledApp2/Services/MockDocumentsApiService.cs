using UntitledApp2.Models.DocumentsApi;

namespace UntitledApp2.DocumentsApi
{
    public class MockDocumentsApiService : IDocumentsApiService
    {
        public Task<GetDocumentResponseDtoListServiceResponse> GetGetDocumentResponseDtoListServiceResponse()
        {
            return Task.FromResult<GetDocumentResponseDtoListServiceResponse>(new());
        }

        public Task<GetDocumentResponseDtoServiceResponse> PostGetDocumentResponseDtoServiceResponse(object data)
        {
            return Task.FromResult<GetDocumentResponseDtoServiceResponse>(new());
        }

        public Task<GetDocumentResponseDtoServiceResponse> PutGetDocumentResponseDtoServiceResponse(object data)
        {
            return Task.FromResult<GetDocumentResponseDtoServiceResponse>(new());
        }

        public Task<GetDocumentResponseDtoServiceResponse> DeleteGetDocumentResponseDtoServiceResponse(string id)
        {
            return Task.FromResult<GetDocumentResponseDtoServiceResponse>(new());
        }
    }
}
