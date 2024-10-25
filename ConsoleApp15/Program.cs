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
            int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };
            int target = 5;
            var result = FindElement(array, target, 0, 0);
            Console.WriteLine(result);
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

