using Employees.DTOs;
namespace Employees.Queries;

    public interface IEmployeeQueries
    {
        EmployeeDTO FindByID(int employeeID);
    }


