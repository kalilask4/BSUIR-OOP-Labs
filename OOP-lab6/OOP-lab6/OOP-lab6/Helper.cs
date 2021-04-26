using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_lab6
{
    class Helper
    {

        public static void imitate_loading(string str)
        {
            Thread.Sleep(50);
            Console.Write("\n");
            Thread.Sleep(50);
            Console.Write(".");
            //Console.Write("\n.");
            Thread.Sleep(50);
            Console.Write("...");
            Thread.Sleep(50);
            Console.Write("...");
            Thread.Sleep(50);
            Console.Write("...");
            Thread.Sleep(50);
            Console.Write("..");
            Thread.Sleep(100);
            Console.Write("........");
            Thread.Sleep(200);
            Console.Write("...");
            Thread.Sleep(100);
            Console.Write("....");
            Thread.Sleep(50);
            Console.Write("........");
            Thread.Sleep(100);
            Console.Write("...");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(str);
            Thread.Sleep(50);
            Console.Write("...");
            Thread.Sleep(100);
            Console.Write("....");
            Thread.Sleep(50);
            Console.Write("...............");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(10);
            Console.Write(".");
            Thread.Sleep(10);
            Console.Write(".");
            Thread.Sleep(10);
            Console.Write(".");
            Thread.Sleep(10);
            Console.Write(".");
            Thread.Sleep(10);
            Console.Write(".\n");
        }
    }
}
