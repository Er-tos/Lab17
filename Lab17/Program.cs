using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моделирование счёта в банке");
            BankAccount<int> account1 = new BankAccount<int>();
            Console.WriteLine("Создадим первый счет, состоящий из цифр. Введите номер первого счета.");
            int account1Number = Convert.ToInt32(Console.ReadLine());
            account1.SetAccountNumber(account1Number);
            Console.WriteLine("Введите баланс первого счета.");
            int account1Balance = Convert.ToInt32(Console.ReadLine());
            account1.SetAccountBalance(account1Balance);
            Console.WriteLine("Введите ФИО владельца первого счета.");
            string account1OwnerName = Console.ReadLine();
            account1.SetOwnerName(account1OwnerName);
            Console.WriteLine("Создадим второй счет, состоящий из символов. Введите номер второго счета.");
            BankAccount<string> account2 = new BankAccount<string>();
            string account2Number = Console.ReadLine();
            account2.SetAccountNumber(account2Number);
            Console.WriteLine("Введите баланс второго счета.");
            int account2Balance = Convert.ToInt32(Console.ReadLine());
            account2.SetAccountBalance(account2Balance);
            Console.WriteLine("Введите ФИО владельца второго счета.");
            string account2OwnerName = Console.ReadLine();
            account2.SetOwnerName(account2OwnerName);
            Console.WriteLine("Первый счет - номер: {0}, баланс: {1}, ФИО владельца: {2}.", account1.GetAccountNumber(), account1.GetAccountBalance(), account1.GetOwnerName());
            Console.Write("Второй счет - номер: {0}, баланс: {1}, ФИО владельца: {2}.", account2.GetAccountNumber(), account2.GetAccountBalance(), account2.GetOwnerName());
            Console.ReadKey();
        }
        class BankAccount<T>
        {
            static T accountNumber;
            static int accountBalance;
            static string ownerName;
            public void SetAccountNumber(T value)
            {
                accountNumber = value;
            }
            public T GetAccountNumber()
            {
                return accountNumber;
            }
            public void SetAccountBalance(int value)
            {
                accountBalance = value;
            }
            public int GetAccountBalance()
            {
                return accountBalance;
            }
            public void SetOwnerName(string value)
            {
                ownerName = value;
            }
            public string GetOwnerName()
            {
                return ownerName;
            }
        }
    }
}
