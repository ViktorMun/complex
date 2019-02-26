using System;

class Program
{
    static void Main()
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
}
