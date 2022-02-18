using System;
using System.Threading;

namespace FlamingoTextAdventureGame
{
    class Program
    {
        static void Main(string[] args)

        {

            //Introduction (get character name) 

            //Print("Welcome to Flamingo!!!"); 
            //Thread.Sleep(1500); 
            //Print("You're probably sitting there thinking to yourself . . ."); 
            //Thread.Sleep(1500); 
            //Print("\"What in the WORLD is Flamingo? . . . and why am I here\""); 
            //Thread.Sleep(1500); 
            //Print("Well . . . That's what I'm here for"); 
            //Thread.Sleep(1500); 
            Print("Nice to meet you, name's Mingo . . . and yours?");
            var player = new Character(Console.ReadLine(), 1, 100, 50);
            Console.Clear();
            Print("Okay now we are getting somewhere . . .");
            Print($"Nice to meet you {player.Name}");
            Print("Would you like a tutorial? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Tutorial();
            }

            else
            {
                Begin();
            }
        }

        //Print words typewriter style 
        public static void Print(string words)
        {
            foreach (var letter in words)
            {
                Console.Write(letter);
                Thread.Sleep(50);
            }
            Console.Write("\n");
        }

        //Tutorial 
        public static void Tutorial()
        {
            Console.Clear();
            Print("Welcome to the Flamingo tutorial!");
        }

        //Start of game 
        public static void Begin()
        {
            Console.Clear();
            Print("Begin");
        }

        //Info Bar 
        public static void InfoBar()
        {
            Console.Clear();
            Print($"Health: ");
        }
    }
}