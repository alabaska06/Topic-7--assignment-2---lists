using System.Collections.Generic;

namespace Topic_7__assignment_2___lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q") 
            {
                List<string> vegetables = new List<string>();
                vegetables.Add("");
                vegetables.Add("Carrot");
                vegetables.Add("Beet");
                vegetables.Add("Celery");
                vegetables.Add("Radish");
                vegetables.Add("Cabbage");

                Console.Clear(); 
                Console.WriteLine("Here is your list of vegetables");
                Console.WriteLine();

                for (int i = 1; i < vegetables.Count; i++)
                    Console.WriteLine($"{i}. {vegetables[i]}");

                Console.WriteLine();
                Console.WriteLine("Welcome to my menu.");
                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine();
                Console.WriteLine("1 – Remove a vegetable by index");
                Console.WriteLine("2 – Remove a vegetable by value");
                Console.WriteLine("3 – Search for a vegetable");
                Console.WriteLine("4 – Add a vegetable");
                Console.WriteLine("5 – Sort list");
                Console.WriteLine("6 - Clear the list\n");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    int RemoveByIndex;
                    Console.WriteLine("You chose: Remove a vegetable by index \n");

                    Console.WriteLine("What vegetable would you like to remove? Type the number below.\n");

                    RemoveByIndex = Convert.ToInt32(Console.ReadLine());

                    vegetables.Remove(vegetables[RemoveByIndex]);

                    Console.WriteLine("\nHere's your new list:\n");
                    for (int i = 1; i < vegetables.Count; i++)
                        Console.WriteLine($"{i}. {vegetables[i]}");

                    Console.WriteLine("\nHit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    string RemoveByValue;
                    Console.WriteLine("You chose: Remove a vegetable by value");
                    Console.WriteLine();
                    Console.WriteLine("Type the name of the vegetable you'd like to remove.");
                    Console.WriteLine();
                    RemoveByValue = Console.ReadLine().ToLower().Trim();

                    if (RemoveByValue == "carrot")
                    {
                        vegetables.Remove(vegetables[1]);
                        Console.WriteLine("You removed Carrot.");
                    }
                    else if (RemoveByValue == "beet")
                    {
                        vegetables.Remove(vegetables[2]);
                        Console.WriteLine("You removed Beet.");
                    }
                    else if (RemoveByValue == "celery")
                    {
                        vegetables.Remove(vegetables[3]);
                        Console.WriteLine("You removed Celery.");
                    }
                    else if (RemoveByValue == "radish")
                    {
                        vegetables.Remove(vegetables[4]);
                        Console.WriteLine("You removed Radish.");
                    }
                    else if (RemoveByValue == "cabbage")
                    {
                        vegetables.Remove(vegetables[5]);
                        Console.WriteLine("You removed Cabbage.");
                        
                    }
                    Console.WriteLine();
                    Console.WriteLine("Here's your new list.");
                    Console.WriteLine();

                    for (int i = 1; i < vegetables.Count; i++)
                            Console.WriteLine($"{i}. {vegetables[i]}");

                    Console.WriteLine("\nHit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    string vegetablSearch;
                    Console.WriteLine("You chose: Search for a vegetable");
                    Console.WriteLine();
                    Console.WriteLine("Type the name of the vegetable you'd like to find.");
                    Console.WriteLine();
                    vegetablSearch = Console.ReadLine().ToLower().Trim();

                    if (vegetablSearch == vegetables[1].ToLower())
                    {
                        Console.WriteLine($"\nCarrot is in the list. It is number 1.");
                    }
                    else if (vegetablSearch == vegetables[2].ToLower())
                    {
                        Console.WriteLine($"\nBeet is in the list. It is number 2.");
                    }
                    else if (vegetablSearch == vegetables[3].ToLower())
                    {
                        Console.WriteLine($"\nCelery is in the list. It is number 3.");
                    }
                    else if (vegetablSearch == vegetables[4].ToLower())
                    {
                        Console.WriteLine($"\nRadish is in the list. It is number 4.");
                    }
                    else if (vegetablSearch == vegetables[5].ToLower())
                    {
                        Console.WriteLine($"\nCabbage is in the list. It is number 5.");
                    }
                    else
                    {
                        Console.WriteLine("That is not on the list");
                    }

                    Console.WriteLine("\nHit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "4")
                {
                    string addVeg;
                    Console.WriteLine("You chose: Add a vegetable");
                    Console.WriteLine();
                    Console.WriteLine("Please type the vegetable you'd like to add below:");
                    Console.WriteLine();
                    addVeg = Console.ReadLine();
                    Console.WriteLine("");

                    vegetables.Add(addVeg);

                    Console.WriteLine("\nGood choice! Here's your new list:\n ");

                    for (int i = 1; i < vegetables.Count; i++)
                        Console.WriteLine($"{i}. {vegetables[i]}");

                    Console.WriteLine("\nHit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("You chose: Sort list\n");
                    Console.WriteLine("Here'd the revised list in alphabetical order:\n");
                    vegetables.Sort();
                    for (int i = 1; i < vegetables.Count; i++)
                        Console.WriteLine($"{i}. {vegetables[i]}");

                    Console.WriteLine("\nHit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "6")
                {
                    Console.WriteLine("You chose: Clear the list\n");
                    Console.WriteLine("Here's your new list:\n\nREDACTED\n");

                    vegetables.Clear();
                    for (int i = 1; i < vegetables.Count; i++)
                        Console.WriteLine($"{i}. {vegetables[i]}");

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }

            }
        }
    }
}