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
            Console.WriteLine("Welcome to Happy Dog House");
            Console.WriteLine("Please select one of our menu opcions");
            Console.WriteLine($"\n 1. Register a dog \n 2. See list of dogs \n 3. Delete a dog \n 4. Update a dog \n 5. Exit from menu ");

        }
    }

}