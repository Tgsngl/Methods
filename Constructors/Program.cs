using System;

namespace Constructors //bir class ilk oluşturulurduğunda çalışır birdaha çalışmaz.
{
    class Program 
    {
        static void Main(string[] args)
        {
           //Customer customer = new Customer();
            Customer customer1 = new Customer(){ Id = 1, FirstName = "Tugay", LastName = "Sengul", City = "İstanbul" };
            Customer customer2 = new Customer(2,"Ali","Sengul","İstanbul");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            Console.WriteLine(customer2.FirstName);
            

        }
    }

    class Customer
    {
        //Default constructor

        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
                
        }   
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
