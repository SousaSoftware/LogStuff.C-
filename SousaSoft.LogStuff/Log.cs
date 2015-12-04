using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SousaSoft.LogStuff
{
    public class Log
    {
        //'
        //' LogStuff.....
        //'
        //' Purpose= Read the current log from file and write the new messages to the log
        //'
        //' Usage= In any form just use LogStuff.Writer("Text") and it will add a new line of log
        //'

        public static string LogFile;

        public static string PreviousLog;

        // ' Identifier to read current log from file
        public static string Header;

        public static string PLReader()
        {
            // ' Function that will read the previous log from file
            if (File.Exists(LogFile))
            {
                // ' Check if we already have a log. If positive will load the previous log to memory
                StreamReader SR = new StreamReader(LogFile);
                PreviousLog = SR.ReadToEnd();
                SR.Close();

            }
            else
            {
                // ' If negative will create a new log with default log message
                PreviousLog = (Header + Environment.NewLine);
               

            }
            return PreviousLog;
        }

        public static string Add(string Text)
        {
            // ' Will write any new text to the log file
            Log.PLReader();
            // ' Load function that will read the previous log from file
            StreamWriter SW = new StreamWriter(LogFile);
            string currentdate;
            string currentminute;
            currentdate = DateTime.Now.ToShortDateString();
            currentminute = DateTime.Now.ToLongTimeString();

            SW.Write(PreviousLog);
            SW.WriteLine("[LOG]= "
                            + Text 
                            + " | "
                            + currentdate
                            + " | "
                            + currentminute);
            SW.Close();
            return "";
        }
    }
    public class LogShow
    {

        public static string LogFile;

        public static string CurrentLog;

        public static string CLReader()
        {
            if (File.Exists(LogFile))
            {
                // ' Check if we already have a log. If positive will load the previous log to memory
                StreamReader SR = new StreamReader(LogFile);
                CurrentLog = SR.ReadToEnd();
                SR.Close();
                return CurrentLog;
            }
            else
            {
                // ' If negative will create a new log with default log message
                CurrentLog = Environment.NewLine;
                return CurrentLog;
               
            }

            return CurrentLog;
        }
    }
}
