namespace DesignPatterns.Library.BuilderExample;

public enum DocumentType { Text, SimpleText, HTML, Markdown }

public sealed class Document
{
    public Document(DocumentType type, string title = "New Document", string? subtitle = null, string? body = null, string? footer = null)
    {
        DocumentType = type;
        Title = title;
        Subtitle = subtitle;
        Body = body;
        Footer = footer;
    }

    public DocumentType DocumentType { get; }
    public string Title { get; set; }
    public string? Subtitle { get; set; }
    public string? Body { get; set; }
    public string? Footer { get; set; }
}