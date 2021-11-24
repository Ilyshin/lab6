using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 3600;
            double sum = 0;
            double average = 0;
            double sqrtaverage = 0;
            for (int i = 0; i<n; i++)
            {
                double y = Math.Pow(Math.E, -rnd.NextDouble());
                average += y / n;
                sqrtaverage += y * y / n;
            }
            Console.WriteLine("Task 1.1 result {0,-40} sigmaM is {1}",avarage, Math.Sqrt((sqrtaverage -  average*average)/n));
            Task12(n);
            Task2(n);
            Console.ReadKey();
        }

        static void Task12 (int n)
        {
            Random rnd = new Random();
            int m = 20;
            double average = 0;
            double sqrtaverage = 0;
            for (int i = 0; i<m; i++)
            {
                double sum = 0;
                for (int j = 0; j < n; j++)
                {
                    double y = Math.Pow(Math.E, -rnd.NextDouble());
                    sum += y;
                }
                
                average+= sum / (n);
                sqrtaverage += sum * sum / (n*n);
            }
            Console.WriteLine("Task 1.2 result {0,-40} sigmaM is {1}", average/m, Math.Sqrt((sqrtaverage/m - average/m * average/m)));
        }
        static void Task2 (int n)
        {
            Random rnd = new Random();
            double average = 0;
            double sqrtaverage = 0;
            for (int i = 0; i < n; i++)
            {
                var r = rnd.NextDouble();

                double x = -Math.Log(1 - r);
                if (x > 10)
                    continue;
                double x = rnd.NextDouble() * 10;
                double y = Math.Pow(x, 1.5)* Math.Pow(Math.E, -x);
                average += y / n;
                sqrtaverage += y * y / n;
            }
            Console.WriteLine("Task 2 result {0,-42} sigmaM is {1}", average, Math.Sqrt((sqrtaverage -  average*average)/n));

        }
    }
}
