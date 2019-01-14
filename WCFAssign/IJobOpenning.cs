using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFAssign
{
    [ServiceContract]
    public interface IJobOpenning
    {
        [OperationContract]
        List<Jobs> OpeningJobs();
        [OperationContract]
        List<Jobs> OpeningJobsByRole(string strJobRole);

    }
}
