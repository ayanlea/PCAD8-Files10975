using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mortgage Calculator");
            Console.WriteLine();

            Console.Write("Enter home selling price: ");
            double homeSellingPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.Write("How much are you going to put down as down payment? ");
            
            double downPayment = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Enter home value ");
            double homeMarketValue = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine();
            Console.Write("Enter annual interest rate, 1 to 5: ");
            double loanRate = Convert.ToInt32(Console.ReadLine());
            loanRate = loanRate/100;// 4% == .004d;

            Console.WriteLine();
            Console.Write("Length of loan in years. Enter 15 or 30: ");
            int loanTermInYears = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Enter your annual income: ");
            double buyerIncome = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            double loanAmount = homeSellingPrice - downPayment;
            double homeEquity = (homeMarketValue - loanAmount) / loanAmount;

             
            double loanInsurance = (homeEquity < 10) ? (homeMarketValue * .01) : 0;
            loanInsurance = (loanInsurance > 0) ? (loanInsurance / 12 ) : 0;
            // Optional: 1 percent of the initial loan value per year
            // only if total equity at inception is less than 10 % of the current market value of the home

            double escrow_closingCost = 2500;
            double homeOwnersInsurance = (homeMarketValue * .0075) / 12; // Assume homeowners insurance is 0.75 percent of market value, yearly split into monthly payments,

            double propertyTaxes = (homeMarketValue * .011) / 12; // 1.1% of total home value by year, collected monthly
            double hoaFee = (homeMarketValue * .01) /12;

            double loanBasePayment = monthlyPayment(loanAmount, loanRate, loanTermInYears);

            double monthlyMortgage = loanInsurance 
                                    + homeOwnersInsurance 
                                    + loanBasePayment 
                                    + propertyTaxes
                                    + hoaFee;

            double affordability = (monthlyMortgage / (buyerIncome / 12))*100;


            double totalLoanAmount = escrow_closingCost
                                    + homeSellingPrice
                                    + loanAmount;


            if(affordability > 25)
            {
                LoanDecision("Denied", Math.Round(affordability, 2),Math.Round(monthlyMortgage,2));
            }
            else
            {
                LoanDecision("Approved", Math.Round(affordability, 2),Math.Round(monthlyMortgage,2));
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");

            #region Console log of initial calculated values
            Console.WriteLine($"hoaFee {hoaFee}"); 
            Console.WriteLine($"loanInsurance {loanInsurance}");
            Console.WriteLine($"loanRate {loanRate}"); 
            Console.WriteLine($"propertyTaxes {propertyTaxes}"); 
            Console.WriteLine($"homeOwnersInsurance {homeOwnersInsurance}");
            Console.WriteLine($"loanBasePayment {loanBasePayment}");
            Console.WriteLine("--------------------------------------------");


            Console.WriteLine($"loanTermInYears {loanTermInYears}");
            Console.WriteLine($"homeMarketValue {homeMarketValue}");
            Console.WriteLine($"homeSellingPrice {homeSellingPrice}");
            Console.WriteLine($"downPayment {downPayment}");
            Console.WriteLine($"buyerIncome {buyerIncome}");
            Console.WriteLine($"homeEquity {homeEquity}"); 
            #endregion
            Console.Read();



        }

        private static double monthlyPayment(double P, double r, double t)
       {
            double Payment;
            // Suppose you borrow $100,000 at 6% for 30 years, to be repaid monthly.
            // The monthly payment is $599.55.

            double i = r / 12;
            Payment = P * ((i * (Math.Pow((1 + i), 12.00 * t))) / (Math.Pow((1 + i), 12.00 * t)-1.00));
            return Payment;

       }

        private static void LoanDecision(string message, double affordability,double monthlymortgage)
        {
            Console.WriteLine("Loan decision:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("----------  "+message);
            Console.WriteLine("------------------------------");
            Console.WriteLine($"monthlyMortgage = ${monthlymortgage}");
            Console.WriteLine($"affordability = {affordability}%");
        }
    }
}