using System;
using System.Collections;

namespace _2021_04_18_作业
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i.ToString());
            }
            int j = 1;
            while (j <= 9)
            {

                Console.WriteLine(j.ToString());
                j += 2;
            }
            int k = 99;
            int m = 99;
            while (k >= 0)
            {

                k -= 2;
                m = m + k;

            }
            Console.WriteLine(m.ToString());
            int l = 100;
            while (l >= 0)
            {
                if (l % 2 == 0)
                {
                    l -= 1;
                }
                else if (l % 3 == 0)
                {
                    l -= 1;
                }
                else if (l % 5 == 0)
                {
                    l -= 1;
                }
                else
                {
                    Console.WriteLine(l.ToString());
                    l -= 1;
                }
            }
            int r1 = new Random().Next(1,100);
            int r2 = new Random().Next(1,100);
            int r3 = new Random().Next(1,100);
            int r4 = new Random().Next(1,100);
            int r5 = new Random().Next(1,100);
            ArrayList i_array = new ArrayList() {r1,r2,r3,r4,r5 };
            i_array.Sort();
            i_array.Reverse();
            for(int i=0;i<i_array.Count;i++)
            {
                Console.WriteLine(i_array[i].ToString());
            }
            int n = 0, o = 0;
            int[,] matrix = new int[4, 4];
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int p=0;p<matrix.GetLength(1);p++)
                {
                    matrix[i, p] = i + p+2;
                    Console.Write(i+p+2+"  ");
                }
                Console.WriteLine();
            }


             
        }
    }
}
