using System;


namespace WCFAssign
{

    public class MyService : IMyService
    {
        public string SayHello(string strName)
        {
            string strMessage = string.Empty;
            if (DateTime.Now.Hour < 12)
            {
                strMessage = "Good Morning "+ strName;
               
            }
            else if (DateTime.Now.Hour < 17)
            {
                strMessage = "Good Afternoon " + strName;
            }
            else
            {
                strMessage = "Good Evening " + strName;
            }

            return strMessage;
        }

        public string TodayProgram(string strName)
        {
            DateTime date = DateTime.Now;
            DayOfWeek day = DateTime.Now.DayOfWeek;
            string strMessage = string.Empty;

            if ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday))
            {
                strMessage = "Happy Weekend.." + strName;
            }
            else
            {
                strMessage = "Enjoy weekdays.." + strName;
            }
            return strMessage;
        }
    }
}
