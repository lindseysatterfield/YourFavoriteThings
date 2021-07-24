using System;
using YourFavoriteThings.MyFavoriteThings;

namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var colorado = new State();
            colorado.Name = "Colorado";
            colorado.Terrain = "mountains";
            colorado.NationalPark = "Rocky Mountain National Park";
            Console.WriteLine($"{colorado.Name} has many {colorado.Terrain} and contains {colorado.NationalPark}.");
            colorado.Snow();

            var murphy = new Pet();
            murphy.Name = "Murphy";
            murphy.Breed = "mutt";
            murphy.GoodBoi = true;
            Console.WriteLine($"It is {murphy.GoodBoi} that {murphy.Name} is a good boi and he is a {murphy.Breed}.");
            murphy.Eat("healthy food");

            var pringles = new Snack();
            pringles.Brand = "Pringles";
            pringles.Flavor = "applewood smoked cheddar";
            pringles.Shape = "wavy";
            Console.WriteLine($"The best brand of chips are {pringles.Brand} that have a flavor of {pringles.Flavor}.");
            pringles.Crunch();
        }
    }
}
