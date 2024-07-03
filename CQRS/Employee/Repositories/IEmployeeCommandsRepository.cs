using Employees.Models;
namespace Employees.Repositories;

    public interface IEmployeeCommandsRepository
    {
        void SaveEmployee(Employee employee);
    }

