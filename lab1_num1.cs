using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public lab1_num1(int a1, int a2)
        {
            Numerator = a1;
            if (a2 == 0)
            {
                throw new ArgumentException("знаменатель не может быть равен нулю!", nameof(a2));
            }
            Denominator = a2;
        }
        private void socrat()
        {
            int max;
            if (Math.Abs(Numerator) < Math.Abs(Denominator))
            {
                if (Numerator < 0)
                {
                    max = -Numerator;
                }
                else { max = Numerator; }
            }
            else
            {
                if (Denominator < 0) { max = Denominator; }
                else
                {
                    max = Denominator;
                }

            }
            int i = 2;
            while (i <= max)
            {
                if (Numerator % i == 0 && Denominator % i == 0)
                {
                    Numerator = Numerator / i;
                    Denominator = Denominator / i;
                    i = 2;
                    continue;
                }
                i++;
            }

        }
        public override string ToString()
        {
            socrat();
            if (Numerator == 0)
            {
                return "0";
            }
            else if (Denominator == 1)
            {
                return Numerator.ToString();
            }
            else if (Numerator % Denominator == 0)
            {
                return Numerator.ToString();
            }
            else if (Denominator % Numerator == 0)
            {
                return (Numerator / Numerator).ToString() + "/" + (Denominator / Numerator).ToString();
            }
            string s = Numerator.ToString() + "/" + Denominator.ToString();
            return s;
        }
        public static lab1_num1 operator -(lab1_num1 a)
        {
                a.denominator = -a.Denominator;
                return a;
           
      
        }
        public static bool operator ==(lab1_num1 a, lab1_num1 b)
        {
                if (a.ToString() == b.ToString() )
                {
                    return true;
                }
                else { return false; }
        }
        public static bool operator !=(lab1_num1 a, lab1_num1 b)
        {
            if (a.Denominator != 0 && b.Denominator != 0)
            {
                if (a.ToString() != b.ToString())
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }
        public static bool operator >(lab1_num1 a, lab1_num1 b)
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
        public static lab1_num1 operator +(lab1_num1 a, lab1_num1 b)
        {
                lab1_num1 c = new lab1_num1(0, 1);
                c.Numerator = a.Numerator * b.Denominator + a.Denominator * b.Numerator;
                c.Denominator = a.Denominator * b.Denominator;
            return c;
                //if (a.Denominator == b.Denominator)
                //{
                //    c.Numerator = a.Numerator + b.Numerator;
                //    c.Denominator = a.Denominator;
                //    return c;
                //}
                //else if (a.Denominator > b.Denominator)
                //{
                //    if (a.Denominator % b.Denominator == 0)
                //    {
                //        c.Numerator = a.Numerator + (b.Numerator * (a.Denominator / b.Denominator));
                //        c.Denominator = a.Denominator;
                //        return c;
                //    }
                //    else
                //    {
                //        c.Numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
                //        c.Denominator = a.Denominator * b.Denominator;
                //        return c;
                //    }
                //}
                //else
                //{
                //    if (b.Denominator % a.Denominator == 0)
                //    {
                //        c.Numerator = b.Numerator + (a.Numerator * (b.Denominator / a.Denominator));
                //        c.Denominator = b.Denominator;
                //        return c;
                //    }
                //    else
                //    {
                //        c.Numerator = b.Numerator * a.Denominator + a.Numerator * b.Denominator;
                //        c.Denominator = b.Denominator * a.Denominator;
                //        return c;
                //    }
                //}
        }
        public static lab1_num1 operator +(lab1_num1 a, int b)
        {
            lab1_num1 c = new lab1_num1(0, 1);
            c.Numerator = a.Numerator + a.Denominator * b;
            c.Denominator = a.Denominator;
            return c;
        }
        public static lab1_num1 operator -(lab1_num1 a, lab1_num1 b)
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
        public static lab1_num1 operator -(lab1_num1 a, int b)
        {
                
                lab1_num1 c = new lab1_num1(0, 1);
                c.Numerator = a.Numerator - b * a.Denominator;
                c.Denominator = a.Denominator;
                return c;    
 

        }
        public static lab1_num1 operator *(lab1_num1 a, lab1_num1 b)
        {
      

                lab1_num1 c = new lab1_num1(0, 1);
                c.Numerator = a.Numerator * b.Numerator;
                c.Denominator = a.Denominator * b.Denominator;
                return c;


        }
        public static lab1_num1 operator *(lab1_num1 a, int b)
        {


            lab1_num1 c = new lab1_num1(0, 1);
            c.Numerator = a.Numerator * b;
            c.Denominator = a.Denominator ;
            return c;


        }
        public static lab1_num1 operator /(lab1_num1 a, lab1_num1 b)
        {
                lab1_num1 c = new lab1_num1(0, 1);
                c.Numerator = a.Numerator * b.Denominator;
                c.Denominator = a.Denominator * b.Numerator;
                return c;

        }
        public static lab1_num1 operator /(lab1_num1 a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("знаменатель не может быть равен нулю!",nameof(b));
            }
            lab1_num1 c = new lab1_num1(0, 1);
            c.Numerator = a.Numerator;
            c.Denominator = a.Denominator * b;
            return c;

        }
    }
}
