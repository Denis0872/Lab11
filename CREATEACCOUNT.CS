
using System;
using System.Collections;
using Banking;

// Test harness
class CreateAccount
{
	static void Main()
	{
		long accNo1 = Bank.CreateAccount(AccountType.Checking,
		100);
		long accNo2 = Bank.CreateAccount(AccountType.Checking,
		100);
		BankAccount acc1 = Bank.GetAccount(accNo1);
		acc1.Dispose();
		BankAccount acc2 = Bank.GetAccount(accNo2);
		acc2.Dispose();
		if (acc1.Equals(acc2))
		{
			Console.WriteLine("ќба счЄта одинаковы");
		}
		else
		{
			Console.WriteLine("—чета разные");
			if (!acc1.Equals(acc2))
			{
				Console.WriteLine("—чета разные");
			}
			else
			{
				Console.WriteLine("—чета одинаковые");
			}
			
			BankAccount acc3 = Bank.GetAccount(accNo1);
			if (acc1.Equals (acc3))
			{
				Console.WriteLine("—чета одинаковые");
			}
			else
			{
				Console.WriteLine("—чета разные");
			}

			if (!acc1.Equals (acc3))
			{
				Console.WriteLine("—чета разные");
			}
			else
			{
				Console.WriteLine("—чета одинаковые");
			}
			Console.WriteLine("acc1 Ц {0}", acc1);
			Console.WriteLine("acc2 Ц {0}", acc2);
			Console.WriteLine("acc3 Ц {0}", acc3);

			
			Console.ReadKey();
		}

		void Write(BankAccount acc)
		{
			Console.WriteLine("Account number is {0}", acc.Number());
			Console.WriteLine("Account balance is {0}", acc.Balance());
			Console.WriteLine("Account type is {0}", acc.Type());

			Console.WriteLine("Transactions");
			Queue tranQueue = acc.Transactions();
			foreach (BankTransaction tran in tranQueue)
			{
				Console.WriteLine("Date: {0}\tAmount: {1}", tran.When(), tran.Amount());
			}

		}
	}
}
