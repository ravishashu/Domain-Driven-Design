using Employees.Repositories;
using Employees.Models;

namespace Employees.Commands;

    public class EmployeeCommands : IEmployeeCommands
    {
        private readonly IEmployeeCommandsRepository _repository;
        public EmployeeCommands(IEmployeeCommandsRepository repository)
        {
            _repository = repository;
        }
        public void SaveEmployeeData(Employee employee)
        {
           _repository.SaveEmployee(employee);
        }
    }

