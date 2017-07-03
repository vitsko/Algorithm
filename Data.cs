namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal class Data
    {
        internal string FullPathToFile { get; private set; }

        internal bool IsException { get; private set; }

        internal bool IsExistData(List<string> result)
        {
            StreamReader reader = null;
            this.FullPathToFile = string.Format(Text.FullPathToFile, Environment.CurrentDirectory, Text.FileWithStrings);

            try
            {
                reader = new StreamReader(this.FullPathToFile);

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
                this.IsException = true;
                Screen.Show(ex.Message);
            }

            return false;
        }
    }
}