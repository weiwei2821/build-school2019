using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int candy = 0;
            int buy = 0;
            int paper = 0;
            int change = 4;
            int total = 11;
            
            while (candy < total)
            {
                buy++;
                candy++;
                paper++;
                if (paper == change)
                {
                    paper = 1;
                    candy++;
                }
            }
            Console.WriteLine("買" + buy + "個"+","+change+"張換一顆糖果"+","+"總共"+candy+"個糖果");
        }
    }
}
