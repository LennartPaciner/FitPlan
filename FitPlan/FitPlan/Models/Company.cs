using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitPlan.Models
{
    public class Company
    {
        [PrimaryKey]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
