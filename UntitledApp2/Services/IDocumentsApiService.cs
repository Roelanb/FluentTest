using UntitledApp2.Models.DocumentsApi;

namespace UntitledApp2.DocumentsApi
{
    public interface IDocumentsApiService
    {
        Task<GetDocumentResponseDtoListServiceResponse> GetGetDocumentResponseDtoListServiceResponse();
        Task<GetDocumentResponseDtoServiceResponse> PostGetDocumentResponseDtoServiceResponse(object data);
        Task<GetDocumentResponseDtoServiceResponse> PutGetDocumentResponseDtoServiceResponse(object data);
        Task<GetDocumentResponseDtoServiceResponse> DeleteGetDocumentResponseDtoServiceResponse(string id);
    }
}
