using System;
using System.Collections.Generic;

namespace HFC_LumberjackFlapjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Lumberjack> logBoyz = new Queue<Lumberjack>();
            Random random = new Random();


            string nameOfLumberjack;
            while ((nameOfLumberjack = Console.ReadLine()) !="")
            {
                Console.WriteLine("Please enter the lumberjack's name");
                string nameOfLumberJack = Console.ReadLine();
                Lumberjack newJack = new Lumberjack(nameOfLumberJack);
                Console.WriteLine("How many flapjacks does he have?");
                string repliedNumber = Console.ReadLine();
                if (int.TryParse(repliedNumber, out int noOfFJacks)
                {
                    for (int i = 0; i <= noOfFJacks; i++)
                    {

                    }
                        
                }

            }
            

            Console.WriteLine("Hello World!");
        }
    }
}
