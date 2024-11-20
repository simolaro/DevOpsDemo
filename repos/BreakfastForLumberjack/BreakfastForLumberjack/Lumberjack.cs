using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastForLumberjack
{
    enum Flapjack{Crispy, Soggy, Browned, Banana}
    class Lumberjack
    {
        private string name; 
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapJackCount { get{ return meal.Count(); } }
        public void TakeFlapjacks(Flapjack food, int howmany)
        {
            // Add some number of flapjacks to the Meal stack
            for (int i = 0; i < howmany; i++) meal.Push(food);

        }
        public void EatFlapjacks()
        {
            // write this output to the console
            foreach(Flapjack fjToEat in meal)
            {
                meal.Pop(); 
            }
        }

    }
}
