using System;

namespace Operatorer
{
    class Program
    {
        static void Main(string[] args)
        {
            // int value1 = 10, value2 = 5;

            //if (value1 > value2)
            {
                //Console.Write("value1 > value2");

                {
                    int value1 = 0, value2 = 0;

                    string Yuhuu = "";

                    Console.WriteLine("Insert number - Biggest first! :");

                    Console.Write("Number 1 :\n");
                    value1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Number 2 :\n");
                    value2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("What is your name? :\n");
                    Yuhuu = Console.ReadLine();

                    if (value1 > value2) // Her vil programmet udregne om "number 1 er større end number 2" og give resultatet "Winner Winner Chicken Dinner"
                    {
                        Console.WriteLine("Winner Winner Chicken Dinner");
                    }
                    else if (Yuhuu == "Dear Leader") // Her vil programmet, hvis ikke "If" er korrekt, tjekke om Yuhuu er "Dear Leader" og give resultatet "Better luck next time"
                    {
                        Console.WriteLine("Better luck next time");
                    }
                    else // Her vil programmet, hvis ikke "If og Else If" er korrekt, give dig resultatet "You are MGK".
                    {
                        Console.WriteLine("You are MGK");
                    }
                    Console.WriteLine("Done!"); Console.ReadKey();

                }

            }

        }
    }
}
