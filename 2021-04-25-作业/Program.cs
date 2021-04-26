using System;

namespace _2021_04_25_作业
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("请输入不超过1000的自然数");
               double input= Console.Read();
                bool y = GuessMe(input, number());
                if (y) { Console.WriteLine("太大了"); }
                
                else { Console.WriteLine("太小了"); }
                
            }
        }
        static double number()
        {
            double r = new Random().NextDouble();
            return 1000*r;            
        }
        static bool GuessMe(double r,double i)
        {
            if (r >=i) { return true; }
            else{ return false; }

        }
    }
}
