using System;
using System.Reflection;

namespace SampleLibrary
{
    public class Class1
    {

        public static string GetTextFile1ContainsWithConcat()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = System.IO.Path.GetDirectoryName(path);
           return System.IO.File.ReadAllText(path + @"\TextFiles\TextFile1.txt");
        }


        public static string GetTextFile1ContainsWithCombine()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = System.IO.Path.GetDirectoryName(path);
            path = System.IO.Path.Combine(path, "TextFiles", "TextFile1.txt");
            return System.IO.File.ReadAllText(path);
        }
    }
}
