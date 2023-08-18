using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public abstract class Cards
    {
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public int CardNumbers { get; protected set; }
        public int CVV { get; protected set; }
        public decimal Balance { get; protected set; }
        public Cards(string name, string surname, int cardNumbers, decimal balance, int cvv)
        {
            Name = name;
            Surname = surname;
            CardNumbers = cardNumbers;
            Balance = balance;
        }

        public virtual void Deposit(decimal amount)
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
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Pul mexaric olundu");
            }
            else
            {
                Console.WriteLine("Balansda yeterli mebleg yoxdur ve ya daxil etdiyiniz reqem duzgun deyil");
            }
        }




    }
}
