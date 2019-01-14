using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFAssign
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        int Add(int x,int y);
        [OperationContract]
        int Subtract(int x, int y);
    }
}
