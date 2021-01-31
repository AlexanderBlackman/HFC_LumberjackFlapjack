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


            string newName;
            Console.WriteLine("Please enter the name of the first lumberjack");
            while ((  newName = Console.ReadLine()) !="")
            {

                Console.WriteLine("How many flapjacks does he have? ");
                string repliedNumber = Console.ReadLine();
                if (int.TryParse(repliedNumber, out int noOfFJacks))
                {
                    Lumberjack newJack = new Lumberjack(newName);

                    for (int i = 0; i <= noOfFJacks; i++)
                    {
                        newJack.StashFlapjack((Flapjack)random.Next(0, 4));
                    }
                    logBoyz.Enqueue(newJack);                        
                }
                Console.Write("Next lumberjack's name: (blank to end)");
            }

            while (logBoyz.Count > 0)
            {
               Lumberjack nextJack = logBoyz.Dequeue();
                nextJack.EatFlapjack();
            }
            

        }
    }
}
