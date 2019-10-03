using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiceGame
{
    
        class Program
        {


            public static void Main()
            {
                bool active = true;
                Console.WriteLine("DiceGame || Console Version");
                Console.WriteLine("Created by Paulo Rafael");
                Console.WriteLine("-----------------------------------");
                while (active)
                {

                    Console.Write("--- Commands: \n");
                    Console.WriteLine("-- Roll\n" +
                                      "-- Clear\n" +
                                      "-- Exit\n");
                    string command = Console.ReadLine();
                    switch (command)
                    {
                        case "Roll":
                            Console.Clear();
                            Console.WriteLine("\n\n\n\n");
                            Roll();
                            Console.WriteLine("\n\n\n\n");
                            break;
                        case"exit":
                            active = false;
                            break;
                        case "clear":
                            Console.Clear();
                            break;
                    }
                }
            }

            public static void Roll()
            {

                Random random = new Random();
                int Dice1 = random.Next(1, 6);
                int Dice2 = random.Next(1, 6);
                Console.WriteLine("  --Your value was: " + Dice1 + "  --My value was: " + Dice2);
                Main();
            }



        }
    }


