﻿using Banking;

Account jill = Banker.OpenSavingsAccount();
jill.Deposit(15000);
Account jack = Banker.OpenCurrentAccount();
jack.Deposit(30000);
Account john = Banker.OpenSavingsAccount();
john.Deposit(35000);
Console.WriteLine("Jill's Account ID is {0} and Initial Balance is {1:0.00}", jill.Id, jill.Balance);
Console.WriteLine("Jack's Account ID is {0} and Initial Balance is {1:0.00}", jack.Id, jack.Balance);
Console.WriteLine("John's Account ID is {0} and Initial Balance is {1:0.00}", john.Id, john.Balance);
if(args.Length > 0)
{
    try
    {
        decimal payment = decimal.Parse(args[0]);
        Console.WriteLine("Jill is paying {0} to Jack...", payment);
        jill.Transfer(payment, jack); //Banker.Transfer(jill, payment, jack);
        Console.WriteLine("Payment succeeded."); 
    }
    catch(InsufficientFundsException)
    {
        Console.WriteLine("Payment failed due to lack of funds!");
        jill.Freeze();
    }
    catch(Exception ex)
    {
        Console.WriteLine("Error: {0}", ex.Message);
    }
}
else
{
    Console.WriteLine("Paying annual interest...");
    //PayInterest(4, new Account[]{jill, jack, john});
    PayInterest(4, jill, jack, john);
}
Console.WriteLine("Jill's Final Balance: {0:0.00}", jill.Balance);
Console.WriteLine("Jack's Final Balance: {0:0.00}", jack.Balance);
Console.WriteLine("John's Final Balance: {0:0.00}", john.Balance);