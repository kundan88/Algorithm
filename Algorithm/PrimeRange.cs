using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class PrimeNo
    {
        int count = 0;
        public void PrimeNoRange()
        {
            Console.WriteLine("Prime numbers between 1 and 1000 are: ");
            Console.WriteLine("==============================================");
            for (int i = 1; i < 1000; i++)
            {
                count = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write(i + "  ");
                    }
                }
            }
        }
    }
}