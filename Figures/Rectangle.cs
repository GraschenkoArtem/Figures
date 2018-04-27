using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle: square
    {
        public int side_two { get; set; }

        public Rectangle()
        {
            side = 2;
            side_two = 4;
        }

        public void Build_Rectangle()
        {
            int[,] mas = new int[side, side_two];
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side_two; j++)
                {
                    if (j == 0 || j == (side_two - 1))
                        mas[i, j] = 1;
                    else
                    {
                        if (i == 0 || i == (side - 1))
                            mas[i, j] = 1;
                        else
                            mas[i, j] = 0;
                    }
                }
            }
            /*
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side_two; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
           Console_Paint_Rectangle(mas);
        }

        private void Console_Paint_Rectangle(int[,] mas)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side_two; j++)
                {
                    if (mas[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("  ");
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
