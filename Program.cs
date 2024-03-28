// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using PetStore.Classes;
using PetStore.Logic;
using static System.Text.Json.JsonSerializer;



public partial class Program
{ 



    static void Main()
    {
        var productLogic = new ProductLogic();

        Console.WriteLine("Press 1 to add a product");

                Console.WriteLine("Type 'exit' to quit");

                string userInput = Console.ReadLine();



                while (userInput.ToLower() != "exit")
                {
                    Console.WriteLine("Press 1 to add a Dog Leash");

                    Console.WriteLine("Press 2 to add a Cat Food");

                    userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        var DogLeash = new DogLeash();
                        Console.WriteLine("Creating Dog Leash...");

                        Console.WriteLine("Enter length in inches");

                        DogLeash.LengthInches = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the material the leash is made of");

                        DogLeash.Material = Console.ReadLine();

                        Console.WriteLine("What is the name of the leash?");

                        DogLeash.Name = Console.ReadLine();

                        Console.WriteLine("Give the product a short description");
                        DogLeash.Description = Console.ReadLine();

                        Console.WriteLine("What is the price of the leash?");
                        DogLeash.Price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("How many do you have?");
                        DogLeash.Quantity = int.Parse(Console.ReadLine());

                    }

                    if (userInput == "2")
                    {
                        var CatFood = new CatFood();
                        Console.WriteLine("Creating new Cat Food...");
                        Console.WriteLine("Please enter the foods name");

                        CatFood.Name = Console.ReadLine();

                        Console.WriteLine("Please enter the Weight");

                        CatFood.WeightPounds = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter a short description of the product");

                        CatFood.Description = Console.ReadLine();

                        Console.WriteLine("What is the Price of the Product?");

                        CatFood.Price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("What is the Quantity of products");

                        CatFood.Quantity = int.Parse(Console.ReadLine());

                    }

                }
            
        
    }
}
