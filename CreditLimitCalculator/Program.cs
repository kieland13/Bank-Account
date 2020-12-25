using System;

namespace CreditLimitCalculator
{
   class Program
   {
      static void Main(string[] args)
      {
         int accntNumber;
         decimal begBalance;
         decimal totItems;
         decimal totCredits;
         decimal allowedCredit;

         Console.WriteLine("What is your account number? (type 0 to exit out)");

         accntNumber = Convert.ToInt32(Console.ReadLine());

         while (accntNumber != 0)
         {
            while (accntNumber < 10000000 || accntNumber > 99999999)
            {
               Console.WriteLine("Invalid Account Number, please re-enter it");
               accntNumber = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("What was your beggining balance for the month in your account?");
            begBalance = decimal.Parse(Console.ReadLine());

            while (begBalance < 0)
            {
               Console.WriteLine("Invalid balance, try again");
               begBalance = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("How much did you spend this month?");
            totItems = decimal.Parse(Console.ReadLine());

            while (totItems < 0)
            {
               Console.WriteLine("Invalid amount, try again");
               totItems = decimal.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("How much did you get credited to your account this month?");
            totCredits = decimal.Parse(Console.ReadLine());

            while (totCredits < 0)
            {
               Console.WriteLine("Invalid amount, try again");
               totCredits = decimal.Parse(Console.ReadLine());
            }
            
            allowedCredit = (begBalance - totItems) + totCredits;
            Console.WriteLine($"Your allowed spending balance is ${allowedCredit:F}");

            if (allowedCredit < 0)
            {
               Console.WriteLine("Credit limit exceeded");               
            }
                       
            Console.WriteLine("What is your account number? (type 0 to exit out)");

            accntNumber = Convert.ToInt32(Console.ReadLine());
         }         
      }
   }
}