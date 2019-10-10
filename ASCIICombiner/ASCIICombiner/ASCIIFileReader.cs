using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ASCIICombiner
{
    class ASCIIFileReader
    {
        public string[] ReadFilesAsync(string[] filenames)
        {
            List<string> fileContents = new List<string>();
            foreach(var filename in filenames)
            {
                string fileContent = "";

                try
                {
                    fileContent = System.IO.File.ReadAllText(@"TestData/"+filename);
                }catch(FileNotFoundException ex)
                {
                    return new List<string>().ToArray();
                }
                fileContents.Add(fileContent);
            }
            return fileContents.ToArray();
        }

        public bool HaveSameLenghts(string[] fileContents)
        {
            var length = fileContents[0].Length;
            var height = fileContents[0].Replace("\r", "").Split("\n").Length;
            foreach(var content in fileContents)
            {
                var curHeight = content.Replace("\r", "").Split("\n").Length;
                if (content.Length != length || curHeight != height)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
