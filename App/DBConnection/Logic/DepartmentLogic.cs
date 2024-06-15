using DBConnection.Logic.Interface;
using DBConnection.Repository.Interface;
using Shared.Models;

namespace DBConnection.Logic;

public class DepartmentLogic : IDepartmentLogic
{
    private IDepartmentRepository repository;

    public DepartmentLogic(IDepartmentRepository repository)
    {
        this.repository = repository;
    }
    public async Task<Department> CreateDepartment(Department department)
    {
        return await repository.CreateDepartment(department);
    }
}