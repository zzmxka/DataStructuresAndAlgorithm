﻿using System;

namespace BaiJi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i=3; i < 100; i+=3)

                for (int j = 1; j < 33; j++)
                {

                    if (i/3+j*3+(100-i-j)*5==100 && 100-i-j>0)
                    {
                        Console.WriteLine("小鸡:" + i+ "母鸡:" + j + "公鸡:" + (100 - i - j));
                    }
                }
            Console.Read();
                
        }
    }
}
