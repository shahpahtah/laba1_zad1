﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp3
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            lab1_num1 a = new lab1_num1(1,2);
            lab1_num1 b = new lab1_num1(1, 20);
            lab1_num1 c = a /2 ;
            Console.WriteLine(c.ToString());

        }
    }

}
