using Shared.Models;

namespace DBConnection.Repository.Interface;

public interface IDepartmentRepository
{
    public Task<Department> CreateDepartment(Department department);

    public Task<Department?> GetDepartment(string id);

    public Task<IEnumerable<Department>> GetDepartments();
}