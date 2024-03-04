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
                vegetables.Add("Carrot");
                vegetables.Add("Beet");
                vegetables.Add("Celery");
                vegetables.Add("Radish");
                vegetables.Add("Cabbage");

                Console.Clear(); 
                Console.WriteLine("Here is your list of vegetables");
                Console.WriteLine();
                Console.WriteLine("1. Carrot");
                Console.WriteLine("2. Beet");
                Console.WriteLine("3. Celery");
                Console.WriteLine("4. Raddish");
                Console.WriteLine("5. Cabbage");

                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine(string.Join($"{i}. ", vegetables));
                }
                for (int i = 0; i < 10; i++)
                {
                    
                }


                    Console.WriteLine("\n");
                Console.WriteLine("Welcome to my menu.");
                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine();
                Console.WriteLine("1 – Remove a vegetable by index");
                Console.WriteLine("2 – Remove a vegetable by value");
                Console.WriteLine("3 – Search for a vegetable");
                Console.WriteLine("4 – Add a vegetable");
                Console.WriteLine("5 – Sort list");
                Console.WriteLine("6 - Clear the list");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    int RemoveByIndex;
                    Console.WriteLine("You chose: Remove a vegetable by index ");

                    Console.WriteLine("What vegetable would you like to remove? Type the number below.");
                    RemoveByIndex = Convert.ToInt32(Console.ReadLine());

                    if (RemoveByIndex == 1)
                    {
                        vegetables.Remove("Carrot");
                        Console.WriteLine("You removed Carrot.");
                    }
                    else if (RemoveByIndex == 2)
                    {
                        vegetables.Remove("Beet");
                        Console.WriteLine("You removed Beet.");
                    }
                    else if (RemoveByIndex == 3)
                    {
                        vegetables.Remove("Celery");
                        Console.WriteLine("You removed Celery.");
                    }
                    else if (RemoveByIndex == 4)
                    {
                        vegetables.Remove("Radish");
                        Console.WriteLine("You removed Raddish.");
                    }
                    else if (RemoveByIndex == 5)
                    {
                        vegetables.Remove("Cabbage");
                        Console.WriteLine("You removed Cabbage.");
                    }

                    Console.WriteLine(string.Join(", ", vegetables));


                    Console.WriteLine("Hit ENTER to continue.");
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
                        vegetables.Remove(vegetables[0].ToLower());
                        Console.WriteLine("You removed Carrot.");
                    }
                    else if (RemoveByValue == "beet")
                    {
                        vegetables.Remove(vegetables[1].ToLower());
                        Console.WriteLine("You removed Beet.");
                    }
                    else if (RemoveByValue == "celery")
                    {
                        vegetables.Remove(vegetables[2].ToLower());
                        Console.WriteLine("You removed Celery.");
                    }
                    else if (RemoveByValue == "radish")
                    {
                        vegetables.Remove(vegetables[3].ToLower());
                        Console.WriteLine("You removed Radish.");
                    }
                    else if (RemoveByValue == "cabbage")
                    {
                        vegetables.Remove(vegetables[4].ToLower());
                        Console.WriteLine("You removed Cabbage.");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Heres your new list.");
                    Console.WriteLine();
                    Console.WriteLine(string.Join(", ", vegetables));

                    Console.WriteLine("Hit ENTER to continue.");
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

                    if (vegetablSearch == vegetables[0].ToLower())
                    {
                        Console.WriteLine($"Carrot is in the list. It is number 1.");
                    }
                    else if (vegetablSearch == vegetables[1].ToLower())
                    {
                        Console.WriteLine($"Beet is in the list. It is number 2.");
                    }
                    else if (vegetablSearch == vegetables[2].ToLower())
                    {
                        Console.WriteLine($"Celery is in the list. It is number 3.");
                    }
                    else if (vegetablSearch == vegetables[3].ToLower())
                    {
                        Console.WriteLine($"Radish is in the list. It is number 4.");
                    }
                    else if (vegetablSearch == vegetables[4].ToLower())
                    {
                        Console.WriteLine($"Cabbage is in the list. It is number 5.");
                    }

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("You chose: Add a vegetable");

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("You chose: Sort list");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "6")
                {
                    Console.WriteLine("You chose: Clear the list");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }

            }
        }
    }
}