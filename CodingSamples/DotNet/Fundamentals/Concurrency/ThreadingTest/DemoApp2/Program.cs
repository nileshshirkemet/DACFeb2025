namespace DemoApp;

class Program
{
    class JointAccount
    {
        public int Balance { get; private set; }

        public bool Debit(int amount)
        {
            bool success = false;
            //in order to continue a thread must acquire ownership of
            //monitor associated with 'this' object, if this monitor
            //is already owned by another thread it must wait until
            //it is released by the current owner
            Monitor.Enter(this);
            try
            {
                if(Balance >= amount)
                {
                    Balance = Activity.Perform(Balance, amount, -1);
                    success = true;
                }
            }
            finally
            {
                //release ownership of monitor associated with 'this' object
                Monitor.Exit(this); 
            }
            return success;
        }

        public void Credit(int amount)
        {
            lock(this)
            {
                Balance = Activity.Perform(Balance, amount, 1);
                //signal monitor associated with this object
                Monitor.Pulse(this); 
            }
        }

        public bool DebitAfterCredit(int amount)
        {
            lock(this)
            {
                //current thread releases ownership of monitor associated 
                //with this object, waits for this monitor to be signalled
                //by some other thread and then continues after reaquiring
                //the ownership of this monitor
                Monitor.Wait(this);
                return Debit(amount);
            }
        }
    }

    static void Main(string[] args)
    {
        JointAccount acc = new(); //new will be applied to type in declaration
        acc.Credit(10000);
        Console.WriteLine("Joint account opened for Jack and Jill");
        Console.WriteLine("Initial Balance = {0}", acc.Balance);
        Thread first = new Thread(() =>
        {
            Console.WriteLine("Jack debits 6000...");
            if(!acc.Debit(6000))
                Console.WriteLine("Jack's transaction failed!");
        });
        first.Start();
        Thread second = new Thread(() =>
        {
            Console.WriteLine("Jill debits 7000...");
            if(!acc.Debit(7000))
                Console.WriteLine("Jill's transaction failed!");
        });
        second.Start();
        first.Join(); //main thread waits for first thread to exit
        second.Join(); //main thread waits for second thread to exit
        Console.WriteLine("Final Balance = {0}", acc.Balance);
    }
}
