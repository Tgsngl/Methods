using System;

namespace ValueReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            //num1 kaçtır ? cvp 30


            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            //numbers1[0] ?? cvp 999
            Console.WriteLine("Hello World!");
        }
    }


}
//int, decimal, float double,bool = değer tip
//array class, interface = referance tip
// stock= değer tipler burada gerçekleşir -- 