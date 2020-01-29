using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public bool Feathers { get; set; }
        public string Tallons { get; set; }
        public string Beak { get; set; }
        public bool CanFly { get; set; }


        public Bird()
        {
            Name = "Tucan";
            Color = "multi";
            Legs = 2;
            Environment = "tops of trees and the sky";

            var text = $"The {Name} is a {Color}-colored, {Legs} legged bird." +
                         $"Its {Beak} beak and {Tallons} tallons are essential" +
                         $" to its survival in the {Environment}. Yes, it is {CanFly}" +
                         $" that {Name}s are able to fly despite their size.";

            Console.WriteLine(text);

        }



    }
}
