using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestlade_loopar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Övning 1
            /*
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (x % 2 == 0)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write("#");
                    } 
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */
            //Övning 2
            /*
            for (int i = 0; i < 11; i++)
            {
                for (int x = 0; x < 11; x++)
                {

                    if (i % 2 == 0)
                    {                    
                        if (x % 2 == 0)
                        {
                            Console.Write("o");
                        }
                        else
                        {
                            Console.Write("#");
                        }
                    }
                    else
                    {
                        if (x % 2 == 0)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write("o");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */
            //Övning 3
            /*
            for (int i = 10; i > 0; i--)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */
            //Övning 4
            /*
            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (y < i)
                    {
                        Console.Write(".");
                    }
                    if (y > i)
                    {
                        Console.Write("#");
                    }                
                }               
                Console.WriteLine();
            }
            Console.ReadKey();
            */
            //Övning 5
            /*
            for (int i = 0; i < 7; i++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (y == i || y+i == 6)
                    {
                        Console.Write("*");
                    }
                    else {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */
            //Övning 6
            /*
            for (int i = 0; i < 7; i++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if ((y < i || y + i < 6 )&& (y > i || y + i > 6))
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */
            //Övning 7
            for (int i = 0; i < 9; i++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (y+i < 4 || y-i > 4 || y+i > 12 )
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }//staticcc
    }
}
