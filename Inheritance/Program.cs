using System;

namespace Inheritance
{ 
    
    class Program
    {
        static void Main(string[] args)
        { 
        // TODO Be sure to follow best practice when creating your classes

        // DONE Create a class Animal
        // DONE give this class 4 members that all Animals have in common


        // DONE Create a class Bird
        // DONE give this class 4 members that are specific to Bird
        // DONE Set this class to inherit from your Animal Class

        // DONE Create a class Reptile
        // DONE give this class 4 members that are specific to Reptile
        // DONE Set this class to inherit from your Animal Class

        
            Bird fly = new Bird();
            fly.Feathers = true;
            fly.Tallons = "lenghty";
            fly.Beak = "long, dark colored";
            fly.CanFly = true;

            string text = $"The {fly.Name} is a {fly.Color}-colored, {fly.Legs} legged bird." +
                       $"Its {fly.Beak} beak and {fly.Tallons} tallons are essential" +
                       $" to its survival in the {fly.Environment}. Yes, it is {fly.CanFly}" +
                       $" that {fly.Name}s are able to fly despite their size.";

            Console.WriteLine(text);



            // var hop = new Reptile()
            //{
            //    Scales = false,
            //    Texture = "slimey"
            //};        OR


            Reptile hop = new Reptile();
            hop.Scales = false;
            hop.Texture = "slimey";
            hop.TransportsHow = "jump/hop";
            hop.ChangesColors = true;

            string textTwo = $"{hop.Name}s are a prime example of a reptile. Their {hop.Texture}, {hop.Color}" +
                        $" skin is key to helping them blend into their" +
                        $" surroundings as they {hop.TransportsHow} around the {hop.Environment}.";


            Console.WriteLine(textTwo);

        }  


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        
    }
}
