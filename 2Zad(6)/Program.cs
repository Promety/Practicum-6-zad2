using System;

namespace _2Zad_6_
{
    class Program
    {
        static void Main(string[] args)
        {
           double max = 0;
            int a ;
            Console.WriteLine("Кол-во элементов массива ");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
                Console.Write("Ошибка, Введите n заново\n");
            double[] G = new double[a];
            Console.WriteLine("Заполнение массивы :");
            for (int j = 0; j < a; j++)
            {
                Console.Write("[{0}]= ", j);
                while (!double.TryParse(Console.ReadLine(), out G[j]))
                {
                    Console.Write("Ошибка" + $"Введите заново [{j}]: ");
                }
                {
                    if (G[j] > max) max = G[j];      
                }
            }
            Console.WriteLine("Максимальное число: {0}", max);
            Console.Write("Список элементов не совпадающих с максимальным:: ");
            for (int j = 0; j < G.Length; j++)
            {
                if(G[j]!= max) Console.Write(j +" ");
            }
            Console.ReadKey();
        }
    }
}
