// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.Design;
namespace DBS
{

    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            List<Dog> dogs = new List<Dog>();
            int option = 0;
            String name;
            String race;
            int id;
            int opOption;
            do
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Welcome to Happy Dog House");
                Console.WriteLine("Please select one of our menu opcions");
                Console.WriteLine($"\n 1. Register a dog \n 2. See list of dogs \n 3. Delete a dog \n 4. Update a dog \n 5. Exit from menu ");
                Console.WriteLine("-------------------------------------------------------");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enter the name of the new dog");
                        name = Console.ReadLine();
                        Console.WriteLine("Please enter the race of the new dog");
                        race = Console.ReadLine();
                        Dog dog = new Dog(name, race);
                        dogs.Add(dog);
                        break;
                    case 2:
                        int i = 0;
                        foreach (Dog dogo in dogs)
                        {
                            
                            Console.WriteLine("-----------------------");
                            Console.WriteLine($"ID: {i.ToString()} ");
                            Console.WriteLine($"Name: {dogo.name}");
                            Console.WriteLine($"Race: {dogo.race}");
                            Console.WriteLine("-----------------------");
                            i++;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please enter the id of the dog you wish to delete");
                        opOption = Convert.ToInt32(Console.ReadLine());
                        dogs.RemoveAt(opOption);
                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("See you!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }

            }while(option !=5);
        }
    }

}