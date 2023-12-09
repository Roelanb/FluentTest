namespace UntitledApp2.Models.DocumentsApi;

public class GetDocumentResponseDtoListServiceResponse
{
    public GetDocumentResponseDto[] Data { get; set; } = Array.Empty<GetDocumentResponseDto>();
    public bool Success { get; set; }
    public string Message { get; set; }
}
