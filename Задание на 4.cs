using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите количесtво элементов");
			int m = Convert.ToInt32(Console.ReadLine());
			int[] agro = new int[m];
			Random ran = new Random();
			for (int i = 0; i < m; i++)
			{
				agro[i] = ran.Next(-20,20);
				Console.Write(agro[i] + " ");
			}
			Console.WriteLine("");
			int c = 0;
			int[] aro = new int[m];
			Console.WriteLine("Новый массив");
			for (int i = 0; i < m; i++)
			{
				if (agro[i]>0)
				{
					aro[i] = agro[i];
					Console.WriteLine("" + aro[i]);
					c++;
				}
			}
			if(c==0) Console.WriteLine("Такого числа нет");
			Console.ReadKey();
		}
	}
            
    
}
