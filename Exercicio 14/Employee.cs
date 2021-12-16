namespace Exercicio_14
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void SalaryIncrease(double percentage)
        {
            Salary += ((percentage * Salary) / 100);
        }

        public override string ToString()
        {
            return Id +
                ", " + 
                Name +
                ", " +
                Salary.ToString("F2");
        }
    }
}
