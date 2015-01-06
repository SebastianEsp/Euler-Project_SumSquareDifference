using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Square_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many natural numbers do you wish to use?\n");
            string value = Console.ReadLine();
            int valueInt = int.Parse(value);
            double finalSum = SumOfSquares(valueInt);
            double finalSquare = SquareOfSums(valueInt);
            Difference(finalSum, finalSquare);
            Console.ReadLine();
        }

        public static double SumOfSquares(int number)
        {
            double[] sumOfSquaresArr = new double[number + 1];

            for (int i = 1; i <= number; i++)
            {
                double sum = i * i;
                sumOfSquaresArr[i] = sum;
            }

            double finalSum = sumOfSquaresArr.Sum();
            Console.WriteLine("\nThe final sum of the squares is: {0}", finalSum);

            return finalSum;
        }

        public static double SquareOfSums(int number)
        {
            double[] squareOfSumsArr = new double[number + 1];

            for (int i = 1; i <= number; i++)
            {
                squareOfSumsArr[i] = i;
            }

            double finalSquare = squareOfSumsArr.Sum() * squareOfSumsArr.Sum();
            Console.WriteLine("The final square of sums is: {0}", finalSquare);

            return finalSquare;
        }

        public static void Difference(double sum, double square)
        {
            double diff = square - sum;

            Console.WriteLine("The difference is {0}", diff);
        }
    }
}
