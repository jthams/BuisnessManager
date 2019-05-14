using System;
using System.Linq;
using System.Text;
using DataAccess.Entities;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Services.Scheduling
{
    public class Scheduler
    {
        private readonly IDataRepository _data;
        private readonly UserManager<IdentityUser> _userManager;
        
        public Scheduler(IDataRepository data)
        {
            _data = data;
        }

        public Organization Organization { get; set; }
        public List<Shift> Shifts { get; set; }

        public Shift CreateShift(Workday workday, int numberOfEmployees, decimal breakLength = 0)
        {
            Shift thisShift = new Shift
            {
                Organization = Organization,
                Workday = workday,
                NumberOfEmployees = numberOfEmployees,
                BreakLength = breakLength
            };

            return thisShift;
        }
        public Shift FillShift(Shift shift)
        {
            //TODO: Complete algorithm
            return shift;
        }
        public List<Employee> OrganizationEmployees()
        {
            return _data.Employees.Where(x => x.Employer.Id == Organization.Id).ToList();
        }

    }
}
