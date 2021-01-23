using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enu,boolean --> value types(değer tiplerdir)
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayı 1: "+sayi1);

            //array,class,interface --> reference types(referans tiptir.

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("Sayilar1[0] = "+sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.Firstname = "Engin";
            person2 = person1;
            person1.Firstname = "Derin";
            Console.WriteLine(person2.Firstname);


            Customer customer = new Customer();
            Employee employee = new Employee();
            Person person3 = customer;
            customer.Firstname = "Ahmet";

            //Console.WriteLine(((Customer)person3).CreditCardNumber);
                    


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.Firstname);
        }
    }
}
