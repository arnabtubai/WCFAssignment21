using System;
using System.ServiceModel;
using WCFAssign;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost myHost = null;
            try
            {
                myHost = new ServiceHost(typeof(MyService));
                myHost.Open();
                Console.WriteLine("The My service is running and is listening on:");
                Console.WriteLine(@"http://localhost:9003/MyService");
                Console.WriteLine(@"net.tcp://localhost:9002/MyService");
                Console.WriteLine("\nPress any key to stop the service.");

                Console.ReadKey();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            finally
            {
                if (myHost.State == CommunicationState.Faulted)
                {
                    myHost.Abort();
                }
                else
                {
                    myHost.Close();
                }
            }
        }
    }
}
