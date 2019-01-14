using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFAssign
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JobOpenning" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JobOpenning.svc or JobOpenning.svc.cs at the Solution Explorer and start debugging.
    public class JobOpenning : IJobOpenning
    {
        List<Jobs> objJob = new List<Jobs> {
            new Jobs("Cognizant","C1","Programmer"),
            new Jobs("Infosysy","I1","Programmer"),
            new Jobs("Accenture","A1","Programmer"),
            new Jobs("Accenture","A3","Manager"),
             new Jobs("Accenture","A2","Associate"),
                    new Jobs("Cognizant","A2","Associate"),
                    new Jobs("Cognizant","A2","Manager"),
        };
        public List<Jobs> OpeningJobs()
        {
            return objJob;
        }

        public List<Jobs> OpeningJobsByRole(string strJobRole)
        {

            List<Jobs> lJobs = null;
            if (string.IsNullOrEmpty(strJobRole))
            {
                lJobs = objJob;
            }
            else
            {
                lJobs= (from job in objJob
                 where job.JobRole.ToUpper() == strJobRole.ToUpper()
                 select job).ToList();
            }
            return lJobs;
        }
    }
}
