using System;

namespace Exceptions
{
    internal class ExceptionClass
    {
        internal static void DefaultException()
        {
            do
            {
                Common.Start(Common.Crash.Default);
                Common.DebugSelector(8, Common.Crash.Default);
            } while (Common.input != "");
        }
        internal static void OutOfMemoryException()
        {
            do
            {
                int[,] map = new int[7, 26]
                {
             // { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52},
                { 0, 0, 0, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  1,  1,  1,  1,  1},
                { 1, 1, 1, 1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  0,  0,  0,  1,  2,  2,  1},
                { 1, 2, 2, 1,  1,  2,  2,  1,  1,  2,  2,  1,  1,  2,  2,  1,  1,  2,  2,  1,  0,  0,  0,  2,  2,  1},
                { 1, 2, 2, 1,  1,  2,  2,  1,  1,  2,  2,  1,  1,  2,  2,  1,  1,  2,  2,  1,  1,  0,  0,  0,  2,  1},
                { 1, 2, 2, 1,  1,  2,  2,  1,  1,  2,  2,  1,  1,  2,  2,  1,  1,  2,  2,  1,  1,  2,  0,  0,  0,  1},
                { 1, 2, 2, 1,  1,  2,  2,  1,  1,  2,  2,  1,  1,  2,  2,  1,  1,  2,  2,  1,  1,  2,  2,  0,  0,  0},
                { 1, 1, 1, 1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  0,  0},
                };
                Common.Start(Common.Crash.OutOfMemoryException);

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        int posX = (j * 2) + 2;
                        int posY = i + 8;
                        switch (map[i, j])
                        {
                            case 0:
                                break;
                            case 1:
                                Common.DrawSquare(posX, posY, ConsoleColor.DarkGreen);
                                break;
                            case 2:
                                Common.DrawSquare(posX, posY, ConsoleColor.DarkGray);
                                break;
                        }
                    }
                }

                for (int i = 2; i < 50; i++)
                {
                    Console.SetCursorPosition(i, 15);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("|");
                }
                Common.DebugSelector(17, Common.Crash.OutOfMemoryException);
            } while (Common.input != "");
        }
        internal static void NullReferenceException()
        {
            do
            {
                int[,] map = new int[6, 19]
                {
        //      { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52},
                { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1},
                { 1, 0, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1},
                { 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1},
                { 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1},
                { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1}
                };
                Common.Start(Common.Crash.NullReferenceException);

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        int posX = (j * 2) + 2;
                        int posY = i + 9;
                        switch (map[i, j])
                        {
                            case 0:
                                break;
                            case 1:
                                Common.DrawSquare(posX, posY, ConsoleColor.White);
                                break;
                        }
                    }
                }
                Common.DebugSelector(16, Common.Crash.NullReferenceException);
            } while (Common.input != "");
        }
        internal static void IOException()
        {
            do
            {
                int[,] map = new int[18, 14]
                {
                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0},
                { 2, 1, 1, 1, 1, 1, 1, 1, 2, 1, 2, 0, 0, 0},
                { 2, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 2, 0, 0},
                { 2, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2, 0},
                { 2, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 2},
                { 2, 1, 1, 1, 1, 1, 3, 1, 2, 2, 2, 2, 2, 2},
                { 2, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 2},
                { 2, 1, 1, 1, 1, 1, 3, 3, 3, 1, 1, 1, 1, 2},
                { 2, 1, 1, 1, 1, 3, 3, 3, 3, 1, 1, 1, 1, 2},
                { 2, 1, 1, 1, 3, 3, 3, 3, 1, 1, 1, 1, 1, 2},
                { 2, 1, 1, 3, 3, 3, 3, 3, 1, 1, 3, 1, 1, 2},
                { 2, 1, 3, 3, 3, 4, 3, 3, 3, 3, 3, 3, 1, 2},
                { 2, 1, 3, 3, 4, 4, 4, 3, 3, 3, 3, 3, 1, 2},
                { 2, 1, 3, 3, 4, 4, 4, 4, 3, 4, 3, 3, 1, 2},
                { 2, 1, 3, 3, 3, 4, 4, 4, 4, 4, 3, 3, 1, 2},
                { 2, 1, 1, 3, 3, 4, 5, 6, 5, 3, 3, 1, 1, 2},
                { 2, 1, 1, 1, 3, 5, 6, 6, 5, 3, 1, 1, 1, 2},
                { 2, 2, 2, 2, 2, 3, 3, 3, 3, 2, 2, 2, 2, 2}
                };
                Common.Start(Common.Crash.IOException);

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        int posX = (j * 2) + 2;
                        int posY = i + 9;
                        switch (map[i, j])
                        {
                            case 0:
                                break;
                            case 1:
                                Common.DrawSquare(posX, posY, ConsoleColor.Gray);
                                break;
                            case 2:
                                Common.DrawSquare(posX, posY, ConsoleColor.DarkGray);
                                break;
                            case 3:
                                Common.DrawSquare(posX, posY, ConsoleColor.DarkRed);
                                break;
                            case 4:
                                Common.DrawSquare(posX, posY, ConsoleColor.DarkYellow);
                                break;
                            case 5:
                                Common.DrawSquare(posX, posY, ConsoleColor.Yellow);
                                break;
                            case 6:
                                Common.DrawSquare(posX, posY, ConsoleColor.White);
                                break;
                        }
                    }
                }
                Common.DebugSelector(28, Common.Crash.IOException);
            } while (Common.input != "");
        }
        internal static void IndexOutOfRangeException()
        {
            do
            {
                int[,] map = new int[10, 21]
                {
                { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0},
                { 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0},
                { 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0},
                { 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0},
                { 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
                { 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0},
                { 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1}
                };
                Common.Start(Common.Crash.IndexOutOfRangeException);

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        int posX = (j * 2) + 2;
                        int posY = i + 9;
                        switch (map[i, j])
                        {
                            case 0:
                                break;
                            case 1:
                                Common.DrawSquare(posX, posY, ConsoleColor.White);
                                break;
                        }
                    }
                }
                Common.DebugSelector(20, Common.Crash.IndexOutOfRangeException);
            } while (Common.input != "");
        }
        internal static void UnauthorizedAccessException()
        {
            do
            {
                int[,] map = new int[18, 14]
                {
                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0},
                { 2, 1, 1, 1, 1, 1, 1, 1, 2, 1, 2, 0, 0, 0},
                { 2, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 2, 0, 0},
                { 2, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2, 0},
                { 2, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 2},
                { 2, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2},
                { 2, 1, 1, 1, 1, 1, 2, 2, 1, 1, 1, 1, 1, 2},
                { 2, 1, 1, 1, 1, 2, 1, 1, 2, 1, 1, 1, 1, 2},
                { 2, 1, 1, 1, 1, 2, 1, 1, 2, 1, 1, 1, 1, 2},
                { 2, 1, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2},
                { 2, 1, 1, 1, 2, 1, 1, 1, 1, 2, 1, 1, 1, 2},
                { 2, 1, 1, 1, 2, 1, 2, 2, 1, 2, 1, 1, 1, 2},
                { 2, 1, 1, 1, 2, 1, 1, 2, 1, 2, 1, 1, 1, 2},
                { 2, 1, 1, 1, 2, 1, 1, 1, 1, 2, 1, 1, 1, 2},
                { 2, 1, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 2},
                { 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2},
                { 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2},
                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2}
                };
                Common.Start(Common.Crash.UnauthorizedAccessException);

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        int posX = (j * 2) + 2;
                        int posY = i + 9;
                        switch (map[i, j])
                        {
                            case 0:
                                break;
                            case 1:
                                Common.DrawSquare(posX, posY, ConsoleColor.Gray);
                                break;
                            case 2:
                                Common.DrawSquare(posX, posY, ConsoleColor.DarkGray);
                                break;
                        }
                    }
                }
                Common.DebugSelector(28, Common.Crash.UnauthorizedAccessException);
            } while (Common.input != "");
        }
    }
}
