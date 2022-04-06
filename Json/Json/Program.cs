using Json.Models;
using System.Collections.Generic;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Product book1 = new Product { Id = 1, Name = "Xez Paltolu Madonna, Sebaheddin Eli", Price = 5.50 };
            Product book2 = new Product { Id = 2, Name = "Haradasan, Mark Levi", Price = 7.99 };
            Product book3 = new Product { Id = 3, Name = "Qurur ve Qerez, Jane Austen", Price = 9.99 };
            Product book4 = new Product { Id = 4, Name = "Min mmohteshem gunesh, Xalid Hüseyni", Price = 7.99 };
            Product book5 = new Product { Id = 5, Name = "Kimyager, Paulo Coelho", Price = 9.4 };
            Orderitem item1 = new Orderitem { Id = 1, Product = book1, Count = 2, TotalPrice = book1.Price * 2 };
            Orderitem item2 = new Orderitem { Id=2, Product=book2, Count=4, TotalPrice=book2.Price*4};
            Orderitem item3 = new Orderitem { Id = 3, Product = book3, Count = 1, TotalPrice = book3.Price * 1 };
            Orderitem item4 = new Orderitem { Id = 4, Product = book4, Count = 5, TotalPrice = book4.Price * 5 };
            Orderitem item5 = new Orderitem { Id = 5, Product = book5, Count = 3, TotalPrice = book5.Price * 3 };
            List<Orderitem> orderitems1 = new List<Orderitem>();
            orderitems1.Add(item1);
            orderitems1.Add(item3);
            orderitems1.Add(item5);
            List<Orderitem> orderitems2 = new List<Orderitem>();
            orderitems2.Add(item2);
            orderitems2.Add(item4);
            Order order1 = new Order { Id = 1, OrderItems = orderitems1 };
            Order order2 = new Order { Id = 2, OrderItems = orderitems2 };
















        }
    }

  
}
