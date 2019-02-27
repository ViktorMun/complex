using System;

/*class Program
{
    private static void Main()
    {

        {
            int x;
            int y = 0;
            string s;
            bool flag = false;
            do
            {
                Console.WriteLine("Введите число:");
                s = Console.ReadLine();
                int.TryParse(s, out x);
                if (x > 0 && x % 2 != 0) { y += x; }
                else if (x == 0) { flag = true; }
            }
            while (!flag);


            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}*/

/// <summary>
/// 3.	*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
//* Добавить свойства типа int для доступа к числителю и знаменателю;
//* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//*** Добавить упрощение дробей.
/// </summary>
class DopZadacha
{
    static void Main()
    {
        Complex a = new Complex(3, 5);
        Complex b = new Complex (2, 5);

        Console.WriteLine((a.Plus(b)).ToString());
        Console.WriteLine((a.Minus(b)).ToString());
        Console.WriteLine((a.Multi(b)).ToString());
        Console.ReadKey();
    }
}

internal class Complex
{
    public double x;
    public double y;

    public Complex(int a, int b)
    {
        this.x = a;
        this.y = b;
    }
    public Complex Plus(Complex a)
    {
        Complex res = new Complex(0, 0);
        if (y == 0 || a.y == 0)
        {
            throw new ArgumentException(String.Format("Знаменатель не может быть равен 0"));
        }
        else if (y == a.y)
        {
            res.x = x + a.x;
            res.y = y;
        }
        else
        {
            res.x = x * a.y + a.x * y;
            res.y = y * a.y;
        }

           return res;
    }

    public Complex Minus(Complex a)
    {
        Complex res = new Complex(0, 0);
        if (y == 0 || a.y == 0)
        {
            throw new ArgumentException(String.Format("Знаменатель не может быть равен 0"));
        }
        else if (y == a.y)
        {
            res.x = x - a.x;
            res.y = y;
        }
        else
        {
            res.x = x * a.y - a.x * y;
            res.y = y * a.y;
        }

        return res;
    }

    public Complex Multi(Complex a)
    {
        Complex res = new Complex(0, 0);
        if (y == 0 || a.y == 0)
        {
            throw new ArgumentException(String.Format("Знаменатель не может быть равен 0"));
        }
        else 
        {
            res.x = x *a.x;
            res.y = y*a.y;
        }
      
        return res;
    }
    public override string ToString()
    {
        return x.ToString() + "/" + y.ToString();
    }

}