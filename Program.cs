//Felipe Ruiz 
//Encapsulation Bank app
using System;
using System.Collections.Generic;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
           var account = new BankAccount();
            ////BankAccount account = new BankAccount();
            //Console.WriteLine("Amount to deposit");
            //var amountToDep = double.Parse(Console.ReadLine());
            //account.Deposit(amountToDep);
            //Console.WriteLine($"Thank you Your balance is now {account.GetBalance()}");
            var philsInfo = new PersonalInformation();

            Console.WriteLine("Enter your phone number include area code");
            philsInfo.NumberFormatted = Console.ReadLine();
            Console.WriteLine($"Your new phone number is {philsInfo.NumberFormatted}");
        }
    }
}
