using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master
{
    struct Complex
    {
        public double im;
        public double re;
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 4;
            complex1.im = 2;

            Complex complex2;
            complex2.re = 8;
            complex2.im = 4;

            Complex result = complex1.Plus(complex2);
            Complex result2 = complex1.Minus(complex2);
            Complex result3 = complex1.Multi(complex2);

            Console.WriteLine(result.ToString());
            Console.WriteLine(result2.ToString());
            Console.WriteLine(result3.ToString());
            Console.ReadLine();
        }
    }

}
