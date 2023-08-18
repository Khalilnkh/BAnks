using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class UniBank : Cards
    {
        public UniBank(string name, string surname, int cardNumber, decimal balance, int cvv) : base(name, surname, cardNumber, balance, cvv)
        {

        }

        public override void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;

            }
            else
            {
                Console.WriteLine("Mebleg 0 dan az olmamalidir");


            }


        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                amount = (amount * (100 + 1.5m) / 100);
                Balance -= amount;



            }
            else
            {
                Console.WriteLine("Balansda yeterli mebleg yoxdur ve ya daxil etdiyiniz reqem duzgun deyil");

            }

        }

    }
}
