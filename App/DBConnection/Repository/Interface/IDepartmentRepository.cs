using Shared.Models;

namespace DBConnection.Repository.Interface;

public interface IDepartmentRepository
{
    public Task<Department> CreateDepartment(Department department);
}