using System;
using System.Threading;

namespace OpenHouse
{
    class Program
    {
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
                else if (response.ToUpper() == "NO")
                {
                    Console.Clear();
                }

                RealtorSpeak("Welcome To The Stately Wayne Manor\nLocated in the Crest Hill Community approximately 12 miles outside of Gotham City\nAt 42,500 it is slightly smaller than The Gotham Rouges football field.");
                RealtorSpeak("The Estate is the current home of Bruce Wayne\nThe heir to Wayne Industries the most prominent tech firm in the world.");
                RealtorSpeak("The palacial residence pertains 11rooms and 7bathrooms,\nif on the market today it would appraise for 32,100,000.");
                RealtorSpeak("Originally Designed by Nathan van Derm as a commission for Darius Wayne in 1795\nThe project was inherited by Darius'sons; Solomon Zebadiah Wayne and Joshua Thomas Wayne in 1858.");
                RealtorSpeak("While construction was underway the wayne siblings discovered catacombs\nunder the soon to be built estate.");
                RealtorSpeak("The Waynes exploited their nack for humanatarian efforts,\nThis was one of the last stops on the upper east coast for The Underground Railroad.");
                Console.WriteLine("Fredrick Douglass and Harriet Tubman are included on the list of our many disinguished guests");
            }
            else if (response.ToUpper() == "YES")
            {
                Console.Clear();
                RealtorSpeak("Welcome To The Stately Wayne Manor\nLocated in the Crest Hill Community approximately 12 miles outside of Gotham City\nAt 42,500 it is slightly smaller than The Gotham Rouges football field.");
                RealtorSpeak("The Estate is the current home of Bruce Wayne\nThe heir to Wayne Industries the most prominent tech firm in the world.");
                RealtorSpeak("The palacial residence pertains 11rooms and 7bathrooms,\nif on the market today it would appraise for 32,100,000.");
                RealtorSpeak("Originally Designed by Nathan van Derm as a commission for Darius Wayne in 1795\nThe project was inherited by Darius'sons; Solomon Zebadiah Wayne and Joshua Thomas Wayne in 1858.");
                RealtorSpeak("While construction was underway the wayne siblings discovered catacombs\nunder the soon to be built estate.");
                RealtorSpeak("The Waynes exploited their nack for humanatarian efforts,\nThis was one of the last stops on the upper east coast for The Underground Railroad.");
                Console.WriteLine("Fredrick Douglass and Harriet Tubman are included on the list of our many disinguished guests");
            }

            Console.WriteLine("Please forgive me, I forgot acquire your name?");
            response = Console.ReadLine();
            Console.Clear();
            RealtorSpeak(response + ", it is a pleasure to meet you.");
            AceSpeak("WOOF WOOF, GRRRRRRRRRRRRRRRRR");
            RealtorSpeak("CALM DOWN BEFORE YOU FRIGHTEN OUR GUEST");
            RealtorSpeak(response + ",This is Archabald Charles Edmondson known as ACE our estate overseer he seems a bit awnry.\nI promise not to let him bite a plug in you");
            RealtorSpeak("Perhaps a size 12, For snack ACE");
            AceSpeak("whimper");
            RealtorSpeak("Oh Hush");
            AceSpeak("WOOF");
            RealtorSpeak("I wont be accepting any Tom Foolery from you today,\n Now say hello or retire to your quarters");

            The_BatCave batcave = new The_BatCave();
            batcave.Name = "The Batcave";
            batcave.Description = "It is Dark";

            Console.WriteLine(batcave.Name);
            Console.WriteLine(batcave.Description);

            Console.ReadLine();
        }

        public static void RealtorSpeak(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            SpeakThenClear(message);
        }

        public static void AceSpeak(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            SpeakThenClear(message);
        }

        public static void SpeakingDelay()
        {
            Thread.Sleep(4000);
        }

        public static void SpeakThenClear(string message)
        {
            Console.WriteLine(message);
            SpeakingDelay();
            Console.Clear();
        }
    }
}