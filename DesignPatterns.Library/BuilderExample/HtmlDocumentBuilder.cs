namespace DesignPatterns.Library.BuilderExample;

public sealed class HtmlDocumentBuilder : DocumentBuilder
{
    public HtmlDocumentBuilder(Document document) : base(document)
    {
    }

    public override void BuildTitle()
    {
        _repr += $"\t<h1>{_document.Title}</h1>" + Environment.NewLine;
    }

    public override void BuildSubtitle()
    {
        _repr += !string.IsNullOrWhiteSpace(_document.Subtitle)
                 ? $"\t<h2>{_document.Subtitle}</h2>" + Environment.NewLine
                 : string.Empty;
    }

    public override void BuildBody()
    {
        // Here could parse body and format paragraph, images, headers, etc.
        _repr += !string.IsNullOrWhiteSpace(_document.Body)
                 ? $"\t<main>{_document.Body}</main>" + Environment.NewLine
                 : string.Empty;
    }

    public override void BuildFooter()
    {
        _repr += !string.IsNullOrWhiteSpace(_document.Footer)
                 ? $"\t<footer>{_document.Footer}</footer>" + Environment.NewLine
                 : string.Empty;
    }

    public override void AddContainer()
    {
        _repr = "<div class=\"container\">" + Environment.NewLine +
                _repr +
                "</div>" + Environment.NewLine;

        base.AddContainer();
    }
}
