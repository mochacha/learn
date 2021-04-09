using System;

namespace csharp_2021_04_10_作业
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] student= new string[ , ] {  { "张三", "apple", "2021-01-01", "男","11" } ,  { "李四", "orange", "2021-02-01 ", "男","20" } ,{ "刘五","banana","2021-03-01","女","30" },{ "王六","garce","2021-04-01","女","41" }, };
            string[,] name_time = new string[4,2];
            string[] time = new string[4];
            time[0] = student[0, 2];
            time[1] = student[1, 2];
            time[2] = student[2, 2];
            time[3] = student[3, 2];
            name_time[0,0]=student[0, 0] ;
            name_time[0,1]=student[0, 2] ;
            name_time[1,0]=student[1, 0] ;
            name_time[1,1]=student[1, 2] ;
            name_time[2,0]=student[2, 0] ;
            name_time[2,1]=student[2, 2] ;
            name_time[3,0]=student[3, 0] ;
            name_time[3,1]=student[3, 2] ;
    

            for(int i=0;i<time.Length;i++)
            {
                Console.WriteLine(time[i]);
            }
            for(int i=0;i<name_time.GetLength(0);i++)
            {
                for(int j=0;j<name_time.GetLength(1); j++)
                Console.WriteLine(name_time[i,j]);

            }
           
        }
    }
}
