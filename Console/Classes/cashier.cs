using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class Cashier
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
            // From "1" to 1
            int userMenuItem = Convert.ToInt32(userInput);
            return userMenuItem;
        }
        public void SayThanksAndGoodBye()
        {
            Console.WriteLine("Thank you and have a great day!");
        }

    }
}
