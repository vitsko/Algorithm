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

            Data data = new Data();

            if (data.IsExistData(forSorting))
            {
                Screen.Show(Text.AboutData, forSorting);

                // Sort list or array by string length (Отсортировать список по длине строк)
                var afterSorting = forSorting.OrderBy(item => item.Length);
                Screen.Show(Text.AfterSorting, afterSorting.ToList());

                // Find the second by length string in a list or array(Найти вторую по длинне строку в списке)
                var secondByLength = afterSorting.ElementAt(afterSorting.Count() - beforLastString);
                Screen.Show(Text.SecondString, secondByLength);
            }
            else
            {
                if (!data.IsException)
                {
                    Screen.Show(string.Format(Text.EmptyFile, data.FullPathToFile));
                }
            }

            Screen.Show(Text.PressAnyKey);
            Console.ReadKey();
        }
    }
}