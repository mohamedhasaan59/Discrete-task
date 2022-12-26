using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, sum = 0;
            Console.Write("Enter the  start number :");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter the end number:");
            int max = int.Parse(Console.ReadLine());

            
            for (int n1 = min; n1 <= max; n1++)
            {
                
                for (int n2 = 1; n2 <= max; n2++)
                {
                    
                    if (n1 % n2 == 0)
                    {
                     
                        sum += 1;
                    }
                }
                
                if (sum == 2)
                {
                    Console.WriteLine( n1);
                }
                sum = 0;
            }
        }
    }
}

