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
            if (ex is OutOfMemoryException) { OutOfMemoryException(); }
            else if (ex is NullReferenceException) { NullReferenceException(); }
            else if (ex is IOException) { IOException(); }
            else if (ex is IndexOutOfRangeException) { IndexOutOfRangeException(); }
            else if (ex is UnauthorizedAccessException) { UnauthorizedAccessException(); }
            else { DefaultException(); }
        }
    }
}