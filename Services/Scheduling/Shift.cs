using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using DataAccess.Entities;

namespace Services.Scheduling
{
    public class Shift
    {
        public Organization Organization { get; set; }
        public int NumberOfEmployees { get; set; }
        public int Length { get { return GetShiftLength(); } }
        public decimal BreakLength { get; set; }
        public List<Employee> Employees { get; set; }
        public decimal Cost { get { return GetCost(); } }
        public Workday Workday { get; set; }

        private int GetShiftLength()
        {
            int hours = 0;
            int difference = Math.Abs(Workday.EndTime - Workday.StartTime);
            hours += difference;

            return hours;
        }
 
        private decimal GetCost()
        {
            decimal hourlyCost = 0;
            decimal totalCost = hourlyCost * Length;
            foreach (var item in Employees)
            {
                hourlyCost += item.Wage;
            }

            return totalCost;
        }
    }
}
