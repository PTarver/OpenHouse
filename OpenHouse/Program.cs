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
                else goto Outer;
            }

            Outer:
            
            Console.Clear();
            Console.WriteLine("Welcome To The Stately Wayne Manor\nLocated in the Crest Hill Community approximately 12 miles outside of Gotham City\nAt 42,500 it is slightly smaller than The Gotham Rouges football field.");
            SpeakingDelay();Console.Clear();
            Console.WriteLine("The Estate is the current home of Bruce Wayne\nThe heir to Wayne Industries the most prominent tech firm in the world.");
            SpeakingDelay();Console.Clear();
            Console.WriteLine("The palacial residence pertains 11rooms and 7bathrooms,\nif on the market today it would appraise for 32,100,000.");
            SpeakingDelay();Console.Clear();
            Console.WriteLine("Originally Designed by Nathan van Derm as a commission for Darius Wayne in 1795\nThe project was inherited by Darius'sons; Solomon Zebadiah Wayne and Joshua Thomas Wayne in 1858.");
            SpeakingDelay(); Console.Clear(); 
            Console.WriteLine("While construction was underway the wayne siblings discovered catacombs\nunder the soon to be built estate.");
            SpeakingDelay();Console.Clear();
            Console.WriteLine("The Waynes exploited their nack for humanatarian efforts,\nThis was one of the last stops on the upper east coast for The Underground Railroad.");
            SpeakingDelay();Console.Clear();
            Console.WriteLine("Fredrick Douglass and Harriet Tubman are included on the list of our many disinguished guests");
            

            Console.WriteLine("Please forgive me, I forgot acquire your name?");
            response = Console.ReadLine();Console.Clear(); 
            Console.WriteLine(response + ", it is a pleasure to meet you.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;SpeakingDelay(); Console.Clear();
            Console.WriteLine("WOOF WOOF, GRRRRRRRRRRRRRRRRR");SpeakingDelay();
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            Console.WriteLine("CALM DOWN BEFORE YOU FRIGHTEN OUR GUEST");SpeakingDelay();
            Console.WriteLine(response + ",This is Archabald Charles Edmondson known as ACE our estate overseer he seems a bit awnry.\nI promise not to let him bite a plug in you"); SpeakingDelay(); Console.Clear();
            Console.WriteLine("Perhaps a size 12, For snack ACE"); SpeakingDelay(); Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("whimper");SpeakingDelay(); Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Oh Hush");SpeakingDelay(); Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("WOOF");SpeakingDelay(); Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("I wont be accepting any Tom Foolery from you today,\n Now say hello or retire to your quarters");SpeakingDelay(); Console.Clear();

            The_BatCave batcave = new The_BatCave();
            batcave.Name = "The Batcave";
            batcave.Description = "It is Dark";

            // Maybe let the user know you're entering the cave?  

            Console.WriteLine(batcave.Name);
            Console.WriteLine(batcave.Description);



















































































































































            Console.ReadLine();
        }
    }

}