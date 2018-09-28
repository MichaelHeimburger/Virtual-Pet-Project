using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Virtual_Pet
{
    class Program
    {
        Pet doggo = new Pet("defualt_name");


        static void Main()
        {
            string userInput;
            Console.WriteLine("Congratulations you are a recipiant of the new Virtual Pet. What are you going to name it?");
            Program program = new Program();
            new Thread(program.DogArt).Start();
            while (5 > 1) // infinitely loops the game
            { 
                while (5 > 1) // Infinite loop that will only exit upon correct user input
                {
                    userInput = Console.ReadLine().ToLower();

                    if (userInput == "play")
                    {
                        doggo.Play();
                        break;
                    }
                    if (userInput == "water")
                    {
                        doggo.Drink();
                        break;
                    }
                    if (userInput == "feed")
                    {
                        doggo.Feed();
                        break;
                    }
                } // input loop

                doggo.Tick(); // ticks after every user input
            } // game loop

        }

        void DogArt() // method shortcut for the ascii dog art - makes the code look nicer imo if its down here
        {

            Console.Clear();
            //Pet Status
            Console.WriteLine("{0} the Virtual Pet's current status levels", doggo.Name);
            Console.WriteLine("Hunger: {0}", doggo.Hunger);
            Console.WriteLine("Thirst: {0}", doggo.Thirst);
            Console.WriteLine("Boredom: {0}", doggo.Boredom);
            //DogArt
            Console.WriteLine("   __");
            Console.WriteLine("o-''|\\_____/)");
            Console.WriteLine(" \\_/|_)     )");
            Console.WriteLine("    \\  __  /");
            Console.WriteLine("    (_/ (_/ ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            //Pet Inputs
            Console.WriteLine("What would you like to do today with {0}", doggo.Name);
            Console.WriteLine("Play?");
            Console.WriteLine("Feed?");
            Console.WriteLine("Water?");
            Console.WriteLine("Please type response below.");
        }



    }
}
