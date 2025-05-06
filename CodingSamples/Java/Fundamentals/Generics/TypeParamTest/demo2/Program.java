class Program {

    private static void printFormatted(SimpleStack<? extends Object> stack) {
        System.out.println("<items>");
        while(!stack.empty())
            System.out.printf("  <item>%s</item>%n", stack.pop());
        System.out.println("</items>");
    }

    public static void main(String[] args) {
        SimpleStack<String> a = new SimpleStack<String>();
        a.push("Monday");
        a.push("Tuesday");
        a.push("Wednesday");
        a.push("Thursday");
        a.push("Friday");
        //a.push(3.14);
        printFormatted(a);
        System.out.println("----------------------");
        SimpleStack<Interval> b = new SimpleStack<>();
        b.push(new Interval(4, 31));
        b.push(new Interval(3, 42));
        b.push(new Interval(5, 13));
        b.push(new Interval(6, 54));
        printFormatted(b);
    }
}