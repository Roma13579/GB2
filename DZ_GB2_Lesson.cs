using System;

namespace DZ_GB2_Lesson_1__1
{
    class Program
    {

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)         //O(N)
            {
                for (int j = 0; j < inputArray.Length; j++)     //O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++)     //O(2N)
                    {
                        int y = 0;

                        if (j != 0)
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y;       //O(1)
                    }
                }
            }

            return sum;     //O(1)
        }
        public static int FuncFib(int n)

        {
                if (n == 1 || n == 2)
                    return 1;
                return FuncFib(n - 1) + FuncFib(n - 2);
        }
        public static void FuncPaymentSimple(int n)
        {
            int d = 0;
            int i = 2;
            while ((i < n) && (n % i == 0))
            {
                d++;
                i++;
            }
            if (d == 0)
                Console.WriteLine("Простое");
            else Console.WriteLine("Не Простое");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите задание: ");
            string lesson = Console.ReadLine();
            switch (lesson)
            {
                case "1":
            Console.Write("Write n = ");
                    int n = int.Parse(Console.ReadLine());
                    FuncPaymentSimple(n);
                    break;
                case "2":

                    Console.WriteLine("Введите порядковый номер числа:");
                    int x = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Числа Фибоначчи:{FuncFib(x)}");
                    break;
                case "3":
                    Console.WriteLine("Введите число :");
                    int position = Convert.ToInt32(Console.ReadLine());
                    int f1, f2;
                    f1 = 0; f2 = 1;
                    int fsum = 0;
                    if (position == 1) fsum = f1;
                    else if (position == 2) fsum = f2;
                    for (int i = 2; i < position; i++)
                    {
                        fsum = f1 + f2;
                        f1 = f2;
                        f2 = fsum;
                    }
                    Console.WriteLine(fsum);
                    Console.ReadLine();
                    break;
            }
        }
    }
}
