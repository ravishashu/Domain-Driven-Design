using Employees.Models;
namespace Employees.Repositories;

    public interface IEmployeeQueriesRepository
    {
        Employee GetByID(int employeeID);
    }

