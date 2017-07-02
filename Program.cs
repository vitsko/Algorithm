namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static System.Console;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            List<string> forSorting = new List<string>();
            byte beforLastString = 2;

            Title = Text.Title;

            if (Screen.IsExistData(forSorting))
            {
                Screen.Show(Text.AboutData, forSorting);
                var afterSorting = forSorting.OrderBy(item => item.Length);
                Screen.Show(Text.AfterSorting, afterSorting.ToList());

                var secondByLength = afterSorting.ElementAt(afterSorting.Count() - beforLastString);
                Screen.Show(Text.SecondString, secondByLength);
            }
            else
            {
                if (!Screen.IsException)
                {
                    Screen.Show(string.Format(Text.EmptyFile, Screen.FullPathToFile));
                }
            }

            Screen.Show(Text.PressAnyKey);
            Console.ReadKey();
        }
    }
}