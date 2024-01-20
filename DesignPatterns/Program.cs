using DesignPatterns.Library.BuilderExample;

List<Document> documents = new()
{
    new Document(DocumentType.SimpleText, body: "Lorem ipsum..."),
    new Document(DocumentType.Text, footer: "Copyright 2024"),
    new Document(DocumentType.HTML, footer: "Copyright 2024"),
    new Document(DocumentType.Text, "Título", "Subtítulo", "Lorem ipsum...", "Copyright 2024"),
    new Document(DocumentType.HTML, "Título", "Subtítulo", "Lorem ipsum...", "Copyright 2024"),
    new Document(DocumentType.Markdown, "Título", "Subtítulo", "Lorem ipsum...", "Copyright 2024"),
};

foreach (var document in documents)
{
    DocumentRenderer renderer = new(document);
    Console.WriteLine(renderer.Render());
}
