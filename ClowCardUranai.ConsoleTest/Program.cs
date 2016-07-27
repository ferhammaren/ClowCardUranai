using ClowCardUranai.DAL;
using System;

namespace ClowCardUranai.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str;
            str = CARDS.getCardData(2);

            if (USER.getUsername().Equals("")){
                Console.WriteLine("Hello, may i ask your name?\n");
                USER.saveUserName(Console.ReadLine());
                Console.WriteLine("\nHello " + USER.getUsername());
            }
            else
            {
                Console.WriteLine("\nHello " + USER.getUsername());
            }
            Console.WriteLine("Card: " + str[0] + "\nMeaning1: " + str[1]);
            Console.ReadKey();
        }
    }
}
