using System;
using System.Diagnostics;

namespace Exceptions
{
    internal class Common
    {
        internal static string input;
        private static bool debug = false;
        internal static int crashMsgIndex = -1;
        internal enum Crash
        {
            Default,
            OutOfMemoryException,
            NullReferenceException,
            IOException,
            IndexOutOfRangeException,
            UnauthorizedAccessException
        }
        internal static void Start(Crash exception, bool debug = false)
        {
            Random rng = new Random();
            string[] crashMsgs = new string[]
            {
                "Task failed successfully.",
                "Crashed successfully",
                "This seemed like a better idea yesterday.",
                "The consequences have arrived.",
                "Something happened. None of it was good.",
                "Everything is proceeding according to a plan we have not seen.",
                "The error was inside us all along.",
                "The bug has spoken.",
                "Nothing further can be achieved.",
                "This process is now a memory.",
                "All roads led here.",
                "The application has become one with the garbage collector.",
                "The application required one more semicolon.",
                "Good news: The bug is no longer running.",
                "Good news: The application has stopped consuming memory.",
                "Good news: Nothing can go wrong anymore.",
                "Good news: The error is gone. Bad news: It took the program with it.",
                "Good news: The application has achieved 100% CPU efficiency. It does absolutely nothing.",
                "Good news: The program found a shortcut to termination.",
                "Good news: Your computer is still functioning.",
                "Bad news: The exception won.",
                "Bad news: We have encountered a feature nobody documented.",
                "Bad news: This worked five minutes ago.",
                "Bad news: The error appears to be user-generated. Unfortunately, the user was us.",
                "Codus Brokenus!",
                "Programus Crashus!",
                "Systemus Explodus!",
                exception == Crash.OutOfMemoryException ? "The final byte has been spent." : exception == Crash.NullReferenceException ? "The application attempted to speak with the Void." : exception == Crash.IOException ? "The disk remembers nothing." : exception == Crash.IndexOutOfRangeException ? "There is nothing beyond this index." : exception == Crash.UnauthorizedAccessException ? "The file rejects your presence." : "Welp, that happened.",
                exception == Crash.OutOfMemoryException ? "Memoria Evaporatus" : exception == Crash.NullReferenceException ? "Nullus Referencius" : exception == Crash.IOException ? "Fileus Missingus" : exception == Crash.IndexOutOfRangeException ? "Indexus Outofrangius" : exception == Crash.UnauthorizedAccessException ? "Accessus Deniedus!" : "Bugus Detectus!"
            };
            Console.CursorVisible = false;
            Console.Clear();

            DrawSquare(7, 0, ConsoleColor.White);

            DrawSquare(2, 1, ConsoleColor.White);
            DrawSquare(6, 1, ConsoleColor.White);
            Console.SetCursorPosition(12, 1);
            if (crashMsgIndex == -1) { crashMsgIndex = rng.Next(crashMsgs.Length); }
            Console.WriteLine(crashMsgs[crashMsgIndex]);

            DrawSquare(6, 2, ConsoleColor.White);

            DrawSquare(2, 3, ConsoleColor.White);
            DrawSquare(6, 3, ConsoleColor.White);
            Console.SetCursorPosition(12, 3);
            Console.WriteLine("Error Code: {0}", exception != Crash.Default ? exception.ToString() : ExceptionSwitch.ex.GetType().Name.ToString());

            DrawSquare(7, 4, ConsoleColor.White);

            if (!debug)
            {
                Console.SetCursorPosition(2, 6);
                Console.Write("To close the Program, hit ENTER. . .");
            }
        }
        internal static void DrawSquare(int left, int top, ConsoleColor Color)
        {
            Console.BackgroundColor = Color;
            Console.SetCursorPosition(left, top);
            Console.Write("  ");
            Console.ResetColor();
        }
        internal static void DebugSelector(int y, Crash crashType)
        {
            Console.SetCursorPosition(2, y);
            Console.CursorVisible = true;
            Console.ResetColor();
            GC.Collect();
            input = Console.ReadLine().ToLower();
            if (input == "debug")
            {
                debug = true;
                do
                {
                    Start(crashType, true);
                    Console.SetCursorPosition(2, 6);
                    Console.Write("Debugmodus aktiv");
                    Console.SetCursorPosition(2, 7);
                    Console.Write("> ");
                    Console.CursorVisible = true;
                    input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "source":
                            Console.WriteLine(ExceptionSwitch.ex.StackTrace);
                            Console.ReadLine();
                            break;
                        case "exit":
                            debug = false;
                            break;
                    }
                } while (debug);
            }
        }
    }
}
