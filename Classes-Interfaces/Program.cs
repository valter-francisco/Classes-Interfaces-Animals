using System;

namespace Classes_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitMenu = false;

            do
            {
                Console.WriteLine("Choose an animal from the list bellow by inserting it's respective number.");
                Console.WriteLine("1 - Cat \n2 - Cow \n3 - Dog \n4 - Pig \n5 - Sheep");



                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Animals.Cat cat = new Animals.Cat();
                        cat.Talk();
                        exitMenu = true;
                        break;

                    case "2":
                        Animals.Cow cow = new Animals.Cow();
                        cow.Talk();
                        exitMenu = true;
                        break;

                    case "3":
                        Animals.Dog dog = new Animals.Dog();
                        dog.Talk();
                        exitMenu = true;
                        break;

                    case "4":
                        Animals.Pig pig = new Animals.Pig();
                        pig.Talk();
                        exitMenu = true;
                        break;

                    case "5":
                        Animals.Sheep sheep = new Animals.Sheep();
                        sheep.Talk();
                        exitMenu = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please insert a valid input.");
                        break;
                }
            }
            while (exitMenu == false);

        }


    }
}
