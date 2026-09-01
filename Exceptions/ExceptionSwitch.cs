using System;
using System.IO;
using static Exceptions.ExceptionClass;

namespace Exceptions
{
    public class ExceptionSwitch
    {
        internal static Exception ex;
        public static void Exception(Exception ex)
        {
            ExceptionSwitch.ex = ex;
            if (ex.GetType() == typeof(OutOfMemoryException)) { OutOfMemoryException(); }
            else if (ex.GetType() == typeof(NullReferenceException)) { NullReferenceException(); }
            else if (ex.GetType() == typeof(IOException)) { IOException(); }
            else if (ex.GetType() == typeof(IndexOutOfRangeException)) { IndexOutOfRangeException(); }
            else if (ex.GetType() == typeof(UnauthorizedAccessException)) { UnauthorizedAccessException(); }
            else { DefaultException(); }
        }
    }
}