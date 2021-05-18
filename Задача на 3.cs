using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
       {
                Console.Write("Введите Начало промежутка: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите конец промежутка: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Введите кратное: ");
                int c = int.Parse(Console.ReadLine());
                if (a < b)
                {
                    int kol = 0, proiz = 1;
                    for (int i = a; i <= b; i++)
                    {
                        if (i % c == 0 )
                        {
                            kol++;
                            proiz *= i;
                        }
                    }
                    Console.WriteLine("В промежутке чисел кратных c = " + kol);
                    Console.WriteLine("Их произведение =" +proiz);
                }
            
        }
           
    }
}

