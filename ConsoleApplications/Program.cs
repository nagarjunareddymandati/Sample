using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 12, 43, 21, 65, 42, 22, 11, 4, 9, 98, 54 };
            int size = 0;
            for(int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    size++;
                }
            }
            int[] br = new int[size];
            int index = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    br[index] = ar[i];
                    index++;
                }
            }
            foreach (var item in br)
            {
                Console.Write(item + " ");

                

            }
        }
    }
}
