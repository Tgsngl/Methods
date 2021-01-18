using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProductName = "Elma";
            double Price = 15;
            string Description = "Amasya elması";
            
            string[] fruits = new string[] {"Elma", "Karpuz" };

            Product Product1 = new Product();
            Product1.Name = "Elma";
            Product1.Price = 15;
            Product1.Description = "Amasya elması";

            Product Product2 = new Product();
            Product2.Name = "Karpuz";
            Product2.Price = 80;
            Product2.Description = "Diyarbakır karpuzu";

            Product[] Products = new Product[] { Product1, Product2 };

            foreach (Product Product in Products) //İlk yazığımız Product yerine string veya var yazsakta olur. 2.yazdığımız Product yerine hehangi birşey yazarsak olur.
            {
                Console.WriteLine(Product.Name);
                Console.WriteLine(Product.Price);
                Console.WriteLine(Product.Description);
                Console.WriteLine(".............");
            }

            Console.WriteLine(".........Methods........");

            //instance- örnek
            BoxManager BoxManager = new BoxManager();

            BoxManager.Add(Product1);
            BoxManager.Add(Product2);

            /* BoxManager.Add2("Armut", "Yeşil Armut", 12, 9);
            BoxManager.Add2("Elma", "Elma Armut", 12, 7);
            BoxManager.Add2("Karpuz", "Diyarbakır Karpuz", 12, 8);
            */
        }
    }
}
