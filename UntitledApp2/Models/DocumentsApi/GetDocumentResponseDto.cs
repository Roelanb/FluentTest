namespace UntitledApp2.Models.DocumentsApi;

public class GetDocumentResponseDto
{
    public string Id { get; set; }
    public string Process { get; set; }
    public string SubProcess { get; set; }
    public string Requirement { get; set; }
    public string DetailedDocument { get; set; }
    public int Sequence { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
}
