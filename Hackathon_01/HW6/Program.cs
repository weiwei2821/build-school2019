using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 101; i < 201; i++)
            {
                int a = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    Console.WriteLine("{0}",i);
                }
            }
        }
    }
}
    

