using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaperSlip
{
    class Day5Quiz
    {
        static int[] minIncomeArray = new int[] { 20000, 30000, 40000, 80000, 120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[] { 0.02,0.035,0.07,0.115,0.15,0.17,0.18,0.20};
        static int[] basePayableAmountArray = new int[] { 0,200,550,3350,7950,13950,20750,42350};

        public static void Main()
        {
           int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        public static int AskForIncome()
        {
            Console.Write("Please enter your annual taxable income:");
            int _income = Convert.ToInt32(Console.ReadLine());

            return _income;
        }

        public static int GetTaxBracket(int income)
        {
            int index = 0;
            if(income < 20000)
            {
                index = -1;
            }
            else
            {
                for (int i = 0; i < minIncomeArray.Length; i++)
                {
                    switch(i)
                    {
                        case 0:
                        case 1:
                                if ((minIncomeArray[i] + 10000) > income)
                                {
                                    index = i;
                                }
                                break;
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            if ((minIncomeArray[i] + 40000) > income)
                            {
                                index = i;
                            }
                            break;
                        case 6:
                            if ((minIncomeArray[i] + 120000) > income)
                            {
                                index = i;
                            }
                            break;
                        case 7:
                            if (income > minIncomeArray[i])
                            {
                                index = i;
                            }
                            break;
                    }
                }
            }

            return index;
        }
        //if(i<= 1)
        //{
        //    if ((minIncomeArray[i]+10000) > income)
        //    {
        //        index = i;
        //        break;
        //    }
        //}
        //else if(i>1 && i<=5)
        //{
        //    if ((minIncomeArray[i] + 40000) > income)
        //    {
        //        index = i;
        //        break;
        //    }
        //}
        //else if(i>5 && i<=6)
        //{
        //    if ((minIncomeArray[i] + 120000) > income)
        //    {
        //        index = i;
        //        break;
        //    }

        //}
        //else if(i==7)
        //{
        //    if( income >= minIncomeArray[i])
        //    {
        //        index = i;
        //        break;
        //    }
        //}


        public static double CalculateIncomeTax(int income,int taxBracket)
        {
            double taxPayable = 0;
            if(taxBracket == -1)
            {
                taxPayable = 0;
            }
            else
            {
                int miniIncome = minIncomeArray[taxBracket];
                double taxRate = taxRateArray[taxBracket];
                int basePayableAmount = basePayableAmountArray[taxBracket];

                taxPayable = (income - miniIncome) * taxRate + basePayableAmount;
            }
            return taxPayable;
        }

        public static void PrintResult(int annualIncome,double payableTax)
        {
            Console.Write($"For taxable annaul income of ${annualIncome:###,##0.00}, the tax payable amount is ${payableTax:###,##0.00}");
            
        }
    }
}
