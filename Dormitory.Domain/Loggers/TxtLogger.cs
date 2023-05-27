using System;
using System.IO;

namespace Dormitory.Domain.Loggers
{
    public class TxtLogger
    {
        private TxtLogger() { }

        private static TxtLogger _instance;

        public static TxtLogger GetLogger()
        {
            if (_instance == null)
                _instance = new TxtLogger();
            return _instance;
        }

        public void LogError(string error)
        {
            using (var sw = new StreamWriter("C:\\Users\\Артем\\source\\repos\\Studying_Practice_semester_4\\Dormitory.Domain\\Data\\Logs\\Log.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString() + " " + error);
            }
        }

    }
}
