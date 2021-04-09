using System;
using System.Collections;

namespace csharp_learning_2021_04_04_作业
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList();
            int b = 1;
            string a = "a";
            list.Add(b);
            list.Add(a);
            Console.WriteLine(list[0].GetType().ToString()) ;
            Console.WriteLine(list[1].GetType().ToString()) ;
            int i = 1;
            while (i == 1)
            {


                Console.WriteLine("输入验证码(123bbb)");
                var keyword = Console.ReadLine();

                if (keyword == "123bbb")
                {
                    i = 2;
                    while (i == 2)
                    {
                        Console.WriteLine("请输入用户名(yefei)");
                        var user = Console.ReadLine();

                        if (user == "yefei")
                        {
                            i = 3;
                            while (i == 3)
                            {
                                Console.WriteLine("请输入密码(123)");
                                var password = Console.ReadLine();



                                if (password == "123")
                                {
                                    i = 4;
                                    Console.WriteLine("登录成功");
                                }
                                else
                                {
                                    Console.WriteLine("用户名或密码错误");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("用户名不存在");
                        }
                    }
                }
                else
                {
                    i = 1;
                    Console.WriteLine("验证码错误");
                }
            }
        }
    }
}
