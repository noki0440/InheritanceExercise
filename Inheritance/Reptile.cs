using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool Scales { get; set; }
        public string Texture { get; set; }
        public string TransportsHow { get; set; }
        public bool ChangesColors { get; set; }


        public Reptile()
        { 
            Name = "Glass Frog";
            Color = "green";
            Legs = 4;
            Environment = "edges of water or forest floors";

            var text = $"{Name}s are a prime example of a reptile. Their {Texture}, {Color}" +
                        $" skin is key to helping them blend into their" +
                        $" surroundings as they {TransportsHow} around the {Environment}.";


            Console.WriteLine(text);

        }


        
    }
}
