using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestlade_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1

            Console.WriteLine("Övning 1");

            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("o#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            //Övning 2

            Console.WriteLine("Övning 2");

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
                } Console.WriteLine();
                
            }
            Console.ReadLine();

            //Övning 3

            Console.WriteLine("Övning 3");

            for (int i = 0; i < 10; i++)
            {
                for (int x = 10; x > i; x--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            //Övning 3 baklänges

            Console.WriteLine("Övning 4");

            for (int i = 0; i < 7; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write(".");
                }
                for (int z = 0; z < (7-i); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            //Övning 5

            Console.WriteLine("Övning 5");

            for (int i = 0; i < 7; i++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (i == x || i + x == 6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Övning 5
        }
    }
}
