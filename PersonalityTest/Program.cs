using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siseta oma lemmikvärv:");
            string userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("Oled Romatiline");
            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled töökas");
            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled loodusesõber");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
