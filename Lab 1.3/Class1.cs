using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._3
{
	internal class Class1
	{
		public double Task1(double x, double z)
		{
			return ((2*Math.Pow(x,2) + x - 5)/(x + 2))+(1.0/Math.Tan(x/(2*z)));
		}
		public void Task2()
		{
            for (int i = 200; i <= 300; i++)
            {
                for (int j = 200; j <= 300; j++)
                {
                    if (i != j && SumOfDividers(i) == SumOfDividers(j))
                        Console.WriteLine($"{i} - {j}");
                }
            }
        }
		private int SumOfDividers(int n)
		{
            var sum = 0;
            for (int i = 1; i < n / 2 + 1; i++)
            {
                if (n % i == 0) sum += i;
            }
            return sum;
        }

        public double Task3(double y)
		{
			return (1.7 * t(0.25) + 2 * t(1 + y)) / (6 - t(Math.Pow(y, 2) - 1));
		}

		private double t(double x)
		{
			double num1 = 0;
			double num2 = 0;
			int k = 0;
            while (k <= 10)
            {
                num1 += Math.Pow(x, 2 * k + 1) / Factorial(2 * k + 1);
                k++;
            }
            k = 0;
            while (k <= 10)
            {
                num2 += Math.Pow(x, 2 * k + 1) / Factorial(2*k);
                k++;
            }
            double res = num1 / num2;
            return res;

        }



        public int Factorial(int k)
		{
			int res = 1;
			while(k > 0)
			{
				res *= k;
				k--;
			}
			return res;
		}
	}
}
