using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.EmpSys.Employees
{
    public class Employee : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public float Salary { get; set; }
        public Guid DepartmentId { get; set; }

    }
}
