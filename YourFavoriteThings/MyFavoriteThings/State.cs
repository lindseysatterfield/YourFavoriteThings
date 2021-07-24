using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.MyFavoriteThings
{
    class State
    {
        public string Terrain { get; set; }
        public string NationalPark { get; set; }
        public string Name { get; set; }

        public void Snow()
        {
            Console.WriteLine($"It is snowing in {Name}.");
        }
    }
}
