#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        public void run()
        {
			double fee = CalculateFee(theDailyRate: 375.0);
			Console.WriteLine("Fee is {0}", fee);
        }

		private double CalculateFee(double theDailyRate = 500.0, int noOfDays = 5)
		{
			Console.WriteLine("calculateFee using two optional parameters");
			return theDailyRate * noOfDays;
		}
		private double CalculateFee(double dailyRate = 500.0)
		{
			Console.WriteLine("calculateFee using one optional parameter");
			int defaultnoOfDays = 1;
			return dailyRate * defaultnoOfDays;
		}
		private double CalculateFee()
		{
			Console.WriteLine("calculateFee using hardcoded values");
			double defaultDailyRate = 400.0;
			int defaultNoOfDays = 1;
			return defaultDailyRate * defaultNoOfDays;
		}

	}
}
