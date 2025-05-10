class Program {

    private static ThreadLocal<String> manager = new ThreadLocal<>();

    private static void handleJob(int jobid) {
        System.out.printf("Thread<%x> has accepted job<%d> for %s%n", Thread.currentThread().hashCode(), jobid, manager.get());
        Activity.perform(jobid);
        System.out.printf("Thread<%x> has finished job<%d> for %s%n", Thread.currentThread().hashCode(), jobid, manager.get());
    }

    public static void main(String[] args) throws Throwable {
        int n = args.length > 0 ? Integer.parseInt(args[0]) : 1;
        Thread child = new Thread(() -> {
            manager.set("Jack");
            handleJob(n);
        });
        if((n % 2) == 1)
            child.setDaemon(true); //making child a back-ground thread
        child.start();
        manager.set("Jill");
        handleJob(2);
    }
}
