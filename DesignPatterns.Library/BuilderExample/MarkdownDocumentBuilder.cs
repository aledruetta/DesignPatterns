namespace DesignPatterns.Library.BuilderExample;

public sealed class MarkdownDocumentBuilder : DocumentBuilder
{
    public MarkdownDocumentBuilder(Document document) : base(document)
    {
    }

    public override void BuildTitle()
    {
        _repr += $"# {_document.Title}" + Environment.NewLine;
    }

    public override void BuildSubtitle()
    {
        _repr += !string.IsNullOrWhiteSpace(_document.Subtitle)
                 ? $"## {_document.Subtitle}" + Environment.NewLine
                 : string.Empty;
    }

    public override void BuildBody()
    {
        // Here could parse body and format paragraph, images, headers, etc.
        _repr += !string.IsNullOrWhiteSpace(_document.Body)
                 ? $"{_document.Body}" + Environment.NewLine
                 : string.Empty;
    }

    public override void BuildFooter()
    {
        _repr += !string.IsNullOrWhiteSpace(_document.Footer)
                 ? $"> **{_document.Footer}**" + Environment.NewLine
                 : string.Empty;
    }
}
