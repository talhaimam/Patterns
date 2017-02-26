using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Patterns
    {
        public void TwoPyramids()
        {
            int rows = 10;
            for (int i = 1; i <= rows; i++)
            {
                for (int k = rows; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                for (int k = rows+10; k >= i+10; k--)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public void EquiTriangle()
        {
            int rows = 10;
            for (int i = 1; i <= rows; i++)
            {
                for (int k = rows; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}