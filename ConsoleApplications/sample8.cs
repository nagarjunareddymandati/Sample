using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample8
    {
        public static void Main()
        {
            Console.WriteLine("Enter N1 Number:");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N2 Number");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N3 Number");
            int N3 = Convert.ToInt32(Console.ReadLine());
            if (N1 > N2 && N1 > N3)
            {
                Console.WriteLine("N1 IS BIGGEST NUMBER");
            }
            else if (N2 > N3)
            {
                Console.WriteLine("N2 IS BIGGEST NUMBER");
                Console.ReadKey();
            }
            else if (N1 == N2 && N2 == N3)
            {
                Console.WriteLine("EQUAL");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("N3 IS BIGGEST NUMBER");
                Console.ReadKey();


            }

        }
             
    }
 
}


