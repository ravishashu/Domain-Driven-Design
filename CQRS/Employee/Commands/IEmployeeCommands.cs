using Employees.Models;

namespace Employees.Commands;

    public interface IEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);
    }

