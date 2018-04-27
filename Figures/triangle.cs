using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class triangle: square
    {
        private int h = 0;
        public triangle()
        {
            side = 3;
        }

        public void Build_Triangle()
        {
            if ((side % 2) == 0)
                side++;
            h = ((side + 1) / 2);
            int[,] mas = new int[h, side];            

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    if (j == ((side / 2) - i))
                        mas[i, j] = 1;
                    else
                        if (j == ((side / 2) + i))
                        mas[i, j] = 1;
                    else
                        mas[i, j] = 0;
                    if (i == (h - 1))
                        mas[i, j] = 1;
                }
            }
            Console_Paint_Triangle(mas);
        }

        private void Console_Paint_Triangle(int[,] mas)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < side; j++)
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
