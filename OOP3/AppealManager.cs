using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppealManager
    {
        public void MakeAnApplication(ICreditManager creditManager,  List<ILoggerService> loggerServices)
        {
            creditManager.calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

            
        }

        public void MakeCreditPreNotification(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.calculate();
            }
        }
    }
}
