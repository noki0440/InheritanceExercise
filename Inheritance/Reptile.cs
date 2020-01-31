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

            

        }


        
    }
}
