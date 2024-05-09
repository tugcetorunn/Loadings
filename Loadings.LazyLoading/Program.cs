// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

BlogContext context = new BlogContext();

InsertDatas(context);

//Lazy Loading
//Bu yöntem için proxies package ını yüklememiz ve context te OnConfiguring metoduna bildirilmesi aktif hale gelmesi gerek.
//Ayrıca navigation property lere virtual keyword ü eklememiz gerek.
//Tüm ilişkili entity leri getirir.

Article article = context.Articles.Where(a => a.ArticleId == 2).FirstOrDefault();

Console.WriteLine($"Başlığı {article.Header} olan {article.Content} içerikli yazımızın yazarı : {article.Author.Name} " +
                                                                                          $"{article.Author.LastName}");


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

    context.Addresses.Add(address);
    context.Addresses.Add(address2);
    context.Addresses.Add(address3);

    context.SaveChanges();
}