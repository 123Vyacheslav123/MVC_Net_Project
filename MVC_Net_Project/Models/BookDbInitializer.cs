using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Net_Project.Models
{
    public class BookDbInitializer : DropCreateDatabaseIfModelChanges<BookContext> {
        protected override void Seed(BookContext db)
        {
            var Books = new List<Book>
            {
                new Book {Name = "Война и мир", Author =  "Л. Толстой", Price = 222}
            };
            foreach (Book b in Books) db.Books.Add(b);
            db.SaveChanges();
        }
    }
}