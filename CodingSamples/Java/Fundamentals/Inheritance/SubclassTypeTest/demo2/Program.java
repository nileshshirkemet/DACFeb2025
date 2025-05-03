class Program {

    private static void print(String label, Object info) {
        System.out.printf("%s = %s%n", label, info.toString());
    }

    public static void main(String[] args) {
        Interval a = new Interval(6, 50);
        print("Interval a", a);
        Interval b = new Interval(4, 15);
        print("Interval b", b);
        print("Sum", a.add(b));
        Interval c = new Interval(5, 110);
        print("Interval c", c);
        Interval d = b;
        print("Interval d", d);
        System.out.println("------------------------------");
        System.out.printf("a is identical to b: %b%n", a == b);
        System.out.printf("a is identical to c: %b%n", a == c);
        System.out.printf("d is identical to b: %b%n", d == b);
        System.out.println("------------------------------");
        System.out.printf("a is equal to b: %b%n", a.hashCode() == b.hashCode() && a.equals(b));
        System.out.printf("a is equal to c: %b%n", a.hashCode() == c.hashCode() && a.equals(c));
        System.out.printf("d is equal to b: %b%n", d.hashCode() == b.hashCode() && d.equals(b));
        System.out.println("------------------------------");
        double e = 9.75;
        //auto-boxing is implicitly conversion of a value of primitive type
        //to an instance of the corresponding wrapper class containing a 
        //copy of that value in order to assign it to a reference of Object type
        print("double e", e); //print("double e", Double.valueOf(e))
    }     
}
