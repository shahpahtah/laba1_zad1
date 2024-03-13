using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp3
{
    public class lab1_num1 
    {
        private int numerator;
        public int Numerator
        {
            get { return numerator; }
            private set { numerator = value; } 
        }
        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            private set { denominator = value; }    
        }
        public lab1_num1(int a1,int a2)
        {
            Numerator = a1;
            Denominator = a2;
        }
        private void socrat()
        {
            int max;
            if (Numerator < Denominator)
            {
                if (Numerator < 0)
                {
                    max = -Numerator;
                }
                else { max = Numerator; }
            }else { max = Denominator; }
            
            int i = 2;
            while (i <= max)
            {
                if (Numerator % i ==0 && Denominator % i == 0)
                {
                    Numerator = Numerator / i;
                    Denominator = Denominator / i;
                    i = 2;
                    continue;
                }
                i++;
            }
  
        }
        new public string ToString()
        {
            socrat();
            if (Numerator == 0)
            {
                return "0\n";
            }
            else if (Denominator == 0)
            {
                return "error, delenie na 0\n";
            }
            else if (Denominator == 1)
            {
                return Numerator.ToString();
            }
            else if (Numerator % Denominator == 0)
            {
                return Numerator.ToString();
            }
            else if (Denominator % Numerator == 0 )
            {
                return (Numerator /Numerator).ToString() + "/" + (Denominator / Numerator).ToString();
            }
            string s = Numerator.ToString() + "/" + Denominator.ToString();
            return s;
        }
        public static lab1_num1 operator-(lab1_num1 a)
        {
            if (a.Denominator != 0)
            {
                a.denominator = -a.Denominator;
                return a;
            }
            else {
                Console.WriteLine("delenine na  0!");
                lab1_num1 c = new lab1_num1(0, 0);
                return c;
            }
        }
        public static bool operator==(lab1_num1 a,lab1_num1 b)
        {
            if(a.Denominator != 0 && b.Denominator != 0)
            {
                if (a.Numerator.ToString() == b.Numerator.ToString() && a.Denominator.ToString() == b.Denominator.ToString())
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }
        public static bool operator !=(lab1_num1 a, lab1_num1 b)
        {
            if (a.Denominator != 0 && b.Denominator != 0)
            {
                if (a.Numerator.ToString() != b.Numerator.ToString() || a.Denominator.ToString() != b.Denominator.ToString())
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }
        public static bool operator>(lab1_num1 a, lab1_num1 b)
        {
            if (a.Denominator != 0 && b.Denominator != 0)
            {
                double a1 = (double)a.Numerator / (double)a.Denominator;
                double b1 = (double)b.Numerator / (double)b.Denominator;
                if (a1 > b1)
                {
                    return true;
                }
                else { return false; }
            }
            return false;
        }
        public static bool operator <(lab1_num1 a, lab1_num1 b)
        {
            if (a.Denominator != 0 && b.Denominator != 0)
            {
                double a1 = (double)a.Numerator / (double)a.Denominator;
                double b1 = (double)b.Numerator / (double)b.Denominator;
                if (a1 < b1)
                {
                    return true;
                }
                else { return false; }
            }
            return false;
        }
        public static bool operator >=(lab1_num1 a, lab1_num1 b)
        {
            if (a.Denominator != 0 && b.Denominator != 0)
            {
                double a1 = (double)a.Numerator / (double)a.Denominator;
                double b1 = (double)b.Numerator / (double)b.Denominator;
                if (a1 >= b1)
                {
                    return true;
                }
                else { return false; }
            }
            return false;
        }
        public static bool operator <=(lab1_num1 a, lab1_num1 b)
        {
            if (a.Denominator != 0 && b.Denominator != 0)
            {
                double a1 = (double)a.Numerator / (double)a.Denominator;
                double b1 = (double)b.Numerator / (double)b.Denominator;
                if (a1 <= b1)
                {
                    return true;
                }
                else { return false; }
            }
            return false;
        }
        public static lab1_num1 operator+(lab1_num1 a, lab1_num1 b) {
            if (a.Denominator != 0 && b.Denominator != 0)
            {
                lab1_num1 c = new lab1_num1(0, 1);
                if (a.Denominator == b.Denominator)
                {
                    c.Numerator = a.Numerator + b.Numerator;
                    c.Denominator = a.Denominator;
                    return c;
                }
                else if (a.Denominator > b.Denominator)
                {
                    if (a.Denominator % b.Denominator == 0)
                    {
                        c.Numerator = a.Numerator + (b.Numerator * (a.Denominator / b.Denominator));
                        c.Denominator = a.Denominator;
                        return c;
                    }
                    else
                    {
                        c.Numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
                        c.Denominator = a.Denominator * b.Denominator;
                        return c;
                    }
                }
                else
                {
                    if (b.Denominator % a.Denominator == 0)
                    {
                        c.Numerator = b.Numerator + (a.Numerator * (b.Denominator / a.Denominator));
                        c.Denominator = b.Denominator;
                        return c;
                    }
                    else
                    {
                        c.Numerator = b.Numerator * a.Denominator + a.Numerator * b.Denominator;
                        c.Denominator = b.Denominator * a.Denominator;
                        return c;
                    }
                }
            }
            else
            {
                Console.WriteLine("у одного или у обоих делитель равен 0!");
                lab1_num1 c = new lab1_num1(0, 0);
                return c;
            }
        }
        public static lab1_num1 operator-(lab1_num1 a,lab1_num1 b)
        {
            if (a.Denominator !=0 && b.Denominator != 0)
            {
                lab1_num1 c = new lab1_num1(0, 1);
                if (a.Denominator == b.Denominator)
                {
                    c.Numerator = a.Numerator - b.Numerator;
                    c.Denominator = a.Denominator;
                }
                else
                {
                    c.Denominator = a.Denominator * b.Denominator;
                    c.Numerator = a.Numerator * (c.Denominator / a.Denominator) - b.Numerator * (c.Denominator / b.Denominator);
                }
                return c;
            }
            else
            {
                lab1_num1 c = new lab1_num1 (0, 0);
                Console.WriteLine("у одного или у обоих делитель равен 0!");
                return c;
            }
        }
        public static lab1_num1 operator*(lab1_num1 a,lab1_num1 b)
        {
            if (a.Denominator != 0 && b.Denominator != 0)
            {
                lab1_num1 c = new lab1_num1(0, 1);
                c.Numerator = a.Numerator * b.Numerator;
                c.Denominator = a.Denominator * b.Denominator;
                return c;
            }
            else {
                lab1_num1 c = new lab1_num1(0, 0);
                Console.WriteLine("у одного или у обоих делитель равен 0!");
                return c;
            }
        }
        public static lab1_num1 operator /(lab1_num1 a, lab1_num1 b)
        {
            if (a.Denominator != 0 && b.Denominator != 0)
            {
                lab1_num1 c = new lab1_num1(0, 1);
                c.Numerator = a.Numerator / b.Numerator;
                if (a.Denominator < b.Denominator)
                {
                    Console.WriteLine("2 delitel > 1, bydet nekkorektniy vivod");
                }
                c.Denominator = a.Denominator / b.Denominator;
                return c;
            }
            else
            {
                lab1_num1 c = new lab1_num1(0, 0);
                Console.WriteLine("у одного или у обоих делитель равен 0!");
                return c;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            lab1_num1 a = new lab1_num1(-5,10);
            lab1_num1 b = new lab1_num1(3, 640);
            lab1_num1 c = a / b;
            Console.WriteLine(c.ToString());
            Console.WriteLine(b>a);

        }
    }

}
