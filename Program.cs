namespace Topic_7__assignment_2___lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                List<string> vegtables = new List<string>();
                vegtables.Add("Carrot");
                vegtables.Add("Beet");
                vegtables.Add("Celery");
                vegtables.Add("Radish");
                vegtables.Add("Cabbage");  

                for (int i = 0; i < vegtables.Count; i++)
                {
                    Console.WriteLine($"{vegtables[i]}");
                }

                

                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("Welcome to my menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");
                Console.WriteLine("5");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine("You chose: ");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose: ");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You chose: ");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("You chose: ");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("You chose: ");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }

            }
        }
    }
}