using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class square
    {
        public int side { get; set; }

        public square()
        {
            side = 2;
        }

        public void Build_Square()
        {
            int[,] mas = new int[side, side];
            for(int i = 0; i < side; i++)
            {
                for(int j = 0; j < side; j++)
                {
                    if (j == 0 || j == (side - 1))
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

            /* удалить комментирование данного блока, что бы убедиться, что в консоле выводится квадрат
              for (int i = 0; i < side; i++)
               {
                   for (int j = 0; j < side; j++)
                   {
                       Console.Write(mas[i, j] + " ");
                   }
                   Console.WriteLine();
               }*/
            Console_Paint_Square(mas);
        }

        private void Console_Paint_Square(int[,] mas)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    if(mas[i,j] == 1)
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
