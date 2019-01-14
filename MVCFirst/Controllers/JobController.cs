using MVCFirst.JobReference;
using MVCFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirst.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        public ActionResult Index()
        {
            JobReference.JobOpenningClient objJob = new JobReference.JobOpenningClient();
            JobModels mdl = new JobModels();
            mdl.JobList=(List<Jobs>)objJob.OpeningJobs().ToList();
            return View(mdl);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string txtJobRole, JobModels job)
        {
            try
            {
                JobReference.JobOpenningClient objJob = new JobReference.JobOpenningClient();

                job.JobList = (List<Jobs>)objJob.OpeningJobsByRole(txtJobRole).ToList();

                return View(job);


            }
            catch
            {
                return View();
            }
        }
    

    }
}
