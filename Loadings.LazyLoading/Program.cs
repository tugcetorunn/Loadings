// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

BlogContext context = new BlogContext();

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

int number = 1;



