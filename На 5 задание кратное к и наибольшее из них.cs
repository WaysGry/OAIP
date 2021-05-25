using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
	class Program
	{
        static void Main(string[] args)
        {
            int k, i, j, max;
             max = 0;
            Random ran = new Random();
            Console.WriteLine("Введите кол-во строк");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int m = int.Parse(Console.ReadLine());
            int[,] roll = new int[n, m];
            Console.WriteLine("Исходный массив");
            for ( i = 0; i < n; ++i)
            {
				Console.WriteLine("");
                for ( j = 0; j < m; ++j)
                {

                    roll[i, j] = ran.Next(1, 20);
                    Console.Write(roll[i, j] + "  ");

                }
            }
			Console.WriteLine("");
            Console.WriteLine("Введите кратное");
            k = int.Parse(Console.ReadLine());
            int[] fox = new int[n*m];
            Console.WriteLine("Новый массив: ");
            for ( i = 0; i < n; ++i)
            {
                for ( j = 0; j < m; ++j)
                {
                    if (roll[i, j] % k == 0)
                    {
                        fox[i] = roll[i, j];
                        Console.WriteLine(fox[i] + "");
                        if (max < fox[i])
                        {
                            max = fox[i];
                            
                        }
                    }
  
                }
            }
            Console.WriteLine("Наибольшее из них");
            Console.WriteLine("" + max);
            Console.ReadKey();
        }
	}
}
