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
                var r =Console.ReadLine();
                int y = GuessMe(Convert.ToInt32( r), Math.Round(number()));
                if (y == 1) { Console.WriteLine($"太大了,（还剩{10-i}次）"); }
                if (y == 2) { Console.WriteLine($"太小了，（还剩{10-i}次）"); }
                if (y == 3) 
                {
                    if (i < 5) 
                    { 
                        Console.WriteLine("牛逼");
                        return;
                    }
                        
                    else if(i<8)
                    {
                        Console.WriteLine("不错嘛");
                        return;
                    }
                    else { Console.WriteLine("猜对了"); }

                     }
                
            }
        }
        static double number()
        {
            double r = new Random().NextDouble();
            return 1000*r;            
        }
        static int GuessMe(double r, double i)
        {
            if (r > i) { return 1; }
            else  if (r < i) { return 2; }
            else{ return 3; }

        }
    }
}
