using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.MyFavoriteThings
{
    class Snack
    {
        public string Brand { get; set; }
        public string Flavor { get; set; }
        public string Shape { get; set; }

        public void Crunch()
        {
            Console.WriteLine($"{Brand} chips are very crunchy.");
        }
    }
}
