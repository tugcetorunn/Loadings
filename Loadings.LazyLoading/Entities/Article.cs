// See https://aka.ms/new-console-template for more information
public class Article
{
    public int ArticleId { get; set; }
    public string Header { get; set; }
    public string Content { get; set; }
    public virtual Category Category { get; set; } //foreign key kendi oluşturabilir.
    public virtual Author Author { get; set; } //foreign key kendi oluşturabilir.
}

