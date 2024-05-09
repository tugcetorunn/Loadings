// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

BlogContext context = new BlogContext();

InsertDatas(context);

//Eager Loading
//Include metodu ile herhangi bir ilişkili olan entityler arasında bir diğerinden veri getirebiliriz.
//Include IQueryable yapı ile çalışır.
//İstediğimiz ilişkili veriyi getirir. Diğerlerini taramaz, null döndürür. Bu yüzden lazy loading ten daha hızlı çalışabilir.
//Virtual keyword ü kullanmamız gerekmez.

List<Author> authorAddresses = context.Authors.Include(a => a.Address).ToList();

Article articleCategory = context.Articles.Include("Category")
                                          .Include("Author")
                                          .FirstOrDefault();

Console.WriteLine("Yazarlar ve adresleri : ");
foreach (Author authorAddress in authorAddresses)
{
    Console.WriteLine($"{authorAddress.Name + " " + authorAddress.LastName} isimli yazarımızın " +
                      $"adresi : {authorAddress.Address.AddressName} ");
}

Console.WriteLine("------------------------");

Console.WriteLine($"İlk yazımızın kategorisi : {articleCategory.Category.CategoryName}\n" +
                  $"başlığı : {articleCategory.Header}\n" +
                  $"içeriği : {articleCategory.Content}\n" +
                  $"ve yazarı : {articleCategory.Author.Name + " " + articleCategory.Author.LastName}");

int number = 1;

static void InsertDatas(BlogContext context)
{
    Author author = new Author() { Name = "Tuğçe", LastName = "Torun" };
    Author author2 = new Author() { Name = "Talha", LastName = "Torun" };
    Author author3 = new Author() { Name = "Zeynep", LastName = "Toker" };
    Author author4 = new Author() { Name = "Barış", LastName = "Özcan" };

    Category category = new Category() { CategoryName = "Bilim", Description = "Dünya, Fizik, Kimya" };
    Category category2 = new Category() { CategoryName = "Teknoloji", Description = "Yazılım, Yapay Zeka, İş Teknolojileri" };
    Category category3 = new Category() { CategoryName = "Girişim", Description = "Marka, Tanıtım" };

    Article article = new Article() { Header = "Yıldızlar", Content = "Yıldızların Dünyamıza Etkileri", Category = category, Author = author2 };
    Article article2 = new Article() { Header = "ChatGPT", Content = "ChatGPT Faydaları ve Zararları", Category = category2, Author = author };
    Article article3 = new Article() { Header = "Nanobotlar", Content = "Nanobotlar: Hayatımızı Değiştirecek Teknoloji", Category = category2, Author = author4 };
    Article article4 = new Article() { Header = "NVidia", Content = "NVidia: 30 Yılda 1.000.000 Kat Artan Değer", Category = category3, Author = author3 };

    context.Articles.Add(article);
    context.Articles.Add(article2);
    context.Articles.Add(article3);
    context.Articles.Add(article4);

    Address address = new Address() { AddressName = "Bursa Nilüfer", Author = author };
    Address address2 = new Address() { AddressName = "İstanbul Pendik", Author = author3 };
    Address address3 = new Address() { AddressName = "İstanbul Ataşehir", Author = author4 };
    Address address4 = new Address() { AddressName = "Bursa Görükle", Author = author2 };

    context.Addresses.Add(address);
    context.Addresses.Add(address2);
    context.Addresses.Add(address3);
    context.Addresses.Add(address4);


    context.SaveChanges();
}