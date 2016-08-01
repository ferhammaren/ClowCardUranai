using ClowCardUranai.BLL;
using ClowCardUranai.DAL;
using System;

namespace ClowCardUranai.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str;
            Random ran=new Random();
                int card = 0;
            GeneralReading reading1 = new GeneralReading();
            if (USER.getUsername().Equals("")){
                Console.WriteLine("Hello, may i ask your name?\n");
                USER.saveUserName(Console.ReadLine());
                Console.WriteLine("\nHello " + USER.getUsername());
            }
            else
            {
                Console.WriteLine("\nHello " + USER.getUsername());
            }
            card = ran.Next(52);
            if (card < 0)
                card = 1;
            str = CARDS.getCardData(card);
            Console.WriteLine("Card: " + str[0] + "\nMeaning1: " + str[1]+"\nMessage: "+str[2]+"\nCard's warning: "+str[3]);
            Console.ReadKey();
        }
    }
}
