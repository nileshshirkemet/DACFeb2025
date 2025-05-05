class Program {

    private static Object select(int index, Object first, Object second) {
        if((index % 2) == 1)
            return first;
        return second;
    }

    public static void main(String[] args) {
        if(args.length > 0){
            int s = Integer.parseInt(args[0]);
            String ss = (String)select(s, "Monday", "Tuesday");
            System.out.printf("Selected string = %s%n", ss);
            double sd = (double)select(s, 45.6, 32.1);
            System.out.printf("Selected double = %s%n", sd);
            select(s, "Wednesday", 54.3);
        }
    }
}