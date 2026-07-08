using System;
using static Exceptions.ExceptionClass;

namespace Exceptions
{
    public class ExceptionSwitch
    {
        internal static Exception ex;
        public static void Exception(Exception ex)
        {
            ExceptionSwitch.ex = ex;
            switch (ex.GetType().Name.ToString())
            {
                case "OutOfMemoryException":
                    OutOfMemoryException();
                    break;
                case "NullReferenceException":
                    NullReferenceException();
                    break;
                case "IOException":
                    IOException();
                    break;
                case "IndexOutOfRangeException":
                    IndexOutOfRangeException();
                    break;
                case "UnauthorizedAccessException":
                    UnauthorizedAccessException();
                    break;
                default:
                    DefaultException();
                    break;
            }
        }
    }
}
