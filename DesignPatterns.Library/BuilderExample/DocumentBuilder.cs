namespace DesignPatterns.Library.BuilderExample;

public abstract class DocumentBuilder
{
    protected readonly Document _document;
    protected string _repr = string.Empty;

    public DocumentBuilder(Document document)
    {
        _document = document;
    }

    public abstract void BuildTitle();
    public abstract void BuildSubtitle();
    public abstract void BuildBody();
    public abstract void BuildFooter();

    public virtual void AddContainer()
    {
        _repr = $"*** {_document.DocumentType} Document ***" + Environment.NewLine + _repr;
    }

    public virtual string Render()
    {
        return _repr;
    }
}
