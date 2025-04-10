namespace Payroll
{
    //Defining SalesPerson as a derived class of Employee (base class)
    class SalesPerson : Employee
    {
        //automatic property
        public double Sales { get; set; }

        public SalesPerson(int h, float r, double s) : base(h, r)
        {
            Sales = s;
        }

        //method overriding - defining a method in a derived class
        //with override keyword whose declaration matches with a
        //virtual method defined in the base class
        public override double Income()
        {
            double amount = base.Income();
            if(Sales >= 20000)
                amount += 0.05 * Sales;
            return amount;
        }
    }
}
