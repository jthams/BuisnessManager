using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Entities;
using DataAccess.Contexts;
using Microsoft.AspNetCore.Identity;

namespace Services
{
    public class Scheduler
    {
        public Scheduler
        public Organization Organization { get; set; }
        public int TotalHours { get; set; }
        public int HoursInWorkDay { get; set; }
        public List<string> WorkingDays { get; set; }

        private void SetTotalHours()
        {
            var total = 
        }
    }
}
