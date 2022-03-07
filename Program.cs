using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");

            int n = int.Parse(Console.ReadLine());
                int[] arrayInitial = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arrayInitial[i] = i;
                }

            Console.WriteLine("Введите число подмассивов: ");

            int k = int.Parse(Console.ReadLine());

            int[][] arraySubarrays = new int[k][];
            int lenIncr = n % k;
            int len = n / k;
            if (lenIncr > 0)
            {
                len++;
            }
            int arrIter = 0;

            Console.WriteLine("Подмассивы:");

            for (int i = 0; i < k; i++)
            {
                if (i == lenIncr)
                    len--;
                arraySubarrays[i] = new int[len];
                Array.Copy(arrayInitial, arrIter, arraySubarrays[i], 0, len);
                arrIter += len;
                for (int j = 0; j < arraySubarrays[i].Length; j++)
                {
                    Console.Write(arraySubarrays[i][j].ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
