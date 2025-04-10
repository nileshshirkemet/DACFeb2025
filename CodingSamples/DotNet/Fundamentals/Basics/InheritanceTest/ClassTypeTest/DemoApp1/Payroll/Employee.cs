//a namespace groups together related types
//to avoid collisions between their names
//and names of type not belonging to their
//group, outside of a namespace a type is identified 
//by its qualified name (Payroll.Employee)
namespace Payroll
{
    class Employee
    {
        private int hours;
        private float rate;

        //parameterized constructor
        public Employee(int h, float r)
        {
            hours = h;
            rate = r;
        }

        //parameterless constructor
        public Employee() : this(0, 50)
        {
        }

        //property - it is a member which provides method for getting/setting
        //the value of a field using field-like syntax
        public int Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        public float Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        //an instance method declared with virtual keyword
        //can be overridden in the derived class
        public virtual double Income()
        {
            double amount = hours * rate;
            int ot = hours - 180;
            if(ot > 0)
                amount += 50 * ot;
            return amount;
        }
    }
}
