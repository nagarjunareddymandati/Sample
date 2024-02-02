using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample7
    {
        public static void Main()
        {
            Console.WriteLine("Enter Email");
            string Email = Console.ReadLine();
            if (Email == "Nag123@gmail.com")
            {
                Console.WriteLine("Enter Password");
                string pwd = Console.ReadLine();
                if (pwd == "Nag@123")
                {
                    Console.WriteLine("Welcome" +Email);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong Password");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Email Wrong");
                Console.ReadLine();
            }
        }
    }
}
