using System;

namespace ASCIICombiner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            if (CheckForErrors(args))
            {
                Console.WriteLine("No file/Too less specified");
                return;
            }

            ASCIIFileReader reader = new ASCIIFileReader();
            var asciiFilesContent = reader.ReadFilesAsync(args);
            if(asciiFilesContent.Length <= 0)
            {
                Console.WriteLine("One or more files you specified do not exist");
                return;
            }

            if (!reader.HaveSameLenghts(asciiFilesContent)) {
                Console.WriteLine("Files do not have equal lengths!");
                return;
            }

            ASCIICombinerClassLibrary.ASCIICombinerClassLibrary combiner = new ASCIICombinerClassLibrary.ASCIICombinerClassLibrary();
            Console.WriteLine(combiner.CombineASCIIs(asciiFilesContent));
            Console.ReadLine();
        }

        private static bool CheckForErrors(string[] args)
        {
            if (args.Length <= 1)
            {
                return true;
            }
            return false;
        }
    }
}
