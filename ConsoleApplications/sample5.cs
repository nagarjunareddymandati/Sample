using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample5
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter UserName");
            string UName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            if (UName == "Nag@gmail.com" && password == "Nag@123")
            {
                Console.WriteLine("Welcome To My website:"   +UName);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sorry !  No User Exist");
                Console.WriteLine("Please Try Again ");
                Console.ReadKey();

            }
           
        }
    }
}
