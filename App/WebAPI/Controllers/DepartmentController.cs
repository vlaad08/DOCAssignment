using DBConnection.Logic.Interface;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace WebApi.Controllers;

[Controller] 
[Route("departments")]
public class DepartmentController
{

    private readonly IConfiguration configuration;
    private readonly IDepartmentLogic departmentLogic;
    public DepartmentController(IConfiguration configuration, IDepartmentLogic departmentLogic)
    {
        this.configuration = configuration;
        this.departmentLogic = departmentLogic;
    }
    
    [HttpPost]
    [Route("")]
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
}