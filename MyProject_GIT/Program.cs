using System.Text;

namespace MyProject_GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Введіть 'ключове' значення аргументу x, при якому програма завершить роботу: ");
            double stop = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Програма працюватиме нескінченно, поки ви не введете x = {stop}.");
            while (true)
            {
                Console.Write("Введіть аргумент x або ключове значення для виходу: ");
                double x = Convert.ToDouble(Console.ReadLine());
                if (x == stop)
                {
                    Console.WriteLine("Введено ключове значення. Завершення роботи програми.");
                    break;
                }
                Console.Write("Введіть аргумент x: ");
                //перша гілка
                if (x <= -1)
                {
                    double argArccos07x = 0.7 * x;
                    if (argArccos07x >= -1 && argArccos07x <= 1)
                    {
                        if (Math.Sin(7 * x) != 0)
                        {
                            double Ctg7x = Math.Cos(7 * x) / Math.Sin(7 * x);
                            double arccos07x = Math.Acos(argArccos07x);
                            if ((Ctg7x - arccos07x) > 0)
                            {
                                double result = Ctg7x - arccos07x;
                                double y1 = Math.Sqrt(Ctg7x - arccos07x);
                                Console.WriteLine("у = " + y1);
                            }
                            else
                            {
                                Console.WriteLine("Підкореневий вираз відємний. Функція не визначена.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Підкореневий вираз відємний. Функція не визначена.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Помилка! Аргумент арккосинуса виходить за межі [-1; 1].");
                    }
                }
                else if (x <= 0)
                {
                    Console.WriteLine("Функція не визначена. X знаходиться в інтервалі (-1; 0].");
                }
                else //друга гілка
                {
                    if (x > 0)
                    {
                        if ((2 * x - 1) > 0)
                        {
                            double lg = Math.Log10(2 * x - 1);
                            if (((x - 5) * lg) != 0)
                            {
                                double y2 = Math.Cos(x) / ((x - 5) * lg);
                                Console.WriteLine("y = " + y2);
                            }
                            else
                            {
                                Console.WriteLine("Помилка! Знаменник дорівнює нулю.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Помилка! Логарифм існує лише тоді, коли його аргумент більший за нуль.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Помилка! Для другої гілки X < 0");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
