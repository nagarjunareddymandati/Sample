using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample4
    {
      public static void Main()
        {
            Console.WriteLine("enter Product Name");
            string PName = Console.ReadLine();
            Console.WriteLine("Enter Price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Quality");
            int Qty = Convert.ToInt32(Console.ReadLine());
            int totalValue = (int)(price * Qty);
            string tot = Convert.ToString(totalValue);
            Console.WriteLine($"Product Name is: {PName} and Total value is: {tot}");
            Console.ReadKey();

        }
    }
}
