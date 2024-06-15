using Shared.Models;

namespace DBConnection.Logic.Interface;

public interface IDepartmentLogic
{
    public Task<Department> CreateDepartment(Department department);
}