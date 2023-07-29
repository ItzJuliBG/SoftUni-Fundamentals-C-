using System;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int singleDigit = int.Parse(Console.ReadLine());
            string product = MultiplyBigNumber(bigNumber, singleDigit);
            Console.WriteLine(product);
        }
        public static string MultiplyBigNumber(string bigNumber, int singleDigit)
        {
            int[] result = new int[bigNumber.Length + 1];
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = bigNumber[i] - '0';
                int temp = digit * singleDigit + result[i + 1];
                result[i + 1] = temp % 10;
                result[i] += temp / 10;
            }
            string product = string.Concat(Array.ConvertAll(result, x => x.ToString()));
            product = product.TrimStart('0');
            return string.IsNullOrEmpty(product) ? "0" : product;
        }
    }
}
