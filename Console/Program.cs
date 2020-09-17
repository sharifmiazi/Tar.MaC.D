using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Make the menu (get the menu)
            Menu ourmenu = new Menu();
            // Display the menu
            MenuDisplayCase displayCase = new MenuDisplayCase();
            displayCase.DispalyMenu();
            //Welcome user, ask for order
            Cashier cashier = new Cashier();
            cashier.Greeting();
            // Translate usr input to menu item
            int userOrderItem = cashier.GetOrder();
            // Cook menu item
            cook cook = new cook();
            string cookedFoodMassage = cook.MakeFood(userOrderItem);
            // Return cooked food
            Console.WriteLine(cookedFoodMassage);
            cashier.SayThanksAndGoodBye();
            Console.WriteLine();

        }
    }
    class cook
    {
        // If you need ---to make food,---is one of our parameters
        public string makefood(int menuItemNumber)
        {
            
            
            Menu menu = new Menu();
            string menuItem = menu.MenuItems[menuItemNumber];
            return $"Your {menuItem} is ready!";

        }

    }
    class Cashier
    {
        public void Greeting()
        {
            Console.WriteLine("Welcome to Mcdonald!");
        }
        public int GetOrder()
        {
            Console.WriteLine("what can i get you today?\n" +
                "please type in the number for the iteam and press enter.");
            string userInput = Console.ReadLine();
            int userMenuItem = Convert.ToInt32(userInput);
            return userMenuItem;
        }
        public void SayThanksAndGoodBye()
        {
        Console.WriteLine("Thank you and have a great day!");
        }
        
           
               
    }
    
    class MenuDisplayCase
    {
        public void DispalyMenu()
        {
            Menu menuToDisplay = new Menu();
            foreach (KeyValuePair<int,string> menuItem in menuToDisplay.MenuItems)
            {
                Console.WriteLine($"{menuItem.Key} - {menuItem.Value}");
            }

        }
    }
    class Menu
    {
        public Menu()
        {
            MenuItems = new Dictionary<int, string>
            {
                {1, "Big Mac" },
                {2, "Mcdoub" },
                {3, "SEG McGriddle" },
                {4, "Chk Nugg" },
                {5, "Cookies" },
                {6, "Apple Pie" },
                {7, "Bagel" },
                {8, "Pancakes" },


            };
        }
        public Dictionary<int, string> MenuItems { get; set; }
    }
}
