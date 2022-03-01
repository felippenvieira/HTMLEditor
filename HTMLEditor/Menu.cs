using System;

namespace HTMLEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen(30, 10);
        }

        public static void DrawScreen(int col, int lines)
        {
            StartEndLine(col);

            for (int y = 0; y <= lines; y++)
            {
                Console.Write("|");
                for (int i = 0; i <= col; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }

            StartEndLine(col);
        }

        public static void StartEndLine(int col)
        {
            Console.Write("+");
            for (int i = 0; i <= col; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }
    }
}
