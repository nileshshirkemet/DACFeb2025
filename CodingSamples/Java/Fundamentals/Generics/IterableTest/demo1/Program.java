class Program {

    public static void main(String[] args) {
        SimpleStack<String> a = new SimpleStack<String>();
        a.push("Monday");
        a.push("Tuesday");
        a.push("Wednesday");
        a.push("Thursday");
        a.push("Friday");
        for(var i = a.iterator(); i.hasNext();)
            System.out.println(i.next());
        System.out.println("------------------------");
        while(!a.empty())
            System.out.println(a.pop());
        System.out.println("------------------------");
        SimpleStack<Double> b = new SimpleStack<>();
        b.push(23.41);
        b.push(56.92);
        b.push(18.23);
        b.push(45.64);
        for(double d : b)
            System.out.println(d);
    }
}