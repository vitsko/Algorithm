namespace Algorithm
{
    using System.Collections.Generic;
    using static System.Console;

    internal static class Screen
    {
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