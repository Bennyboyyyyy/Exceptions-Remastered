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
            try { throw ex; }
            catch (OutOfMemoryException) { OutOfMemoryException(); }
            catch (NullReferenceException) { NullReferenceException(); }
            catch (IOException) { IOException(); }
            catch (IndexOutOfRangeException) { IndexOutOfRangeException(); }
            catch (UnauthorizedAccessException) { UnauthorizedAccessException(); }
            catch (Exception) { DefaultException(); }
        }
    }
}