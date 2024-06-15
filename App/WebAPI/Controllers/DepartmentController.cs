
using DBConnection.Logic.Interface;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace WebApi.Controllers;

[Route("departments")]
[ApiController] 
public class DepartmentController
{

    private readonly IConfiguration configuration;
    private readonly IDepartmentLogic departmentLogic;
    public DepartmentController(IConfiguration configuration, IDepartmentLogic departmentLogic)
    {
        this.configuration = configuration;
        this.departmentLogic = departmentLogic;
    }
    
    [HttpPost, Route("")]
    public async Task<ActionResult<Department>> CreateDepartment([FromBody]CreateDepartmentInput department)
    {
        var input = new Department
        {
            name = department.Name,
            description = department.Description
        };
        var dep = await departmentLogic.CreateDepartment(input);
        return dep;
    }

    [HttpGet, Route("")]
    public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
    {
        var deps = await departmentLogic.GetDepartments();
        return deps.ToList();
    }

    [HttpGet, Route("{id}")]
    public async Task<ActionResult<Department>> GetDepartment(string id)
    {
        var dep = await departmentLogic.GetDepartment(id);
        if (dep == null)
        {
            throw new Exception("Department not found");
        }
        return dep;
    }

    
}