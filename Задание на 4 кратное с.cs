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
			Random ran = new Random();
			Console.Write("Введите кол-во строк: ");
			int n = int.Parse(Console.ReadLine());
			Console.Write("Введите кол-во столбцов: ");
			int m = int.Parse(Console.ReadLine());
			int[,] roll = new int[n, m];
			Console.WriteLine("Исходный массив");
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("");
				for (int k = 0; k < m; k++)
				{

					roll[i, k] = ran.Next(1, 10);
					Console.Write(roll[i, k] + "  ");
				}
			}
			Console.WriteLine("");
			Console.WriteLine("Введите кратное");
			int c = int.Parse(Console.ReadLine());
			int[] fox = new int[n * m];
			Console.WriteLine("Новыйй массив: ");
			for (int i = 0; i < n; ++i)
				for (int k = 0; k < m; ++k)
					if (roll[i, k] % c == 0)
					{
						fox[i] = roll[i, k];
						Console.WriteLine(fox[i] + "");
					}


			Console.ReadKey();
		}
	}
}
