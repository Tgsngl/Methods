using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" Eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");

        }

       
        
        
        
        
        
        
        
        
        
        
        
        
        /* public int Topla(int sayi1, int sayi2)
         {
             return sayi1 + sayi2;                //void ile int lı classların farkını görmek için bu örnek yapıldı. "/ *" "* /" araları
         }

         public void Topla2(int sayi1, int sayi2)
         {
             Console.WriteLine(sayi1 + sayi2); 
         }*/
    }
}
