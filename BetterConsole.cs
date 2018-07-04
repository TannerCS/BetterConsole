using System;

namespace BetterConsole
{
    public class Console
    {
        public enum FormattedLines
        {
            numbered,
            bulleted,
            dashed
        };

        public ConsoleColor ForegroundColor = System.Console.ForegroundColor;
        public ConsoleColor BackgroundColor = System.Console.BackgroundColor;

        /// <summary>
        /// Writes a line to the Console
        /// </summary>
        public static void WriteLine(object obj)
        {
            System.Console.WriteLine(obj);
        }

        /// <summary>
        /// Writes to the Console in a specified color
        /// </summary>
        public static void Write(object obj, ConsoleColor color)
        {
            System.Console.ForegroundColor = color;
            System.Console.Write(obj);
            System.Console.ResetColor();
        }

        /// <summary>
        /// Writes a line to the Console with specified color
        /// </summary>
        public static void WriteLine(object obj, ConsoleColor foregroundColor)
        {
            System.Console.ForegroundColor = foregroundColor;
            System.Console.WriteLine(obj);
            System.Console.ResetColor();
        }

        /// <summary>
        /// Writes a line to the Console with specified colors
        /// </summary>
        public static void WriteLine(object obj, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            System.Console.ForegroundColor = foregroundColor;
            System.Console.BackgroundColor = backgroundColor;
            System.Console.WriteLine(obj);
            System.Console.ResetColor();
        }

        /// <summary>
        /// Writes a new line to the Console
        /// </summary>
        public static void WriteLine()
        {
            System.Console.WriteLine();
        }

        /// <summary>
        /// Writes to the Console
        /// </summary>
        public static void Write(object obj)
        {
            System.Console.Write(obj);
        }

        /// <summary>
        /// Writes a red error line to the Console
        /// </summary>
        public static void WriteErrorLine(object obj)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(obj);
            System.Console.ResetColor();
        }

        /// <summary>
        /// Writes a red error to the Console
        /// </summary>
        public static void WriteError(object obj)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(obj);
            System.Console.ResetColor();
        }

        /// <summary>
        /// Writes a yellow warning line to the Console
        /// </summary>
        public static void WriteWarningLine(object obj)
        {
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine(obj);
            System.Console.ResetColor();
        }

        /// <summary>
        /// Writes a yellow warning to the Console
        /// </summary>
        public static void WriteWarning(object obj)
        {
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(obj);
            System.Console.ResetColor();
        }

        /// <summary>
        /// Writes a green successful line to the Console
        /// </summary>
        public static void WriteSuccessLine(object obj)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(obj);
            System.Console.ResetColor();
        }

        /// <summary>
        /// Writes a green successful to the Console
        /// </summary>
        public static void WriteSuccess(object obj)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(obj);
            System.Console.ResetColor();
        }

        /// <summary>
        /// Writes to the console in alternating colors
        /// </summary>
        public static void WriteAlternatingColors(string line, ConsoleColor firstColor, ConsoleColor secondColor)
        {
            for (int i = 0; i < line.Length; i += 2)
            {
                System.Console.ForegroundColor = firstColor;
                Write(line[i]);
                System.Console.ForegroundColor = secondColor;
                Write(line[i + 1]);
            }
            WriteLine();
            System.Console.ResetColor();
        }

        /// <summary>
        /// Writes numbered lines to the console
        /// </summary>
        public static string[] WriteFormattedLines(string[] lines, FormattedLines formattedLines = FormattedLines.numbered)
        {
            string[] output = new string[lines.Length];
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (formattedLines == FormattedLines.numbered)
            {
                for (int i = 1; i < lines.Length + 1; i++)
                {
                    WriteLine(i + ". " + lines[i - 1]);
                    output[i - 1] = i + ". " + lines[i - 1];
                }
            }
            else if (formattedLines == FormattedLines.bulleted)
            {
                for (int i = 1; i < lines.Length + 1; i++)
                {
                    WriteLine("• " + lines[i - 1]);
                    output[i - 1] = "• " + lines[i - 1];
                }
            }
            else if (formattedLines == FormattedLines.dashed)
            {
                for (int i = 1; i < lines.Length + 1; i++)
                {
                    WriteLine("- " + lines[i - 1]);
                    output[i - 1] = "- " + lines[i - 1];
                }
            }
            return output;
        }
    }
}
