using System;
using System.Collections.Generic;
using HungryNinja.BuffetClass;
using HungryNinja.FoodClass;
using HungryNinja.NinjaClass;

namespace HungryNinja
{
    class Program
    {
        static void Main (string[] args)
        {
            int calIntake = 0;
            Buffet ninjaBuffet = new Buffet ();
            List<Food> foodHistory = new List<Food> ();
            Ninja ninja = new Ninja (calIntake, foodHistory);

            while (!ninja.isFull)
            {
                Food item = ninjaBuffet.Serve (ninjaBuffet.Menu);
                ninja.Eat (item);
            }

        }
    }
}