package payroll;

//define SalesPerson as a subclass of Employee (super-class)
public class SalesPerson extends Employee {
    
    private double sales;

    public SalesPerson(int h, float r, double s) {
        super(h, r);
        sales = s;
    }

    public double getSales() {
        return sales;
    }

    public void setSales(double value) {
        sales = value;
    }

    //method overriding - defining method in subclass whose declaration
    //matches with the declaration of same method in super-class
    public double income() {
        double amount = super.income();
        if(sales >= 25000)
            amount += 0.05 * sales;
        return amount;
    }
}
