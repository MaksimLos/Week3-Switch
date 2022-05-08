using System;

namespace PersonalityTestSwitchh
{
    class Program
    {
        static void Main(string[] args)
        {
        //programm küsib kasutajalt ta lemmikvärvi
        //punane-romantiline
        //sinine-töökas
        //roheline-looduse sõber
        //muu-ükssarvik

        Console.WriteLine("Siseta oma lemmikvärv:");
            string userColor = Console.ReadLine();

        switch (userColor)
         {
            case "punane":
            Console.WriteLine("Oled romantiline");
            break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled loodusesõber");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik");
                    break;
                    }
            Console.WriteLine("Kena päeva!");


        }
}
}
