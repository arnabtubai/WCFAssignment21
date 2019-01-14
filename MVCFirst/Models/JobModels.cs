using MVCFirst.JobReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirst.Models
{
    public class JobModels
    {
        public List<Jobs> JobList { get; set; }

        public string JobRole { get; set; }
        public JobModels()
        {
            JobRole = string.Empty;
        }
    }
}