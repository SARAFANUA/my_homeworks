using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3_чет_нечет_вы_диапазоне 
    
    //количество четных и нечетных чисел в диапапазоне который укажет пользователь
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введните диапазон для вычесления четных и нечетных значений");
                Console.WriteLine();
                Console.WriteLine("Введните первое значение:");
                int value1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введните второе значение:");
                int value2 = int.Parse(Console.ReadLine());

                int result1 = (value2 - value1) + 1;
                int result2 = (value1 - value2) + 1;

                if (value1 == value2)
                    Console.WriteLine("Введите диапазон");
                    Console.WriteLine();

                if (value1 < value2)
                {
                    value1++;
                    Console.WriteLine();
                    Console.WriteLine("Количетво значений с " + (value1 - 1) + " по " + value2 + " равен " + result1);
                    Console.WriteLine();

                    if (result1 % 2 == 0)
                    {
                        Console.WriteLine("Количество четных чисел: " + result1 / 2);
                        Console.WriteLine("Количество нечетных чисел: " + (result1 - result1 / 2));
                        Console.WriteLine();
                    }
                    else if (result1 % 2 == 1)
                    {
                        Console.WriteLine("Количество четных чисел: " + result1 / 2);
                        Console.WriteLine("Количество нечетных чисел: " + (result1 - result1 / 2));
                        Console.WriteLine();
                    }

                }
                else if (value1 > value2)
                {
                    value1--; //для разнообразия
                    Console.WriteLine();
                    Console.WriteLine("Количетво значений с " + (value1 + 1) + " по " + value2 + " равен " + result2);
                    Console.WriteLine();
                    if (result2 % 2 == 0)
                    {
                        Console.WriteLine("Количество четных чисел: " + result2 / 2);
                        Console.WriteLine("Количество нечетных чисел: " + (result2 - result2 / 2));
                        Console.WriteLine();
                    }
                    else if (result2 % 2 == 1)
                    {
                        Console.WriteLine("Количество четных чисел: " + result2 / 2);
                        Console.WriteLine("Количество нечетных чисел: " + (result2 - result2 / 2));
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Нажмитте Ввод, чтобы повторить.");
                Console.ReadLine();

            }
        }
    }