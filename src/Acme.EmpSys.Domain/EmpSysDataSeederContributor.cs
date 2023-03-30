using System;
using System.Threading.Tasks;
using Acme.EmpSys.Departments;
using Acme.EmpSys.Employees;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.EmpSys;

public class EmpSysDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Employee, Guid> _employeeRepository;
    private readonly IDepartmentRepository _departmentRepository;
    private readonly DepartmentManager _departmentManager;

    public EmpSysDataSeederContributor(
        IRepository<Employee, Guid> employeeRepository,
        IDepartmentRepository departmentRepository,
        DepartmentManager departmentManager)
    {
        _employeeRepository = employeeRepository;
        _departmentRepository = departmentRepository;
        _departmentManager = departmentManager;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _employeeRepository.GetCountAsync() > 0)
        {
            return;
        }

        var development = await _departmentRepository.InsertAsync(
            await _departmentManager.CreateAsync(
                "Development",
                "Development for developers"
            )
        );

        var testing = await _departmentRepository.InsertAsync(
            await _departmentManager.CreateAsync(
                "Testing",
                "Testing for testers"
            )
        );

        await _employeeRepository.InsertAsync(
            new Employee
            {
                DepartmentId = development.Id, // SET THE AUTHOR
                Name = "Divyanshu",
                Age = 23,
                Email = "d1403kr@gmail.com",
                JoinDate = new DateTime(2023, 1, 23),
                Salary = 7000.0f
            },
            autoSave: true
        );

        await _employeeRepository.InsertAsync(
            new Employee
            {
                DepartmentId = testing.Id, // SET THE AUTHOR
                Name = "Haresh",
                Age = 24,
                Email = "haresh65@gmail.com",
                JoinDate = new DateTime(2023, 1, 23),
                Salary = 7500.0f
            },
            autoSave: true
        );
    }
}
