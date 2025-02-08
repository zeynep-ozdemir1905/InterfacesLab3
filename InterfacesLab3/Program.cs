using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Zeynep Ozdemir
 * 000940656
 * Interfaces Lab 3 
 */
namespace InterfacesLab3
{
    //main class Program 
    class Program
    {
        static void Main(string[] args)
        {
            // dog object
            Console.Write("Enter the dog's details");
            Console.Write("\nName: ");
            string dogName = Console.ReadLine();

            Dog myDog = new Dog();
            myDog.Name = dogName;
            Console.Write("Colour: ");
            myDog.Colour = Console.ReadLine();
            Console.Write("Height: ");
            myDog.Height = int.Parse(Console.ReadLine());
            Console.Write("Age: ");
            myDog.Age = int.Parse(Console.ReadLine());

            //method to run cry interface for dog Woof
            Console.WriteLine($"\nDog Details:\nName: {myDog.Name}\nColour: {myDog.Colour}\nHeight: {myDog.Height} cm\nAge: {myDog.Age}");
            myDog.Eat();
            Console.WriteLine($"{myDog.Cry()}");  

            //cat object 
            Console.WriteLine("\nEnter the cat's details");
            Console.Write("\nName: ");
            string catName = Console.ReadLine();

            Cat myCat = new Cat();
            myCat.Name = catName;
            Console.Write("Colour: ");
            myCat.Colour = Console.ReadLine();
            Console.Write("Height: ");
            myCat.Height = int.Parse(Console.ReadLine());
            Console.Write("Age: ");
            myCat.Age = int.Parse(Console.ReadLine());

            //method to run the cry interface Meow
            Console.WriteLine($"\nCat Details:\nName: {myCat.Name}\nColour: {myCat.Colour}\nHeight: {myCat.Height} \nAge: {myCat.Age}");
            myCat.Eat();
            Console.WriteLine($"{myCat.Cry()}"); 

            //Create a list called "animals"
            List<IAnimal> animals = new List<IAnimal> { myDog, myCat };

            Console.WriteLine("\nList of Animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"- {animal.Name}");
            }
        }
    }
}
