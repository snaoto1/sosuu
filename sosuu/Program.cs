using System;

namespace sosuu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int number = int.Parse(Console.ReadLine());
            //1と0は素数ではない
            if (number == 0 || number == 1)
            {
                Console.WriteLine(number + "は素数ではありません。");
            }
            //偶数を排除するために2を排除
            else if (number == 2)
            {
                Console.WriteLine(number + "は素数です。");
            }
            else
            {
                int result = program.sosuu(number);
                if (result == 0)
                {
                    Console.WriteLine(number + "は素数です。");
                }
                else
                {
                    Console.WriteLine(number + "は" + result + "で割り切れます。");
                }
            }
        }
        public int sosuu(int a)
        {
            //偶数排除
            if (a % 2 == 0)
            {
                return 2;
            }
            for (int i = 3; i < a / 2; i = i + 2)
            {
                if (a % i == 0)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
