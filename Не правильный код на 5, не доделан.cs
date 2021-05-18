using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Random r = new Random();
            Console.WriteLine("Введите кол-во строк");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int m = int.Parse(Console.ReadLine());
            int[,] roll = new int[n, m];
            Console.WriteLine("Исходный массив");
            for ( i = 0; i < n; ++i)
            {
                for ( j = 0; j < m; ++j)
                {

                    roll[i, j] = r.Next(-20, 20);
                    Console.Write(roll[i, j] + "  ");

                }
                Console.WriteLine("");
            }
            Console.WriteLine("Массив из положительных элементов каждого столбца митрицы: ");
            int[] mas = new int[n*m];
            int k;
                for ( j = 0; j < m; ++j)
                {
                k = roll[0, j];
                    for (i = 0; i < n; i++)
                        if (roll[i,j] < k)
                        {
                            k = roll[j, i];
                        }
                Console.WriteLine(k + "");
            }
            Console.ReadKey();
        }
    }
}
