using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i= 1; i < 101;i++)
            {
                char[] result;
                result = i.ToString().ToCharArray();
                for (int w= 0;w<result.Length;w++)
                {
                    if (result[w] == '3') result[w] = 'A';
                    if (result[w] == '5') result[w] = 'B';
                    if (result[w] == '9') result[w] = 'C';
                    if (result[w] == '0') result[w] = 'D';
                    
                }
                Console.WriteLine(result);
                 
            }
            


        }
    }
}
