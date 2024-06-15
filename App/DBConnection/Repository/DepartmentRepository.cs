using DBConnection.Context;
using DBConnection.Repository.Interface;
using Shared.Models;

namespace DBConnection.Repository;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly TabloidContext context;

    public DepartmentRepository(TabloidContext context)
    {
        this.context = context;
    }
    public async Task<Department> CreateDepartment(Department department)
    {
        var dep = await context.department.AddAsync(department);
        await context.SaveChangesAsync();
        return dep.Entity;
    }
}