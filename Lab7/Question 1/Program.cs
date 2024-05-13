using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        { }
            public abstract class Animal
        {
            public abstract string MakeSound();
        }
    

        public class Lion : Animal
        {
            public override string MakeSound()
            {
                return "Roar!";
            }
        }

        public class Tiger : Animal
        {
            public override string MakeSound()
            {
                return "Growl!";
            }
        }

        public class Elephant : Animal
        {
            public override string MakeSound()
            {
                return "Trumpet!";
            }
        }

        public class Zoo
        {
            private List<Animal> animals;

            public Zoo()
            {
                animals = new List<Animal>();
            }

            public void AddAnimal(Animal animal)
            {
                animals.Add(animal);
            }

            public void MakeAllSounds()
            {
                foreach (Animal animal in animals)
                {
                    Console.WriteLine(animal.MakeSound());
                }
            }

            public void AddAnimalMenu()
            {
                Console.WriteLine("Select animal type (1: Lion, 2: Tiger, 3: Elephant):");
                string choice = Console.ReadLine();

                try
                {
                    int animalType = int.Parse(choice);
                    Animal newAnimal;

                    switch (animalType)
                    {
                        case 1:
                            newAnimal = new Lion();
                            break;
                        case 2:
                            newAnimal = new Tiger();
                            break;
                        case 3:
                            newAnimal = new Elephant();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            return;
                    }

                    AddAnimal(newAnimal);
                    Console.WriteLine("Animal added successfully!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        public class program
        {
            public static void Main(string[] args)
            {
                Zoo zoo = new Zoo();

                int choice;

                do
                {
                    Console.WriteLine("\nZoo Management System");
                    Console.WriteLine("1. Add Animal");
                    Console.WriteLine("2. Make all animals sound off");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("Enter your choice:");

                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        choice = 0; // Invalid input, set to exit loop
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }

                    switch (choice)
                    {
                        case 1:
                            zoo.AddAnimalMenu();
                            break;
                        case 2:
                            zoo.MakeAllSounds();
                            break;
                    }
                } while (choice != 3);

                Console.WriteLine("Exiting Zoo Management System.");
            } 
        }
    }
}
