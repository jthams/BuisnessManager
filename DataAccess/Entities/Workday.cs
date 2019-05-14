using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public class Workday
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

    }
}
