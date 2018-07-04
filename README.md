# BetterConsole
A better console for C#

---

### HowTo
```cs
using System;
using Console = BetterConsole.Console;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteAlternatingColors("Hello World!", ConsoleColor.Magenta, ConsoleColor.DarkMagenta);
            Console.WriteErrorLine("Hello World!");
            Console.WriteWarningLine("Hello World!");
            Console.WriteSuccessLine("Hello World!");

            System.Console.Read();
        }
    }
}```