import java.util.concurrent.CompletableFuture;
import java.util.stream.IntStream;

class Program {

    static class Computation {

        private long start;

        public long compute(int first, int last) {
            start = System.nanoTime();
            return IntStream.range(first, last + 1)
                .parallel() //split the stream based on number of processors/cores
                .mapToLong(Activity::perform)
                .sum();
        }

        public CompletableFuture<Long> computeAsync(int first, int last) {
            //schedule the supplied operation on a worker thread allowing
            //the calling thread to resume execution and obtain the result
            //of the operation in future when its execution is completed
            //by the worker thread
            return CompletableFuture.supplyAsync(() -> compute(first, last));
        }

        public double time() {
            long stop = System.nanoTime();
            return (stop - start) / 1e9;
        }
    }

    public static void main(String[] args) throws Exception {
        int n = Integer.parseInt(args[0]);
        System.out.print("Computing...");
        var c = new Computation();
        var job = c.computeAsync(1, n)
            .thenAccept(r ->  {
                System.out.println("Done!");
                System.out.printf("Result = %d, computed in %.3f seconds.%n", r, c.time());
            });
        while(!job.isDone()){
            System.out.print(".");
            Thread.sleep(500);
        }
    }
}
