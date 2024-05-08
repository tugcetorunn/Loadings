// See https://aka.ms/new-console-template for more information


public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public virtual ICollection<Article> Articles { get; set;}
    public virtual Address Address { get; set; }
}

