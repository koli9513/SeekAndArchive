using System;

namespace SeekAndArchive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintMenu();
            SelectMenu();
        }

        private static void SelectMenu()
        {
            var chosenMenu = Console.ReadLine();
            switch (chosenMenu)
            {
                case "1":
                    Console.Clear();
                    Search();
                    break;
                case "2":
                    Console.Clear();
                    ShowSearchHistory();
                    break;
                case "3":
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid menu option, choose again.");
                    PrintMenu();
                    SelectMenu();
                    break;
            }
        }

        private static void Search()
        {
            throw new NotImplementedException();
        }
        
        private static void ShowSearchHistory()
        {
            throw new NotImplementedException();
        }

        private static void PrintMenu()
        {
            Console.WriteLine(@"
---------------------
Please choose a menu item:
    1 - New search
    2 - Browse search history
    3 - Exit
---------------------");
        }
    }
}