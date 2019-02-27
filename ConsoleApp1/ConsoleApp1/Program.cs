using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master
{
    class Complex
    {
        public double im;
        public double re;
      
        public Complex(int x, int y)
        {
            this.im = x;
            this.re = y;
        }
       
        public Complex Plus(Complex x)
        {
            Complex y=new Complex(0,0);
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y = new Complex(0, 0);
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public Complex Multi (Complex x)
        {
            Complex y = new Complex(0, 0);
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
            Complex complex1=new Complex(4,2);
            Complex complex2 = new Complex(8,4) ;
           
          string method = "Plus";
            Complex result = new Complex(0, 0);
                switch (method)
            {
                case "Plus":
                 result=  complex1.Plus(complex2);
                    break;
                case "Minus":
                  result=  complex1.Minus(complex2);
                    break;
                case "Multi":
                  result=  complex1.Multi(complex2);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }


            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        public static void ComplexChoose(String method)
        {

          
        }
    }

}
