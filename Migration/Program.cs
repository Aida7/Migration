using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookContext())
            {
                context.Books.Add(new Book { Name = "Alice", Autor = "Karol", Price = 2000, Review = "the best" });
                context.Deliveries.Add(new Delivery
                {
                    Addres = "push",
                    BookId=1
                });
            }
        }
    }
}
