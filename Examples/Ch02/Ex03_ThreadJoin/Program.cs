﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex03_ThreadJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(MyTask);
            Thread t2 = new Thread(MyTask);
            Thread t3 = new Thread(MyTask);

            t1.Start("X");
            t2.Start("Y");
            t3.Start("Z");

            t1.Join();
            t2.Join();
            t3.Join();

            for (int i = 0; i < 500; i++)
            {
                Console.Write(".");
            }
        }

        static void MyTask(object param)
        {
            for (int i = 0; i < 500; i++)
            {
                Console.Write(param);
            }
        }
    }
}
