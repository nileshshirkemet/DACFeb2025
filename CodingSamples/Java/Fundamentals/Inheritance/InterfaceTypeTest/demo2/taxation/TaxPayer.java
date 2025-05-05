package taxation;

public interface TaxPayer {
    
    double annualIncome();

    //default interface method is an instance method of an interface
    //declared with default keyword, such a method provides a default
    //implementation which can be overridden by a class that inherits
    //from this interface
    default double incomeTax() {
        double income = annualIncome();
        return income > 200000 ? 0.15 * (income - 200000) : 0;
    }
}
