using System;
using System.Text;

namespace ASCIICombinerClassLibrary
{
    public class ASCIICombinerClassLibrary
    {
        public string CombineASCIIs(string[] asciiFileContents)
        {
            var combinedASCII = asciiFileContents[0].Replace("\r", "").Split('\n');
            for (int i = 0; i < asciiFileContents.Length; i++)
            {
                var asciiFile = asciiFileContents[i].Replace("\r", "").Split('\n');
                for (int lineNr = 0; lineNr < asciiFile.Length; lineNr++)
                {
                    var curLine = asciiFile[lineNr];
                    StringBuilder sb = new StringBuilder(combinedASCII[lineNr]);
                    for (int colNr = 0; colNr < curLine.Length; colNr++)
                    {
                        if (curLine[colNr] != ' ')
                        {
                            sb[colNr] = curLine[colNr];
                        }
                    }
                    combinedASCII[lineNr] = sb.ToString();
                }
            }
            return string.Join("\n", combinedASCII);
        }
    }
}
