using DBConnection.Context;
using DBConnection.Repository.Interface;
using Microsoft.EntityFrameworkCore;
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

    public Task<Department?> GetDepartment(string id)
    {
        return context.department.FirstOrDefaultAsync(d => d.id == id);
    }

    public async Task<IEnumerable<Department>> GetDepartments()
    {
        return await context.department.ToListAsync();
    }
}