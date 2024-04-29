using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace EelQuest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer();
            CurrentLocation location = new CurrentLocation();
         
            player.SoundLocation = @"..\..\eeltown.wav";

            player.PlayLooping();

            Console.WriteLine("Welcome to Eel Quest!");
            Console.WriteLine("You are but a small eel with big plans. To make them into reality, you need to assimilate 9 more eels.");
            Console.WriteLine("\n...that's the quest, if that wasn't obvious.");

            Console.WriteLine("You can LOOK, GET and TALK to things, or people, which I guess are a subset of things anyway.");
            Console.WriteLine("Additionally, you can USE things, including on other things.");
            Console.WriteLine("You can also MOVE between locations.");

            Console.WriteLine("You find yourself in EEL TOWN.");
            Console.WriteLine("What now.");

            Console.WriteLine("DEBUG TESTING: ");

            location.PrintCurrentLocationData();

            Console.WriteLine("WHERE GO: ");

            int selection = Int32.Parse(Console.ReadLine());

            location.ChangeRoom(selection);

            location.PrintCurrentLocationData();

            Console.ReadKey();
        }
    }
}
