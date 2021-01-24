using System;
using System.Collections.Generic;
namespace OOP3
{
     class Program
    {
        static void Main(string[] args)
        {
           ICreditManager personalFinanceCredit = new PersonalFinanceCredit();
           ICreditManager vehicleCreditManager = new VehicleCreditManager();
           ICreditManager mortgageCreditManager = new MortgageCredit();

            ILoggerService databaseLoggerService = new DateBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService(); 

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            
            
            AppealManager appealManager = new AppealManager();
            appealManager.MakeAnApplication(new ArtisanCreditManager(), loggers);


          


            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCredit, vehicleCreditManager };

            









        }
    }

   
}
