namespace t2009a_lab
{
    public class Employee
    {
        private string fistName;
        private string lastName;
        private string address;
        private long sin;
        private double salary;

        public Employee(string fistName, string lastName, string address, long sin, double salary)
        {
            this.fistName = fistName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"FistName:{fistName}, Last Name:{lastName}, Address:{address}, Sin:{sin}, Salary:{salary}";
        }

        public double CalculateTheBonus(double percentage)
        {
            return salary * percentage;
        }
        
        public string FistName
        {
            get => fistName;
            set => fistName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public long Sin
        {
            get => sin;
            set => sin = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }
    }
}