using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem, võib ta Instagrami kasutada;
            //kui kasutaja on noorem kui 13 aastat, siis on ta liiga noor;

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if(userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagram'i kontot luua.");

            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagram'i kontot luua.");
            }
            else
            {
                Console.WriteLine("Oledki 13, nüüd saad endale Instagram'i konto luua.");
            }
            Console.WriteLine("Kena päeva.");

        }
    }
}
