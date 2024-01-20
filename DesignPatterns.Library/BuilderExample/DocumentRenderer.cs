namespace DesignPatterns.Library.BuilderExample;

/// <summary>
/// Director Class.
/// </summary>
public sealed class DocumentRenderer
{
    private readonly Document _document;

    public DocumentRenderer(Document document)
    {
        _document = document ?? throw new ArgumentNullException(nameof(document));
    }

    public string Render()
    {
        DocumentBuilder builder = _document.DocumentType switch
        {
            DocumentType.SimpleText => new TextDocumentBuilder(_document),
            DocumentType.Text => new TextDocumentBuilder(_document),
            DocumentType.Markdown => new MarkdownDocumentBuilder(_document),
            DocumentType.HTML => new HtmlDocumentBuilder(_document),
            _ => throw new NotImplementedException(),
        };

        switch (_document.DocumentType)
        {
            case DocumentType.SimpleText:
                builder.BuildTitle();
                builder.BuildBody();
                break;

            default:
                builder.BuildTitle();
                builder.BuildSubtitle();
                builder.BuildBody();
                builder.BuildFooter();
                break;
        }

        builder.AddContainer();

        return builder.Render();
    }
}
