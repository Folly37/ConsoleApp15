using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int Akk = Akkerman(1,6);
            Console.WriteLine(Akk);
        }
        static int Akkerman(int n, int m)
        {
            if (n == 0) return m + 1;
            else if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
            else return Akkerman(n - 1, Akkerman(n, m - 1));
        }
    }
}

