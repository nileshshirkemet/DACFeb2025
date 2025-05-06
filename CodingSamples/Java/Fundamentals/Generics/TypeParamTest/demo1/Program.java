class Program {

    private static <T> T select(int index, T first, T second) {
        if((index % 2) == 1)
            return first;
        return second;
    }

    private static <T extends Comparable<T>> T select(T first, T second) {
        if(first.compareTo(second) > 0)
            return first;
        return second;
    }

    public static void main(String[] args) {
        if(args.length > 0){
            int s = Integer.parseInt(args[0]);
            String ss = select(s, "Monday", "Tuesday");
            System.out.printf("Selected string = %s%n", ss);
            double sd = select(s, 45.6, 32.1);
            System.out.printf("Selected double = %s%n", sd);
        }else{
            String ss = select("Monday", "Tuesday");
            System.out.printf("Selected string = %s%n", ss);
            double sd = select(45.6, 32.1);
            System.out.printf("Selected double = %s%n", sd);          
            Interval si = select(new Interval(4, 30), new Interval(3, 20));
            System.out.printf("Selected Interval = %s%n", si);
        }
    }
}