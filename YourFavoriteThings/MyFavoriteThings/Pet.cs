using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.MyFavoriteThings
{
    class Pet
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public bool GoodBoi { get; set; }

        public void Eat(string typeOfFood)
        {
            Console.WriteLine($"{Name} is eating {typeOfFood}.");
        }
    }
}
