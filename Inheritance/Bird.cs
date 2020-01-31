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


          

        }



    }
}
