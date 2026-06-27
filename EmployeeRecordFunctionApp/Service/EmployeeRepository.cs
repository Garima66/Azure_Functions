using EmployeeRecordFunctionApp.Model;
namespace EmployeeRecordFunctionApp.Service
{
    public static class EmployeeRepository
    {
        public static List<Employee> Employees = new()
        {
            new Employee()
            {
                EmployeeId = 1,
                EmployeeName="John",
                Department="SalITary",
                Salary=500000
            }
        };
    }
}
