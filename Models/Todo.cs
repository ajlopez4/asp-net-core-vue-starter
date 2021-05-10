using System;
using System.Collections.Generic;

namespace AspNetCoreVueStarter.Models
{
    public partial class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool? Done { get; set; }
        public bool? IsPriority { get; set; }
    }
}
