using System.ServiceModel;

namespace WCFAssign
{
    [ServiceContract]
    public interface IMyService
    {

        [OperationContract]
        string SayHello(string strName);

        [OperationContract]
        string TodayProgram(string strName);


    }


}
