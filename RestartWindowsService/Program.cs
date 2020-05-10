using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace RestartWindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            RestartService("Fls.V7.IOT.PLGInterface.BL.SH", 10000);
            Console.Read();
        }

        private static void RestartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                if ((service.Status.Equals(ServiceControllerStatus.Running)) || (service.Status.Equals(ServiceControllerStatus.StartPending)))
                {

                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                }

                // count the rest of the timeout
                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
