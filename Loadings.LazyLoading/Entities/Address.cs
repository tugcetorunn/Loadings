// See https://aka.ms/new-console-template for more information



using System.ComponentModel.DataAnnotations.Schema;

public class Address
{
    public int AddressId { get; set; }
    public string AddressName { get; set; }
    public virtual Author Author { get; set; }
    public virtual int AuthorId { get; set; }
}

