// See https://aka.ms/new-console-template for more information



using System.ComponentModel.DataAnnotations.Schema;

public class Address
{
    public int AddressId { get; set; }
    public string AddressName { get; set; }
    public Author Author { get; set; }
    public int AuthorId { get; set; }
}

