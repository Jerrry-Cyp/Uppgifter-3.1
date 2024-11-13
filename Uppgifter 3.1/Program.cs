using System;

namespace Uppgifter_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv din ålder:");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder < 19 && ålder > 16) Console.WriteLine("Du kan delta i tävlingen");
            if (ålder < 16) Console.WriteLine("Du är tyvär för ung för att delta i tävlingen");
            if (ålder > 19) Console.WriteLine("Du är för gammal för att delta i tävlingen");
        }
    }
}