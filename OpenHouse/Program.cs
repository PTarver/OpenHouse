using System;
using System.Threading;

namespace OpenHouse
{
    class Program
    {
        public static void SpeakingDelay()
        {
            Thread.Sleep(4000);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Open house\nAugust 15th 2008\n4:00pm\n1007 Mountian Drive,Gotham");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("ALL GUESTS!!!\n(Including Media Personnel)\nMust Register At The Gate House\nTrespassing Is Not Allowed!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nGood Evening!!!");

            String response = Console.ReadLine();

            SpeakingDelay();

            if (response.ToUpper() == "GOOD EVENING" || response.ToUpper() == "HELLO" || response.ToUpper() == "HI")
            {
                Console.WriteLine("Hello I'm Sir Alfred Pennyworth");
                Console.WriteLine("Shall? i give you a brief history of our grounds before our evening begins");
            }

            response = Console.ReadLine();

            if (response.ToUpper() == "NO")
            {
                Console.WriteLine("Is there a problem?\nIf there are any descrepancies i can have GCPD escort you off the premises PROMPTLY!");
                response = Console.ReadLine();

                if (response.ToUpper() == "YES")
                {
                    Console.WriteLine("OFFICER MONYOYA!!!\nPlease escort this ruffian off of our premises!!!");
                    response = Console.ReadLine();

                }
                if (response.ToUpper() == "NO")
                    Console.WriteLine("Welcome To The Stately Wayne Manor\nLocated in the Crest Hill Community approximately 12 miles outside of Gotham City\nAt 42,500 it is slightly smaller than The Gotham Rouges football field");
                Console.WriteLine("The Estate is the current home of Bruce Wayne\nThe heir to Wayne Industries the most prominent tech firm in the world.");
                Console.WriteLine("The palacial residence pertains 11 rooms and 7 bathrooms,if on the market today it would appraise for 32,100,000");
                Console.WriteLine("Originally Designed by Nathan van Derm as a commission for Darius Wayne in 1795\nThe project was inherited by Darius'sons; Solomon Zebadiah Wayne and Joshua Thomas Wayne in 1858");
            }
            else if (response.ToUpper() == "YES")
            {
                Console.WriteLine("Welcome To The Stately Wayne Manor\nLocated in the Crest Hill Community approximately 12 miles outside of Gotham City\nAt 42,500 it is slightly smaller than The Gotham Rouges football field");
                Console.WriteLine("The Estate is the current home of Bruce Wayne\nThe heir to Wayne Industries the most prominent tech firm in the world.");
                Console.WriteLine("The palacial residence pertains 11 rooms and 7 bathrooms,if on the market today it would appraise for 32,100,000");
                Console.WriteLine("Originally Designed by Nathan van Derm as a commission for Darius Wayne in 1795\nThe project was inherited by Darius'sons; Solomon Zebadiah Wayne and Joshua Thomas Wayne in 1858");



            }







            Console.ReadLine();
        }
    }

}