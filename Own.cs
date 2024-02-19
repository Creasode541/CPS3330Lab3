using System.Numerics;

namespace MyOwnLib;
    public class Own
    {
        public BigInteger MyPow(int baseNumber, int exponent)
        {
            BigInteger result = BigInteger.Pow(baseNumber, exponent);
            return result;
        }

        public BigInteger MyPow(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Please provide at least one number.");

            BigInteger result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result = BigInteger.Pow(result, numbers[i]);
            }
            return result;
        }
    }

