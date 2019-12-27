using System;

namespace program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = 0;
            string[,] str1 = { { "人工智能", "3", "zzm", "产生效果" },
                { "智能化","3","超智能","影响"}
            };

            foreach (string i in str1)
            {
                if (i == str)
                {
                    Console.WriteLine("在" + a);
                }
                a++;
                continue;
            }
        }
    }
}
