using System;
using System.Collections.Generic;

namespace AspNetCoreVueStarter.Models
{
    public partial class Photos
    {
        public int Id { get; set; }
        public string PhotoTitle { get; set; }
        public string ImageName { get; set; }
        public string Path { get; set; }
    }
}
