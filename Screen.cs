namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using static System.Console;

    internal static class Screen
    {
        internal static string FullPathToFile { get; private set; }

        internal static bool IsException { get; private set; }

        internal static bool IsExistData(List<string> result)
        {
            StreamReader reader = null;
            FullPathToFile = string.Format(Text.FullPathToFile, Environment.CurrentDirectory, Text.FileWithStrings);

            try
            {
                reader = new StreamReader(FullPathToFile);

                while (reader.Peek() >= 0)
                {
                    var oneString = reader.ReadLine();

                    if (result == null)
                    {
                        result = new List<string>();
                    }

                    result.Add(oneString);
                }

                if (result.Count == 0)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                IsException = true;
                Screen.Show(ex.Message);
            }

            return false;
        }

        internal static void Show(string title, List<string> textToShow)
        {
            WriteLine(string.Empty);
            WriteLine(title);

            foreach (var stringToShow in textToShow)
            {
                WriteLine(stringToShow);
            }
        }

        internal static void Show(params string[] textToShow)
        {
            WriteLine(string.Empty);

            foreach (var stringToShow in textToShow)
            {
                WriteLine(stringToShow);
            }
        }

        internal static void Show(string message)
        {
            WriteLine(string.Empty);
            WriteLine(message);
        }
    }
}
