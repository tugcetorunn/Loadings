// See https://aka.ms/new-console-template for more information

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public virtual ICollection<Article> Articles { get; set; }
}

