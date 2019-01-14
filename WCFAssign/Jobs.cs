using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFAssign
{
    [DataContract]
    public class Jobs
    {
        [DataMember]
        public string Company{ get; set; }
        [DataMember]
        public string JobId { get; set; }
        [DataMember]
        public string JobRole { get; set; }

        public Jobs(string strComp,string strJobId,string strJobRole)
        {
            Company = strComp;
            JobId = strJobId;
            JobRole = strJobRole;
        }
    }
}