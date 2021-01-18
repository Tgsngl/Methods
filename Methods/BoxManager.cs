using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BoxManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Name);

        }


       /* public void Add2(string ProductName, string Description, double Price, int stockAmount)//Bu koda stok adedi eklediğimiz anda, program.cs deki 43-44-45 . satırlar hata verir. 
        {                                                                                      //Olası bir ekleme ve değiştirme durumuna bu yazım uygun değildir.
                                                                                               //Bu sebeple Classları tercih etmek gerekir. YAzarak eklesekte tek te keklemek derektiği için uğraştırıcı olur.
            Console.WriteLine("Tebrikler. Sepete eklendi : " + ProductName);
        } */
    }
}
