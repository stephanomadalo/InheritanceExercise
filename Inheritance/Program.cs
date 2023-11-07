using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var falcon = new Bird();
            {
                falcon.Defecates = true;
                falcon.NumberOfEyes = 2;
                falcon.NumberOfLegs = 2;
                falcon.NeedsToEat = true;
                falcon.HowMuchFoodRegurgitated = "too much";
                falcon.HasBeak = true;
                falcon.HasHollowBones = true;
                falcon.HowManyToes = 8;
            }
            Console.WriteLine($" does it crap? Falcon:{falcon.Defecates}");
            Console.WriteLine($" how many eyes does it have? Falcon has {falcon.NumberOfEyes} eyes");
            Console.WriteLine($" how many legs does it have? Falcon has {falcon.NumberOfLegs} legs");
            Console.WriteLine($" does it need to eat? Falcon:{falcon.NeedsToEat}");
            Console.WriteLine($" how much food does it regurgitate? {falcon.HowMuchFoodRegurgitated}");
            Console.WriteLine($" does it have a beak? {falcon.HasBeak}");
            Console.WriteLine($" does it have hollow bones? {falcon.HasHollowBones}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine("*****************************************************************");
            
            var copperhead = new Reptile();
            {
                copperhead.Defecates = true;
                copperhead.NumberOfEyes = 2;    
                copperhead.NumberOfLegs = 0;
                copperhead.NeedsToEat = true;
                copperhead.HasScales = true;
                copperhead.HasNictitatingMembrane = false;
                copperhead.HowManyFangs = 2;
                copperhead.DoesItScurry = false;
            }

            Console.WriteLine($" does it crap? Copperhead:{copperhead.Defecates}");
            Console.WriteLine($" how many eyes does it have? Copperhead has {copperhead.NumberOfEyes} eyes");
            Console.WriteLine($" how many legs does it have? Copperhead has {copperhead.NumberOfLegs} legs");
            Console.WriteLine($" does it need to eat? Copperhead:{copperhead.NeedsToEat}");
            Console.WriteLine($" does it have a nictitating membrane? Copperhead:{copperhead.HasNictitatingMembrane}");
            Console.WriteLine($" how many fangs does it have? Copperhead has {copperhead.HowManyFangs}");
            Console.WriteLine($" does it scurry? Copperhead:{copperhead.DoesItScurry}");

        }
    }
}
