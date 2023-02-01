using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLI.Main.Utils
{
    public static class Display
    {
        private static ConsoleColor[] colorMap = new ConsoleColor[]
        {
            ConsoleColor.Gray,
            ConsoleColor.Green,
            ConsoleColor.Blue,
            ConsoleColor.Yellow,
            ConsoleColor.DarkCyan,
            ConsoleColor.DarkMagenta,
            ConsoleColor.DarkGreen,
            ConsoleColor.Cyan,
            ConsoleColor.Magenta
        };

        public static void Clear()
        {
            Console.Clear();
        }

        public static string GetQuery(string message)
        {
            Console.Write(message);
            string query = Console.ReadLine();
            return query;
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void PrintErrorMessage(string message)
        {
            PrintColorMessage(message, ConsoleColor.DarkRed);
        }
        public static void PrintSucessMessage(string message)
        {
            PrintColorMessage(message, ConsoleColor.DarkGreen);
        }
        public static void SetApplicationTitle(string title)
        {
            Console.Title = $"CLI Base :: Version = {title}";
        }
        private static void PrintColorMessage(string message, ConsoleColor color)
        {
            WriteColor(String.Concat("[", message, "]"), ConsoleColor.DarkGreen);
        }

        private static void WriteColor(string message, ConsoleColor color)
        {
            var pieces = Regex.Split(message, @"(\[[^\]]*\])");

            for (int i = 0; i < pieces.Length; i++)
            {
                string piece = pieces[i];

                if (piece.StartsWith("[") && piece.EndsWith("]"))
                {
                    Console.ForegroundColor = color;
                    piece = piece.Substring(1, piece.Length - 2);
                }

                Console.Write(piece);
                Console.ResetColor();
            }

            Console.WriteLine();
        }

        
    }
}
