using System;
using System.Collections.Generic;

#nullable disable

namespace EdDbProject.Models
{
    public partial class StrugglingStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal YearBorn { get; set; }
    }
}
