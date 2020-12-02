using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab6_rw;
using System.IO;

namespace lab7
{

    public class ConsoleLogger
    {
        public void OutputInfo(string info)
        {
            Console.WriteLine(DateTime.Now + $", {info}: Test log message.");
        }
    }

    public class FileLogger
    {

        public void OutputInfo(string info)
        {
            string path = @"C:\Users\yegor\source\repos\lab7\lab7\lab7\LogFile.txt";
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(DateTime.Now + $", {info}: Test log message.");
            Console.WriteLine("Log written");
            sw.Close();
        }
    }
    public class ClassForExceptions
    {
        public string correctbookname;
        public int pages;
        public void DoesTheStringMatch()
        {
            if ( correctbookname == "Война и мир")
            {
                throw new WrongStringFormat("Wrong String Format!");
            }
        }
        public void IsTheNumberCorrect()
        {
            if (pages != 4)
            {
                throw new WrongNumberValue("Wrong Number Value!");
            }
        }
    }
    class WrongStringFormat : Exception
    {
        public string message = "Your String Has Wrong Format! Please Try Again!";
        public string diagnostics = "Please, don't write \"Война и мир\"";
        public WrongStringFormat(string message) : base(message)
        {

        }
    }

    class WrongNumberValue : Exception
    {
        public string message = "We only sell books that contain 100 pages";
        public string diagnostics = "Don't ask us for 100 pages books";
        public WrongNumberValue(string message) : base(message)
        {

        }
    }


    class NullException : ApplicationException
    {
        public string diagnostics = "Ummm... Just Delete This Exception. It Doesn't Matter";
        public string message = "Please, Don't send empty string!";
        public NullException(string message) : base(message)
        {

        }
    }
}
