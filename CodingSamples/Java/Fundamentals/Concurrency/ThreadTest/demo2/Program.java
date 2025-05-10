class Program {

    static class JointAccount
    {
        private int balance;

        public int balance() {
            return balance;
        }

        public boolean debit(int amount) {
            boolean result = false;
            //to enter a synchronized statement block a thread must acquire
            //monitor associated with the specified object(this), if this
            //monitor is owned by some other thread then the current thread
            //will have to wait until the owner releases the monitor by
            //exiting the synchronized block
            synchronized(this){
                if(balance >= amount){
                    balance = Activity.perform(balance, amount, -1);
                    result = true;
                }
            }
            return result;
        }

        public synchronized void credit(int amount) {
            balance = Activity.perform(balance, amount, 1);
            this.notify(); //signal the monitor of this object
        }

        public synchronized boolean debitAfterCredit(int amount) throws InterruptedException {
            //release the monitor of 'this' object, wait until this monitor is
            //signalled by another thread and then resume execution after
            //reaquring this monitor
            this.wait();
            return debit(amount);
        }
    }

    public static void main(String[] args) throws Throwable {
        var acc = new JointAccount();
        acc.credit(10000);
        System.out.println("Joint account opened for Jack and Jill.");
        System.out.printf("Initial Balance: %d%n", acc.balance());
        Thread first = Thread.ofPlatform().start(() -> {
            System.out.println("Jack is withdrawing 6000...");
            if(acc.debit(6000) == false)
                System.out.println("Jack's transaction failed!");
        });
        Thread second = Thread.ofPlatform().start(() -> {
            System.out.println("Jill is withdrawing 7000...");
            if(acc.debit(7000) == false)
                System.out.println("Jill's transaction failed!");
        });
        first.join(); //wait for first to exit
        second.join();
        System.out.printf("Final Balance: %d%n", acc.balance());
    }
}
