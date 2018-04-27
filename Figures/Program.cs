using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int menu = 1;
            while (menu!= 4)
            {
                Console.Clear();
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("Квадрат - 1;");
                Console.WriteLine("Прямоугольник - 2;");
                Console.WriteLine("Треугольник - 3;");
                Console.WriteLine("Выход - 4;");
                Console.Write(">>");
                try { menu = Convert.ToInt32(Console.ReadLine()); }
                catch { menu = 1; }
                switch (menu)
                {
                    case 1:
                        {
                            square new_square = new square();
                            Console.WriteLine("Введите сторону квадрата");
                            try { new_square.side = Convert.ToInt32(Console.ReadLine()); }
                            catch { new_square.side = 2; }
                            new_square.Build_Square();
                            break;
                        }
                    case 2:
                        {
                            Rectangle new_rectangle = new Rectangle();
                            Console.WriteLine("Введите стороны прямоугольника");
                            try
                            {
                                Console.WriteLine("Введите высоту");
                                new_rectangle.side = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                new_rectangle.side = 2;                                
                            }
                            try
                            {
                                Console.WriteLine("Введите ширину");
                                new_rectangle.side_two = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                new_rectangle.side_two = 4;
                            }
                            new_rectangle.Build_Rectangle();
                            break;
                        }
                    case 3:
                        {
                            triangle new_triangle = new triangle();
                            Console.WriteLine("Введите основание треугольника(нечетное число)");
                            try
                            {
                                new_triangle.side = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                new_triangle.side = 3;
                            }
                            new_triangle.Build_Triangle();
                            break;
                        }
                }
            }
        }
    }
}
