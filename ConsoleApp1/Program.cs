using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y;

            Console.WriteLine("----------------  Calculation ------------------------");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Minus");
            Console.WriteLine("3) Div ");
            Console.WriteLine("4) Modulo");
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    {
                        Console.WriteLine("X :");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Y :");
                        y = Convert.ToInt32(Console.ReadLine());
                        int z = x + y;
                        Console.WriteLine("Z : " + z);
                        Console.ReadKey();
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("X :");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Y :");
                        y = Convert.ToInt32(Console.ReadLine());
                        int r = x + y;
                        Console.WriteLine("r : " + r);
                        Console.ReadKey();
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("X :");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Y :");
                        y = Convert.ToInt32(Console.ReadLine());

                        if (y == 0)
                        {
                            Console.WriteLine("ERROR : VARIABLE Y SHOULD BE DIFFERENT THAN 0");
                        }
                        else
                        {
                            int d = x / y;
                            Console.WriteLine("d : " + d);
                        }
                        Console.ReadKey();
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("X :");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Y :");
                        y = Convert.ToInt32(Console.ReadLine());

                        if (y == 0)
                        {
                            Console.WriteLine("ERROR : VARIABLE Y SHOULD BE DIFFERENT THAN 0");
                        }
                        else
                        {
                            int m = x % y;
                            Console.WriteLine("m : " + m);
                        }

                        Console.ReadKey();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("ADD REAL VARIABLES");
                    }
                    break;

            }







        }
    }
}
