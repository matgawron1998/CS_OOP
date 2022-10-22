namespace Crucial_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee mateusz = new Employee("Mateusz", "Mate");
            mateusz.DisplayEmployee();

            Employee.AssignNewEmployee(mateusz.Id);

            Console.WriteLine($"Number of Employees: {Employee.EmployeeCounter}");
            Console.WriteLine($"New Employee: {Employee.NewEmployee}");

            Employee marek = new Employee("Marek", "Maro");
            marek.DisplayEmployee();

            Employee.AssignNewEmployee(marek.Id);

            Console.WriteLine($"Number of Employees: {Employee.EmployeeCounter}");
            Console.WriteLine($"New Employee: {Employee.NewEmployee}");
        }
    }
}