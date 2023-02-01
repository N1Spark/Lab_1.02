using System;

namespace Lab_1._02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Зад 1
            Console.WriteLine("It's easy to win forgiveness for being wrong; \nbeing right is what gets you into real trouble.\nBjarne Stroustrup\n");
            #endregion

            #region Зад 2
            int[] number = new int[5];
            int sum = 0, multi = 1, min = number[0], max = number[0];
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Write num {i + 1}: ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < number.Length; i++)
            {
                sum += number[i];
                multi *= number[i];
                if(min > number[i])
                {
                    min = number[i];
                }
                if (max < number[i])
                {
                    max = number[i];
                }
            }
            Console.WriteLine($"Sum: {sum}\nMulti: {multi}\nMin: {min}\nMax: {max}\n");

            #endregion

            #region Зад 3

            Console.Write($"Write number: \n");
            string buf = Console.ReadLine();
            Console.Write("Reverse: ");
            for (int i = buf.Length - 1; i >= 0; i--)
            {
                Console.Write($"{buf[i]}");
            }
            Console.WriteLine("\n");

            #endregion

            #region Зад 4

            int n = 0, n1 = 1;
            Console.Write("Lim: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{n} {n1} ");
            int t;
            while (true)
            {
                if (n + n1 > limit)
                    break;
                t = n1;
                n1 = n + n1;
                n = t;
                Console.Write($"{n1} ");
            }
            Console.WriteLine("\n");

            #endregion

            #region Зад 5

            Console.Write("Min: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max: ");
            int B = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < B - A + 1; i++)
            {
                for (int j = 0; j < A + i; j++)
                    Console.Write($"{A + i}");
                Console.WriteLine();
            }

            #endregion

            #region

            Console.WriteLine("\n1 - Вертикально, 2 - Горизонтально");
            int type = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nСимвол: ");
            string buf_char = Console.ReadLine();
            Console.Write("Кол-во: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                if (type == 1)
                {
                    Console.WriteLine($"{buf_char}");
                }
                else
                {
                    Console.Write($"{buf_char}");
                }
            }
            Console.WriteLine();

            #endregion
        }
    }
}
