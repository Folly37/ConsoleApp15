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

            int Fib = Fibonachi(4);
            Console.WriteLine(Fib);
            int Akk = Akkerman(1,6);
            Console.WriteLine(Akk);
            int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };
            int target = 5;
            var result = FindElement(array, target, 0, 0);
            Console.WriteLine(result);
        }
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static int Akkerman(int n, int m)
        {
            if (n == 0) return m + 1;
            else if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
            else return Akkerman(n - 1, Akkerman(n, m - 1));
        }
        static (int, int) FindElement(int[,] array, int target, int row, int col)
        {
            if (row >= array.GetLength(0))
            {
                return (-1, -1); 
            }

            if (col >= array.GetLength(1))
            {
                return FindElement(array, target, row + 1, 0);
            }

            if (array[row, col] == target)
            {
                return (row, col); 
            }

            return FindElement(array, target, row, col + 1);
        }
    }
}

