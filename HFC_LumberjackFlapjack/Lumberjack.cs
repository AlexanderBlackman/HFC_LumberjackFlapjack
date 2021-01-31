using System;
using System.Collections.Generic;
using System.Text;

namespace HFC_LumberjackFlapjack
{
    class Lumberjack
    {
        public string Name { get; private set; }
        private Stack<Flapjack> pouch = new Stack<Flapjack>();


        public Lumberjack(string name)
        {
            Name = name;        
        }
        public  void StashFlapjack(Flapjack tasty)
        {
            pouch.Push(tasty);
        }

        public void EatFlapjack()
        {
            while (pouch.Count > 0) 
              Console.WriteLine($"{Name} ate a {pouch.Pop().ToString().ToLower()} flapjack");
        }
    }

    enum Flapjack
    {
        Crispy,
        Soggy, 
        Browned,
        Banana,
    }
}
